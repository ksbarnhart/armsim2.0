
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
    // Simulates RAM with a byte array of a given size
    public class Memory
    {
        byte[] ram;

        public Memory()
        {

        }

        public Memory(int size)
        {
            ram = new byte[size];
        }

        public byte[] GetRam()
        {
            return ram;
        }

        public void SetMem(int size)
        {
            ram = new byte[size];
        }

        // clears the ram array
        public void ClearMem()
        {
            Array.Clear(ram, 0, ram.Length);
        }

        // generates a hash value for the ram array contents and outputs it to the console
        public string Hash()
        {
            MD5 m = MD5.Create();
            byte[] hash = m.ComputeHash(ram);
            string tst = BitConverter.ToString(hash).Replace("-", "");
            Logger.WriteLog(tst);
            return tst;
        }

        // Reads 4 bytes from ram starting at the address given and returns it as an int
        public uint ReadWord(uint addr)
        {
            uint rword = 0;
            if ((addr % 4) == 0)
            {
                byte[] bytes = new byte[4];
                for (int i = 0; i < 4; ++i)
                {
                    bytes[i] = ram[addr + i];
                }
                rword = BitConverter.ToUInt32(bytes, 0);
                //Convert.ToUInt32(BitConverter.ToInt32(ram, Convert.ToInt32(addr)));
            }
            else
            { // if the address !divisible by 4
                return 0;
            }
            return rword;
        }

        // Writes an int given into ram as 4 bytes starting at the given address
        public void WriteWord(uint addr, uint wword)
        {
            byte[] bytes = new byte[4];
            if ((addr % 4) == 0)
            {
                bytes = BitConverter.GetBytes(wword);
                //Array.Reverse(bytes);
                for (int i = 0; i < 4; ++i)
                {
                    ram[addr + i] = bytes[i];
                }
            }
        }

        // Reads 2 bytes from the ram array starting at the given address and returns them as a short
        public short ReadHalfWord(int addr)
        {
            short rhword = 0;
            if ((addr % 2) == 0)
            {
                rhword = BitConverter.ToInt16(ram, addr);
            }
            else
            { // if the address !divisible by 2
                return -1;
            }
            return rhword;
        }

        // Writes a short into the ram array as 2 bytes
        public void WriteHalfWord(int addr, short whword)
        {
            byte[] bytes = new byte[2];
            if ((addr % 2) == 0)
            {
                bytes = BitConverter.GetBytes(whword);
                //Array.Reverse(bytes);
                for (int i = 0; i < 2; ++i)
                {
                    ram[addr + i] = bytes[i];
                }
            }
        }

        // Reads a byte from the ram array at the given address and returns it
        public byte ReadByte(int addr)
        {
            return ram[addr];
        }

        // Writes a given byte to the ram array at the given address
        public void WriteByte(int addr, byte wbyte)
        {
            ram[addr] = wbyte;
        }

        // Reads 4 bytes from ram starting at the address given and returns the value of the specified bit as a bool
        public bool TestFlag(uint addr, byte bit)
        {
            byte[] bytes = new byte[4];
            bytes = BitConverter.GetBytes(ReadWord(addr));
            BitArray bits = new BitArray(bytes);
            return bits[bit];
        }

        // Sets the bit specified in the 4 bytes starting at the given address to the value of the flag
        public void SetFlag(uint addr, byte bit, bool flag)
        {
            if (bit < 0 || bit > 31)
            {
                return;
            }
            byte[] bytes = new byte[4];
            bytes = BitConverter.GetBytes(ReadWord(addr));
            BitArray bits = new BitArray(bytes);
            bits[bit] = flag;
            bits.CopyTo(bytes, 0);
            WriteWord(addr, BitConverter.ToUInt32(bytes, 0));
        }
    }
}
