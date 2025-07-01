using System;
using System.IO;
using System.IO.Compression;
using static System.Console;


namespace filestrem;
public class Program
{
    static void Main(string[] args)
    {
        var p1 = new point(2, 4);
        var p3 = p1 with { x = 5 };
        WriteLine(p3);
        ReadKey();

    }



    public record struct point(int x,int y);
}