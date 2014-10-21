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
    public class CPU
    {
        Registers regs;
        Memory mem;
        public CPU(ref Registers r, ref Memory m)
        {
            regs = r;
            mem = m;
        }

        public uint Fetch()
        {
            uint progCounter = regs.ReadWord(60);
            regs.IncProgramCounter();
            return mem.ReadWord(progCounter);
        }

        public Instruction Decode(uint fetch)
        {
            switch (Instruction.GetBits(fetch, 27, 26))
            {
                //Special Cases?
                case 0: //Data Processing
                    return new DataProcessing(fetch, ref regs);
                case 1: //Load-Store
                    return null;
                case 2: //Branch
                    return null;
            }
            return null;
        }

        public void Execute(Instruction inst)
        {
            inst.Execute();
        }
    }
}
