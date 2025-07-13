using System;
using System.Drawing;
using System.IO;
using static System.Console;
using System.Collections.Generic;
using System.Xml;


namespace Records;
public class Program
{
    static void Main(string[] args)
    {

        var e1 = new Employee(2, 3);
        var e2 = new Employee(2, 3);

        e1.ID = 1;
        WriteLine(e1.Equals(e2)); // ==> true because method e7na ely 3menha
            WriteLine(e1==e2); // ==> false because the class beshawer 3ala el refrance not value
        WriteLine(e1.ID);
        
        ReadKey();

    }
}

class Employee : IEquatable<Employee>
{
    public int x, y;



    public Employee(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
     
    public int ID
    {
        get; set;
    }
    public String Name
    {
        get; set;
    }

    public override bool Equals(object obj)
    {
        Employee p = obj as Employee;
        return this.Equals(p);
         
    }

    public bool Equals(Employee point)
    {
        if(point is null)
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