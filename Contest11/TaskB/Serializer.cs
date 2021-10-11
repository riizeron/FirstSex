using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class Serializer
{
    public static void ReadStudents(string path)
    {
        string[] a = File.ReadAllLines(path);
        foreach(string j in a)
        {
            Student.Create(j);
        }
    }

    public static void SerializeStudents(string path)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
        {
            formatter.Serialize(fs, Student.list);
        }
    }
}