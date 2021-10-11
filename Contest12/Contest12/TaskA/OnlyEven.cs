using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

public class OnlyEven : IEnumerable<int>
{
    private IEnumerable<int> numbers;

    public OnlyEven(List<int> numbers)
    {
        this.numbers = from t in numbers
                                  where t % 2 == 0
                                  select t;
    }

    IEnumerator<int> IEnumerable<int>.GetEnumerator()
    {
        return numbers.GetEnumerator();
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return numbers.GetEnumerator();
    }
}