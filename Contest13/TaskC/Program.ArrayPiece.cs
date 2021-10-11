using System;
using System.Numerics;

public partial class Program
{
    private static BigInteger[,] GetArrayPart(int x1, int y1, int x2, int y2)
    {
        int[] a1 = new int[] { x2 - x1+1,y2-y1 +1};
        int[] a2 = new int[] { x1, y1 };

        BigInteger[,] a = (BigInteger[,])Array.CreateInstance(typeof(BigInteger), a1, a2);
        for (int i = x1; i <= x2 ; i++)
        {
            for(int j = y1; j <= y2 ; j++)
            {
                a[i, j] = (BigInteger)i * (BigInteger)j;
            }
        }
        return a;
    }
}