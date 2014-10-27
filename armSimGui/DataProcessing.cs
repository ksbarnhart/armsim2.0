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
                case 0: // AND
                    regs.WriteWord(4 * rd, rn & op2.Execute());
                    break;
                case 1: // EOR
                    regs.WriteWord(4 * rd, rn ^ op2.Execute());
                    break;
                case 2: // SUB
                    regs.WriteWord(4 * rd, rn - op2.Execute());
                    break;
                case 3: // RSB
                    regs.WriteWord(4 * rd, op2.Execute() - rn);
                    break;
                case 4: // ADD
                    regs.WriteWord(4 * rd, rn + op2.Execute());
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
                case 12: // ORR
                    regs.WriteWord(4 * rd, rn | op2.Execute());
                    break;
                case 13: // MOV
                    regs.WriteWord(4 * rd, op2.Execute());
                    break;
                case 14: // BIC
                    regs.WriteWord(4 * rd, rn & ~(op2.Execute()));
                    break;
                case 15: // MVN
                    regs.WriteWord(4 * rd, ~(op2.Execute()));
                    break;
            }
        }

        public override string ToString()
        {
            switch (opcode)
            {
                case 0: // AND
                    return string.Format("{0:X8}", fetch) + "   and r" + rd + ", r" + rn + ", " + op2.ToString();
                case 1: // EOR
                    return string.Format("{0:X8}", fetch) + "   eor r" + rd + ", r" + rn + ", " + op2.ToString();
                case 2: // SUB
                    return string.Format("{0:X8}", fetch) + "   sub r" + rd + ", r" + rn + ", " + op2.ToString();
                case 3: // RSB
                    return string.Format("{0:X8}", fetch) + "   rsb r" + rd + ", r" + rn + ", " + op2.ToString();
                case 4: // ADD
                    return string.Format("{0:X8}", fetch) + "   add r" + rd + ", r" + rn + ", " + op2.ToString();
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
                case 12: // ORR
                    return string.Format("{0:X8}", fetch) + "   orr r" + rd + ", r" + rn + ", " + op2.ToString();
                case 13: // MOV
                    return string.Format("{0:X8}", fetch) + "   mov r" + rd + ", " + op2.ToString();
                case 14: // BIC
                    return string.Format("{0:X8}", fetch) + "   bic r" + rd + ", r" + rn + ", " + op2.ToString();
                case 15: // MVN
                    return string.Format("{0:X8}", fetch) + "   mvn r" + rd + ", " + op2.ToString();
            }
            return null;
        }
    }
}
