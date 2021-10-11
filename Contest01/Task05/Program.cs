using System;
using static System.Console;

namespace Task05
{
    class Program
    {
        static void Main()
        {
            string s = ReadLine();
            if ( (!uint.TryParse(s, out uint a))||(s.Length!=4) )
            {
                WriteLine("Incorrect input");
            }
            else
            {
                char[] t = new char[4];
                for (int i = 0; i < 4; i++)
                {
                    t[i] = s[i];
                }
                Array.Reverse(t);
                
                string v = String.Concat<char>(t);

                if (s == v)
                {
                    WriteLine("True");
                }
                else
                {
                    WriteLine("False");
                }

                }
            }
        }
    }

