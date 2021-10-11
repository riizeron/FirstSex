using System;

public class Program
{
    public static void Main(string[] args)
    {
        string name = Console.ReadLine();
        int skillWeights = int.Parse(Console.ReadLine());
        int newSkillWeights = int.Parse(Console.ReadLine());
        string skillToCheck = Console.ReadLine();
        
        try
        {
            var witcher = new Witcher(name, skillWeights);
            Console.WriteLine(witcher[newSkillWeights]);
            Console.WriteLine(witcher[skillToCheck]);
        }
        catch (ArgumentException exception)
        {
            Console.WriteLine(exception.Message);
        }
    }
}