using System;
using System.Collections.Generic;
using System.Linq;

public class SchoolManager
{
    public static void UniteSchools(List<School> schools, List<string> schoolNumbers)
    {
        var scho = (from sc in schools
                   where schoolNumbers.Contains(sc.SchoolNumber)
                   select sc).ToList();
        School main = scho.First();
        for(int i = 1; i < scho.Count(); i++)
        {
            scho[i].SchoolNumber = $"{main.SchoolNumber}-{i+1}";
        }
        main.SchoolNumber += "-1";
       
       

    }

    public static void TransferPupil(List<Pupil> pupils, List<School> schools, int pupilId, string newSchoolNumber)
    {

        var ne = from sc in schools
                 where sc.SchoolNumber == newSchoolNumber
                 select sc;
        School neededSc = ne.FirstOrDefault();
        var pups = from pou in pupils
                   where pou.Id == pupilId
                   select pou;
        Pupil pup = pups.FirstOrDefault();
        if (pup != default(Pupil) && neededSc != default(School)) 
        {
            foreach (School sc in schools)
            {
                if (sc.Pupils.Contains(pup))
                {
                    sc.Pupils.Remove(pup);
                }
            }
            neededSc.Pupils.Add(pup);
        }
    }

    public static void CloseSchool(List<School> schools, string schoolNumber, string newSchoolNumber)
    {
        List<Pupil> newList = new List<Pupil>();
        var ne = from sc in schools
                 where sc.SchoolNumber == schoolNumber
                 select sc;
        School clSc = ne.FirstOrDefault();
        Pupil[] pups = clSc.Pupils.ToArray();

        foreach (Pupil pu in pups)
        {
            TransferPupil(clSc.Pupils, schools, pu.Id, newSchoolNumber);
        }
        clSc.Pupils.Clear();
    }
}