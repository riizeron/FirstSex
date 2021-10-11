using System;
using System.Collections.Generic;

public class Monster : Mob
{
    public Monster(int hp, int attack, int position) : base(hp, attack)
    {
        Position = position;
    }
    protected int Position { set; get; }
    public void AttackHero(Mob hero, int position)
    {
        if (position==Position)
        {
            Console.WriteLine($"Mario meet monster on {position}");
            hero.AttackMob(this);
        }
    }

    public override string ToString() => $"Monster with HP = {this.HP} and attack = {this.Attack}";

}