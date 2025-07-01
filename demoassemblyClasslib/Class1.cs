using System;
using System.IO;
using static System.Console;
using System.Collections.Generic;
using System.Reflection;

namespace demoassembly;


public class Class1
{
    public static void Trace()
    {
        WriteLine("Trace....");
        WriteLine($"Executing assembly : {Assembly.GetExecutingAssembly()}");
        WriteLine($"Entry assembly : {Assembly.GetEntryAssembly()}");
        WriteLine($"Calling assembly : {Assembly.GetCallingAssembly()}");
    }
}