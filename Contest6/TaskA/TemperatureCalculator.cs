using System;

public static class TemperatureCalculator
{
    public static double FromCelsiusToFahrenheit(double celsiusTemperature)
    {
        if (celsiusTemperature >= -273.15)
        {
            return celsiusTemperature * 1.8 + 32;
        }
        else
        {
            throw new ArgumentException("Incorrect input");
        }
        throw new NotImplementedException();
    }

    public static double FromCelsiusToKelvin(double celsiusTemperature)
    {
        if (celsiusTemperature >= -273.15)
        {
            return celsiusTemperature + 273.15;
        }
        else
        {
            throw new ArgumentException("Incorrect input");
        }
        throw new NotImplementedException();
    }

    public static double FromFahrenheitToCelsius(double fahrenheitTemperature)
    {
        if (fahrenheitTemperature >= -459.67)
        {
            return (fahrenheitTemperature - 32) / 1.8;
        }
        else
        {
            throw new ArgumentException("Incorrect input");
        }
        throw new NotImplementedException();
    }

    public static double FromFahrenheitToKelvin(double fahrenheitTemperature)
    {
        return FromCelsiusToKelvin((fahrenheitTemperature - 32) / 1.8);
        throw new NotImplementedException();
    }

    public static double FromKelvinToCelsius(double kelvinTemperature)
    {
        if (kelvinTemperature >= 0)
        {
            return kelvinTemperature - 273.15;
        }
        else
        {
            throw new ArgumentException("Incorrect input");
        }
        throw new NotImplementedException();
    }

    public static double FromKelvinToFahrenheit(double kelvinTemperature)
    {
        if (kelvinTemperature >= 0)
        {
            return (FromCelsiusToFahrenheit(FromKelvinToCelsius(kelvinTemperature)));
        }
        else
        {
            throw new ArgumentException("Incorrect input");
        }
        throw new NotImplementedException();
    }

}
