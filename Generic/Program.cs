using System;
using System.IO;
using System.IO.Compression;
using static System.Console;


namespace Generic;
    
public class Program
{
    static void Main(string[] args)
    {

        ReadKey();


    }

    class any<T>
    {
        private T[] Item;

        public void Add(T item)
        {
            if(item is null)
            {
                Item = new T[] { item };
            }
            else
            {
                var length = Item.Length;
                var dest = new T[length + 1];
                for (global::System.Int32 i = 0; i < length; i++)
                {
                    dest[i] = Item[i];
                }
                dest[dest.Length - 1] = item;
                Item = dest;
            }


        }
        public void Remove(int pos)
        {

        }

        public bool IsEmpty => Item is null || Item.Length == 0;

        public int count => Item is null ? 0 : Item.Length;

    }

}