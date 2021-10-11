using System;

public class Hero : Mob
{
    public double startHp;
    public Hero(int hp, int attack) : base(hp,attack)
    {
        startHp = hp;  
    }

    public bool IsHpMoreThen75()
    {
        return true ? (this.HP*1.0/startHp) >= 0.75 : false;
    }

    public override string ToString() => $"Mario with HP = {this.HP} and attack = {this.Attack}";
}

