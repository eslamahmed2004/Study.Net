using System;
using System.IO;
using static System.Console;


namespace Delegate;

public class Program
{
    static void Main(string[] args)
    {
        var emp = new Employee[]
        {
            new Employee { Id = 1, Name = "eslam", Gender = "f", totalsales = 40000m },
            new Employee { Id = 2, Name = "ahmed", Gender = "m", totalsales = 59999m },
            new Employee { Id = 3, Name = "mostafa", Gender = "f", totalsales = 70000m },
            new Employee { Id = 4, Name = "hjgrg", Gender = "m", totalsales = 90000m },
            new Employee { Id = 5, Name = "owfkosa", Gender = "m", totalsales = 20000m },
            new Employee { Id = 6, Name = "voe", Gender = "m", totalsales = 30000m },
            new Employee { Id = 7, Name = "vowqv", Gender = "f", totalsales = 10000m }
        };

        var report = new Report();
        report.processEmployeewith60000(emp,"sales >= 60.000", e => e.totalsales > 60000m );
        report.processEmployeewith60000(emp,"sales >= 40.000", (Employee e) => e.totalsales > 30000m && e.totalsales <60000m);
        report.processEmployeewith60000(emp,"sales >= 30.000", (Employee e) => e.totalsales <= 30000m);
        

        ReadKey();
    }

  //  static bool isgraterthanorequal60000(Employee e) => e.totalsales > 60000m;
    //static bool isgraterthanorequalless30000(Employee e) => e.totalsales > 30000m && e.totalsales <60000m;
    //static bool isgraterthanorequal30000(Employee e) => e.totalsales <= 30000m;

}


