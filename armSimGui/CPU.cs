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
            // Special Cases
            if (Instruction.GetBits(fetch, 27, 24) == 15)
            { // SWI
                return new SWI(fetch);
            } else if (Instruction.GetBits(fetch, 27, 21) == 0 &&
                Instruction.GetBits(fetch, 7, 4) == 9)
            { // Multiply
                return new Multiply(fetch, ref regs);
            }
            switch (Instruction.GetBits(fetch, 27, 26))
            {
                case 0: //Data Processing
                    return new DataProcessing(fetch, ref regs);
                case 1: //Load-Store
                    return new LoadStore(fetch, ref regs, ref mem);
                case 2:
                    if (Instruction.GetBits(fetch, 25, 25) == 1) // Branch
                    {

                    }
                    else // LSMult
                    {
                        return new LSMult(fetch, ref regs, ref mem);
                    }
                    return null;
            }
            return null;
        }

        public void Execute(Instruction inst)
        {
            if (inst != null)
            {
                inst.Execute();
            }
        }
    }
}
