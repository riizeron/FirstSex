using System;
using System.Collections.Generic;

class Singleton<T> where T:class,new()
{ 
    static T v = new T();
    public static T Instance
    {
        get
        {
            return v;
        }
        set
        {
            throw new NotSupportedException("This operation is not supported");

        }
    }
}

