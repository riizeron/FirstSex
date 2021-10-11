using System;

public class Download<T> : IDownload where T : Content
{
    private readonly T download;

    public Download(T download)
    {
        this.download = download;
    }
    public override string ToString() => this.download.GetType().Name;

    public bool DownloadContent()
    {



        if (Program.FreeSpace - this.download.Size >= 0 )
        {
            Console.WriteLine($"{this.download.Size}/{this.download.Size} MB");
            Program.FreeSpace -= this.download.Size;
            return true;
        }
        else if(Program.FreeSpace>0)
        {
            Console.WriteLine($"{Program.FreeSpace}/{this.download.Size} MB");
            Program.FreeSpace = 0;
            Console.WriteLine("Not enough free space!");
            return false;
        }
        return false;


    }
}