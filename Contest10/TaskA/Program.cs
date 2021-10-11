using System.IO;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        //ushort n = ushort.Parse(System.Console.ReadLine());
        ushort n;
        ushort[] u;
        using(StreamReader sr = new StreamReader(File.OpenRead("input.txt")))
        {
            n = ushort.Parse(sr.ReadLine());
            u = new ushort[n];
            for(int i = 0; i < n; i++)
            {
                u[i] = ushort.Parse(sr.ReadLine());
            }
        }

        using (BinaryWriter writer = new BinaryWriter(File.Open("output.bin", FileMode.OpenOrCreate,FileAccess.Write)))
        {
            writer.Write(n);
            for (ushort i = 0; i < n; i++)
            {
                writer.Write(u[i]);
            }
        }
    }
}