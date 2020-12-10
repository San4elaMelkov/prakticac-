using System;
using System.Collections.Generic;
using System.Text;

namespace praktikaMelkov
{
    class laba3
    {
        public static void print()
        {
            string text = Melkov.Read("Введите текст");
            string[] s = text.Split();
            Array.Sort(s);
            foreach(string str in s)
                Console.WriteLine(str);
        }   
    }
}
