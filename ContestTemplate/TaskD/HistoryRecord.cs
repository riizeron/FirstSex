using System;

public class HistoryRecord
{
    public string Query { get; set; }
    public DateTime TimeStamp { get; set; }
    public int? UserId { get; set; }
}