using System;
using System.Xml.Serialization;
public class Lamp : Furniture
{
    protected double LifeTimeSeconds => lifeTime;
    public double lifeTime;
    public Lamp() { }
    public Lamp(long id, TimeSpan lifeTime) : base(id)
    {
        this.lifeTime = lifeTime.TotalSeconds;
    }
}