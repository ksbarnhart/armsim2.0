using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace armsim
{
    class SWI : Instruction
    {
        uint fetch;
        public SWI(uint f)
        {
            fetch = f;
        }

        public override string ToString()
        {
            return string.Format("{0:X8}", fetch) + "   swi";
        }
    }
}
