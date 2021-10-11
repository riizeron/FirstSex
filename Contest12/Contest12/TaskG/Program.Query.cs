using System;
using System.Collections.Generic;
using System.Linq;

public partial class Program
{
    // Необходимо:
    // 1. Сформировать группы юзеров по их имени, предварительно отсортировав их по возрасту в убывающем порядке (от большего к меньшему).
    // 2. Отфильтровать группы: оставить в группах только тех пользователей, чей возраст строго больше 10.
    // 3. Из каждой группы взять m пользователей, предварительно отсортировав по Id, и вывести на экран сумму возрастов таких пользователей.
    private static IEnumerable<IGrouping<string, User>> GetGroups(List<User> users)
    {
        return from h in users
               orderby h.Age descending
               group h by h.Name;


    }
    private static List<int> GetQueryResult(IEnumerable<IGrouping<string, User>> groups, int m)
    {
        var groupedResults = groups.Select(grp => grp.Where(r => r.Age>10));
        var gt = groupedResults.Select(gr => gr.OrderBy(r => r.Id));

        List<int> li = new List<int>();
        foreach (var j in gt)
        {
            int i = 1;
            int count = 0;
            foreach (var c in j)
            {
                if (i++ <= m)
                {
                    count += c.Age;
                }
                else break;
            }
            li.Add(count);
        }
        return li;
    }
}