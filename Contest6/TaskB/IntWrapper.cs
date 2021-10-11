using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class IntWrapper
{
    int value;
    public IntWrapper(int number)
    {
        this.value = number;
    }

    public int FindNumberLength()
    {
        if (value >= 0)
        {
            return value.ToString().Length;
        }
        else
        {
            throw new ArgumentException("Number should be non-negative.");
        }
        throw new NotImplementedException();
    }
}
