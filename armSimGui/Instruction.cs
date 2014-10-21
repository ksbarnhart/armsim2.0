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

    // Contains the information of the decoded instruction
    public abstract class Instruction
    {
        public Instruction()
        {

        }

        public virtual void Decode()
        {

        }

        public virtual void Execute()
        {

        }

        public virtual string ToString()
        {
            return null;
        }

        public static uint GetBits(uint data, int start, int end)
        {
            return data << (31 - start) >> (31 - start + end);
        }
    }
}
