using System;

public class Student
{
    public string name;
    public int grade;
    public static int o;
    public Student(string name, int grade)
    {
        this.name = name;
        this.grade = grade;
    }

    public static Student Parse(string line)
    {
        o++;
        string[] a = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        if (!int.TryParse(a[1], out int y))
        {
            throw new ArgumentException("Incorrect input mark");
        }
        else if (a[0].Length<3||((int)a[0][0]<(int)'A')||((int)'Z' < (int)a[0][0]))
        {
            throw new ArgumentException("Incorrect name");
        }
        else if(y > 10 || y < 0)
        {
            throw new ArgumentException("Incorrect mark");

        }
        
        return new Student(a[0], int.Parse(a[1]));
    }

    public override string ToString()
    {
        return $"{name} got a grade of {grade}.";
    }
}