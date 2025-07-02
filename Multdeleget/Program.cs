using System;
using System.IO;
using static System.Console;


namespace Mulrdegelet;
public delegate void ret(decimal width, decimal height);

public class Program
{
    static void Main(string[] args)
    {
        var helper = new Retanglehelper();
        ret ret = helper.getarea;
        ret += helper.getprameter;
        ret += helper.getprameters; 
        

        ret(10, 10);
        ReadKey();

    }
}

public class Retanglehelper
{
    public void getarea(decimal width, decimal height)
    {
        var result = width * height;
        WriteLine("the area = "+ result);
    }
    public void getprameter(decimal width, decimal height)
    {
        var result = 2 * (width + height);
        WriteLine("the area = "+ result);
    }
    public void getprameters(decimal width, decimal height)
    {
        var result = 4 * (width + height);
        WriteLine("the area = "+ result);
    }
}