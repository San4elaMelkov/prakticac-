using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace praktikaMelkov
{
    class laba6
    {
        public static void print()
        {
            List<int> A = Melkov.Generator(10, -10, 10);
            Console.WriteLine("Вывод массива");
            int count=0, total = 1;
            List<int> A1 = new List<int>();
            foreach (int a in A)
            {
                Console.WriteLine(a);
                A1.Add(Math.Abs(a));
                if (a > 0 && a % 3 == 0)
                {
                    total *= a;
                    count++;
                }
                   
            }
            Console.WriteLine($"Произведение положительных элементов массива кратных 3-м = {total}\n" +
                $"Всего таких элементов {count}");
            int min = A1.Min();
            Console.WriteLine($"Индекс минимального элемента массива = {A1.IndexOf(min)}");
            total = 0;
            int idxNegative = 0;
            foreach(int a in A)
                if(a<0)
                {
                    idxNegative = A.IndexOf(a);
                    break;
                }
            for (int i = idxNegative; i < A.Count; i++)
                total += A[i];


        }
    }
}
