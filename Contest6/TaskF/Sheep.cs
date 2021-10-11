
using System;

public class Sheep
{
    public int _id;
    public string _name;
    public string _sound;
    public string _str;

    public Sheep(int id, string name, string sound)
    {
        _id = id;
        _name = name;
        _sound = sound;
        _str= ($"[{_id}-{_name}]: {_sound}...{_sound}");
    }
    public override string ToString()
    {
        return _str;
    }

}
