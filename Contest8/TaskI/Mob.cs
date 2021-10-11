using System;

public abstract class Mob
{
    
    public Mob(int hp, int attack)
    {
        HP = hp;
        Attack = attack;
    }
    
    public void AttackMob(Mob other)
    {
        while (this.HP > 0 && other.HP > 0)
        {
            Console.WriteLine(this.ToString() + " attacked " + other.ToString());
            Console.WriteLine(other.ToString() + " attacked " + this.ToString());
            this.HP -= other.Attack;
            other.HP -= this.Attack;
            if (this.HP <= 0)
            {
                Console.WriteLine("You Lose! Game over!");
                Environment.Exit(0);
            }
        }
        
    }

    protected int HP { set; get; }
    protected int Attack { set; get; }

}