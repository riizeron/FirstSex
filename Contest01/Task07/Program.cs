using static System.Console;

namespace Task07
{
    class Program
    {
        static void Main()
        {
            double a;
            if ( (!double.TryParse(ReadLine(), out a))||(a<0) )
            {
                WriteLine("Incorrect input");
            }
            else
            {
                WriteLine((int)((a * 10) % 10));
            }
        }
    }
}
