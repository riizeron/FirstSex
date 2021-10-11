using static System.Console;

namespace Task06
{
    class Program
    {
        static void Main()
        {

            if ( (!double.TryParse(ReadLine(), out double a) || (!double.TryParse(ReadLine(), out double b)))|| (a<=0)||(b<=0) )
            {
                WriteLine("Incorrect input");
            }
            else
            {
                double c = System.Math.Sqrt(a * a + b * b);
                WriteLine($"{c:#.#####}");
            }
        }   
    }
}
