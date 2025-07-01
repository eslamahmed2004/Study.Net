using System;
using System.IO;
using static System.Console;
using System.Collections.Generic;


namespace Event;



public class Program
{
    static void Main(string[] args)
    {
        var stock = new Stock("amr");
        stock.Price = 100;
        stock.onpriceischanged += stockonprice;

        stock.changestockpriceby(0.02m);
        stock.changestockpriceby(-0.06m);
        stock.changestockpriceby(99.055m);
        
        ReadKey();

    }


    private static void stockonprice(Stock stock, decimal oldprice)
    {
        if (stock.Price > oldprice)
        {
            ForegroundColor = ConsoleColor.Green;

        }
        else if(stock.Price < oldprice)
        {
            ForegroundColor = ConsoleColor.Red;   

        }
        else
        {
            ForegroundColor = ConsoleColor.Gray;   
            
        }
        WriteLine(stock.Name +"  "+ stock.Price);

        
    }
    
}

public delegate void stockpricechangehandel(Stock stock, decimal oldprice);

public class Stock
{
    private string name;
    private decimal price;
    public event stockpricechangehandel onpriceischanged;
    public string Name => this.name;
    public decimal Price
    {
        get => this.price;
        set => this.price = value;
    }
    

    public Stock(string stockname) => this.name = stockname;

    public void changestockpriceby(decimal precent)
    {
        decimal oldprice = this.price;
        this.price += Math.Round(this.price * precent, 2);
        if (onpriceischanged != null)
        {
            onpriceischanged(this, oldprice);
        }
    }
}