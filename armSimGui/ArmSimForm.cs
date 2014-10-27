using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace armsim
{
    public partial class ArmSimForm : Form
    {
        Computer comp;
        uint address;
        uint startaddr;
        string lastFileName;
        bool trace = true, dec = false;
        public delegate void Del();
        public Del myDelegate;
        public ArmSimForm(Computer c)
        {
            InitializeComponent();
            comp = c;
            comp.SetForm(this);
            myDelegate = new Del(ThreadEnd);
            InitializeGui();

            address = Convert.ToUInt32(comp.GetRegs().GetProgramCounter());
            startaddr = address;

            if (comp.GetOpts().parsedArgs.ContainsKey("exec") &&
                comp.GetOpts().parsedArgs.ContainsKey("load"))
            {
                new Thread(comp.Run).Start();
            }
        }

        public void InitializeGui()
        {
            string[] row = new string[] { "address", "0x00000000", "0x00000000", "0x00000000", "0x00000000" };
            for (int i = 0; i < 8; ++i)
            {
                gridMem.Rows.Add(row);
            }
            for (int i = 0; i < 16; ++i)
            {
                string[] regRow = new string[] { "R" + Convert.ToString(i), "0x00000000" };
                gridRegs.Rows.Add(regRow);
            }
            for (int i = 0; i < 16; ++i)
            {
                string[] stackRow = new string[] { "0x00000000", "0x00000000" };
                gridStack.Rows.Add(stackRow);
            }
            if (comp.GetOpts().parsedArgs.ContainsKey("load"))
            {
                lastFileName = comp.GetOpts().parsedArgs["load"];
                lblFileName.Text = comp.GetOpts().parsedArgs["load"];
                UpdateMemory();
                UpdateRegisters();
                UpdateStack();
                UpdateDisassembly();
            }
            else
            {
                btnRun.Enabled = false;
                btnStep.Enabled = false;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // Configure open file dialog box
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.FileName = ""; // Default file name
            dlg.DefaultExt = ".exe"; // Default file extension
            dlg.Filter = "ELF|*.exe|All|*.*"; // Filter files by extension 
            // Show open file dialog box
            dlg.ShowDialog();
            // Process open file dialog box results 
            if (dlg.FileName != null)
            {
                // Open document
                string extension = Path.GetExtension(dlg.FileName);
                if (extension == ".exe")
                {
                    trace = true;
                    menuTrace.Checked = true;
                    address = 0;
                    comp.Load(dlg.FileName);
                    lastFileName = dlg.FileName;
                    lblFileName.Text = Path.GetFileName(dlg.FileName);
                    address = Convert.ToUInt32(comp.GetRegs().GetProgramCounter());
                    startaddr = address;
                    UpdateMemory();
                    UpdateRegisters();
                    UpdateStack();
                    UpdateDisassembly();
                    btnRun.Enabled = true;
                    btnStep.Enabled = true;
                }
                else { 
                
                }
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            btnRun.Enabled = false;
            btnStep.Enabled = false;
            btnLoad.Enabled = false;
            new Thread(comp.Run).Start();
        }

        private void btnBreak_Click(object sender, EventArgs e)
        {
            comp.Break();
        }

        private void btnStep_Click(object sender, EventArgs e)
        {
            comp.Step();
            UpdateMemory();
            UpdateRegisters();
            UpdateDisassembly();
            UpdateStack();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            comp.Load(lastFileName);
            UpdateMemory();
            UpdateRegisters();
            UpdateStack();
            UpdateDisassembly();
        }

        public void UpdateMemory()
        {
            address = startaddr;
            for (int i = 0; i < 8; ++i)
            {
                for (int j = 0; j < 5; ++j)
                {
                    string str;
                    if (j == 0)
                    {
                        str = "0x" + string.Format("{0:X8}", address);
                    }
                    else
                    {
                        str = "0x" + string.Format("{0:X8}", comp.GetMem().ReadWord(address));
                        address += 4;
                    }
                    gridMem.Rows[i].Cells[j].Value = str;
                }
            }
        }

        public void UpdateRegisters()
        {
            string str;
            for (int i = 0; i < 16; ++i)
            {
                str = string.Format("{0:X8}", comp.GetRegs().ReadWord(Convert.ToUInt32(i*4)));
                gridRegs.Rows[i].Cells[1].Value = str;
            }
        }

        public void UpdateDisassembly()
        {
            uint pc = comp.GetRegs().GetProgramCounter();
            pc = pc - (5 * 4);
            string text = "";
            for (int i = 0; i < 11; ++i)
            {
                uint fetch = comp.GetMem().ReadWord(pc);
                Instruction inst = comp.GetCPU().Decode(fetch);
                if (inst != null)
                {
                    text += inst.ToString();
                }
                text += "\r\n";
                pc += 4;
            }
            txtDisassembly.Text = text;
        }

        public void UpdateStack()
        {
            uint stackPointer = comp.GetRegs().GetStackPointer();
            uint sp = stackPointer - 5 * 4;
            string straddr, str;
            for (int i = 0; i < 16; ++i)
            {
                straddr = string.Format("{0:X8}", sp);
                gridStack.Rows[i].Cells[0].Value = straddr;
                str = string.Format("{0:X8}", comp.GetMem().ReadWord(sp));
                gridStack.Rows[i].Cells[1].Value = str;
                sp += 4;
            }
        }

        private void txtMem_TextChanged(object sender, EventArgs e)
        {
            if (txtMem.Text != "" && txtMem.Text != null)
            {
                uint txt;
                if (dec)
                {
                    txt = Convert.ToUInt32(txtMem.Text);
                }
                else
                {
                    txt = Convert.ToUInt32(txtMem.Text, 16);
                }
                if ((txt % 4) == 0 && txt < comp.GetMem().GetRam().Length)
                {
                    startaddr = txt;
                    UpdateMemory();
                }
            }
            else
            {
                startaddr = 0;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dec = !dec;
        }

        private void menuLoad_Click(object sender, EventArgs e)
        {
            btnLoad_Click(sender, e);
        }

        private void menuRun_Click(object sender, EventArgs e)
        {
            btnRun_Click(sender, e);
        }

        private void menuStep_Click(object sender, EventArgs e)
        {
            btnStep_Click(sender, e);
        }

        private void menuBreak_Click(object sender, EventArgs e)
        {
            btnBreak_Click(sender, e);
        }

        private void menuTrace_Click(object sender, EventArgs e)
        {
            trace = !trace;
            if (trace)
            {
                comp.EnableTrace();
            }
            else
            {
                comp.DisableTrace();
            }
        }

        private void menuReset_Click(object sender, EventArgs e)
        {
            btnReset_Click(sender, e);
        }

        public void ThreadEnd()
        {
            if (comp.GetOpts().parsedArgs.ContainsKey("exec") &&
                comp.GetOpts().parsedArgs.ContainsKey("load"))
            {
                Application.Exit();
            }
            btnRun.Enabled = true;
            btnStep.Enabled = true;
            btnLoad.Enabled = true;
            UpdateMemory();
            UpdateRegisters();
            UpdateDisassembly();
            UpdateStack();
        }
    }
}
