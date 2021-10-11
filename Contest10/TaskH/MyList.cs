
using System.Linq;
using System;

public class MyList<T>
{

    int capacity;
    int count = 0;
    T[] l;
    public MyList()
    {
        l = new T[1];
        
    }

    public MyList(int capacity)
    {
        this.capacity = capacity;
        l = new T[capacity];
    }

    public int Count => this.count;
    public int Capacity => this.capacity;


    public void Add(T element)
    {
        l[Count]=element;
        count++;
    }

    public T this[int x]
    {
        get
        {
            return l[x];
        }
    }

    public void Clear()
    {
        for(int i = 0; i < capacity; i++)
        {
            l[i] = default(T);
        }
    }

    public void RemoveLast()
    {
        l[l.Length - 1] = default(T);
    }

    public void RemoveAt(int index)
    {
        l[index] = default(T);
    }

    public T Max()
    {
        return Enumerable.Max(l);
    }

    public override string ToString()
    {
        string s="";
        foreach(T t in l)
        {
            s+=(t.ToString() + " ");
        }
        return s;
    }
}