using System;

public delegate void AtackHeroOnPosition(Mob hero, int position);
public class Game
{
    public AtackHeroOnPosition attackHero;
    private Hero hero;
    private Boss boss;
    protected int CastlePosition { get; set; }
    protected int CountOfMonsters { get; set; }
    public Game(int castlePosition, int countOfMonster, Hero hero, Boss boss)
    {
        CastlePosition = castlePosition;
        CountOfMonsters = countOfMonster;
        this.hero = hero;
        this.boss = boss;
    }
    public void Play()
    {
        for(int c = 0; c <= CastlePosition; c++)
        {
                attackHero?.Invoke(hero,c);
        }
        hero.AttackMob(boss);
       
        
        if (hero.IsHpMoreThen75())
        {
            Console.WriteLine("You win! Princess released!");
        }
        else
        {
            Console.WriteLine("Thank you, Mario! But our princess is in another castle... You lose!");

        }
    }

    

}
