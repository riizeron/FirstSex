using System;

public partial class Program
{
    public static void Main(string[] args)
    {
        int[] array = ReadIntArrayFromString(Console.ReadLine());
        StrangeSort(array);
        
        Console.WriteLine(string.Join(' ', array));
    }
}