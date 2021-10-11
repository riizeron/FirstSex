using System;

public abstract class Function
{
    public static string _name;
    public string Name { get;set; }
    
    public static Function GetFunction(string functionName)
    {
        if (functionName == "Sin" || functionName == "Exp" || functionName == "Parabola")
        {

            _name = functionName;
            if (functionName == "Sin")
            {
                Sin f = new Sin();
                return f;

            }
            else if (functionName == "Exp") 
            {
                Exponent f = new Exponent();
                return f;

            }
            else if (functionName == "Parabola")
            {
                Parabola f = new Parabola();
                return f;

            }
            throw new ArgumentException("Incorrect input");

        }
        else
        {
            throw new ArgumentException("Incorrect input");
        }

    }

    public abstract double GetValueInX(double x);

    public static double SolveIntegral(Function func, double left, double right, double step)
    {
        if ((left > right))
        {
            throw new ArgumentException("Left border greater than right");
        }

        double res = 0;
        int check = (int)((right - left) / step);
        double ost = right - left - step * check;
        double k = left;

        if (Function._name == "Sin")
        {
            if (right % Math.PI == 0 || left % Math.PI == 0)
            {
                throw new ArgumentException("Function is not defined in point");
            }
            for(double i = 0; i <check; i ++)
            {
                res += ((1 / Math.Sin(k) + 1 / Math.Sin(k + step)) / 2 * step);
                k += step;
            }
            res += ((1 / Math.Sin(right-ost) + 1 / Math.Sin(right)) / 2 * ost);
            return res; 
        } 
        else if (Function._name == "Exp")
        {
            if (right == 0 || left == 0)
            {
                throw new ArgumentException("Function is not defined in point");
            }
            for(double i = 0; i <check; i ++)
            {
                res+=((Math.Exp(1/k)+Math.Exp(1/(k+step)))/2)*step;
                k += step;
            }
            res += ((Math.Exp(1 / (right-ost)) + Math.Exp(1 / (right))) / 2) * ost;

            return res;
        }
        else if(Function._name=="Parabola")
        {
           
            for(double i = 0; i < check; i ++)
            {
                res += ((k * k + k + 7) + ((k + step) * (k + step) + (k + step) + 7)) / 2 * step;
                k += step;
            }
            res+= (((right-ost) * (right-ost) + (right-ost) + 7) + ((right) * (right) + (right) + 7)) / 2 * ost;
            return res;
        }
        throw new NotImplementedException();
    }
}
