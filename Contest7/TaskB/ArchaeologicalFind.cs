using System;
using System.Collections.Generic;
#pragma warning disable

public class ArchaeologicalFind
{
    int A;
    int W;
    static int y = 0;
    string N;
    int index;
    public static int TotalFindsNumber = 0;
    static int o = 0;
    static List<object> K = new List<object>();
    static int i = 0;
    public ArchaeologicalFind(int age, int weight, string name)
    {
        if (age <= 0)
        {
            throw new ArgumentException("Incorrect age");
        }
        if (weight <= 0)
        {
            throw new ArgumentException("Incorrect weight");
        }
        if (name == "?")
        {
            throw new ArgumentException("Undefined name");

        }
        A = age;
        W = weight;
        N = name;
        index = i++;
        if (this.A > 0&& this.W > 0&& this.N != "?")
        {
            TotalFindsNumber++;
        }
        
    }

    /// <summary>
    /// Добавляет находку в список.
    /// </summary>
    /// <param name="finds">Список находок.</param>
    /// <param name="archaeologicalFind">Находка.</param>
    public static void AddFind(ICollection<ArchaeologicalFind> finds, ArchaeologicalFind archaeologicalFind)
    {
        bool f = true;
        K.Add(archaeologicalFind);
        for(int h = 0; h < K.Count-1; h++)
        {
            if (K[h].Equals(archaeologicalFind))
            {
                f = false;
            }
        }
        if (f)
        {
            finds.Add(archaeologicalFind);
        }
        
    }


    public override bool Equals(object obj)
    {
        if (index > 9) { o = 1; }
        if (index > 99) { o = 2; }
        if (this.auf() == obj.ToString().Substring(2+o)) { return true; }
        y++;
        return false;
    }

    public override string ToString() 
    { 
        
        

        return ($"{this.index} {this.N} {this.A} {this.W}"); 
    }
    public string auf() => ($"{this.N} {this.A} {this.W}");

}