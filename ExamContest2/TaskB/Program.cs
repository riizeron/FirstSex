    using System;

    class Program
    {
        public static void Main(string[] args)
        {
            // Write your code here
            string[] a = (Console.ReadLine().Split());
            int b=0;
            double count = 0.0;
            foreach(var item in a)
            {
                b+= int.Parse(item);
                count++;
            }
            double f = b / count;
            Console.WriteLine($"{f:F3}");
        }
    }