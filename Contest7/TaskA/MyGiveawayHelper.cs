using System;

internal class MyGiveawayHelper
{
    int number = 1579;
    int i = 0;
    string[] l;
    string[] p;
    int c;
    public MyGiveawayHelper(string[] logins, string[] prizes)
    {
        p = prizes;
        l = logins;
        c = p.Length-1;
        
    }

    public bool HasPrizes => c>=0;
    

    public (string prize,string login) GetPrizeLogin()
    {
        number = number * number;
        string n = number.ToString();
        int j = n.Length - 3;
        string nums =""+n[j-3] + number.ToString()[j-2] + number.ToString()[j-1] + number.ToString()[j];
        number = int.Parse(nums);


            c--;
            return (p[i++], l[int.Parse(nums) % l.Length]);
            
        
        
    }
}   