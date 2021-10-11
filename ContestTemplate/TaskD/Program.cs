using System;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        var historyController = new HistoryController();
        using (var sr = new StreamReader("input.txt"))
        {
            while (!sr.EndOfStream)
            {
                string[] command = sr.ReadLine().Split(';');
                switch (command[0])
                {
                    case "get":
                        Console.WriteLine(historyController.Get());
                        break;
                    case "get_by_user_id":
                        Console.WriteLine(historyController.GetByUserId(int.Parse(command[1])));
                        break;
                    case "get_by_time_range":
                        Console.WriteLine(historyController.GetByTimeRange(DateTime.Parse(command[1]), DateTime.Parse(command[2])));
                        break;
                    case "update":
                        historyController.Update(command[1]);
                        break;
                    case "delete":
                        historyController.Delete();
                        break;
                    case "delete_by_user_id":
                        historyController.DeleteByUserId(int.Parse(command[1]));
                        break;
                    case "delete_by_time_range":
                        historyController.DeleteByTimeRange(DateTime.Parse(command[1]), DateTime.Parse(command[2]));
                        break;
                }
            }
        }
    }
}