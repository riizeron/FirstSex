using static System.Console;

namespace Task04
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
                if(a == b)
                {
                    WriteLine("Equal");
                }
                if(a > b)
                {
                    WriteLine("First");
                }   
                if (a < b)
                {
                    WriteLine("Second");
                }
            }
        }
    }
}
