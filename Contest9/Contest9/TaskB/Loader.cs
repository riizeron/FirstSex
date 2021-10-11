using System;
using System.Collections.Generic;

public class Loader
{
    private static Dictionary<string, int> memory = new Dictionary<string, int>();

    public static void AddValueToStore(string key)
    {
        if (!memory.ContainsKey(key))
        {
            memory.Add(key, 0);
            memory[key]++;

        }
        else
        {
            memory[key]++;

        }
    }

    public static void Download(IList<IDownload> downloadsQueue)
    {
        foreach(var t in downloadsQueue)
        {
            if (t.DownloadContent())
            {
                AddValueToStore(t.ToString());
            }
        }
        Console.WriteLine(String.Empty);
        Console.WriteLine("Downloaded content:");
        foreach(var g in memory)
        {
            Console.WriteLine($"{ g.Key}: {g.Value}");
        }
        
    }
}