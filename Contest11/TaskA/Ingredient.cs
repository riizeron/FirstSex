using System;
using System.Runtime.Serialization;

[KnownType(typeof(Meat))]
[KnownType(typeof(Vegetable))]
[KnownType(typeof(Ingredient))]
[DataContract]
public class Ingredient:IComparable<Ingredient>
{
    [DataMember]
    public string Name { get; set; }
    [DataMember]
    protected int TimeToCook { get; set; }
    public Ingredient() { }

    public Ingredient(string name, int timeToCook)
    {
        Name = name;
        TimeToCook = timeToCook;
    }
    int IComparable<Ingredient>.CompareTo(Ingredient i)
    {
        if (TimeToCook < i.TimeToCook)
        {
            return 1;
        }
        else if(TimeToCook>i.TimeToCook)
        {
            return -1;
        }
        else
        {
            return 0;
        }
    }
    public override string ToString()
    {
        return Name;
    }

}