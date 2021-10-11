using System;
using static System.Console;

namespace Task09
{
    class Program
    {
        static void Main()
        {
            if (!double.TryParse(ReadLine(), out double x))
            {
                WriteLine("Incorrect input");
            }
            else
            {
                int n = (int)x;
                double z = x - n;
                if (x >= 0)
                {


                    if (z == 0.5)
                    {
                        if (n % 2 == 0)
                        {
                            WriteLine(n + 1);
                        }
                        else
                        {
                            WriteLine(n);
                        }
                    }
                    else
                    {
                        WriteLine(Math.Round(x));
                    }
                }
                else
                {
                    if (z == -0.5)
                    {
                        if (n % 2 == 0)
                        {
                            WriteLine(n - 1);
                        }
                        else
                        {
                            WriteLine(n);
                        }
                    }
                    else
                    {
                        WriteLine(Math.Round(x));
                    }
                }
            }
        }
    }
}
