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
    // Simulates Registers with a byte array of 64
    public class Registers : Memory
    {
        // increases R15 by 4
        public void IncProgramCounter()
        {
            uint progCounter = ReadWord(60);
            progCounter += 4;
            WriteWord(60, Convert.ToUInt32(progCounter));
        }

        // sets R15 to the value given
        public void SetProgramCounter(uint progCounter)
        {
            WriteWord(60, progCounter);
        }

        // returns R15
        public uint GetProgramCounter()
        {
            uint progCounter = this.ReadWord(60);
            return progCounter;
        }
    }
}
