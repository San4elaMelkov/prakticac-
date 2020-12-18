using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace praktikaMelkov
{
    class laba3
    {
        public static void print()
        {
            Library.Sort(Melkov.Read("Введите текст"));
        }
        class Library 
        {
            public static void Sort(string text)
            {
                if(text.Split().Length % 2 == 0) 
                    Array.ForEach(text.Split(' ').OrderBy(x => x.Length).ToArray(), x => Console.WriteLine(x));
                else 
                    Array.ForEach(text.Split(' ').OrderByDescending(x => x.Length).ToArray(), x => Console.WriteLine(x));
            }
        }
    }
}
