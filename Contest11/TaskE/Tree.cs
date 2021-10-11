using System;
using System.Xml.Serialization;
[Serializable]
[XmlInclude(typeof(Oak))]
[XmlInclude(typeof(Ash))]

public class Tree : IComparable<Tree>
{
    public int height;
    public int age;

    public Tree()
    {
    }

    public Tree(int height, int age)
    {
        this.height = height;
        this.age = age;
    }

    public override string ToString()
    {
        return $"height:{height} age:{age}";
    }
    public int CompareTo(Tree other)
    {
        if (this is Oak&&other is Oak)
        {
            if (((Oak)this).acornCount == ((Oak)other).acornCount)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        else if (this is Ash && other is Ash)
        {
            if (((Ash)this).leafCount == ((Ash)other).leafCount)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        else
        {
            return 1;
        }
    }
}