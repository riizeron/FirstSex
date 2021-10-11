using System;

public partial class Program
{
    private static int[] ReadIntArrayFromString(string input)
    {
        return Array.ConvertAll(input.Split(), int.Parse);

    }

    private static void StrangeSort(int[] array)
    {
        int len = array.Length;
        if (len % 2 == 0)
        {
            Array.Sort(array, 0, len / 2);
            Array.Sort(array, len / 2, len / 2);
            Array.Reverse(array, len /2,len/2);
        }
        else
        {
            Array.Sort(array, 0, len / 2);
            Array.Sort(array, len / 2+1 , len / 2);
            Array.Reverse(array, len / 2+1 , len / 2);
        }



    }
}