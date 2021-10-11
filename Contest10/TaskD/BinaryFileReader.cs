using System;
using System.IO;
using System.Text;

public class BinaryFileReader
{
    private string path;
    
    public BinaryFileReader(string path)
    {
        this.path = path;
    }
    public int GetDifference()
    {
        Int32 i32 = 0;
        Int16 i16 = 0;
        
        using (BinaryReader br = new BinaryReader(File.Open(path, FileMode.Open, FileAccess.Read),Encoding.ASCII))
        {
            while (br.PeekChar() > -1)
            {
                i16 += br.ReadInt16();
            }
        }
        using (BinaryReader br = new BinaryReader(File.Open(path, FileMode.Open, FileAccess.Read),Encoding.ASCII))
        {
            while (br.PeekChar() > -1)
            {
                try
                {
                    i32 += br.ReadInt32();
                }
                catch(Exception)
                {
                    br.BaseStream.Position -= 2;
                    i32 += (Int32)br.ReadInt16();
                }
            }
            br.Close();
        }
        return Math.Abs(i16-i32);
    }
}






