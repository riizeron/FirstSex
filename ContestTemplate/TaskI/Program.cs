using System;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;

public class Program
{
    
    public static void Main(string[] args)
    {
        string filename = "input.txt";
        List<string> text = new List<string>(); 

        using (StreamReader sr = new StreamReader(filename, System.Text.Encoding.Default))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                text.Add(line);
            }
        }
        Item[] items = new Item[text.Count];
        int i = 0;
        foreach(var str in text)
        {
            string[] par = str.Split();
            string att = "";
            for(int j = 2; j < par.Length-1; j++) 
            {
                att += par[j]+" ";
            }
            att += par[par.Length - 1];
            items[i++] = new Item(int.Parse(par[0]), par[1], att);
        }
        XmlSerializer x = new XmlSerializer(typeof(Item[]));
        TextWriter writer = new StreamWriter("result.xml") ;
        x.Serialize(writer, items);
        writer.Close();
    }
}