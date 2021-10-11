using static System.Console;

namespace Task08
{
    class Program
    {
        static void Main()
        {
            if ( (!char.TryParse(ReadLine(), out char x))||((int)x<97)||((int)x>122) )
            {
                WriteLine("Incorrect input");
            }
            else
            {
                WriteLine((int)x - 96);
            }
        }
    }
}
