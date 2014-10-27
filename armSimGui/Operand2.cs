using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace armsim
{
    public class Operand2
    {
        uint rs, rm, shiftType, shift, rotate, immediate, rotimm;
        string type, shiftString;
        Registers regs;
        public Operand2(Registers r)
        {
            regs = r;
        }

        public void Decode(uint fetch)
        {
            if (Instruction.GetBits(fetch, 25, 25) == 1) // immediate bit
            {
                type = "immediate";
                rotate = 2*Instruction.GetBits(fetch, 11, 8);
                immediate = Instruction.GetBits(fetch, 7, 0);
            }
            else
            {
                if (Instruction.GetBits(fetch, 4, 4) == 1) // register shift
                {
                    type = "regShift";
                    shiftType = Instruction.GetBits(fetch, 6, 5);
                    rs = Instruction.GetBits(fetch, 11, 8);
                    rm = Instruction.GetBits(fetch, 3, 0);
                }
                else
                {
                    type = "immShift";
                    shiftType = Instruction.GetBits(fetch, 6, 5);
                    shift = Instruction.GetBits(fetch, 11, 7);
                    rm = Instruction.GetBits(fetch, 3, 0);
                }
            }
            switch (shiftType)
            {
                case 0: // LSL
                    shiftString = "lsl";
                    break;
                case 1: // LSR
                    shiftString = "lsr";
                    break;
                case 2: // ASR
                    shiftString = "asr";
                    break;
                case 3:
                    shiftString = "ror";
                    break;
                default:
                    break;
            }
        }

        public uint Execute()
        {
            uint rmVal = regs.ReadWord(rm * 4);
            switch (type)
            {
                case "immediate":
                    rotimm = (immediate >> (int)rotate) | (immediate << (32 - (int)rotate));
                    return rotimm;
                case "regShift":
                    uint rsVal = regs.ReadWord(rs * 4);
                    return this.Shift(rmVal, (int)rsVal);
                case "immShift":
                    return this.Shift(rmVal, (int)shift);
            }
            return 0;
        }

        public uint Shift(uint rmVal, int shiftVal)
        {
            uint shiftResult = 0;
            switch (shiftType)
            {
                case 0: // LSL
                    shiftResult = rmVal << shiftVal;
                    return shiftResult;
                case 1: // LSR
                    shiftResult = rmVal >> shiftVal;
                    return shiftResult;
                case 2: // ASR
                    shiftResult = (uint)((int)rmVal >> shiftVal);
                    return shiftResult;
                case 3:
                    shiftResult = (rmVal >> shiftVal) | (rmVal << (32 - shiftVal));
                    return shiftResult;
                default:
                    return shiftResult;
            }
        }

        public string ToString()
        {
            switch (type)
            {
                case "immediate":
                    rotimm = (immediate >> (int)rotate) | (immediate << (32 - (int)rotate));
                    return "#" + rotimm;
                case "regShift":
                    return "r" + rm + ", " + shiftString + " r" + rs;
                case "immShift":
                    if (shift == 0)
                    {
                        return "r" + rm;
                    }
                    else
                    {
                        return "r" + rm + ", " + shiftString + " #" + shift;
                    }
            }
            return null;
        }

    }
}
