using System;

public class Citizen : IOptimist, IPessimist
{
    int predictedValue;

    public Citizen(int predictedValue)
    {
        this.predictedValue = predictedValue;
    }

    public double GetForecast()
    {
        return predictedValue * 1.1;
        throw new NotImplementedException();
    }

    double IPessimist.GetForecast()
    {
        return predictedValue * 0.6;
        throw new NotImplementedException();
    }

    double IOptimist.GetForecast()
    {
        return predictedValue * 2;
        throw new NotImplementedException();
    }

    internal static Citizen Parse(string input)
    {
        if(!int.TryParse(input, out int f))
        {
            throw new ArgumentException("Incorrect citizen");
        }
        return new Citizen(int.Parse(input));
        throw new NotImplementedException();
    }
}