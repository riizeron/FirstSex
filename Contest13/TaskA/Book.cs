using System;

public class Book : Product
{
    private readonly int age;

    public Book(long id, int age) : base(id)
    {
        this.age = age;
    }

    public override string ToString() => $"Product. Id = {base.ToString()}. Type = Book. Age = {age}";
}