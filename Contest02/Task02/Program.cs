using System;

namespace Task02
{
    class Program
    {
        static void Main()
        {
            int k = 0;
            int a;
            string s;
            do
            {
                s = Console.ReadLine();
                if (!int.TryParse(s, out a))
                {
                    Console.WriteLine("Incorrect input");
                    break;
                }
                else
                {
                    if ((a % 2) != 0)
                    {
                        k += a;
                    }
                }
            } while (int.Parse(s)!= 0);
            if (int.TryParse(s, out a))
            {
                Console.WriteLine(k);
            }
        }
    }
}
