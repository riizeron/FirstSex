using System;
using System.Collections.Generic;

class DelegateWorker
{
    //Action<int> myDel;
    List<int> values;
    public delegate void A(ref int a);
    public A myDel;
    public DelegateWorker(List<int> values)
    {
        this.values = values;
    }

    public void Assign(A act)
    {
        myDel += act;
    }

    public void Invoke()
    {

      
        for (int j = 0; j < values.Count; j++)
        {
            int h = values[j];
            myDel.Invoke(ref h);
            values[j] = h;
        }


    }
}