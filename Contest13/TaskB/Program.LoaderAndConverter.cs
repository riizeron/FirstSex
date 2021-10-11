using System;
using System.Collections.Generic;
using System.IO;

public partial class Program
{
    private static Dictionary<string, List<string>> Convert(KeyPredicate keyPredicate, ValuePredicate valuePredicate, Dictionary<int, List<int>> data)
    {
        Dictionary<string, List<string>> dt = new Dictionary<string, List<string>>();
        foreach (int k in data.Keys)
        {
            List<string> l = new List<string>();
            foreach(int j in data[k])
            {
                l.Add(valuePredicate.Invoke(j));
            }
            dt.Add(keyPredicate(k), l);
        }
        return dt;
    }

    private static void LoadAreas()
    {
        using(StreamReader sr = new StreamReader("areas.txt"))
        {
            string s;
            while ((s = sr.ReadLine())!= null)
            {
                string[] str = s.Split();
                string y="";
                for(int i =1;i<str.Length;i++)
                {
                    if (i < str.Length - 1)
                    {
                        y += str[i] + " ";
                    }
                    else
                    {
                        y += str[i];
                    }
                }
                areas.Add(int.Parse(str[0]), y);
            }
            
        }
    }

    private static void LoadCities()
    {
        using (StreamReader sr = new StreamReader("cities.txt"))
        {
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                string[] str = s.Split();
                string y = "";
                for (int i = 1; i < str.Length; i++)
                {
                    if (i < str.Length - 1)
                    {
                        y += str[i] + " ";
                    }
                    else
                    {
                        y += str[i];
                    }
                    
                }
                cities.Add(int.Parse(str[0]), y);
            }

        }
    }
}