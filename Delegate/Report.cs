using System;
using static System.Console;


namespace Delegate;

public class Report
{
    public delegate bool ellegal(Employee e);
    public void processEmployeewith60000(Employee[] employees, string title, ellegal ellegal)
    {
        WriteLine(title);
        WriteLine(",,,,,,,,,,,,,,,,,,,,,,,,,,,,,,");
        foreach (var employee in employees)
        {
            if (ellegal(employee))
            {
                WriteLine($"{employee.Id} | {employee.Name} | {employee.Gender} | ${employee.totalsales}");
            } 
                
        }
        WriteLine("\n\n");
         
    }
    
    

    
}