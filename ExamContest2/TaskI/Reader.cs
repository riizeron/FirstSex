using System;
using System.IO;
using System.Text;

public static class Reader
{
    public static int[] ReadFile(string fileName)
    {
        string[] g = File.ReadAllText(fileName).Split();
        int[] f = new int[g.Length];
        int i = 0;
        foreach (var t in g)
        {
            f[i] = ParseWord(t);
            i++;
        }
        return f;
    }

    private static int ParseWord(string word)
    {
        StringBuilder sb = new StringBuilder();
        
        for(int i = 0; i < word.Length - 1; i++)
        {
            if(int.TryParse(word[i].ToString(),out int b) || word[i] == '-')
            
            {
                sb.Append(word[i].ToString());
            }
        }
        int count = 0;
        StringBuilder st = new StringBuilder();

        for (int i = 0; i < sb.Length - 1; i++)
        {
            if (sb[i] == '-')
            {
                count++;
            }
            else
            {
                st.Append(sb[i]);

            }

        }
        if (count % 2 == 0)
        {
            Console.WriteLine(st.ToString());
            return int.Parse(st.ToString());
        }
        else
        {
            Console.WriteLine(st.ToString());

            return -int.Parse(st.ToString());
        }
        
    }
}