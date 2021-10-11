using System;
using System.Runtime.Serialization;
public class Soup
{
    public Soup(Ingredient[] ingredients)
    {
        foreach(Ingredient i in ingredients)
        {
            if(i is Meat&&(i as Meat).IsTasty == false)
            {
                WillEat = false;
                break;
            }
            else if(i is Vegetable&&(i as Vegetable).IsAllergicTo == true)
            {
                WillEat = false;
                break;
            }
        }   
    }

    public bool WillEat { set; get; } = true;
}