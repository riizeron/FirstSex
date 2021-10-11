using System;
using System.Collections.Generic;
using System.Xml.Serialization;

public class Bed : Furniture
{
    [XmlElement(ElementName = "pillow")]
    public List<Pillow> pillows { get; set; }
    public Bed() { }
    public Bed(long id, List<Pillow> pillows) : base(id)
    {
        this.pillows = pillows;
    }
}