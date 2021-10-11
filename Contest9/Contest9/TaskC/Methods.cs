using System;
using System.Collections.Generic;

public static class Methods
{
    public static int FindBestBiathlonistValue(List<Sportsman> sportsmen)
    {
        int i = 0;
        foreach(var s in sportsmen)
        {
            if (s.GetType().Name == "Biathlonist")
            {
                if ((int)(0.4 * Math.Max(((IShooter)s).Shoot(), ((ISkiRunner)s).Run()) + 0.6 * Math.Min(((IShooter)s).Shoot(), ((ISkiRunner)s).Run())) > i)
                {
                    i = (int)(0.4 * Math.Max(((IShooter)s).Shoot(), ((ISkiRunner)s).Run()) + 0.6 * Math.Min(((IShooter)s).Shoot(), ((ISkiRunner)s).Run()));
                }
                
            }
            /*else if (s.GetType().Name == "SkiRunner")
            {
                if (((ISkiRunner)s).Run() > i)
                {
                    i = ((ISkiRunner)s).Run();
                }
            }
            else if (s.GetType().Name == "Shooter")
            {
                if (((IShooter)s).Shoot() > i)
                {
                    i = ((IShooter)s).Shoot();
                }
            }*/
        }
        /*Console.WriteLine(i);
        Console.WriteLine(j);*/

        return i;
    }

    public static int FindBestShooterValue(List<Sportsman> sportsmen)
    {
        int i = 0;
        foreach (var s in sportsmen)
        {
            if (s.GetType().Name == "Shooter"|| s.GetType().Name == "Biathlonist")
            {
                if (((IShooter)s).Shoot() > i)
                {
                    i = ((IShooter)s).Shoot();
                }
            }
        }
        return i;
    }

    public static int FindBestRunnerValue(List<Sportsman> sportsmen)
    {
        int i = 0;
        foreach (var s in sportsmen)
        {
            if (s.GetType().Name == "SkiRunner"|| s.GetType().Name == "Biathlonist")
            {
                if (((ISkiRunner)s).Run() > i)
                {
                    i = ((ISkiRunner)s).Run();
                }
            }
        }
        return i ;
    }
}