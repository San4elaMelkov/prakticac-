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
            Console.WriteLine("Задание 1");
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
            Melkov.Whait("Задание 2.1");
            int min = A1.Min();
            Console.WriteLine($"Индекс минимального элемента массива по модулю = {A1.IndexOf(min)}");
            Melkov.Whait("Задание 2.2");
            total = 0;
            int idxNegative = 0;
            foreach(int a in A)
                if(a<0)
                {
                    idxNegative = A.IndexOf(a);
                    break;
                }
            for (int i = idxNegative; i < A.Count; i++)
                total += Math.Abs(A[i]);
            Console.WriteLine($"Cумма модулей элементов массива, расположенных после первого отрицатель¬ного элемента  = {total}");
            Melkov.Whait("Задание 2.3");
            int a1 = int.Parse(Melkov.Read("Введите интервал а: "));
            int b1 = int.Parse(Melkov.Read("Введите интервал b: "));
            List<int> idx = new List<int>();
            foreach (int a in A)
                if (a1 <= a && a <= b1)
                    idx.Add(a);
            foreach (int i in idx)
                A.Remove(i);
            while (idx.Count != 0)
            {
                A.Add(0);
                idx.RemoveAt(idx.Count-1);
            }
            Console.WriteLine("Вывод массива");
            foreach(int a in A)
                Console.WriteLine(a);
            Melkov.Whait("Задание 3");
            double[,] matrix = new double[3, 3];
            Random random = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(0); j++)
                    matrix[i, j] = random.Next(1, 9);
            Print(ToTriangle(matrix));

        }
        static double [,] ToTriangle(double[,] matr)
        {
            double n = matr.GetLength(0);
            for (int i = 0; i < n - 1; i++)
                for (int j = i + 1; j < n; j++)
                {
                    double koef = matr[j, i] / matr[i, i];
                    for (int k = i; k < n; k++)
                        matr[j, k] -= matr[i, k] * koef;
                }
            return matr;
        }
        static void Print(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                    Console.Write("{0:0.0}\t", matrix[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
