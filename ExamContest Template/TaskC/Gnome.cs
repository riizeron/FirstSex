using System;
using System.Linq;

public class Gnome
{
    private double weight;
    private int height;

    public static Gnome GetGnome(string[] inputLines, double minWeight, int neededHeight)
    {
        Gnome[] gnomes = new Gnome[inputLines.Length];
        int i = 0;
        foreach(string str in inputLines)
        {
            string[] s = str.Split(' ');
            gnomes[i++] = new Gnome(double.Parse(s[0]), int.Parse(s[1]));
        }

        var li = from gn in gnomes
                 where gn.weight > minWeight
                 select gn;
        var nor = from gn in li
                  where gn.height == neededHeight
                  select gn;
        
        return nor.Count()==0?null:nor.Last();
    }

    private Gnome(double weight, int height)
    {
        if (weight<=0||weight > 50)
        {
            throw new ArgumentException("Incorrect weight");
        }
        else if (height<=0||height >= 100)
        {
            throw new ArgumentException("Incorrect height");
        }
        this.weight = weight;
        this.height = height;
    }
    public override string ToString()
    {
        return $"{weight:f2} {height}";
    }
}