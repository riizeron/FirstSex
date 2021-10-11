using System;
using System.Collections.Generic;

public partial class TestSystem
{    
    public void Add(string username)
    {
        int f = 0;
        foreach(User k in User.l)
        {
            if (k.username == username)
            {
                f = 1;
            }
            if (k.username == username + "!")
            {
                f = 9;
                k.username = username;
                Notifications += k.SendMessage;
            }
        }
        if (f==0)
        {
            User u = new User(username);
            Notifications += u.SendMessage;
        }
        else if(f==1)
        {
            throw new ArgumentException("User already exists");
        }
    }
    
    public void Remove(string username)
    {
        bool f = false;
        foreach(User u in User.l)
        {
            if (u.username == username)
            {
                f = true;
                u.username  +="!";
                Notifications -= u.SendMessage;
            }
        }
        if (!f)
        {
            throw new ArgumentException("User does not exist");
        }
    }

}