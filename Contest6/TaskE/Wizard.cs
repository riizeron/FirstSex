using System;
using System.IO;
using System.Collections.Generic;

public class Wizard : LegendaryHuman
{

    public int rankInt;
    public string rankName;
    public Wizard(string name, int healthPoints, int power, string rank) : base(name, healthPoints,
        power)
    {
        rankName = rank;
        switch (rank)
        {
            case "Neophyte":
                rankInt = 1;
                break;
            case "Adept":
                rankInt = 2;
                break;
            case "Charmer":
                rankInt = 3;
                break;
            case "Sorcerer":
                rankInt = 4;
                break;
            case "Master":
                rankInt = 5;
                break;
            case "Archmage":
                rankInt = 6;
                break;
            default:
                throw new ArgumentException("Invalid wizard rank.");
        }
    }

    public override void Attack(LegendaryHuman enemy)
    {
        if (HealthPoints > 0 && enemy.HealthPoints > 0)
        {
            Console.Write(this);
            Console.Write(" attacked ");
            Console.WriteLine(enemy+".");
            enemy.HealthPoints -= (Power * (int)(Math.Pow(rankInt, 1.5)) + HealthPoints / 10);
           
            if (enemy.HealthPoints <= 0)
            {
                Console.Write(enemy);
                Console.WriteLine(" is dead.");
            }
        }
       
        
    }
    public override string ToString()
    {
        string s = $"{rankName} Wizard {Name} with HP {HealthPoints}";
         return s;
    }
}