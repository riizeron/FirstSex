public abstract class FigureWorker<T> where T : Figure
{
    protected T figure;

    public FigureWorker(T figure)
    {
        this.figure = figure;
    }

    public string GetCoordinateQuarterOfCenter()
    {
        if (figure.X == 0 || figure.Y == 0)
        {
            return figure.X == 0 ? "OY" : "OX";
        }
        
        if (figure.X * figure.Y > 0)
        {
            return figure.X > 0 ? "I" : "III";
        }

        return figure.X < 0 ? "IV" : "II";
    }
    
    public abstract double GetSquare();
}