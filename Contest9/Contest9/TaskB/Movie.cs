using System;

public class Movie : Content
{
    private short runningTime;
    private short releaseYear;
    private string genre;

    public Movie(int size, string name, short runningTime,
        short releaseYear, string genre) : base(size, name)
    {
        this.runningTime = runningTime;
        this.releaseYear = releaseYear;
        this.genre = genre;
    }
}