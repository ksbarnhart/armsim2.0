using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.IO;
using System.Security.Cryptography;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading;
using System.Text;

namespace armsim
{

    // Simulates the computers; contains the Memory, Registers, and CPU
    public class Computer
    {
        ArmSimForm myForm;
        Memory mem;
        Registers regs;
        CPU cpu;
        Options opts;
        FileStream filestream;
        bool stop = false;
        bool trace = true;
        int stepnum = 0;
        int nFlag = 0, zFlag = 0, cFlag = 0, fFlag = 0;
        public Computer(Options options)
        {
            opts = options;
            if (opts.parsedArgs.ContainsKey("mem"))
            {
                mem = new Memory(Convert.ToInt32(opts.parsedArgs["mem"]));
            }
            else
            {
                mem = new Memory(32768);
            }
            regs = new Registers();
            regs.SetMem(64);
            cpu = new CPU(ref regs, ref mem);
            filestream = new FileStream("trace.log", FileMode.Create);
            filestream.Close();
        }

        public Options GetOpts()
        {
            return opts;
        }

        public Memory GetMem()
        {
            return mem;
        }

        public Registers GetRegs()
        {
            return regs;
        }

        public CPU GetCPU()
        {
            return cpu;
        }

        // sets the stop bool to true
        public void Break()
        {
            stop = true;
        }

        // loops through fetch, decode, execute until "stop" is true or Fetch() returns 0
        public void Run()
        {
            stop = false;
            uint fetch = cpu.Fetch();
            while (fetch > 0 && !stop)
            {
                stepnum += 1;
                uint progCounter = regs.ReadWord(60);
                Instruction inst = cpu.Decode(fetch);
                if (inst == null)
                {
                    break;
                }
                cpu.Execute(inst);
                if (trace)
                {
                    Trace(stepnum, (int)progCounter, nFlag, zFlag, cFlag, fFlag, regs);
                }
                regs.WriteWord(60, progCounter + 4);
                fetch = cpu.Fetch();
            }
            myForm.Invoke(myForm.myDelegate);
        }

        // runs Fetch(), Decode(), and Execute() once
        public void Step()
        {
            stepnum += 1;
            uint progCounter = regs.ReadWord(60);
            uint fetch = cpu.Fetch();
            Instruction inst = cpu.Decode(fetch);
            cpu.Execute(inst);
            if (trace)
            {
                Trace(stepnum, (int)progCounter, nFlag, zFlag, cFlag, fFlag, regs);
            }
            regs.WriteWord(60, progCounter + 4);
        }

        // calls SantasHelpers to load a file not specified on the command line
        public bool Load(string filename)
        {
            mem.ClearMem();
            regs.ClearMem();
            if (trace) 
            {
                DisableTrace();
            }
            EnableTrace();
            bool b = SantasHelpers.ReadElf(filename, ref mem, ref regs);
            return b;
        }

        public void SetForm(ArmSimForm asf)
        {
            myForm = asf;
        }

        public void DisableTrace()
        {
            trace = false;
            filestream.Close();
        }

        public void EnableTrace()
        {
            trace = true;
            filestream = new FileStream("trace.log", FileMode.Create);
        }


        public void Trace(int step, int progCounter, int n, int z, int c, int f, Registers r)
        {
            string tracestr = "";
                string step_num = Convert.ToString(step);
                tracestr += (step_num.PadLeft(6, '0') + " " +
                    string.Format("{0:X8}", progCounter-4) + " " + mem.Hash() + " " +
                    Convert.ToString(n) + Convert.ToString(z) + Convert.ToString(c) +
                    Convert.ToString(f) + " 0=" + string.Format("{0:X8}", 
                    r.ReadWord(0)) + " 1=" + string.Format("{0:X8}", 
                    r.ReadWord(4)) + " 2=" + string.Format("{0:X8}", 
                    r.ReadWord(8)) + " 3=" + string.Format("{0:X8}", 
                    r.ReadWord(12)) + "\r\n");
                tracestr += ("        4=" + string.Format("{0:X8}", 
                    r.ReadWord(16)) + "  5=" + string.Format("{0:X8}", 
                    r.ReadWord(20)) + "  6=" + string.Format("{0:X8}",
                    r.ReadWord(24)) + "  7=" + string.Format("{0:X8}",
                    r.ReadWord(28)) + "  8=" + string.Format("{0:X8}", 
                    r.ReadWord(32)) + "  9=" + string.Format("{0:X8}", 
                    r.ReadWord(36)) + "\r\n");
                tracestr += ("       10=" + string.Format("{0:X8}", 
                    r.ReadWord(40)) + " 11=" + string.Format("{0:X8}", 
                    r.ReadWord(44)) + " 12=" + string.Format("{0:X8}", 
                    r.ReadWord(48)) + " 13=" + string.Format("{0:X8}", 
                    r.ReadWord(52)) + " 14=" + string.Format("{0:X8}", 
                    r.ReadWord(56)) + "\r\n");
                filestream.Write(Encoding.ASCII.GetBytes(tracestr), 0, tracestr.Length);
        }
    }
}
