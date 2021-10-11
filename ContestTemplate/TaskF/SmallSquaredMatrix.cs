using System;
using System.Windows;
public class SmallSquaredMatrix : IComparable<SmallSquaredMatrix>
{
    public int Dimension { get; }

    public int[][] Matrix;

    public int this[int i, int j]
    {
        get
        {
            return Matrix[i][j];
        }
    }


    int FindDet()
    {

        if (this.Dimension == 1)
        {
            return Matrix[0][0];
        }

        if (Dimension == 2)
            return Matrix[0][0] * Matrix[1][1] - Matrix[0][1] * Matrix[1][0];


        return (Matrix[0][0] * Matrix[1][1] * Matrix[2][2] + Matrix[0][1] * Matrix[1][2] * Matrix[2][0] + Matrix[1][0] * Matrix[2][1] * Matrix[0][2]
        - Matrix[2][0] * Matrix[1][1] * Matrix[0][2] - Matrix[1][0] * Matrix[0][1] * Matrix[2][2] - Matrix[2][1] * Matrix[1][2] * Matrix[0][0]);

    }

    public static SmallSquaredMatrix operator +(SmallSquaredMatrix m1, SmallSquaredMatrix m2)
    {
        if (m1.Dimension != m2.Dimension)
            throw new InvalidOperationException("Could not sum matrices with unequal dimensions");
        int[][] resultMatrix = new int[m1.Dimension][];
        for (int i = 0; i < m1.Dimension; i++)
        {
            resultMatrix[i] = new int[m1.Dimension];
        }
        SmallSquaredMatrix result = new SmallSquaredMatrix(resultMatrix);
        for (int i = 0; i < m1.Dimension; i++)
        {
            for (int j = 0; j < m1.Dimension; j++)
            {
                result.Matrix[i][j] = m1.Matrix[i][j] + m2.Matrix[i][j];
            }
        }
        return result;
    }

    public static SmallSquaredMatrix operator -(SmallSquaredMatrix m1, SmallSquaredMatrix m2)
    {
        if (m1.Dimension != m2.Dimension)
            throw new InvalidOperationException("Could not subtract matrices with unequal dimensions");
        int[][] resultMatrix = new int[m1.Dimension][];
        for (int i = 0; i < m1.Dimension; i++)
        {
            resultMatrix[i] = new int[m1.Dimension];
        }
        SmallSquaredMatrix result = new SmallSquaredMatrix(resultMatrix);
        for (int i = 0; i < m1.Dimension; i++)
        {
            for (int j = 0; j < m1.Dimension; j++)
            {
                result.Matrix[i][j] = m1.Matrix[i][j] - m2.Matrix[i][j];

            }
        }

        return result;
    }

    public SmallSquaredMatrix(int[][] matrix)
    {
        Matrix = matrix;
        Dimension = matrix.GetLength(0);
    }

    public static bool operator <(SmallSquaredMatrix m1, SmallSquaredMatrix m2)
    {

        return ((m1 as IComparable<SmallSquaredMatrix>).CompareTo(m2) < 0);
    }

    public static bool operator >(SmallSquaredMatrix m1, SmallSquaredMatrix m2)
    {
        return ((m1 as IComparable<SmallSquaredMatrix>).CompareTo(m2) > 0);
    }



    int IComparable<SmallSquaredMatrix>.CompareTo(SmallSquaredMatrix other)
    {
        if (this.FindDet() > other.FindDet())
            return 1;
        if (FindDet() == other.FindDet())
            return 0;
        return -1;
    }
}
