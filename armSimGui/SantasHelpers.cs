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

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct ELF
    {
        public byte EI_MAG0, EI_MAG1, EI_MAG2, EI_MAG3, EI_CLASS, EI_DATA, EI_VERSION;
        byte unused1, unused2, unused3, unused4, unused5, unused6, unused7, unused8, unused9;
        public ushort e_type;
        public ushort e_machine;
        public uint e_version;
        public uint e_entry;
        public uint e_phoff;
        public uint e_shoff;
        public uint e_flags;
        public ushort e_ehsize;
        public ushort e_phentsize;
        public ushort e_phnum;
        public ushort e_shentsize;
        public ushort e_shnum;
        public ushort e_shstrndx;
    }

    public struct ELFS
    {
        public uint p_type;
        public uint p_offset;
        public uint p_vaddr;
        public uint p_paddr;
        public uint p_filesz;
        public uint p_memsz;
        public uint p_flags;
        public uint p_align;
    }


    // Reads an Elf file into the simulated ram (byte array)
    public class SantasHelpers
    {
        public static bool ReadElf(string elfFilename, ref Memory mem, ref Registers regs)
        {
            Logger.WriteLog("Loader: Opening " + elfFilename + " ...");
            string extension = Path.GetExtension(elfFilename);
            if (extension == ".exe")
            {
                try
                {
                    using (FileStream strm = new FileStream(elfFilename, FileMode.Open))
                    {
                        ELF elfHeader = new ELF();
                        byte[] data = new byte[Marshal.SizeOf(elfHeader)];

                        // Read ELF header data
                        strm.Read(data, 0, data.Length);
                        // Convert to struct
                        elfHeader = ByteArrayToStructure<ELF>(data);
                        // set program counter in Registers
                        regs.SetProgramCounter(elfHeader.e_entry);
                        // set stack pointer in Registers
                        regs.SetStackPointer(0x7000);
                        // Read first program header entry
                        strm.Seek(elfHeader.e_phoff, SeekOrigin.Begin);
                        ELFS[] elfArray = new ELFS[elfHeader.e_phnum];
                        ELFS elfData = new ELFS();
                        for (int i = 0; i < elfHeader.e_phnum; ++i)
                        {
                            data = new byte[elfHeader.e_phentsize];
                            strm.Read(data, 0, (int)elfHeader.e_phentsize);
                            elfData = ByteArrayToStructure<ELFS>(data);
                            elfArray[i] = elfData;
                        }
                        Logger.WriteLog("Loader: Number of Segments -- " + elfArray.Length);
                        Logger.WriteLog("Loader: Program Header Offset -- " + elfData.p_offset);
                        for (int i = 0; i < elfArray.Length; ++i)
                        {
                            Logger.WriteLog("Loader: Segment " + (i + 1) + " - Address = " +
                                elfArray[i].p_vaddr + ", Offset = " + elfArray[i].p_offset +
                                ", Size = " + elfArray[i].p_filesz);
                            strm.Seek(elfArray[i].p_offset, SeekOrigin.Begin);
                            strm.Read(mem.GetRam(), (int)elfArray[i].p_vaddr, (int)elfArray[i].p_filesz);
                        }
                    }
                }
                catch (Exception e)
                {
                    Logger.WriteLog("Loader: Error: File Could Not Be Loaded");
                    return false;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        // Converts a byte array to a struct
        static T ByteArrayToStructure<T>(byte[] bytes) where T : struct
        {
            GCHandle handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
            T stuff = (T)Marshal.PtrToStructure(handle.AddrOfPinnedObject(),
                typeof(T));
            handle.Free();
            return stuff;
        }

    }
}
