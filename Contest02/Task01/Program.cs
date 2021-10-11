using System;

namespace Task01
{
    class Program
    {
        static void Main()
        {

            string s = Console.ReadLine();
            uint a;
            if (!uint.TryParse(s, out a))
            {
                Console.WriteLine("Incorrect input");
            }
            else
            {

                uint k = 0;


                while (a != 0)
                {
                    k += a % 10;
                    a /= 10;
                }
                Console.WriteLine(k);
            }

        }

    }
}

