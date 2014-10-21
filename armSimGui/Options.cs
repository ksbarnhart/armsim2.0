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
    // Parses the command line arguments and stores them in a dictionary
    public class Options
    {
        string[] args;
        public Dictionary<string, string> parsedArgs;

        public Options(string[] args)
        {
            this.args = args;
            this.parsedArgs = this.Parse();
        }

        public Dictionary<string, string> Parse()
        {
            Dictionary<string, string> parsedArgs = new Dictionary<string, string>();
            for (int i = 0; i < args.Length; ++i)
            {
                switch (args[i])
                {
                    case "--load":
                        ++i;
                        parsedArgs.Add("load", args[i]);
                        break;
                    case "--mem":
                        ++i;
                        parsedArgs.Add("mem", args[i]);
                        break;
                    case "--test":
                        parsedArgs.Add("test", "True");
                        break;
                    case "--exec":
                        parsedArgs.Add("exec", "True");
                        break;
                    default:
                        Console.WriteLine("No option '" + args[i] + "' exists");
                        break;
                }
            }
            if (parsedArgs.ContainsKey("test"))
            {
                return parsedArgs;
            }
            if (!parsedArgs.ContainsKey("mem"))
            {
                parsedArgs.Add("mem", "32768");
            }
            return parsedArgs;
        }

    }
}
