using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Army : IEnumerable
{
    int[] soldiers;

    int n;
    public Army(int[] soldiers, int n)
    {
        if (n > soldiers.Length)
        {
            throw new ArgumentException("N is not valid");
        }
        else
        {
            this.soldiers = soldiers;
            this.n = n;
        }
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return new SoldierEnumerator(soldiers, n);
    }

}
class SoldierEnumerator : IEnumerator
{
    List<int> soldiers;
    int n;
    int position = -1;
    int c = 1;
    List<int> s;
    int o;
    public SoldierEnumerator(int[] soldiers, int n)
    {
        this.soldiers = soldiers.ToList();
        this.n = n;
    }
    object IEnumerator.Current
    {
        get
        {
            return o;
        }
    }


    public bool MoveNext()
    {
        if (c * n <= soldiers.Length)
        {
            o = soldiers[c * n - 1];
            soldiers.ToList()        }
        
        if (position < soldiers.Length - 1)
        {
            position++;
            return true;
        }
        else
            return false;
    }

    public void Reset()
    {
        position = -1;
    }


}