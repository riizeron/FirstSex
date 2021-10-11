using System;
using System.Collections.Generic;
using System.Linq;

public class Files
{
    Dictionary<string, Permissions> database = new Dictionary<string, Permissions>();

    public void CreateFile(string filename)
    {
        database.Add(filename, PermissionBuilder.FromName("Default"));
    }

    public void AddPermission(string filename, string permissionName)
    {
        database[filename]|= PermissionBuilder.FromName(permissionName);
    }

    public void RemovePermission(string filename, string permissionName)
    {
        if((database[filename]& PermissionBuilder.FromName(permissionName)) == PermissionBuilder.FromName(permissionName))
        {
            database[filename] ^= PermissionBuilder.FromName(permissionName);

        }

    }

    public override string ToString()
    {
        string str = "";
        foreach(var d in database)
        {

            str += ($"{d.Key}: {d.Value.ToString().Replace(",","")}");
            str += "\n";

        }
        return str;
    }
}