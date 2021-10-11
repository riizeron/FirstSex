using System;
using System.Collections.Generic;
using System.Text;
public class Field
{
    public int[][] matrix;
    int type;
    public Field(int[][] matrix)
    {
        this.matrix = matrix;


    }

    public void FillIn(string fillType)
    {
        if (fillType == ("left to right"))
        {
            this.type = 2;
        }
        else if (fillType == ("right to left"))
        {
            this.type = 1;
        }
        else
        {
            throw new ArgumentException("Incorrect input");
        }
        int size = matrix.GetLength(0);
        if (type == 1)
        {
            for (int i = 0; i < size; i++)
            {
                int[] a = new int[size];
                int y = size + i;
                for (int j = 0; j < size; j++)
                {
                    a[j] = y--;
                }
                matrix[i] = a;
            }
        }
        else if (type == 2)
        {
            for (int i = 0; i < size; i++)
            {
                int[] a = new int[size];
                int y = i+1;
                for (int j = 0; j < size; j++)
                {
                    a[j] = y++;
                }
                matrix[i] = a;
            }
        }
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        int s = matrix.GetLength(0);
        List<string> l = new List<string>();
        for (int i = 0; i < s; i++)
        {
            for (int j = 0; j < s; j++)
            {
                sb.Append(matrix[i][j].ToString());
                if (j != s)
                {
                    sb.Append(" ");
                }
            }
            if (i != s)
            {
                sb.Append(Environment.NewLine);
            }
        }

        return sb.ToString();
    }
}