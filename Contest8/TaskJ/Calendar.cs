using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Calendar
{
    public event Action<DateTime> EveryDayNotification;

    public void Simulate(DateTime startTime, DateTime endTime)
    {
        for(DateTime i = startTime; i <=endTime; i=i.AddDays(1))
        {
            EveryDayNotification?.Invoke(i);
        }
    }
}