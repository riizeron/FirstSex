using System;

public partial class Program
{
    public static void Main(string[] args)
    {
        AggregatePurchasesListByBuyer(ReadCsv("orders.csv")).ForEach(Console.WriteLine);
    }
}