using System;
using System.Collections.Generic;
using System.Text;

namespace praktikaMelkov
{
    class laba4
    {
        public static void print()
        {
            int n = int.Parse(Melkov.Read("Введите ранг матрицы"));
            List<List<int>> mass = Melkov.Generator2x(n, -100, 100);
            Melkov.PrintMass2x(mass);
            Console.WriteLine($"Определитель матрицы = {Determinant(mass, n)}");
        }
        
        static int Determinant(List<List<int>> mass, int m)
        {
            if (m < 1) Console.WriteLine("Определитель вычислить невозможно!");
            if (m == 1) return mass[0][0];
            if (m == 2) return (mass[0][0] * mass[1][1] - (mass[1][0] * mass[0][1]));
            return 0;
        }
    }
     
}

