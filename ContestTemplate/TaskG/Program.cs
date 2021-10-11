using System;

public class Program
{
    public static void Main(string[] args)
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double radius = double.Parse(Console.ReadLine());

        try
        {
            Circle circle = new Circle(x, y, radius);
            FigureWorker<Circle> circleWorker = new CircleWorker(circle);

            Console.WriteLine(circleWorker.GetCoordinateQuarterOfCenter());
            Console.WriteLine($"{circleWorker.GetSquare():f3}");
        }
        catch (ArgumentException exception)
        {
            Console.WriteLine(exception.Message);
        }
    }
}