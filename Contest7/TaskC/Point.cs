using System;

public class Point
{
    int x;
    int y;
    int z;

    public Point(int x, int y, int z)
    {
        this.x = x;
        this.y = y;
        this.z = z;

    }

    public override bool Equals(object obj) => this.ToString() == obj.ToString();

    public override int GetHashCode() => x;

    public override string ToString() => $"{this.x} {this.y} {this.z}";
}