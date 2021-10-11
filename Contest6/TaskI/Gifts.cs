using System;

public static class GiftCreator
{
    static int i = 0;
    static int j = 0;
    public static Gift CreateGift(string giftName)
    {
        
        if (giftName == "Phone")
        {
            Gift phone = new Phone(i++);
            
            return phone;
        }
        else
        {
            Gift play = new PlayStation(j++);
            
            return play;

        }
        throw new NotImplementedException();
    }
}

public class Phone : Gift
{
    public Phone (int id):base(id)
    {
        ID = id;
    }
}

public class PlayStation : Gift
{
   public PlayStation(int id) : base(id)
    {
        ID = id;
    }
}

