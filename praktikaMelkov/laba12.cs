using System;
using System.Collections.Generic;
using System.Text;

namespace praktikaMelkov
{
    class laba12
    {
        public static void print()
        {
            Melkov.Whait("Задание 1");
            Manager manager = new Manager("Дима");
            Developer dev = new Developer("Александр",100000);
            Admin admin = new Admin();

            dev.Job();
            manager.Job(100);
            admin.Relax(10);
            manager.experience = 3.5;
            manager.Show();
            Melkov.Whait("Задание 2");
            MyArray<int> arr1 = new MyArray<int>(Melkov.Generator(4, 1, 5));
            MyArray<int> arr2 = new MyArray<int>(Melkov.Generator(4, 1, 5));
            List<int> arr = arr1 * arr2;
            Console.WriteLine("Умножение массивов");
            foreach (double ar in arr)
                Console.WriteLine(ar);
        }

        abstract class Worker
        {
            public string name { get; set; }
            public double pay { get; set; }
            public string position { get; set; }
            public double experience { get; set; }

            public virtual void Job()
            {
                Console.WriteLine("Метод заставляет работать");
            }
            public virtual void Relax()
            {
                Console.WriteLine("Метод позволяет отдыхать");
            }

        }
        class Manager:Worker
        {
            public override void Job()
            {
                base.Job();
                this.Show();
                this.pay += 1000;
            }
            public void Job(double pay)
            {
                base.Job();
                this.pay += pay;
            }
            public Manager()
            {
                this.position = "Менеджер";
            }
            public Manager(string name)
            {
                this.name = name;
                this.position = "Менеджер";
            }
            public Manager(string name, double pay)
            {
                this.name = name;
                this.pay = pay;
                this.position = "Менеджер";
            }
            public override void Relax()
            {
                base.Relax();
                this.pay -= 1000;
            }
            public void Relax(double pay)
            {
                base.Relax();
                this.pay -= pay;
            }
            public void Show()
            {
                Console.WriteLine($"Имя: {this.name}\n" +
                    $"Стаж: {this.experience}\n" +
                    $"Зарплата: {this.pay}\n" +
                    $"Должность: {this.position}\n");
            }
        }
        class Developer : Worker
        {
            public override void Job()
            {
                base.Job();
                this.Show();
                this.pay += 1000;
            }
            public void Job(double pay)
            {
                base.Job();
                this.pay += pay;
            }
            public Developer()
            {
                this.position = "Программист";
            }
            public Developer(string name)
            {
                this.name = name;
                this.position = "Программист";
            }
            public Developer(string name, double pay)
            {
                this.name = name;
                this.pay = pay;
                this.position = "Программист";
            }
            public override void Relax()
            {
                base.Relax();
                this.pay -= 1000;
            }
            public void Relax(double pay)
            {
                base.Relax();
                this.pay -= pay;
            }
            public void Show()
            {
                Console.WriteLine($"Имя: {this.name}\n" +
                    $"Стаж: {this.experience}\n" +
                    $"Зарплата: {this.pay}\n" +
                    $"Должность: {this.position}\n");
            }
        }
        class Admin : Worker
        {
            public override void Job()
            {
                base.Job();
                this.pay += 1000;
            }
            public void Job(double pay)
            {
                base.Job();
                this.Show();
                this.pay += pay;
            }
            public Admin()
            {
                this.position = "Администратор";
            }
            public Admin(string name)
            {
                this.name = name;
                this.position = "Администратор";
            }
            public Admin(string name, double pay)
            {
                this.name = name;
                this.pay = pay;
                this.position = "Администратор";
            }
            public override void Relax()
            {
                base.Relax();
                this.pay -= 1000;
            }
            public void Relax(double pay)
            {
                base.Relax();
                this.pay -= pay;
            }
            public void Show()
            {
                Console.WriteLine($"Имя: {this.name}\n" +
                    $"Стаж: {this.experience}\n" +
                    $"Зарплата: {this.pay}\n" +
                    $"Должность: {this.position}\n");
            }
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
                if (ob1.GetType() != ob2.GetType()) throw new Exception("Даны разных типов массивы");
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
                if (ob1.GetType() != ob2.GetType()) throw new Exception("Даны разных типов массивы");
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
    }
}
