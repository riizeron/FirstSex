using System;
public class CircleWorker : FigureWorker<Circle>
{

    public CircleWorker(Circle figure):base(figure)
    {
        
    }
    public override double GetSquare()
    {
        return Math.PI * figure.rad * figure.rad;
    }

}