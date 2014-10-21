// Program.cs
// Simulates a Loader

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.IO;
using System.Security.Cryptography;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading;

namespace armsim
{
    // Main class; Runs the program
    class ArmSim
    {
        [STAThread]
        static int Main(string[] args)
        {
            Options opts = new Options(args);
            if (opts.parsedArgs.ContainsKey("test"))
            {
                Test t = new Test();
                t.TestMethods(opts);
                return 0;
            }
            else
            {
                Computer comp = new Computer(opts);
                //if (!b)
                //{
                //    Console.WriteLine("Invalid File.");
                //    return 0;
                //}
                // string tst = ram.Hash();
                // Console.Write("\n HASH IS: " + tst + "\n");
                // Console.ReadLine();
                if (opts.parsedArgs.ContainsKey("load"))
                {
                    Memory mem = comp.GetMem();
                    Registers regs = comp.GetRegs();
                    bool b = SantasHelpers.ReadElf(opts.parsedArgs["load"], ref mem, ref regs);
                    if (opts.parsedArgs.ContainsKey("exec"))
                    {

                    }
                }
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new ArmSimForm(comp));

                return 0;
            }

        }
    }
}