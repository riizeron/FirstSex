using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        int x;
        // Write your code here
        List<int> a = new List<int>();
        do
        {

            x = int.Parse(Console.ReadLine());
            if (x==0||x >= 100 && x <= 150)
            {
                a.Add(x);
            }
            else
            {
                Console.WriteLine("Incorrect number");
            }

        } while (x != 0);
        int[] b = a.ToArray();
        Array.Sort(b);
        Console.WriteLine(b[b.Length-1]);
        Console.WriteLine(b[b.Length-2]);

    }
}