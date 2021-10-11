using System;

public class Apple
{
    double weight;
    string color;
    public double Weight
    {
        get 
        {
            return weight;
        }
        set {
            if (value <= 1000&&value>0)
            {
                weight = value;
            }
            else
            {
                throw new ArgumentException("Incorrect input");
            }
        }
    }
    public string Color
    {
        get {
            return color;
            throw new NotImplementedException();
        }
        set {
            if ((int)value[0] <(int)('A') || (int)(value[0]) > (int)('Z') || value.Length > 5)
            {
                throw new ArgumentException("Incorrect input");
            }
            else
            {
                color = value;
            }
        }
    }

    public override string ToString()
    {
        return ($"{color} Apple. Weight = {weight:f2}g.");
    }
}