using System;

public class MartianInt
{
    private int value;
    private static int count = 0;

    public MartianInt(int value)
    {
        this.value = value + count;
    }

    public int Value => value;
    public static explicit operator int(MartianInt m)
    {
        count++;
        if (m.value + count < 0)
        {
            throw new ArgumentException("Value is negative");
        }
        m.value += count;
        return m.Value;
    }
    public static implicit operator MartianInt(int m)
    {
        count++;
        if (m - count < 0)
        {
            throw new ArgumentException("Value is negative");
        }
        m -= count;
        return m;
    }
}