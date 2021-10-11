using System;

public class Notebook : Product
{
    private readonly string color;
    
    public Notebook(long id, string color) : base(id)
    {
        this.color = color;
    }
    
    public override string ToString() => $"Product. Id = {base.ToString()}. Type = Notebook. Color = {color}";
}