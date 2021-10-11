using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

[DataContract]
[KnownType(typeof(Penalty))]
public class Camera
{
    [DataMember]
    public int id;
    [IgnoreDataMember]
    public int maxSpeed;
    [DataMember]
    private List<Penalty> penalties = new List<Penalty>();

    public Camera(int id, int maxSpeed)
    {
        this.id = id;
        this.maxSpeed = maxSpeed;
    }

    public void AddPenalty(int carNumber, int speed)
    {
        penalties.Add(new Penalty(carNumber, (speed-maxSpeed)*100));
    }
}