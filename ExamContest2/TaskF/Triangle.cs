using System;
using System.Collections.Generic;

public sealed class Triangle : GeometryRef
{
    protected override List<Point> Points
    {
        set
        {
            points = value;
        }
        
    }

    public Triangle(List<Point> points) : base(points)
    {
    }
}