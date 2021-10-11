using System;

public class RegularPolygon : Polygon
{
    double side;
    int numberOfSides;
    public RegularPolygon(double side, int numberOfSides)
    {
        if (side > 0)
        {
            this.side = side;
        }
        else
        {
            throw new ArgumentException("Side length value should be greater than zero.");
        }
        if (numberOfSides >= 3)
        {
            this.numberOfSides = numberOfSides;
        }
        else
        {
            throw new ArgumentException("Number of sides value should be greater than 3.");
        }
    }

    public override double Perimeter => side * numberOfSides;

    public override double Area => 0.25 * numberOfSides * side*side * (1.0 / Math.Tan(Math.PI / numberOfSides));
    public override string ToString() => $"side: {side}; numberOfSides: {numberOfSides}; area: {Area:f3}; perimeter: {Perimeter:f3}";
}