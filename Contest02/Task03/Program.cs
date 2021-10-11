using System;

namespace Task03
{
    class Program
    {
        static void Main()
        {
            int a;
            int b;
            
            if ((!int.TryParse(Console.ReadLine(), out a))||(!int.TryParse(Console.ReadLine(), out b))||(a>=b))
            {
                Console.WriteLine("Incorrect input");
            }
            else
            {
                for (int i = a; i < b; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
