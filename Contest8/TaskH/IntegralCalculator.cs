using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class IntegralCalculator
{
    public static void InsertParameter(int param)
    {
        
            switch (param)
            {
                case 0:
                    Program.func = S;
                    break;
                case 1:
                    Program.func = C;
                    break;
                case 2:
                    Program.func = T;
                    break;
            }
        
    }
    

    public static double S(double a,double b)
    {
        double res=0;
        for(double i = a; i <= b;)
        {
            res += (Math.Sin(i) + Math.Sin(i+=Program.EPSYLON))* Program.EPSYLON / 2;
        }
        return res;
    }
    public static double C(double a, double b)
    {
        double res = 0;
        for (double i = a; i <= b;)
        {
            res += (Math.Cos(i) + Math.Cos(i += Program.EPSYLON))* Program.EPSYLON / 2;
        }
        return res;
    }
    public static double T(double a, double b)
    {
        double res = 0;
        for (double i = a; i <= b;)
        {
            res += (Math.Tan(i) + Math.Tan(i += Program.EPSYLON)) *Program.EPSYLON/ 2;
        }
        return res;
    }
}

