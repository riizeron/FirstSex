public class Boss : Mob
{
    public Boss(int hp, int attack) : base(hp,attack) 
    {
    }
    public override string ToString() => $"Boss with HP = {this.HP} and attack = {this.Attack}";
}
