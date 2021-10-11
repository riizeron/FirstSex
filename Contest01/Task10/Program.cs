using static System.Console;

namespace Task10
{
    class Program
    {
        static void Main()
        {
            if ( (!double.TryParse(ReadLine(),out double x))||(!double.TryParse(ReadLine(), out double y)))
            {
                WriteLine("Incorrect input");
            }
            else
            {
                if ( (x*x+y*y<=2)||(x*x+y*y<=1))
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
