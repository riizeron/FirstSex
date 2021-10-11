using static System.Console;

namespace Task03
{
    class Program
    {
        static void Main()
        {
            uint a;
            if ( (!uint.TryParse(ReadLine(), out a)) )
            {
                WriteLine("Incorrect input");
            }
            else
            {
                WriteLine(a % 10);
            }
        }
    }
}
