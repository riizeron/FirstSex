using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

internal static class Program
{
    private static void Main(string[] args)
    {
        string[] str = (Console.ReadLine().Split(','));
        int[][] arr1 = new int[str.Length][];

        arr1[0] = new int[str.Length];
        for (int j = 0; j < str.Length; j++)
        {
            arr1[0][j] = int.Parse(str[j]);
        }

        for(int i = 1; i < str.Length; i++)
        {
            arr1[i] = new int[str.Length];
            for(int j = 0; j < str.Length - 1; j++)
            {
                arr1[i][j] = arr1[i-1][j + 1];
                arr1[i][str.Length - 1] = arr1[i-1][0];
            }
        }

        for(int i = 0; i < str.Length; i++)
        {
            for(int j = 0; j < str.Length; j++)
            {
                Console.Write(arr1[i][j]);
            }
            Console.WriteLine(String.Empty);
        }

        


    }
}