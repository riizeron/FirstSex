using System;
using System.Collections.Generic;

public class Grassland
{
    List<string> names = new List<string>();
    List<int> ides = new List<int>();
    List<string> sound = new List<string>();

    List<Sheep> list = new List<Sheep>();
    public Grassland(List<Sheep> sheeps)
    {
        
        for(int i = 0; i < sheeps.ToArray().Length; i++)
        {
            list.Add(sheeps[i]);
            names.Add(sheeps[i]._name);
            ides.Add(sheeps[i]._id);            
        }
        
    }

    public List<Sheep> GetEvenSheeps()
    {
        List<Sheep> ret = new List<Sheep>();
        for (int j = 0; j < ides.ToArray().Length;j++)
        {
            if (ides[j] % 2 == 0)
            {
                ret.Add(list[j]);
            }
        }
        return ret;
        throw new NotImplementedException();
    }

    public List<Sheep> GetOddSheeps()
    {
        List<Sheep> ret = new List<Sheep>();
        for (int j = 0; j < ides.ToArray().Length; j++)
        {
            if (ides[j] % 2 == 1)
            {
                ret.Add(list[j]);
            }
        }
        return ret;
        throw new NotImplementedException();
    }

    public List<Sheep> GetSheepsByContainsName(string name)
    {
        List<Sheep> ret = new List<Sheep>();
        for (int j = 0; j < ides.ToArray().Length; j++)
        {
            if (names[j].Contains(name))
            {
                ret.Add(list[j]);
            }
        }
        return ret;
        throw new NotImplementedException();
    }
    
}
