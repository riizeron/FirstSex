using System;
using System.Collections.Generic;

public class User
{
    public List<string> m = new List<string>();
    public string username;
    public static List<User> l = new List<User>();

    public User(string username)
    {
        this.username = username;
        l.Add(this);
    }

    public override string ToString() => $"-{username}-";

    public void SendMessage(string text)
    {
        
        Console.WriteLine($"{this}");
        if (m.ToArray().Length!=0)
        {
            Console.WriteLine("Received notifications:");
            foreach (string v in m)
            {
                Console.WriteLine(v);
            }
        }
        
        m.Add(text);
        Console.Write("New notification: ");
        Console.WriteLine(text);
    }
    
}