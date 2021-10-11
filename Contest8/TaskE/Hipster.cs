using System;

internal class Hipster
{
    private int money;
    private int donate;

    public Hipster(int money, int donate)
    {
        this.money = money;
        this.donate = donate;
    }

    public int GetMoney()
    {
        if (donate <= money)
        {
            money -= donate;
            return donate;
        }
        else
        {
            int y = money;
            money = 0;
            return y;
        }
        
        
    }
}