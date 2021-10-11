using System;
using System.Collections.Generic;
[Serializable]
public class Student
{
    public string Name { get; private set; }
    public string LastName { get; private set; }
    public int GroupNumber { get; private set; }
    public List<int> Grades { get; private set; }
    public static List<Student> list = new List<Student>();

    public Student(string name, string lastName, int groupNumber, List<int> grades)
    {
        Name = name;
        LastName = lastName;
        GroupNumber = groupNumber;
        Grades = grades;
    }

    public static Student Create(string studentInfo)
    {
        List<int> gr = new List<int>();
        string[] arr = studentInfo.Split(' ');
        for (int i = 3; i < arr.Length; i++)
        {
            gr.Add(int.Parse(arr[i]));
        }
        list.Add(new Student(arr[0], arr[1], int.Parse(arr[2]), gr));
        return new Student(arr[0], arr[1], int.Parse(arr[2]), gr);
    }
    public override string ToString()
    {
        return $"{Name} {LastName} {GroupNumber}";
    }
}