using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

public class SimpleFurnitureSerializer
{
    public void Serialize(List<Furniture> furniture, string outputPath)
    {
        XmlSerializer formatter = new XmlSerializer(typeof(List<Furniture>));

        using (FileStream fs = new FileStream(outputPath, FileMode.OpenOrCreate))
        {
            formatter.Serialize(fs, furniture);
        }
    }
}