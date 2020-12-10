using System;
using System.Collections.Generic;
using System.Text;

namespace praktikaMelkov
{
    class laba1
    {
        public void print()
        {
            Console.WriteLine("Задание 3");
            laba1_3 zad1 = new laba1_3();
            zad1.Repeat(3,0.2);
            zad1.Pred(3, 0.2);
            zad1.Post(3, 0.2);
            Melkov.Whait();
            Console.WriteLine("Задание 4");
            List<int> array = Melkov.Generator(4,10,99);
            int summ = 0;
            foreach(int a in array)
            {
                Console.Write($"{a} ");
                if (a % 2 == 0)
                    summ += a;
            }
            Console.WriteLine($"Cумма четных чисел = {summ}");
            Melkov.Whait();
            Console.WriteLine("Задание 5");
            array = Melkov.Generator(4, -100, 100);
            summ = 0;
            foreach (int a in array)
            {
                Console.Write($"{a} ");
                if (a > 0)
                    summ += a;
            }
            Console.WriteLine($"Cумма положительных чисел = {summ}");

        }
    }

    class laba1_3
    {
        public void Repeat(double n, double shag)
        {
            Console.WriteLine("Выполняется цикл с повторением");
            for (double a = 0; a <= n; a += shag)
            {
                double z = (Math.Sin(2 * a) + Math.Sin(5 * a) - Math.Sin(3 * a)) / (Math.Cos(a) + 1 - 2 * Math.Pow(Math.Sin(2 * a), 2));
                Console.WriteLine($"При а = {Math.Floor(a * 1000) / 1000} z= {Math.Floor(z * 1000) / 1000}");
            }
        }
        public void Post(double n, double shag)
        {
            Console.WriteLine("Выполняется цикл с постусловием");
            double a = 1;
            do
            {
                double z = (Math.Sin(2 * a) + Math.Sin(5 * a) - Math.Sin(3 * a)) / (Math.Cos(a) + 1 - 2 * Math.Pow(Math.Sin(2 * a), 2));
                Console.WriteLine($"При а = {Math.Floor(a*1000)/1000} z= {Math.Floor(z * 1000) / 1000}");
                a += shag;
            }
            while (a <= n);
        }
        public void Pred(double n, double shag)
        {
            Console.WriteLine("Выполняется цикл с предусловием");
            double a = 1;
            while (a <= n)
            {
                double z = (Math.Sin(2 * a) + Math.Sin(5 * a) - Math.Sin(3 * a)) / (Math.Cos(a) + 1 - 2 * Math.Pow(Math.Sin(2 * a), 2));
                Console.WriteLine($"При а = {Math.Floor(a * 1000) / 1000} z= {Math.Floor(z * 1000) / 1000}");
                a += shag;
            }
        }
    }
}
