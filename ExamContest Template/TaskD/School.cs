using System;
using System.Collections.Generic;
using System.Linq;

public class School
{
    public string SchoolNumber { get; set; }
    public string Address { get; }
    public List<Pupil> Pupils { get; }
    public School(string address, string schoolNumber, List<Pupil> pupils)
    {
        this.Address = address;
        this.SchoolNumber = schoolNumber;
        
        this.Pupils = (from t in pupils
                      where t.SchoolNumber==schoolNumber
                      select t).ToList();
    }
    public override string ToString()
    {
        string gadding = "";
        if (SchoolNumber.Contains('-'))
        {
            gadding = "was united";
        }
        else if (Pupils.Count == 0)
        {
            gadding = "was closed";
        }
        string sPupils = "";
        for(int i = 0; i < Pupils.Count() ; i++)
        {
            sPupils += Pupils[i].ToString()+Environment.NewLine;
        }
//sPupils += Pupils.Last().ToString();
        return $"{Address} {SchoolNumber} {Pupils.Count()} {gadding}{Environment.NewLine}{sPupils}";
    }
}