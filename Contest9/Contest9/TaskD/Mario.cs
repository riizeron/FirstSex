public class Mario :IHero,IPlumber
{
    public void KillMonster(ref int numberOfMonsters)
    {
        numberOfMonsters--;
    }
    public void FixPipe(ref int numberOfCrashes)
    {
        numberOfCrashes--;
    }

}