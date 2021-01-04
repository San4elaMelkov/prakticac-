using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace praktikaMelkov
{
    class laba7
    {
        public static void print()
        {
            Console.WriteLine("Задание 1");
            using (StreamReader reader = new StreamReader("D:\\file.txt"))
            {
                Regex regex = new Regex(@"\b[+-]?\d{2}\b");
                string s = null;
                while (false == reader.EndOfStream)
                {
                    s = reader.ReadLine();
                    if (true == regex.IsMatch(s))
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            Melkov.Whait("Задание 2");
            Console.WriteLine($"Число четных чисел = {Melkov.Read("Введите строку символов, через пробел").Split().Where(x => int.Parse(x) % 2 == 0).Count()}");
        }
    }
}
