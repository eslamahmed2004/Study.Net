using System;
using System.IO;
using System.IO.Compression;
using static System.Console;


namespace overrider
    ;
public class Program
{
    static void Main(string[] args)
    {
        var p1 = new point
        {
            x = 1,
            y = 9
        };

        ReadKey();


    }
}

class point
{
    public int x { get; init; }
    public int y { get; init; }
    public point() { }
    public point(int x,int y)
    {
        this.x = x;
        this.y = y;
    }
    public override bool Equals(object obj)
    {
        point p = obj as point;
        return this.Equals(p);

    }

    public bool Equals(point point)
    {
        if (point is null)
            return false;

        return point.x == x && point.y == y;
    }

    public override int GetHashCode()
    {
        //int hash = 13;
        //hash = hash * 7 + x.GetHashCode();

        //hash = hash * 7 + y.GetHashCode();

        //return hash;
        return HashCode.Combine(x, y);
    }
}
