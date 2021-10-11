using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

public partial class Program
{
    /// <summary>
    /// Считывает точки в список.
    /// </summary>
    /// <returns>Список точек.</returns>
    private static List<Point> GetPoints()
    {
        string[] a = File.ReadAllLines(InputPath);
        List<Point> l = new List<Point>();
        for (int i = 0; i < a.Length; i++)
        {
            string[] b = a[i].Split();
            l.Add(new Point(int.Parse(b[0]), int.Parse(b[1]), int.Parse(b[2])));
        }
        return (l);
    }


    /// <summary>
    /// Получает коллекцию уникальных точек.
    /// </summary>
    /// <param name="points">Список исходных точек.</param>
    /// <returns>Коллекция точек.</returns>
    static HashSet<Point> GetUnique(List<Point> points)
    {
        HashSet<Point> s = new HashSet<Point>();

        
        var uniquePoint = points.Distinct();
        foreach (Point i in uniquePoint)
        {
            s.Add(i);
        }
       
        return s;
    }

}