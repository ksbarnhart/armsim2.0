using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace armsim
{
    class LoadStore : Instruction
    {
        Registers regs;
        Memory mem;
        Operand2 op2;
        uint fetch, cond, rn, rd, immbit, pFlag, uFlag, bFlag, wFlag, lFlag, imm;
        public LoadStore(uint f, ref Registers r, ref Memory m)
        {
            fetch = f;
            regs = r;
            mem = m;
            op2 = new Operand2(r);
            Decode();
        }

        public override void Decode()
        {
            cond = Instruction.GetBits(fetch, 31, 28);
            immbit = Instruction.GetBits(fetch, 25, 25);
            pFlag = Instruction.GetBits(fetch, 24, 24);
            uFlag = Instruction.GetBits(fetch, 23, 23);
            bFlag = Instruction.GetBits(fetch, 22, 22);
            wFlag = Instruction.GetBits(fetch, 21, 21);
            lFlag = Instruction.GetBits(fetch, 20, 20);
            rn = Instruction.GetBits(fetch, 19, 16);
            rd = Instruction.GetBits(fetch, 15, 12);
            if (immbit == 1)
            {
                fetch = fetch ^ 0x02000000;
                op2.Decode(fetch);
            }
            else
            {
                imm = Instruction.GetBits(fetch, 11, 0);
            }
        }

        public override void Execute()
        {
            uint rnaddr = regs.ReadWord(4 * rn);
            uint rdval = regs.ReadWord(4 * rd);
            switch (lFlag)
            {
                case 0:
                    if (immbit == 1)
                    {
                        mem.WriteWord(rnaddr + op2.Execute(), rdval);
                    }
                    else
                    {
                        mem.WriteWord(rnaddr + imm, rdval);
                    }
                    break;
                case 1:
                    uint load;
                    if (immbit == 1)
                    {
                        load = mem.ReadWord(rnaddr + op2.Execute());
                        regs.WriteWord(rd * 4, load);
                    }
                    else
                    {
                        load = mem.ReadWord(rnaddr + imm);
                        regs.WriteWord(rd * 4, load);

                    }
                    break;
            }
        }

        public override string ToString()
        {
            switch (lFlag)
            {
                case 0:
                    if (immbit == 1)
                    {
                        return string.Format("{0:X8}", fetch) + "   str r" + rd + ", [r" + rn + ", " + op2.ToString() + "]";
                    }
                    else
                    {
                        if (imm > 0)
                        {
                            return string.Format("{0:X8}", fetch) + "   str r" + rd + ", [r" + rn + ", #" + imm + "]";
                        }

                        return string.Format("{0:X8}", fetch) + "   str r" + rd + ", [r" + rn + "]";
                    }
                case 1:
                    if (immbit == 1)
                    {
                        return string.Format("{0:X8}", fetch) + "   ldr r" + rd + ", [r" + rn + ", " + op2.ToString() + "]";
                    }
                    else
                    {
                        if (imm > 0)
                        {
                            return string.Format("{0:X8}", fetch) + "   ldr r" + rd + ", [r" + rn + ", #" + imm + "]";
                        }

                        return string.Format("{0:X8}", fetch) + "   ldr r" + rd + ", [r" + rn + "]";
                    }
            }
            return null;
        }
    }
}
