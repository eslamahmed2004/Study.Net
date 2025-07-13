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
        var p1 = new point(2, 3);
        var p2 = new point(2, 3);
        WriteLine(p1);
        WriteLine(p2);

        WriteLine(p1.Equals(p2));
        WriteLine(p1 == p2);

        ReadKey();

    }


    record point
    {


        public int x;
        public int y;

        public point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }


}