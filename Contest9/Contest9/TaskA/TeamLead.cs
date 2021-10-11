using System;
using System.Collections.Generic;

public class TeamLead : Programmer
{
    private readonly List<Programmer> programmers;

    public TeamLead(int id, List<Programmer> programmers) : base(id)
    {
        this.programmers = programmers;
    }

    public List<Programmer> Programmers
    {
        get { return programmers; }
    }

    public void HuntProgrammers(List<TeamLead> teamLeads)
    {
        foreach (var lead in teamLeads)
        {
            if (lead == this) { continue; }
            for(int i = 0; i < lead.programmers.Count ;)
            {
                if (lead.programmers[i].LinesOfCode % (this.Id + 1) == 0)
                {
                    this.programmers.Add(lead.programmers[i]);
                    lead.programmers.RemoveAt(i);
                }
                else { i++; }
            }
            
        }
        /*for (int i = 0; i < teamLeads.Count-1; i++)
        {
            for(int j = 0; j < teamLeads[i].programmers.Count-1; j++)
            {
                for (int k = 0; k < teamLeads.Count-1; k++)
                {
                    if (teamLeads[i].programmers[j].LinesOfCode % (teamLeads[k].Id + 1) == 0)
                    {
                        teamLeads[k].programmers.Add(teamLeads[i].programmers[j]);
                        teamLeads[i].programmers.RemoveAt(j);
                    }
                }
            }
        }*/
    }

    public int GetWrittenLinesOfCode()
    {
        int i = 0;
        foreach (var prog in programmers)
        {
            i += prog.LinesOfCode;
        }
        i += this.LinesOfCode;
        return i;
    }

    public override string ToString()
    {
        return String.Format("Team lead #{0}\nAmount of programmers in team: {1}", Id, programmers.Count);
    }
}