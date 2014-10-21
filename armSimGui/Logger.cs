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
    // Enables logging to a .log file
    public class Logger
    {
        //Create a Logger Var to use to log to file and designates a place to hold it
        static TextWriterTraceListener myLog = new TextWriterTraceListener("logging.log");

        //This method takes a string of output andwrites it to the logfile
        public static void WriteLog(string info)
        {
            myLog.WriteLine(info);
            myLog.Flush();
        }
    }
}
