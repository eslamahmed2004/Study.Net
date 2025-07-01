using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;
using System.IO;
using System.Numerics;
using System.Text.RegularExpressions;
using System.Collections;
using System.Text;
using static System.IO.Directory;
using static System.IO.Path;
using static System.Environment;
using System.Reflection;


namespace thestart.project1;
public  class Program
{
    static void Main(string[] args)
    {
        // 1 way 
        //Curry curry = new Curry();
        //var result = curry.getcuury();
        //curry.Dispose();
        //WriteLine(result);

        // 2 way reco
        //Curry curry = null;

        // try {
        //     curry = new Curry();
        //     var result = curry.getcuury();
        //     WriteLine(result);

        // }
        // catch (Exception) {

        //     throw;
        // }
        // finally {
        //     curry?.Dispose();
        // }

        //3 way more reco
        using (Curry curry = new Curry())
        {
               var result = curry.getcuury();
                 WriteLine(result);

        }



        ReadKey();
    }

}
class Curry :IDisposable
{
    private readonly HttpClient httpClient;
    private bool disposed = false;
    public Curry()
    {
        httpClient = new HttpClient();
    }

    ~Curry()
    {
        Dispose(false);
    }

    // dis true (dispos mange+unmange)
    // dis false (dispos unmange+large fields)
    protected virtual void Dispose(bool Disposing)
    {
        if (disposed)
        {
            return;
        }
        // disposd logic
        if (Disposing)
        {
            // disposd mange 
            httpClient.Dispose();

        }

                disposed = true;
    }
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);

    }

    public String getcuury()
    {
        string url = "https://www.coinbase.com/api/v2/currencies";
        var result = httpClient.GetStringAsync(url).Result;
        return result;
    }

}

