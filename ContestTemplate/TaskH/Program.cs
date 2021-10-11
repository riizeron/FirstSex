using System;
using System.Collections.Generic;

public partial class Program
{
    public static void Main(string[] args)
    {
        List<int> lengths = new List<int>();
        List<string> strings = new List<string>();

        IEnumerable<string> result = GetStringsByLength(lengths, strings);

        ReadIntArray(lengths, "lengths.txt");
        ReadStringArray(strings, "strings.txt");
        
        foreach (string line in result)
        {
            Console.WriteLine(line);
        }
    }
}