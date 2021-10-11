using System;
using System.IO;
using System.Collections.Generic;
public class Knight : LegendaryHuman
{
    int equipment;
    public Knight(string name, int healthPoints, int power, string[] equipment) : base(name, healthPoints, power)
    {
        if (equipment.Length != 0)
        {
            this.equipment = equipment.Length;
        }
        else
        {
            throw new ArgumentException("Not enough equipment.");
        }
    }

    public override void Attack(LegendaryHuman enemy)
    {

        if (HealthPoints > 0 && enemy.HealthPoints > 0)
        {
            Console.Write(this);
            Console.Write(" attacked ");
            Console.WriteLine(enemy+".");
            enemy.HealthPoints -= (Power + 10 * equipment);
            

            if (enemy.HealthPoints <= 0)
            {
                Console.Write(enemy);
                Console.WriteLine(" is dead.");
            }
        }
        else
        {
            return;
        }
    }
    public override string ToString()
    {
        string s = $"Knight {Name} with HP {HealthPoints}"; 
        
        return s;
    }

}