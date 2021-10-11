using System;
using System.Collections.Generic;

class Linguist : Editor
{
    string bannedWord;
    private Linguist(string name, int salary, string bannedWord) : base(name, salary)
    {
        this.bannedWord = bannedWord;
    }

    public new string EditHeader(string header)
    {
        return base.EditHeader(header.Replace(bannedWord,""))+" "+name;
        /*List<string> l = new List<string>();
        string[] s = header.Split(' ',StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != bannedWord)
            {
                l.Add(s[i]);
            }
        }
        return String.Join(" ", l.ToArray())+" "+name;*/
    }

    public static Linguist Parse(string line)
    {
        string[] words = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);

        if (words.Length != 3 || !int.TryParse(words[1], out int payment) ||
             payment < 0)
        {
            throw new ArgumentException("Incorrect input");
        }
        return new Linguist(words[0], int.Parse(words[1]), words[2]);
        throw new NotImplementedException();
    }
}