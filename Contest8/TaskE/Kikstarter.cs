using System;

class Kikstarter
{
    // Данный тип необходимо обязательно использовать
    public delegate int GetMoneyDelegate();

    GetMoneyDelegate[] getMoney;
    private int m;

    public Kikstarter(int m, Hipster[] hipsters)
    {
        this.m = m;
        if (hipsters.Length > 0)
        {
            getMoney = new GetMoneyDelegate[hipsters.Length];
            for (int i = 0; i < hipsters.Length; i++)
            {
                getMoney[i] = hipsters[i].GetMoney;
            }
        }
        else
        {
            throw new ArgumentException("Not enough hipsters");
        }
    }

    public int Run()
    {
        int res = 0;
        int c = 0;
        while (res < m)
        {
            int fgt = 0;
            foreach (GetMoneyDelegate d in getMoney)
            {
                fgt += d.Invoke();
            }
            if (fgt == 0)
            {
                break;
            }
            res += fgt;
            c++;
        }
        if (res >= m)
        {
            return c ;
        }
        else
        {
            throw new InvalidOperationException("Not enough money");
        }
        throw new NotImplementedException();
    }
}