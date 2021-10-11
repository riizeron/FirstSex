using System;

public class User
{
    private ushort age;
    private string city;
    private long id;
    private string name;

    private User(long id, string name, ushort age, string city)
    {
        Id = id;
        Name = name;
        Age = age;
        City = city;
    }

    private long Id
    {
        get => id;
        set
        {
            id = value;
        }
    }

    public string Name
    {
        get => name;
        private set
        {
            
            name = value;
        }
    }

    public ushort Age
    {
        get => age;
        private set
        {
            age = value;
        }
    }

    public string City
    {
        get => city;
        private set
        {
            city = value;
        }
    }

    public static User Parse(string str)
    {
        string[] g = str.Split(';');
        if (g.Length != 4)
        {
            throw new ArgumentException("Incorrect input");
        }
        char[] b = g[1].ToCharArray();
        foreach (char e in b)
        {
            if (int.TryParse(e.ToString(), out int y))
            {
                throw new ArgumentException("Incorrect input");
            }
        }
        if (!ushort.TryParse(g[2], out ushort u) || u > 128)
        {
            throw new ArgumentException("Incorrect input");
        }
        if (!long.TryParse(g[0], out long h) || h <= 0)
        {
            throw new ArgumentException("Incorrect input");
        }
        return new User(h, g[1], u,g[3]);
    }
}