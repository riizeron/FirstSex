using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.IO;

public class StudentReader : IEnumerable<Student>, IDisposable
{
    List<Student> students = new List<Student>();
    public StudentReader(string path)
    {
        using(StreamReader sr = new StreamReader(path))
        {
            while (sr.Peek()!= -1)
            {
                string line = sr.ReadLine();

                students.Add(new Student(Student.PreprocessStudentData(line).Item1,
                    Student.PreprocessStudentData(line).Item2));
            }
        }
    }


    public IEnumerable<Student> GetStudentsWithGreaterGpa(double gpa)
    {
        return from t in students
               where t.Gpa > gpa
               select t;
    }
    void IDisposable.Dispose()
    {

    }
    IEnumerator<Student> IEnumerable<Student>.GetEnumerator()
    {
        return new StudentEnumerator(students);
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return new StudentEnumerator(students);
    }
    
}
class StudentEnumerator : IEnumerator<Student>
{
    Student[] students;
    int position = -1;
    public StudentEnumerator(List<Student> students)
    {
        this.students = students.ToArray();
    }
    object IEnumerator.Current
    {
        get
        {
            if (position == -1 || position >= students.Length)
                throw new InvalidOperationException();
            return students[position];
        }
    }
    public Student Current
    {
        get
        {
            if (position == -1 || position >= students.Length)
                throw new InvalidOperationException();
            return students[position];
        }
    }

    public bool MoveNext()
    {
        if (position < students.Length - 1)
        {
            position++;
            return true;
        }
        else
            return false;
    }

    public void Reset()
    {
        position = -1;
    }
    void IDisposable.Dispose()
    {

    }
    
}