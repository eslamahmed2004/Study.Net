using System;
using System.IO;
using static System.Console;
using System.Collections.Generic;


namespace newdegelet;
    
public delegate bool Filter<in T >(T number);


public class Program
{
    static void Main(string[] args)
    {
        Action<string> action = print;
        action("eslam");
        Func<int, bool> fun = isEven;
        Func<int, int, int> fun2 = add;
        WriteLine(fun2(4,6));
        WriteLine(fun(28));
        Predicate<int> pre = isEven;
        WriteLine(pre(8));
        

        ReadKey();

    }

    static void print(String s) => WriteLine(s);
    static int add(int x, int y) => x + y;
    static bool isEven(int x) => x % 2 == 0;
}