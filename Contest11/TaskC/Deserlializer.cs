using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class Deserializer
{
    public static List<Student> DeserializeStudents(string path)
    {
        object obj;
        BinaryFormatter formatter = new BinaryFormatter();
        using (FileStream fs = new FileStream(path, FileMode.Open))
        {
            obj = formatter.Deserialize(fs);
        }
        return (List<Student>)obj;
    }
}