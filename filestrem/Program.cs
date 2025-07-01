using System;
using System.IO;
using static System.Console;


namespace filestrem;
public class Program
{
    static void Main(string[] args) {

        ex08();
        ReadKey();


    }

    static void ex02()
    {
        String Path = @"C:\C# and .NET\test\test1.txt";
        using (var fs = new FileStream(Path,FileMode.Open,FileAccess.ReadWrite))
        {

            byte[] data = new byte[fs.Length];
            int numbytoread = (int)fs.Length;
            int numread = 0;

            while (numbytoread > 0)
            {
                int n = fs.Read(data, numread, numbytoread);

                if (n == 0)
                    break;

                numbytoread -= n;
                numread += n;

            }

            foreach (var b in data)
                WriteLine(b);

            var newpath = @"C:\C# and .NET\test\test2.txt";
            using (var fs2 = new FileStream(newpath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                fs2.Write(data, 0, data.Length);
            }

        }

       
    }

    static void ex03()
    {
        String Path = @"C:\C# and .NET\test\test3.txt";
        using (var fs = new FileStream(Path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
        {
            fs.Seek(20, SeekOrigin.Begin);
            fs.WriteByte(65);
            fs.Position=0;

            for (int i = 0; i < fs.Length; i++)
            {
                WriteLine(fs.ReadByte());
            }

        }


    }

    static void ex04()
    {
        String path = @"C:\C# and .NET\test\test4.txt";
        using (var s = new StreamWriter(path))
        {
            s.WriteLine("this");
            s.WriteLine("is");
            s.WriteLine("s");
        }
    }
    static void ex05()
    {
        String path = @"C:\C# and .NET\test\test4.txt";
        using (var s = new StreamReader(path))
        {
            while (s.Peek() > 0) 
            {
                WriteLine((char)s.Read());
                
            }
        }
    }

   

    static void ex07()
    {
        string path = @"C:\C# and .NET\test\test5.txt";

        String[] lines =
        {
            "C#","ikgrj","ogogk","oithqw"
        };

        File.WriteAllLines(path, lines);

    }
    static void ex08()
    {
        string path = @"C:\C# and .NET\test\test6.txt";

        String lines =

            "C# ikgrj  ogogkoithqw";
        
        File.WriteAllText(path, lines);

    }

}