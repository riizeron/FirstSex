using System;

public class Round
{
    private int amountOfMonsters;
    private int amountOfCrashes;

    public Round(int amountOfMonsters, int amountOfCrashes)
    {
        this.amountOfCrashes = amountOfCrashes;
        this.amountOfMonsters = amountOfMonsters;
    }

    public void Play(ref bool f)
    {
        if (amountOfMonsters <= 0 && amountOfCrashes <= 0)
        {
        }
        else
        {
            foreach (IHelper j in Game.helpers)
            {
                if (j.GetType().Name == "Mario")
                {
                    ((Mario)j).FixPipe(ref amountOfCrashes);
                    ((Mario)j).KillMonster(ref amountOfMonsters);

                }
                else if (j.GetType().Name == "Plumber")
                {
                    ((Plumber)j).FixPipe(ref amountOfCrashes);
                }
                else if (j.GetType().Name == "Hero")
                {
                    ((Hero)j).KillMonster(ref amountOfMonsters);
                }
            }
            if (amountOfCrashes > 0 && amountOfMonsters <= 0)
            {
                Game.helpers.Add(new Plumber());
            }
            else if (amountOfCrashes <= 0 && amountOfMonsters > 0)
            {
                Game.helpers.Add(new Hero());
            }
            else if (amountOfCrashes > 0 && amountOfMonsters > 0)
            {
                Game.helpers.Add(new Mario());
            }
            else
            {
                Console.WriteLine("Helpers won this round!");
                f = true;
            }
        }
        
    }
}