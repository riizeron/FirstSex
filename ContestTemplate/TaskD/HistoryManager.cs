using System;
using System.Collections.Generic;
using System.IO;

public partial class HistoryManager
{
    private readonly List<HistoryRecord> searchHistory;

    public HistoryManager()
    {
        searchHistory = new List<HistoryRecord>();
        
        using (var sr = new StreamReader("history.txt"))
        {
            while (!sr.EndOfStream)
            {
                var historyRecord = sr.ReadLine().Split(';');
                searchHistory.Add(new HistoryRecord
                {
                    Query = historyRecord[0],
                    TimeStamp = DateTime.Parse(historyRecord[1]),
                    UserId = historyRecord.Length > 2 ? int.Parse(historyRecord[2]) : default
                });
            }
        }
    }
}