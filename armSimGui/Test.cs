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
    // Holds and runs the unit tests
    public class Test
    {
        public void TestMethods(Options opts)
        {
            Computer comp = new Computer(opts);

            comp.GetMem().WriteWord(0, 34567);
            Debug.Assert(comp.GetMem().ReadWord(0) == 34567);

            short s = 789;
            comp.GetMem().WriteHalfWord(100, s);
            Debug.Assert(comp.GetMem().ReadHalfWord(100) == s);

            byte b = 123;
            comp.GetMem().WriteByte(250, b);
            Debug.Assert(comp.GetMem().ReadByte(250) == b);

            comp.GetMem().SetFlag(500, 3, true);
            Debug.Assert(comp.GetMem().TestFlag(500, 3) == true);

            comp.GetMem().SetFlag(500, 3, false);
            Debug.Assert(comp.GetMem().TestFlag(500, 3) == false);

            Debug.Assert(comp.Load("test1.exe"));
            Debug.Assert(comp.GetMem().Hash() == "3500a8bef72dfed358b25b61b7602cf1".ToUpper());

            Debug.Assert(comp.Load("test2.exe"));
            Debug.Assert(comp.GetMem().Hash() == "0a81d8b63d44a192e5f9f52980f2792e".ToUpper());

            Debug.Assert(comp.Load("test3.exe"));
            Debug.Assert(comp.GetMem().Hash() == "977159b662ac4e450ed62063fba27029".ToUpper());

            //uint progCounter = comp.GetRegs().GetProgramCounter();
            //comp.Step();
            //uint newCounter = comp.GetRegs().GetProgramCounter();
            //Debug.Assert(newCounter > progCounter);
            //comp.GetRegs().IncProgramCounter();
            //Debug.Assert(comp.GetRegs().GetProgramCounter() > newCounter);

            //Debug.Assert(comp.GetCPU().Fetch() == comp.GetMem().ReadWord(
            //    Convert.ToUInt32(comp.GetRegs().GetProgramCounter())));

            Instruction inst = comp.GetCPU().Decode(0xe3a02030);
            comp.GetCPU().Execute(inst);
            string str = inst.ToString();
            Debug.Assert(str == "mov r2, #48");
            Debug.Assert(comp.GetRegs().ReadWord(8) == 48);

            Console.WriteLine("All Tests Passed.");
        }
    }
}
