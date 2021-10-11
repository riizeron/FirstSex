﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate void Print(string line);

class Logger
{
    List<LogPair> list = new List<LogPair>();

    public void OutputLogs()
    {
        foreach(LogPair a in list)
        {
            Console.WriteLine(a.ToString());
        }
    }

    public void MakeLog(Print method, string line)
    {
        Print m = method;
        m(line);
    }
}

