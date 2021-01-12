using System;
using System.Collections.Generic;
using System.Text;

namespace praktikaMelkov
{
    class laba5
    {
        public static void print()
        {
            try
            {
                Melkov.Whait("Задание 1");
                int n = int.Parse(Melkov.Read("Введите количество комнат"));
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
            }
            catch (Exception e)
            {
                Console.WriteLine("Демон не ломай мою программу");
                Console.WriteLine(e.Message);
                Console.WriteLine("Я лучше сам введу данные");
                Melkov.Whait();
                int n = 3;
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
                if (n > rooms.Length) Console.WriteLine($"У тебя всего {rooms.Length} комнат");
                else Console.WriteLine($"Площадь комнаты = {rooms[3 - 1].GetSquare()} метров квадратных");
                n = 2;
                if (n > rooms.Length) Console.WriteLine($"У тебя всего {rooms.Length} комнат");
                else Console.WriteLine($"Обьем комнаты = {rooms[2 - 1].GetVolume()}");            }
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
