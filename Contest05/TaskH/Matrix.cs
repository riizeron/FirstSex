using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

internal class Matrix
{
    int[,] matrix;

    public Matrix(string filename)
    {
        string[] s = File.ReadAllLines(filename);
        int j = 0;
        matrix = new int[s.Length, s[0].Split(';').Length];
        foreach(string v in s)
        {
            string[] m = v.Split(';');
            for(int i = 0; i < m.Length; i++)
            {
                matrix[j, i] = int.Parse(m[i]);
            }
            j++;
        }
        
        
    }

    public int SumOffEvenElements
    {
        get
        {
            int k = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        k += matrix[i, j];
                    }
                }
            }
            return k;
            throw new NotImplementedException();
        }
    }


    public override string ToString()
    {
        string s;
        string[] f = new string[matrix.GetLength(0)];
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            List<string> g = new List<string>(); 
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                g.Add(matrix[i, j].ToString()+"\t" );
            }
            f[i] = String.Concat<string>(g)+Environment.NewLine;
        }
        s = String.Concat<string>(f);
        return s;
        throw new NotImplementedException();
    }
}