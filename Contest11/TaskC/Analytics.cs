using System;
using System.Collections.Generic;
using System.IO;

public static class Analytics
{
    public static double FindGpa(List<Student> students)
    {
        double d = 0;
        foreach (Student s in students)
        {
            double k = 0;
            foreach (int gr in s.Grades)
            {
                k += gr;
            }
            d += k / s.Grades.Count;
        }
        return d / students.Count;
    }


    public static void WriteStudentsWithGpaNoLessThanAverage(List<Student> students, string path, double gpa)
    {
        using (StreamWriter sw = new StreamWriter(path))
        {
            sw.WriteLine($"{gpa:f2}");
            foreach (Student s in students)
            {
                double g = 0;
                foreach (int i in s.Grades)
                {
                    g += i;
                }
                g /= s.Grades.Count;
                if (g >= gpa)
                {
                    sw.WriteLine(s);
                }
            }
        }
    }
}