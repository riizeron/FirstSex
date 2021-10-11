using System;

abstract class Editor
{
    public string name;
    public int salary;

    protected Editor(string name, int salary)
    {
        this.name = name;
        this.salary = salary;
    }

    public virtual string EditHeader(string header)
    {
        return header;
    }

    public int CountSalary(string oldStr, string newStr)
    {
        return Math.Abs(oldStr.Length - newStr.Length)*salary;
        throw new NotImplementedException();
    }
}