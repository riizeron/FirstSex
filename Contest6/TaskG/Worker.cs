using System;

public class Worker
{
    Apple[] a;
    public Worker(Apple[] apples)
    {
        this.a = apples;

    }

    public Apple[] GetSortedApples()
    {
        Apple app = new Apple();
       
        for (int j = 0; j < a.Length-1; j++)
        {
            for (int i = j+1; i < a.Length; i++)
            {
                if (a[j].Weight > a[i].Weight)
                {
                    app = a[j];
                    a[j] = a[i];
                    a[i] = app;
                }
            }
        }
        return a;
    }
}