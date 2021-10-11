using System;
using System.IO;

public class Summator
{
    int sum;
    public Summator(string path)
    {
        using (StreamReader sr = new StreamReader(File.Open(path, FileMode.Open, FileAccess.Read)))
        {
            int[] i = Array.ConvertAll(sr.ReadToEnd().Split('_', '\n'), int.Parse);
            foreach(int c in i)
            {
                sum += c;
            }
        }
    }

    public int Sum
    {
        get
        {
            return sum;
        }
    }
}