using static System.Console;

namespace Task02
{
    class Program
    {
        static void Main()
        {
            int a, b;

            if ( (!int.TryParse(ReadLine(), out a)) || (!int.TryParse(ReadLine(), out b)) )
            {
                WriteLine("Incorrect input");
            }
            else
            {
                WriteLine(a - b);
            }
                
        }
    }
}
