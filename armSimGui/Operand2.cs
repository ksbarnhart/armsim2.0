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
        string type;
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

        }

        public uint Execute()
        {
            switch (type)
            {
                case "immediate":
                    rotimm = (immediate >> (int)rotate) | (immediate << (32 - (int)rotate));
                    return rotimm;
                case "regShift":
                    return 0;
                case "immShift":
                    return 0;
            }
            return 0;
        }

        public string ToString()
        {
            switch (type)
            {
                case "immediate":
                    return "#" + rotimm;
                case "regShift":
                    return null;
                case "immShift":
                    return null;
            }
            return null;
        }

    }
}
