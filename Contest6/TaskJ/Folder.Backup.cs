using System;
using System.Collections.Generic;
using System.Text;

partial class Folder
{
    List<File> th = new List<File>();
    

    internal class Backup
    {
        
        List<File> l = new List<File>();
        public Backup(Folder folder)
        {
            foreach(File v in folder.th)
            {
                l.Add(new File(v));
            }
        }

        public static void Restore(Folder folder, Backup backup)
        {
            folder.th = backup.l;
        }
    }

    public void AddFile(string name, int size)
    {
        th.Add(new File(name,size));
    }
    public void RemoveFile(File file)
    {
        th.Remove(file);
    }

    public File this[int i]
    {
        get {
            if (th.ToArray().Length > i&&i>=0)
            {
                return th[i];
            }
            else
            {
                throw new IndexOutOfRangeException("Not enough files or index less zero");
            }
        }
    }

    public File this[string filename]
    {
        get {
            foreach(File v in th)
            {
                if (v.Name == filename)
                {
                    return v;
                }
            }
            throw new ArgumentException("File not found");
        }
    }

    public override string ToString()
    {
        string s="Files in folder:"+Environment.NewLine;
        for (int i = 0; i < th.ToArray().Length-1; i++)
        {
            s+= $"{th[i].Name,-15} {th[i].Size,5}" + Environment.NewLine;
        }
        s += $"{th[th.ToArray().Length-1].Name,-15} {th[th.ToArray().Length-1].Size,5}";
        return s;
    }
    
}

