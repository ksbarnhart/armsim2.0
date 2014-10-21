using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace armsim
{
    class DataProcessing : Instruction
    {
        uint fetch, cond, opcode, rn, rd;
        Registers regs;
        Operand2 op2;
        public DataProcessing(uint f, ref Registers r)
        {
            fetch = f;
            regs = r;
            op2 = new Operand2(regs);
            Decode();
        }

        public override void Decode()
        {
            cond = Instruction.GetBits(fetch, 31, 28);
            opcode = Instruction.GetBits(fetch, 24, 21);
            rn = Instruction.GetBits(fetch, 19, 16);
            rd = Instruction.GetBits(fetch, 15, 12);
            op2.Decode(fetch);
        }

        public override void Execute()
        {
            switch (opcode)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    break;
                case 11:
                    break;
                case 12:
                    break;
                case 13: //MOV
                    regs.WriteWord(4 * rd, op2.Execute());
                    break;
                case 14:
                    break;
                case 15:
                    break;
            }
        }

        public override string ToString()
        {
            switch (opcode)
            {
                case 0:
                    return null;
                case 1:
                    return null;
                case 2:
                    return null;
                case 3:
                    return null;
                case 4:
                    return null;
                case 5:
                    return null;
                case 6:
                    return null;
                case 7:
                    return null;
                case 8:
                    return null;
                case 9:
                    return null;
                case 10:
                    return null;
                case 11:
                    return null;
                case 12:
                    return null;
                case 13: //MOV
                    return "mov r" + rd + ", " + op2.ToString();
                case 14:
                    return null;
                case 15:
                    return null;
            }
            return null;
        }
    }
}
