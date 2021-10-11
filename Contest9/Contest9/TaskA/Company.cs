using System;
using System.Collections.Generic;

public class Company
{
    private readonly List<TeamLead> teamLeads;

    public Company(int teamLeadsAmount, int[] programmersAmount)
    {
        teamLeads = new List<TeamLead>();
        for (int i = 0; i < teamLeadsAmount; i++)
        {
            List<Programmer> list = new List<Programmer>();
            for (int j = 0; j < programmersAmount[i]; j++)
            {
                list.Add(new Programmer(int.Parse($"{i + 1}{j + 1}")));
            }
            teamLeads.Add(new TeamLead(i + 1, list));
        }
    }

    public List<TeamLead> TeamLeads
    {
        get { return teamLeads; }
    }

    public void PrintTeams()
    {
        foreach (TeamLead lead in teamLeads)
        {
            Console.WriteLine(lead.ToString());
            Console.WriteLine($"Written lines of code: {lead.GetWrittenLinesOfCode()}");
        }
        Console.WriteLine(String.Empty);
    }
}