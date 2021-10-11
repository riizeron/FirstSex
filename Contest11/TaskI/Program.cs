using System;
public class Program
{
    public static void Main(string[] args)
    {
        int amount = int.Parse(Console.ReadLine());
        int count = int.Parse(Console.ReadLine());
        (int, int)[] arr = new (int, int)[count];
        for(int i = 0; i < count; i++)
        {
            int[] tt = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            arr[i] = (tt[0], tt[1]);
        }
        Array.Sort(arr, CompareTo1);
        (int, int)[] lj = new (int, int)[amount];
        for(int i = 0; i < amount; i++)
        {
            lj[i] = arr[i];
        }
        Array.Sort(lj, CompareTo2);
        
        
        for (int i = 0; i < amount; i++)
        {
            Console.WriteLine(lj[i]);
        }
        static int CompareTo1((int,int) o1,(int,int)o2)
        {
            double r = Math.Sqrt(o1.Item1 * o1.Item1 + o1.Item2 * o1.Item2);
            double q = Math.Sqrt(o2.Item1 * o2.Item1 + o2.Item2 * o2.Item2);
            if (r > q)
            {
                return 1;
            }
            else if (r < q)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        static int CompareTo2((int, int) o1, (int, int) o2)
        {
            if (o1.Item1 > o2.Item1)
            {
                return 1;
            }
            else if (o1.Item1 < o2.Item1)
            {
                return -1;
            }
            else
            {
                if (o1.Item2 > o2.Item2)
                {
                    return 1;
                }
                else if (o1.Item2 < o2.Item2)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}