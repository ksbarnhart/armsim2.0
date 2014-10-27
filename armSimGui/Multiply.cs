using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace armsim
{
    class Multiply : Instruction
    {
        uint fetch, cond, opcode, rd, rm, rs;
        Registers regs;

        public Multiply(uint f, ref Registers r)
        {
            fetch = f;
            regs = r;
            Decode();
        }

        public override void Decode()
        {
            cond = Instruction.GetBits(fetch, 31, 28);
            rd = Instruction.GetBits(fetch, 19, 16);
            rs = Instruction.GetBits(fetch, 11, 8);
            rm = Instruction.GetBits(fetch, 3, 0);
        }

        public override void Execute()
        {
            regs.WriteWord(4 * rd, regs.ReadWord(rm * 4) * regs.ReadWord(rs * 4));
        }

        public override string ToString()
        {
            return string.Format("{0:X8}", fetch) + "   mul r" + rd + ", r" + rm + ", r" + rs;
        }
    }
}
