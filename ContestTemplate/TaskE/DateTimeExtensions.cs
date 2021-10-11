using System;
public static class DateTimeExtensions
{
    public static bool IsWeekend(this DateTime dt)
    {
        return dt.DayOfWeek.ToString() == "Sunday" || dt.DayOfWeek.ToString() == "Saturday";
    }

    public static bool IsWorkingDay(this DateTime dt)
    {
        return dt.DayOfWeek.ToString() != "Sunday" && dt.DayOfWeek.ToString() != "Saturday";
    }

    public static string NextDayOfWeek(this DateTime dt)
    {
        return ((DayOfWeek)(((int)dt.DayOfWeek + 1)%7)).ToString();
    }
    public static string DaysBetween(this DateTime dt1, DateTime dt2)
    {
        int d = (dt1.Date - dt2.Date).Days;
        return dt1 < dt2 ? $"{-d} days in future" : $"{d} days ago";

    }

    public static string DayOfWeekSomeDaysFromCurrent(this DateTime dt, int some)
    {
        if (some < 0)
        {
            some = 7+some%7;
        }
        return ((DayOfWeek)(((int)dt.DayOfWeek +(int)some)%7)).ToString();

    }
}