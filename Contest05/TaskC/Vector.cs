using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Globalization;

partial class Program
{
    static bool TryParseVectorFromFile(string filename, out int[] vector)
    {
        bool flag = true;
        string[] a = File.ReadAllText(filename).Split();
        vector = new int[a.Length];
        for (int i = 0; i < a.Length; i++)
        {
            if (!int.TryParse(a[i], out vector[i]))
            {
                flag = false;
            }

        }

        return flag;
    }

    static int[,] MakeMatrixFromVector(int[] vector)
    {
        int[,] matrix1 = new int[vector.Length, 1];
        int[,] matrix2 = new int[1, vector.Length];
        int[,] matrix = new int[vector.Length, vector.Length];
        for (int i = 0; i < vector.Length; i++)
        {
            matrix1[i, 0] = vector[i];
            matrix2[0, i] = vector[i];

        }

        for (int i = 0; i < vector.Length; i++)
        {
            for (int j = 0; j < vector.Length; j++)
            {
                matrix[i, j] = matrix1[i, 0] * matrix2[0, j];
            }


        }



        return matrix;
    }

    static void WriteMatrixToFile(int[,] matrix, string filename)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            string[] str = new string[matrix.GetLength(1)];
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                File.AppendAllText(filename, matrix[i, j].ToString()+" ");
            }
            File.AppendAllText(filename, String.Empty+Environment.NewLine);
        }
    }
}
