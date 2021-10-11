using System;
using System.Collections.Generic;
using System.Text;


public class Item
{
    public int ID;
    public string location;
    public string name;

    public Item()
    {
    }

    public Item(int iD, string location, string name)
    {
        ID = iD;
        this.location = location;
        this.name = name;
    }
}

