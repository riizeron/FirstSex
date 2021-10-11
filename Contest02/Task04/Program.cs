using System;

namespace Task04
{
    class Program
    {
        static void Main()
        {
            double a;
            double b;
            if ((double.TryParse(Console.ReadLine(),out a))&&(double.TryParse(Console.ReadLine(), out b))){
                double k = (a >= b) ? a : b;
                Console.WriteLine(k);
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
