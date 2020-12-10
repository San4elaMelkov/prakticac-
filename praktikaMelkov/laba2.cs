using System;
using System.Collections.Generic;
using System.Text;

namespace praktikaMelkov
{
    class laba2
    {
        public static void print()
        {
         
            Console.WriteLine("Задание 1");
            double x = 5.4;
            double y = 1.9;
            double b = 3.5;
            double m = 0.2;
            double z = Math.Pow(x, 3) * Math.Pow(Math.Sin(x + b), 2) + x / (x + Math.Pow(b, 2));
            double s = (Math.Pow(m, 2) + Math.Pow(y, 2)) * Math.Pow(Math.E, m * y) + Math.Sqrt(3*m+Math.Log10(m+4*y));
            Console.WriteLine($"По уровнению Y = {Melkov.Round(z,100)}");
            Console.WriteLine($"По уровнению S = {Melkov.Round(s,100)}");
            Melkov.Whait();
            Console.WriteLine("Задание 2");
            int n =  int.Parse(Melkov.Read("Введите n"));
            if (n < 1) n = 1;
            double a = double.Parse(Melkov.Read("Введите a"));
            b = double.Parse(Melkov.Read("Введите b"));
            for (double i = a; i < b; i+=0.5)
                Console.WriteLine($"Интеграл = {Melkov.Round(integral(i,n),1000)} при i = {i}");
        }
        public static double integral(double x,int n)
        {
            switch (n)
            {
                case 1:
                    return Math.Sin(x);
                case 2:
                    return (x / 2) + 1 / 4 * Math.Sin(2 * x);
                default:
                    return (Math.Pow(Math.Cos(x), n - 1) * Math.Sin(x) / n) + ((n - 1) / n) * integral(x, 2);
            }
        }
    }
}
