using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
public class ReadWriter
{
    public static Tuple<char, char> GetMostAndLeastCommonLetters(string path)
    {
        char[] u = File.ReadAllText(path, Encoding.UTF8).ToLower().ToCharArray();
        Dictionary<char, int> dt = new Dictionary<char, int>();
        foreach (char t in u)
        {
            if (96 < t && 123 > t|| 64 < t && 91 > t)
            {
                if (!dt.ContainsKey(t))
                {
                    dt.Add(t, 1);
                }
                else
                {
                    dt[t] += 1;
                }
            }
            
        }
        int y = 0;
        int v = 1000;
        char max = 'l';
        char min = 'k';
        foreach (char t in dt.Keys)
        {
            if (dt[t] > y)
            {
                max = t;
                y = dt[t];
            }
            if (dt[t] < v)
            {
                min = t;
                v = dt[t];
            }

        }
        /*Console.WriteLine(max.ToString());
        Console.WriteLine(y);
        Console.WriteLine(min.ToString());
        Console.WriteLine(v);*/


        return new Tuple<char, char>(min, max);
    }

    public static void ReplaceMostRareLetter(Tuple<char, char> leastAndMostCommon, string inputPath, string outputPath)
    {

        char[] g = File.ReadAllText(inputPath).ToCharArray();
        for (int i = 0; i < g.Length; i++)
        {

            if (g[i] == leastAndMostCommon.Item1)
            {
                g[i] = leastAndMostCommon.Item2;
            }

            else if (g[i] == (char)(((int)leastAndMostCommon.Item1) - 32))
            {

                g[i] = (char)((int)leastAndMostCommon.Item2 - 32);
            }
        }
        File.WriteAllText(outputPath, String.Concat(g));

    }
}