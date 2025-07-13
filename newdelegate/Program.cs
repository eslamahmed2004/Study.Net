using System;
using System.IO;
using static System.Console;
using System.Collections.Generic;


namespace newdegelet;



public class Program
{
    static void Main(string[] args)
    {

        IEnumerable<int> list = new [] { 2, 3, 4, 5, 6, 2, 78, 6, 53, 2,3,7,5,99,13,15 };

        Number(list, number => number % 2 == 0);
        WriteLine();
        Number(list,number => number % 3==0);  WriteLine();
        Number(list,number => number % 1==0 && number % 2 != 0 &&  number % 3!=0);
        ReadKey();

    }

    static void Number<T>(IEnumerable<T> number, Func<T,bool> filter)
    {
        foreach (var n in number)
        {
            if (filter(n))
            {
                Write(n + " ");
            }
        }
    }
}