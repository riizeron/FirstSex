using System;
using System.Xml.Serialization;

[Serializable]
public class Pillow
{
    public long id;
    protected string IsRuinedStr => isRuined;
    public string isRuined;
    
    public Pillow() { }

    public Pillow(long id, bool isRuined) 
    {
        this.id = id;
        this.isRuined = isRuined ? "Yes" : "No";
    }
}