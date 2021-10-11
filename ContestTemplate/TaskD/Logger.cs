using System;

public class Logger
{
    private static Logger logger;
    
    private Logger()
    {
    }

    public static Logger Instance => logger ?? new Logger();
    
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}