using System;
using System.Collections.Generic;

public partial class HistoryManager
{
    public IEnumerable<HistoryRecord> GetAllHistory()
    {
        throw new NotImplementedException();
    }
    
    public IEnumerable<HistoryRecord> GetHistoryByUserId(int userId)
    {
        throw new NotImplementedException();
    }
    
    public IEnumerable<HistoryRecord> GetHistoryByTimeRange(DateTime from, DateTime to)
    {
        throw new NotImplementedException();
    }

    public bool UpdateSearchHistory(string jsonString)
    {
        throw new NotImplementedException();
    }

    public void DeleteAllHistory()
    {
        throw new NotImplementedException();
    }

    public void DeleteHistoryByUserId(int userId)
    {
        throw new NotImplementedException();
    }

    public void DeleteHistoryByTimeRange(DateTime from, DateTime to)
    {
        throw new NotImplementedException();
    }
}