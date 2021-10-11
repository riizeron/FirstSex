using System;
using System.Collections.Generic;
using System.Linq;

public partial class Program
{
    private static List<Cat> ChooseCats(int minTailLength, int maxTailLength, int maxAge, List<Cat> cats)
    {
        var sortedUsers = cats.OrderByDescending(u => u.TailLength).ToArray();
        int l = sortedUsers[0].TailLength;
        return (from t in cats
                where t.Age <= maxAge && t.TailLength >= minTailLength && t.TailLength <= maxTailLength&&t.IsBlack==true || t.TailLength == l
                select t).ToList();
    }
}