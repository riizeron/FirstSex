using System;
using System.Collections.Generic;

public class Game
{
    public static IList<IHelper> helpers = new List<IHelper>();
    public static int numberOfPlayedRounds = 0;
    private readonly int numberOfRounds;

    public Game(int numberOfHeroes, int numberOfPlumbers, int numberOfMarios, int numberOfRounds)
    {
        this.numberOfRounds = numberOfRounds;
        for (int i = 0; i < numberOfHeroes; i++)
        {
            helpers.Add(new Hero());
        }
        for (int i = 0; i < numberOfPlumbers; i++)
        {
            helpers.Add(new Plumber());
        }
        for (int i = 0; i < numberOfMarios; i++)
        {
            helpers.Add(new Mario());
        }
    }

    public void Play()
    {
        while (numberOfPlayedRounds != numberOfRounds)
        {
            bool flag = false;
            Round r;
            try
            {
                int[] ap = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                if (ap.Length > 2) { throw new Exception(); }
                r = new Round(ap[0], ap[1]);
                r.Play(ref flag);
                if (!flag) { Console.WriteLine("Helpers lost this round!"); }
                numberOfPlayedRounds++;

            }
            catch (Exception)
            {
                Console.WriteLine("Incorrect data!");
                Play();
            }
        }
        

    }
}