using System;
using System.IO;
using System.Collections.Generic;

public partial class Program
{
    List<string> strings;
    private static void ReadIntArray(List<int> ints, string path)
    {
        using (StreamReader sr = new StreamReader(path))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                ints.Add(int.Parse(line));
            }
        }
    }

    private static void ReadStringArray(List<string> strings, string path)
    {
        using(StreamReader sr = new StreamReader(path))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                strings.Add(line);
            }
        }
    }
    
    private static IEnumerable<string> GetStringsByLength(List<int> lengths, List<string> strings)
    {
        List<string> en = new List<string>();
        foreach(var a in lengths)
        {
            foreach(var b in strings)
            {
                if (b.Length == a)
                {
                    yield return b;
                }
            }
        }
        //return en;
    }
}