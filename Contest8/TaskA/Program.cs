using System;

delegate double Calculate(int n);

class Program
{
    public static void Main(string[] args)
    {
        Calculate s;
        s = x =>
        {

            double res=0;
            for (int i = 1; i < 6; i++)
            {
                double mul = 1;

                for (int j = 1; j < 6; j++)
                {
                    mul *= ((i+42.0)*x)/(j*j);
                }
                res += mul;
            }
            
            return res;

        };


        Console.WriteLine($"{s(int.Parse(Console.ReadLine())):F3}");
    }


}