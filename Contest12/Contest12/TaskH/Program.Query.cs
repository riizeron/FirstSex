using System;
using System.Collections.Generic;
using System.Linq;

public partial class Program
{
    // Сортируем по возрастанию лексикографическому города и создаём на основе их группы.
    // Далее сортируем такие группы по количеству в них пользователей. Сортировка убавающая
    // Берём пять первых групп, не включая первую.
    // В каждой такой группе необходимо сгруппировать пользователей по имени, и уже каждую такую группу преобразовать в число, равное среднему возрасту этой группы.

    private static double GetAverage(IEnumerable<User> users)
    {
        var t = users.OrderBy(s => s.City).GroupBy(s => s.City);
        var v = t.OrderByDescending(j => j.Count());
        int i = 1;
        if (v.Count() > 5)
        {
            v.Skip(1);
            var x = (from g in v
                where i++ <= 5
                select g);
            var f = x.Select(gr => gr.GroupBy(l => l.Name));
            var u = f.Select(gr => gr.OrderBy(s => s.Key));
            var h = u.Select(gr => gr.Select(gr => gr.Sum(d => d.Age)));

            var max = h.Select(gr => gr.Max());
            return max.Max();
        }
        else
        {
            var x = v;
            var f = x.Select(gr => gr.GroupBy(l => l.Name));
            var u = f.Select(gr => gr.OrderBy(s => s.Key));
            var h = u.Select(gr => gr.Select(gr => gr.Sum(d => d.Age)));

            var max = h.Select(gr => gr.Max());
            return max.Max();
        }

        
        /*HashSet<double> set = new HashSet<double>(max);
        IEnumerable<double> n = set.ToList();*/

        //return n.Average();
    }
}