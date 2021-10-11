using System;
using System.Collections.Generic;

partial class Program
{
    internal static int[] StrangeSort(int[] arr)
    {
        int[] lul = new int[arr.Length];
        int y = 0;
        foreach(int i in arr)
        {
            lul[y] = i;
            y++;
        }
        Array.Sort(lul, S);
        return lul;
    }
    private static int S(int x, int y)
    {
        if (x.ToString().Length > y.ToString().Length)
        {
            return 1;
        }
        else if (x.ToString().Length < y.ToString().Length)
        {
            return -1;
        }
        else return 0;
    }
    
}