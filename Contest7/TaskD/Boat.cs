using System;

class Boat
{
    public int value;
    public bool IsAtThePort;

    public Boat(int value, bool isAtThePort)
    {
        this.IsAtThePort = isAtThePort; 

        this.value = value ;
        
    }


    public virtual int CountCost(int weight)
    {
        return weight * value;
    }
}


