using System;
using System.Collections.Generic;

public class Program
{
    private static void PrintList(List<int> values)
    {
        Console.WriteLine(string.Join(" ", values));
    }

    private static void Transform1(ref int x)
    {
        x = Math.Abs(x);
    }

    private static void Transform2(ref int x)
    {
        x++;
    }

    public static void Main(string[] args)
    {
        List<int> values = new List<int>(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));
        DelegateWorker dw = new DelegateWorker(values);
        dw.Assign(Transform2);
        dw.Invoke();
        Console.WriteLine("First invoke:");
        PrintList(values);
        dw.Assign(Transform1);
        dw.Invoke();
        Console.WriteLine("Second invoke:");
        PrintList(values);
    }
}