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

            uint progCounter = comp.GetRegs().GetProgramCounter();
            comp.Step();
            uint newCounter = comp.GetRegs().GetProgramCounter();
            Debug.Assert(newCounter > progCounter);
            comp.GetRegs().IncProgramCounter();
            Debug.Assert(comp.GetRegs().GetProgramCounter() > newCounter);

            Instruction inst = comp.GetCPU().Decode(0xE3A02030);
            comp.GetCPU().Execute(inst);
            string str = inst.ToString();
            Debug.Assert(str == "E3A02030   mov r2, #48");
            Debug.Assert(comp.GetRegs().ReadWord(8) == 48);

            inst = comp.GetCPU().Decode(0xE3E03001);
            comp.GetCPU().Execute(inst);
            str = inst.ToString();
            Debug.Assert(str == "E3E03001   mvn r3, #1");
            int mvn = ~1;
            Debug.Assert((int)comp.GetRegs().ReadWord(12) == mvn);

            inst = comp.GetCPU().Decode(0xE2445003);
            comp.GetCPU().Execute(inst);
            str = inst.ToString();
            Debug.Assert(str == "E2445003   sub r5, r4, #3");

            inst = comp.GetCPU().Decode(0xE2645003);
            comp.GetCPU().Execute(inst);
            str = inst.ToString();
            Debug.Assert(str == "E2645003   rsb r5, r4, #3");

            inst = comp.GetCPU().Decode(0xE20020FF);
            comp.GetCPU().Execute(inst);
            str = inst.ToString();
            Debug.Assert(str == "E20020FF   and r2, r0, #255");
            Debug.Assert(comp.GetRegs().ReadWord(8) == comp.GetRegs().ReadWord(0));

            inst = comp.GetCPU().Decode(0xE3802012);
            comp.GetCPU().Execute(inst);
            str = inst.ToString();
            Debug.Assert(str == "E3802012   orr r2, r0, #18");

            inst = comp.GetCPU().Decode(0xE2202FB7);
            comp.GetCPU().Execute(inst);
            str = inst.ToString();
            Debug.Assert(str == "E2202FB7   eor r2, r0, #732");


            Console.WriteLine("All Tests Passed.");
        }
    }
}
