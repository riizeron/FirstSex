﻿using System;

static class Methods
{
    public static T Max<T>(T a, T b) where T:IComparable
    {
        if (a.CompareTo(b)==1)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
}

