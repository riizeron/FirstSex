using System;
using System.Collections.Generic;
using System.Collections;

public class Game : IEnumerable
{
    private readonly LinkedList<int> first;
    private readonly LinkedList<int> second;

    public Game(LinkedList<int> first, LinkedList<int> second)
    {
        this.first = first;
        this.second = second;
    }

    
    IEnumerator IEnumerable.GetEnumerator()
    {
        return new StudentEnumerator(first, second);
    }
}

class StudentEnumerator : IEnumerator
{
    LinkedList<int> first;
    LinkedList<int> second;
    //int position = 0;
    int r = 1;
    int nakop1 = 0;
    int nakop2 = 0;
    int value;
    public StudentEnumerator(LinkedList<int> first, LinkedList<int> second)
    {
        this.first = first;
        this.second = second;

    }
    object IEnumerator.Current
    {
        get
        {
            if (r == 2)
            {
                return $"First: {value}";
            }
            else
            {
                return $"Second: {value}";
            }
        }
    }


    public bool MoveNext()
    {

        while (true)
        {
            if (r == 2)
            {
                if (nakop2 > second.Count || first.Count == 0)
                {
                    Console.WriteLine("First win!");
                    return false;
                }
                if (second.First.Value >= first.First.Value)
                {
                    r = 1;
                    nakop2 = 0;
                    value = second.First.Value;
                    second.RemoveFirst();
                    return true;
                }
                else
                {
                    nakop2++;
                    LinkedListNode<int> t = second.First;
                    second.RemoveFirst();
                    second.AddLast(t);
                }
            }
            else
            {
                if (nakop1 > first.Count || second.Count == 0)
                {
                    Console.WriteLine("Second win!");
                    return false;
                }
                if (first.First.Value >= second.First.Value)
                {
                    r = 2;
                    nakop1 = 0;
                    value = first.First.Value;
                    first.RemoveFirst();
                    return true;
                }
                else
                {
                    nakop1++;
                    LinkedListNode<int> t = first.First;
                    first.RemoveFirst();
                    first.AddLast(t);
                    continue;
                }
            }
        }

    }

    public void Reset()
    {
        //position = 0;
    }


}