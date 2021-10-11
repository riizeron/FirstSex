using System;

public delegate void Calc(ref double x);

class StackCalculator
{
    public static void CreateRules(int[] args)
    {
        foreach(int i in args)
        {
            switch (i)
            {
                case 0:
                    Program.func += S;
                    break;
                case 1:
                    Program.func += C;
                    break;
                case 2:
                    Program.func += T;
                    break;
            }
        }

    }
    
    public static void S(ref double x)
    {
        x = Math.Sin(x);
    }
    public static void C(ref double x)
    {
        x = Math.Cos(x);
    }
    public static void T(ref double x)
    {
        x = Math.Tan(x);
    }
}