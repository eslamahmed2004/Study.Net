using System;
using System.IO;
using static System.Console;
using System.Collections.Generic;
using System.Reflection;
using demoassembly;



namespace Assemblies ;


public class Program
{
    
    static void Main(string[] args)
    {
        // var type = typeof(Employee);
        // // var assembly = type.Assembly;
        // var assembly = Assembly.GetExecutingAssembly(); // the three to know type of assembly
        // WriteLine(assembly.FullName);
        // WriteLine(type);
        //  Class1.Trace(); //  هتربط المكتبه بالكلاس الاساسي 
        var type = typeof(Program);
        var assembly = type.Assembly;
        // WriteLine(assembly.FullName); // output => Assemblies, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
        // WriteLine(assembly.Location); // output => C:\C# and .NET\thestart\Assemblies\bin\Debug\net9.0\Assemblies.dll
        var assemblyName = assembly.GetName();
        assemblyName.Name = "eslam";
        WriteLine($"Name: {assemblyName.Name}");
        WriteLine($"Version: {assemblyName.Version}");
        WriteLine($"Total Key Tokens length: {assemblyName.GetPublicKeyToken().Length}");
        WriteLine($"Code: {assemblyName.CodeBase}");
        WriteLine($"DateTime Assembly Name: {typeof(DateTime).Assembly.GetName().Name}");

        // var stream = assembly.GetManifestResourceStream("Assemblies.data.country.json");
        var stream1 = assembly.GetManifestResourceStream(type,"data.country.json");
        var data = new BinaryReader(stream1).ReadBytes((int) stream1.Length);
            
        for (int i = 0; i < data.Length; i++)
        {
          // Write( (char) data[i] + "" +
                                  //        "");
          // Thread.Sleep(1);
        }
        stream1.Close();
        ReadKey();

    } 
    
    }

public class Employee
{
    
    
}


