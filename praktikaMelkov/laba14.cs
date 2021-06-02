using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace praktikaMelkov
{
    class laba14
    {
        public static void print()
        {
            Array array = new Array
            {
                myArray = new int[]{ 2, 3, 4, 762, 2, 62, 36, 7 }
            };

            array.Notify += Console.WriteLine;

            do
            {
                array.Start(int.Parse(Melkov.Read("Выберите действие")));
            } while (true);
        }

        class Array
        {
            public delegate void MyDelegate(string str);
            public event MyDelegate Notify;

            private int[] arr;

            public int[] myArray { get { return this.arr; } set { this.arr = value; this.isSorted = false; } }
            bool isSorted { get; set; }
            bool Ascending { get; set; }

            public void Start(int x)
            {
                switch (x)
                {
                    case 1:{
                        Notify?.Invoke($"Массив начал сортироваться по возрастанию");
                        this.SortAscending();
                        break;
                    }

                    case 2:
                    {
                        Notify?.Invoke($"Массив начал сортироваться по убыванию");
                        this.SortDescending();
                        break;
                    }

                    case 3:
                    {
                        Notify?.Invoke($"Начался вывод массива");
                        this.Output();
                        break;
                    }
                }
                return;
            } 

            public void SortAscending()
            {
                this.arr = arr.OrderBy(i => i).ToArray();

                this.isSorted = true;

                this.Ascending = true;

                Notify?.Invoke($"Массив только что был отсортирован по возрастанию");
                return;
            }

            public void SortDescending()
            {
                arr = arr.OrderByDescending(i => i).ToArray();

                this.isSorted = true;

                this.Ascending = false;

                Notify?.Invoke($"Массив только что был отсортирован по убыванию");
                return;
            }

            public void Status()
            {
                Console.WriteLine("Состояние массива");

                Console.WriteLine(this.isSorted ? this.Ascending ? "Массив отсортирован по возрастанию" : "Массив не отсортирован по убыванию" : "Массив не отсортирован");
                return;
            } 

            public void Output()
            {
                this.Status();
                foreach (var item in arr)
                {
                    Console.WriteLine(item);
                }   
                return;
            } 
        }
    }
}
