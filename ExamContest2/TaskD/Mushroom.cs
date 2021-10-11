using System;
using System.Collections.Generic;

public class Mushroom
{
    private string Name { get; set; }
    private double Weight { get; set; }
    private double Diameter { get; set; }

    private Mushroom(string name, double weight, double diameter)
    {
        Name = name;
        Weight = weight;
        Diameter = diameter;
    }

    public static Mushroom Parse(string line)
    {

        string[] g = line.Split();
        if (g.Length == 3)
        {
            if(double.TryParse(g[1],out double a)&&(double.TryParse(g[2],out double b)&& double.Parse(g[1]) > 0 && double.Parse(g[2]) > 0))
            
            {
                return new Mushroom(g[0], double.Parse(g[1]), double.Parse(g[2]));
            }
            else
            {
                throw new ArgumentException("Incorrect input");

            }
        }
        else
        {
            throw new ArgumentException("Incorrect input");
        }
        throw new NotImplementedException();
    }

    public static double GetAverageDiameter(List<Mushroom> mushrooms, double m)
    {
        double d = 0.0;
        int count = 0;
        foreach (var i in mushrooms)
        {
            if (i.Weight >= m)
            {
                d += i.Diameter;
                count++;
            }
        }
        if (count == 0)
        {
            return 0;
        }
        else
        {
            return d / count;
        }
        throw new NotImplementedException();
    }
}