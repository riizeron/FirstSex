using System;

public class Triangle
{
    private readonly Point a;
    private readonly Point b;
    private readonly Point c;

    private double AB => GetLengthOfSide(a, b);
    private double AC => GetLengthOfSide(a, c);
    private double BC => GetLengthOfSide(b, c);

    public Triangle(Point a, Point b, Point c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public double GetPerimeter()
    {
        return AB + AC + BC;
        throw new NotImplementedException();
    }

    public double GetSquare()
    {
        double p = (AB + AC + BC) / 2.0;
        return Math.Sqrt(p * (p - AB) * (p - BC) * (p - AC));
        throw new NotImplementedException();
    }

    public bool GetAngleBetweenEqualsSides(out double angle)
    {
        angle = 0;
        if (AB == AC || AB == BC || AC == BC)
        {
            //AB
            double[] A = { b.GetX() - a.GetX(), b.GetY() - a.GetY() };
            double ax = b.GetX() - a.GetX();
            double ay = b.GetY() - a.GetY();
            //BC
            double[] B = { c.GetX() - b.GetX(), c.GetY() - b.GetY() };
            double bx = c.GetX() - b.GetX();
            double by = c.GetY() - b.GetY();
            //AC
            double[] C = { c.GetX() - a.GetX(), c.GetY() - a.GetY() };
            double cx = c.GetX() - a.GetX();
            double cy = c.GetY() - a.GetY();
            if (AB == BC)
            {
                angle = Math.Acos((ax * bx + ay * by) / (Math.Sqrt(ax * ax + ay * ay) * Math.Sqrt(bx * bx + by * by)));
            }
            else if (AB == AC)
            {
                angle = Math.Acos((ax * cx + ay * cy) / (Math.Sqrt(ax * ax + ay * ay) * Math.Sqrt(cx * cx + cy * cy)));
            }
            else if (AC == BC)
            {
                angle = Math.Acos((cx * bx + cy * by) / (Math.Sqrt(cx * cx + cy * cy) * Math.Sqrt(bx * bx + by * by)));
            }
            return true;

        }
        else
        {

            return false;
        }
        throw new NotImplementedException();
    }

    public bool GetHypotenuse(out double hypotenuse)
    {
        hypotenuse = 0;
        //AB
        double[] A = { b.GetX() - a.GetX(), b.GetY() - a.GetY() };
        double ax = b.GetX() - a.GetX();
        double ay = b.GetY() - a.GetY();
        //BC
        double[] B = { c.GetX() - b.GetX(), c.GetY() - b.GetY() };
        double bx = c.GetX() - b.GetX();
        double by = c.GetY() - b.GetY();
        //AC
        double[] C = { c.GetX() - a.GetX(), c.GetY() - a.GetY() };
        double cx = c.GetX() - a.GetX();
        double cy = c.GetY() - a.GetY();

        if (Math.Acos((ax * bx + ay * by) / (Math.Sqrt(ax * ax + ay * ay) * Math.Sqrt(bx * bx + by * by))) == Math.Acos(0))
        {
            hypotenuse = AC;
            return true;
        }
        else if (Math.Acos((ax * cx + ay * cy) / (Math.Sqrt(ax * ax + ay * ay) * Math.Sqrt(cx * cx + cy * cy))) == Math.Acos(0))
        {
            hypotenuse = BC;
            return true;
        }
        else if(Math.Acos((cx * bx + cy * by) / (Math.Sqrt(cx * cx + cy * cy) * Math.Sqrt(bx * bx + by * by))) == Math.Acos(0))
        {
            hypotenuse = AB;
            return true;
        }
        else
        {
            return false;
        }



        throw new NotImplementedException();
    }


    private static double GetLengthOfSide(Point first, Point second)
    {
        return (Math.Sqrt(Math.Pow((second.GetX() - first.GetX()), 2) + Math.Pow((second.GetY() - first.GetY()), 2)));
        throw new NotImplementedException();
    }
}