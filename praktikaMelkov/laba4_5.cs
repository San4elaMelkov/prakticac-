using System;
using System.Collections.Generic;
using System.Text;

namespace praktikaMelkov
{
    class laba4_5
    {
        public static void print()
        {
            try
            {
                int n = int.Parse(Melkov.Read("Введите ранг матрицы"));
                List<List<int>> mass = Melkov.Generator2x(n, -100, 100);
                Melkov.PrintMass2x(mass);
                Console.WriteLine($"Определитель матрицы = {Determinant(mass, n)}");
                Melkov.Whait("Задание 2");
                n = int.Parse(Melkov.Read("Введите количество комнат"));
                Room[] rooms = new Room[n];
                int i;
                double metr, height, width;
                int window;
                for (i = 0; i < rooms.Length; i++)
                {
                    metr = double.Parse(Melkov.Read($"Введите метраж {i + 1}-й комнаты"));
                    window = int.Parse(Melkov.Read($"Введите количество окон {i + 1}-й комнаты"));
                    height = double.Parse(Melkov.Read($"Введите высоту потолка {i + 1}-й комнаты"));
                    width = double.Parse(Melkov.Read($"Введите ширину {i + 1}-й комнаты"));
                    rooms[i] = new Room(metr, height, window, width);
                }
                Console.WriteLine("Создание комнат завершено");
                n = int.Parse(Melkov.Read("Введите номер комнаты которой надо посчитать площадь"));
                if (n > rooms.Length) Console.WriteLine($"Дибил, у тебя всего {rooms.Length} комнат");
                else Console.WriteLine($"Площадь комнаты = {rooms[n - 1].GetSquare()} метров квадратных");
                n = int.Parse(Melkov.Read("Введите номер комнаты которой надо посчитать обьем метров кубических"));
                if (n > rooms.Length) Console.WriteLine($"Дибил, у тебя всего {rooms.Length} комнат");
                else Console.WriteLine($"Обьем комнаты = {rooms[n-1].GetVolume()}");
                Melkov.Whait("Задание 3");
                MyArray<int> arr1 = new MyArray<int>(Melkov.Generator(4,1,5));
                MyArray<int> arr2 = new MyArray<int>(Melkov.Generator(4, 1, 5));
                List<int> arr = arr1 * arr2;
                Console.WriteLine("Умножение массивов");
                foreach(double ar in arr)
                    Console.WriteLine(ar);
            }
            catch (Exception e)
            {
                Console.WriteLine("Демон не ломай мою программу");
                Console.WriteLine(e.Message);
                Console.WriteLine("Я лучше сам введу данные");
                Melkov.Whait();
                int n = 3;
                List<List<int>> mass = Melkov.Generator2x(n, -100, 100);
                Melkov.PrintMass2x(mass);
                Console.WriteLine($"Определитель матрицы = {Determinant(mass, n)}");
                Melkov.Whait("Задание 2");
                n = 3;
                Room[] rooms = new Room[n];
                int i;
                double metr, height, width;
                int window;
                for (i = 0; i < rooms.Length; i++)
                {
                    metr = 10;
                    window = 5;
                    height = 2.3;
                    width = 19;
                    rooms[i] = new Room(metr, height, window, width);
                }
                Console.WriteLine("Создание комнат завершено");
                n = 1;
                if (n > rooms.Length) Console.WriteLine($"Дибил, у тебя всего {rooms.Length} комнат");
                else Console.WriteLine($"Площадь комнаты = {rooms[3 - 1].GetSquare()} метров квадратных");
                n = 2;
                if (n > rooms.Length) Console.WriteLine($"Дибил, у тебя всего {rooms.Length} комнат");
                else Console.WriteLine($"Обьем комнаты = {rooms[2 - 1].GetVolume()}");
                Melkov.Whait("Задание 3");
                MyArray<int> arr1 = new MyArray<int>(Melkov.Generator(4, 1, 5));
                MyArray<int> arr2 = new MyArray<int>(Melkov.Generator(4, 1, 5));
                List<int> arr = arr1 * arr2;
                Console.WriteLine("Умножение массивов");
                foreach (double ar in arr)
                    Console.WriteLine(ar);
            }
        }
        static int Determinant(List<List<int>> mass, int m)
        {
            if (m < 1) Console.WriteLine("Определитель вычислить невозможно!");
            if (m == 1) return mass[0][0];
            if (m == 2) return (mass[0][0] * mass[1][1] - (mass[1][0] * mass[0][1]));
            return 0;

        }
        class MyArray<T>
        {
            List<double> dArray = new List<double>();
            List<int> iArray = new List<int>();

            public MyArray(List<double> arr)
            {
                for (int i = 0; i < arr.Count; i++)
                    this.dArray.Add(arr[i]);
            }
            public MyArray(List<int> arr)
            {
                for (int i = 0; i < arr.Count; i++)
                    this.iArray.Add(arr[i]);
            }
            List<double> Multi(List<double> arr1, List<double> arr2)
            {
                int i;
                for (i = 0; i < arr1.Count; i++)
                    this.dArray[i] = arr1[i] * arr2[i];
                return this.dArray;
            }
            List<int> Multi(List<int> arr1, List<int> arr2)
            {
                int i;
                for (i = 0; i < arr1.Count; i++)
                    this.iArray[i] = arr1[i] * arr2[i];
                return this.iArray;
            }
            public static List<double> operator *(MyArray<double> ob1, MyArray<T> ob2)
            {
                if(ob1.GetType() != ob2.GetType()) throw new Exception("Даны разной длины массивы");
                if (ob1.iArray.Count != ob2.iArray.Count) throw new Exception("Даны разной длины массивы");
                try
                {
                    return ob1.Multi(ob1.dArray, ob2.dArray);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return new List<double>();
                }
            }
            public static List<int> operator *(MyArray<int> ob1, MyArray<T> ob2)
            {
                if(ob1.GetType() != ob2.GetType()) throw new Exception("Даны разной длины массивы");
                if (ob1.iArray.Count != ob2.iArray.Count) throw new Exception("Даны разной длины массивы");
                try
                {
                    return ob1.Multi(ob1.iArray, ob2.iArray);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return new List<int>();
                }
                
                
            }
        }
        class Room
        {
            private double metr;
            private double height;
            private double width;
            private int window;
            private double volume = 0.0;
            private double square=0.0;

            public double Metr
            {
                get{return this.metr;}
                set {
                    if (value > 0 && value < 100)
                        this.metr = value;
                    else
                        Console.WriteLine("Недопустимые значение");
                }
            }
            public Room(double metr = 0.0, double height = 0.0, int window = 0, double width = 0.0)
            {
                Metr = metr;
                Height = height;
                Width = width;
                Window = window;
            }
            public double Height
            {
                get { return this.height; }
                set { 
                    if (value > 0 && value < 10) 
                        this.height = value;
                    else 
                        Console.WriteLine("Недопустимые значение");
                }
            }
            public double Width
            {
                get { return this.width; }
                set
                {
                    if (value > 0 && value < 30)
                        this.width = value;
                    else 
                        Console.WriteLine("Недопустимые значение");
                }
            }
            public int Window
            {
                get { return this.window; }
                set { 
                    if (value > 0 && value < 10) 
                        this.window = value;
                    else 
                        Console.WriteLine("Недопустимые значение");
                }
            }
            public double Square
            {
                get { return this.square; }
                set
                {
                    if (value > 0 && value < 50)
                        this.square = value;
                    else 
                        Console.WriteLine("Недопустимые значение");
                }
            }
            public double Volume
            {
                get { return this.volume; }
                set
                {
                    if (value > 0 && value < 100)
                        this.volume = value;
                    else 
                        Console.WriteLine("Недопустимые значение");
                }
            }
            public double GetSquare()
            {
                this.square = this.height*this.width;
                return this.square;
            }
            public double GetVolume()
            {
                this.volume = this.height * this.width;
                return this.volume;
            }
            
        }
    }
}
