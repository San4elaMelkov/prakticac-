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
        public static double Round(double value, int dec)
        {
            return Math.Floor(value*dec)/dec;
        }
        public static string Read(string str)
        {
            Console.WriteLine(str);
            return Console.ReadLine();
        }
        
    }
}
