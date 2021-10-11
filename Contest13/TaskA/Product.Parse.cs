using System;

public abstract partial class Product
{
    public static Product Parse(string line)
    {
        string[] a = line.Split(';');
        if (a[0] == "Book")
        {
            return new Book(long.Parse(a[1]), int.Parse(a[2]));
        }
        else if(a[0] == "Notebook")
        {
            return new Notebook(long.Parse(a[1]), a[2]);
        }
        else
        {
            throw new ArgumentException("Incorrect type");
        }
    }
}