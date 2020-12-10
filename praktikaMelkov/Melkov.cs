using System;
using System.Collections.Generic;
using System.Text;

namespace praktikaMelkov
{
    class Melkov
    {
        public static List<int> Generator(int length, int min, int max)
        {
            Random rnd = new Random();
            List<int> arr = new List<int>();
            for (int i = 0; i < length; i++)
                arr.Add(rnd.Next(min, max));
            return arr;
        }
        public static void Whait()
        {
            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для продолжения");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
