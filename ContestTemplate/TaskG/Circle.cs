using System;
public class Circle :Figure
{
    public double rad;
    public Circle(double x, double y, double rad) : base(x, y)
    {
        if (rad < 0) { throw new ArgumentException("Invalid circle"); }
        this.rad = rad;
    }

}