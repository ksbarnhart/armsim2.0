using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace armsim
{
    class LSMult : Instruction
    {
        uint fetch, regList, rn, pFlag, uFlag, sFlag, wFlag, lFlag;
        Registers regs;
        Memory mem;
        public LSMult(uint f, ref Registers r, ref Memory m)
        {
            fetch = f;
            regs = r;
            mem = m;
        }

        public override void Decode()
        {
            pFlag = Instruction.GetBits(fetch, 24, 24);
            uFlag = Instruction.GetBits(fetch, 23, 23);
            sFlag = Instruction.GetBits(fetch, 22, 22);
            wFlag = Instruction.GetBits(fetch, 21, 21);
            lFlag = Instruction.GetBits(fetch, 20, 20);
            rn = Instruction.GetBits(fetch, 19, 16);
            regList = Instruction.GetBits(fetch, 15, 0);
        }

        public override void Execute()
        {
            uint regNum = 0, addr, rnVal;
            for (int i = 0; i < 16; ++i)
            {
                if (Instruction.GetBits(fetch, i, i) == 1)
                {
                    ++regNum;
                }
            }

            if (pFlag == 1) // Decrement Before
            {
                addr = rn - (regNum * 4);
            }
            else // Increment After
            {
                addr = rn;
            }

            for (int i = 0; i < 16; ++i)
            {
                if (Instruction.GetBits(fetch, i, i) == 1)
                {
                    if (lFlag == 1)
                    {
                        regs.WriteWord((uint)i * 4, mem.ReadWord(addr));
                    }
                    else
                    {
                        mem.WriteWord(addr, regs.ReadWord((uint)i * 4));
                    }
                    addr += 4;
                }
            }

            if (wFlag == 1)
            {
                rnVal = regs.ReadWord(rn * 4);
                if (pFlag == 1)
                {
                    regs.WriteWord(rn * 4, rnVal - (regNum * 4));
                }
                else
                {
                    regs.WriteWord(rn * 4, rnVal + (regNum * 4));
                }
            }
        }

        public override string ToString()
        {
            string mulstr = "";
            if (lFlag == 1)
            {
                mulstr += string.Format("{0:X8}", fetch) + "   {pop";
            }
            else
            {
                mulstr += string.Format("{0:X8}", fetch) + "   {push";
            }
            for (int i = 0; i < 16; ++i)
            {
                if (Instruction.GetBits(fetch, i, i) == 1)
                {
                    mulstr += " r" + i + ",";
                }
            }
            return mulstr + "}";
        }
    }
}
