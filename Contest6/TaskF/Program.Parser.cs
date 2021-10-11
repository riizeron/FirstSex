using System;


public partial class Program
{
    static Sheep ParseSheep(string line)
    {
        string[] g = line.Split();
        if (!int.TryParse(g[4], out int y) || int.Parse(g[4]) <= 0 || int.Parse(g[4]) >= 1000)
        {
            throw new ArgumentException("Incorrect input");
        }
        else
        {
            return new Sheep(int.Parse(g[4]), g[1], g[6]);
        }
    }  
}
