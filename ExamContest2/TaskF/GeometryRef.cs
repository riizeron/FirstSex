using System;
using System.Collections.Generic;

public class GeometryRef
{
    protected List<Point> points;

    protected virtual List<Point> Points
    {
        get
        {
            return points;
        }
        set => points=value;
    }

    protected GeometryRef(List<Point> points)
    {
        Points = points;
       /* foreach(var i in points)
        {
            this.points.Add(i);
        }*/
    }

    protected virtual double GetPerimeter()
    {
        if (this.points.Count == 3)
        {
            double bc = Math.Sqrt((points[1].X - points[2].X) * (points[1].X - points[2].X) + (points[1].Y - points[2].Y) * (points[1].Y - points[2].Y));
            double ca = Math.Sqrt((points[2].X - points[0].X) * (points[2].X - points[0].X) + (points[2].Y - points[0].Y) * (points[2].Y - points[0].Y));
            double ab = Math.Sqrt((points[0].X - points[1].X) * (points[0].X - points[1].X) + (points[0].Y - points[1].Y) * (points[0].Y - points[1].Y));
            return ab + bc + ca;
        }
        else
        {
            double bc = Math.Sqrt((points[1].X - points[2].X) * (points[1].X - points[2].X) + (points[1].Y - points[2].Y) * (points[1].Y - points[2].Y));
            double cd = Math.Sqrt((points[2].X - points[3].X) * (points[2].X - points[3].X) + (points[2].Y - points[3].Y) * (points[2].Y - points[3].Y));
            double da = Math.Sqrt((points[0].X - points[3].X) * (points[0].X - points[3].X) + (points[0].Y - points[3].Y) * (points[0].Y - points[3].Y));
            double ab = Math.Sqrt((points[0].X - points[1].X) * (points[0].X - points[1].X) + (points[0].Y - points[1].Y) * (points[0].Y - points[1].Y));
            return ab + bc + cd + da;
        }
        
    }

    public virtual double GetSquare()
    {
        if (this.points.ToArray().Length == 3)
        {
            double bc = Math.Sqrt((points[1].X - points[2].X) * (points[1].X - points[2].X) + (points[1].Y - points[2].Y) * (points[1].Y - points[2].Y));
            double ca = Math.Sqrt((points[2].X - points[0].X) * (points[2].X - points[0].X) + (points[2].Y - points[0].Y) * (points[2].Y - points[0].Y));
            double ab = Math.Sqrt((points[0].X - points[1].X) * (points[0].X - points[1].X) + (points[0].Y - points[1].Y) * (points[0].Y - points[1].Y));
            double p = (ab + bc + ca) / 2;
            return  Math.Sqrt(p * (p - ab) * (p - bc)*(p - ca));
        }
        else  
        {
            double bc = Math.Sqrt((points[1].X - points[2].X) * (points[1].X - points[2].X) + (points[1].Y - points[2].Y) * (points[1].Y - points[2].Y));
            double cd = Math.Sqrt((points[2].X - points[3].X) * (points[2].X - points[3].X) + (points[2].Y - points[3].Y) * (points[2].Y - points[3].Y));
            double da = Math.Sqrt((points[0].X - points[3].X) * (points[0].X - points[3].X) + (points[0].Y - points[3].Y) * (points[0].Y - points[3].Y));
            double ab = Math.Sqrt((points[0].X - points[1].X) * (points[0].X - points[1].X) + (points[0].Y - points[1].Y) * (points[0].Y - points[1].Y));
            double p = (ab + bc + cd+da) / 2;
            return  Math.Sqrt((p - ab) * (p - bc) * (p - cd)*(p-da));
        }
        
    }

    public static GeometryRef Parse(string line)
    {
        string f = line.Split()[0];
        string[] p = line.Split();
        List<Point> k = new List<Point>();
        for(int i = 1; i < (p.Length) / 2; i++)
        {
            k.Add(new Point(double.Parse(p[i]), double.Parse(p[i + 1])));
        }

        GeometryRef g = new GeometryRef(k);
        GeometryRef er;
        if (f == "Rectangle")
        {
           er = new Rectangle(g.points);
        }
        else
        {
            er = new Triangle(g.points);
        }
        return er ;
        throw new NotImplementedException();
    }
}