using System.Collections.Generic;
using System;
using System.Text;

internal class ChristmasArray : BaseArray
{
    public ChristmasArray(int []array) : base(array) { }
    public override int this[int number]
    {
        get
        {
            List<int> l = new List<int>();
            bool f = false;
            foreach (var t in array)
            {
                if (t < number)
                {
                    l.Add(t);
                    f = true;
                }
            }
            l.Sort();
            if (f)
            {
                return l[l.Count-1];
            }
            else
            {
                throw new ArgumentException("Number does not exist.");
            }
        }
    }
    public override double GetMetric()
    {
        StringBuilder sb = new StringBuilder();
        double count=0.0;
        foreach(var e in array)
        {
            sb.Append(e.ToString());
            
        }
        foreach(var t in sb.ToString())
        {
            if (t == '6')
            {
                count++;
            }
        }
        return count/sb.Length;

    }
}

