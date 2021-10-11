using System;

public class User
{
    private long id;
    private string name;
    private ushort age;

    public long Id
    {
        get => id;
        private set
        {

            id = value;
        }
    }

    public string Name
    {
        get => name;
        private set
        {
            char[] h = value.ToCharArray();
            foreach (char e in h)
            {
                if (int.TryParse(e.ToString(), out int y))
                {
                    throw new ArgumentException("Incorrect input");
                }
            }
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

    private User(long id, string name, ushort age)
    {
        Id = id;
        Name = name;
        Age = age;
    }

    public static User Parse(string str)
    {
        string[] g = str.Split(';');
        if (!ushort.TryParse(g[2], out ushort u) || u > 128)
        {
            throw new ArgumentException("Incorrect input");
        }
        if (!long.TryParse(g[0], out long h) || h <= 0)
        {
            throw new ArgumentException("Incorrect input");
        }
        return new User(long.Parse(g[0]), g[1], u);
    }
}