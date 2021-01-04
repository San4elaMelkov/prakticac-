using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace praktikaMelkov
{
    class laba8
    {
        public static void print()
        {
            Console.WriteLine("Задание 1");

            Regex regex = new Regex(@"((0?\((33|29|44|25)\))\s?((\d{7})|(\d{3}(-|\s)?\d{2}(-|\s)?\d{2})))");
            string str = Melkov.Read("Введите строку");
            MatchCollection matches = regex.Matches(str);
            foreach (Match item in matches)
            {
                Console.WriteLine(item);
            }

        }
    }
}
