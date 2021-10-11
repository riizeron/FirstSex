using System;
using System.Collections.Generic;
using System.Linq;

public partial class Program
{
    private static List<Cat> ChooseCats(int minTailLength, int maxTailLength, int maxAge, List<Cat> cats)
    {
        return (from t in cats
               where t.IsBlack == true && t.Age <= maxAge && t.TailLength >= minTailLength && t.TailLength <= maxTailLength
               select t).ToList();

    }
}