using System;

public class Vector : IComparable
{
    int x, y;

    public Vector(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public double Length
    {
        get { return Math.Sqrt(x * x + y * y); }
    }

    internal static Vector Parse(string input)
    {
        string[] a = input.Split(' ');
        if (a.Length != 2)
        {
            throw new ArgumentException("Incorrect vector");
        }
        if(!int.TryParse(a[0],out int x)||!int.TryParse(a[1],out int y))
        {
            throw new ArgumentException("Incorrect vector");
        }
        return new Vector(x, y);
    }

    public int CompareTo(object second)
    {
        if (this.Length > ((Vector)second).Length)
        {
            return 1;
        }
        else if (this.Length < ((Vector)second).Length)
        {
            return -1;
        }
        else
        {
            return 0;
        }
        throw new NotImplementedException();
    }
}