using System;


public class Group
{
    public Student[] students;
    public int p;
    public Group (Student[] students)
    {
        if (students.Length>=5)
        {
            this.students = new Student[students.Length];
            this.students = students;
        }
        else
        {
            throw new ArgumentException("Incorrect group");
        }
    }
    public Student this[int index]
    {
        
        get
        {
            return students[index];
        }
    }

    public int IndexOfMaxGrade()
    {
        int u = 0;
        Student s = new Student("name", 0);
        for (int i = 0; i < students.Length ; i++)
        {
            
            if (s.grade < students[i].grade)
            {
                s = students[i];
                u = i;
            }
        }
        return u;
    }

    public int IndexOfMinGrade()
    {
        Student s = new Student("name", 10);
        int u = 0;
        for (int i = 0; i < students.Length; i++)
        {
            /* for(int j = i + 1; j < students.Length; j++)
             {*/
            if (s.grade > students[i].grade)
            {
                s = students[i];
                u = i;
            }
            /*}*/
        }
        return u;
    }
}