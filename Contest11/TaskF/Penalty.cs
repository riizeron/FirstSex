using System;
using System.Runtime.Serialization;
[DataContract]
public class Penalty
{
    [DataMember]
    private int car_number;
    [DataMember]
    private int cost;

    public Penalty(int carNumber, int cost)
    {
        this.car_number = carNumber;
        this.cost = cost;
    }
}