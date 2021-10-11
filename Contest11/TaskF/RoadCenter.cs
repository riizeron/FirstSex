using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.IO;
[DataContract]
[KnownType(typeof(Camera))]
[KnownType(typeof(Penalty))]
public class RoadCenter : ITrackingCenter
{
    [DataMember]
    private List<Camera> cameras = new List<Camera>();
    public void AddCamera(int id, int maxSpeed)
    {
        cameras.Add(new Camera(id, maxSpeed));
    }

    public void CheckCarSpeed(int forCameraId, int carNumber, int carSpeed)
    {
        Camera h=null;
        foreach(Camera c in cameras)
        {
            if (c.id == forCameraId)
            {
                h = c;
                break;
            }
        }
        if (carSpeed > h?.maxSpeed)
        {
            h.AddPenalty(carNumber, carSpeed);
        }
    }

    public void GetData(string inFilePath)
    {
        using (var fs = new FileStream(inFilePath, FileMode.OpenOrCreate))
        {
            var formatter = new DataContractJsonSerializer(typeof(RoadCenter));
            formatter.WriteObject(fs,this);
        }
    }
}