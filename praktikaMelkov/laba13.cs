using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace praktikaMelkov
{
    class laba13
    {
        delegate List<Char> Stringer(string str);

        class Char
        {
            public int Count { get; set; }
            public char Symbol { get; set; }
            public override string ToString()
            {
                return $"{Count} - {Symbol}";
            }
        }

        static List<Char> strings(string str)
        {
            List<Char> chars = new List<Char>();
            string stringChars = new string(str.Distinct().ToArray());

            foreach (var cr in stringChars)
            {
                chars.Add(
                    new Char
                    {
                        Count = str.ToCharArray().Count(c => c == cr),
                        Symbol = cr
                    }
                );
            }
            return chars;
        }

        public static void print()
        {
            Func<Action<int, int>, bool> func;
            Action<int, int> op = isEqual;
            func = isEqual;
            bool a = func.Invoke(op);
            Console.WriteLine($"Ответ {a}");

            Melkov.Whait("Задание 2");
            Stringer delegat = strings;


            foreach (var cr in delegat(Melkov.Read("Введите строку"))){
                Console.WriteLine(cr.ToString());
            }
        }

        static void isEqual(int x1, int x2)
        {
            Console.WriteLine($"Числа равны: {x1 == x2}");
        }

        static bool isEqual(Action<int,int> aa)
        {
            int x1 = int.Parse(Melkov.Read("Введите x1"));
            int x2 = int.Parse(Melkov.Read("Введите x2"));
            aa.Invoke(x1,x2);
            return x1 == x2;
        }
    }
}