using System;
using System.Collections.Generic;
using System.Collections;

public class ConverterArray<TV, TU> : IEnumerable<TU>
{
    //private readonly TV[] originArr;
    public List<TU> arr;
    private readonly IConverter<TV, TU> converter;

    public ConverterArray(int length, IConverter<TV, TU> converter)
    {
        this.converter = converter;
        arr = new List<TU>();
        //Console.WriteLine(arr.Count);
        for (int i=0;i<length;i++)
        {
            arr.Add(default);
        }
    }

    public TU GetAt(int index)
    {
        return arr[index];
    }

    public void SetAt(int index, TV element)
    {
        TU d = converter.Convert(element);
        arr[index] = d;

    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return arr.GetEnumerator();
    }
        

    IEnumerator<TU> IEnumerable<TU>.GetEnumerator()
    {
        return arr.GetEnumerator();
    }
        
}