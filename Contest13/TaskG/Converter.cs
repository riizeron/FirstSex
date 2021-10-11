using System;

public class Converter : IConverter<MessageNetwork, MessageDb>
{
    public MessageDb Convert(MessageNetwork obj)
    {
       return new MessageDb(obj.Id,obj.Content.Replace(" ",""),obj.ImageNetwork.Url.Replace(" ",""));
    }
}