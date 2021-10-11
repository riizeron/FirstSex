using System;
public class Program
{
    public static void Main(string[] args)
    {
        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int[] b = new int[a.Length];
        
        for(int i = 0; i < a.Length; i++)
        {
            int count = 0;
            for(int j = i; j < b.Length; j++)
            {
                if (a[j] > a[i])
                {
                    b[i] = count;
                    break ;
                }
                count++;
            }
        }
        foreach(int t in b)
        {
            Console.Write(t+" ");
        }
    }
}