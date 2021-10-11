using System;

internal struct Student : IComparable<Student>
{
    private int id;
    private int height;
    private int math;
    private int english;
    private int PE;
    

    public Student(int id, int height, int math, int english, int PE)
    {
        this.id = id;
        this.height = height;
        this.math = math;
        this.english = english;
        this.PE = PE;
        
    }

    internal static Student Parse(string v)
    {
        int[] a = Array.ConvertAll(v.Split(' '), int.Parse);
        return new Student(a[0], a[1], a[2], a[3], a[4]);
    }
    public int CompareTo(Student s)
    {
        if (s.math > this.math)
        {
            return -1;
        }
        else if (s.math < this.math)
        {
            return 1;
        }
        else 
        {
            if (s.english > this.english)
            {
                return -1;
            }
            else if(s.english < this.english)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        
    }
    int IComparable<Student>.CompareTo(Student s)
    {
        if (s.PE > this.PE)
        {
            return -1;
        }
        else if (s.PE < this.PE)
        {
            return 1;
        }
        else
        {
            if (s.height > this.height)
            {
                return -1;
            }
            else if(s.height < this.height)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }
    }

    public override string ToString()
    {
        return this.id.ToString() ;
    }
}