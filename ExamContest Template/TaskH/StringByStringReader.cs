using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;

class StringByStringReader : IEnumerable<string>
{
    private string filename;
    public List<string> str = new List<string>();
    public StringByStringReader(string filename)
    {
        this.filename = filename;
        using (StreamReader sr = new StreamReader(filename))
        {
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                str.Add(s);
            }
        }
    }
    
    public IEnumerable<string> CutStrings(int length)
    {
        
        for(int i = 0; i < str.Count; i++)
        {
            if (str[i].Length > length)
            {
                str[i] = str[i].Substring(0, length);
            }
        }
        return str;
    }
    IEnumerator<string> IEnumerable<string>.GetEnumerator()
    {
        return str.GetEnumerator();
    }
    public IEnumerator GetEnumerator()
    {
        return str.GetEnumerator();
    }
}