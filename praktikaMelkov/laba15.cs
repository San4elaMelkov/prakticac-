using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace praktikaMelkov
{
    class laba15
    {
        static object locker = new object();

        public static void print()
        {
            int threadCount = 4;
            Thread[] threads = new Thread[threadCount]; 
            for (int i = 0; i < threadCount; i++)
            {
                threads[i] = new Thread( new ThreadStart(getStats));
                threads[i].Name = (i + 1).ToString();
                threads[i].Start();
            }

            Thread.Sleep(1000);

            Melkov.Whait("Задание 2");

            for (int i = 0; i < threadCount; i++)
            {
                threads[i] = new Thread(MyMethod);
                threads[i].Name = (i+1).ToString();
                threads[i].Priority = (ThreadPriority)i;
                Console.WriteLine($"Поток {i} создан!");
            }
            foreach (var thread in threads)
            {
                thread.Start();
                Console.WriteLine($"Поток {thread.Name} запущен");
            }

            Thread.Sleep(1000);

            Melkov.Whait("Задание 3");

            for (int i = 0; i < threadCount; i++)
            {
                threads[i] = new Thread(new ParameterizedThreadStart(getStats));
                threads[i].Start(5+i);

            }
        }

        static void MyMethod()
        {
            lock (locker)
            {
                Console.WriteLine($"Поток номер {Thread.CurrentThread.Name} имеет приоритет {Thread.CurrentThread.Priority}");
                return;
            }
        }

        static void getStats(object len)
        {
            lock (locker)
            {
                int[] Array = new int[Convert.ToInt32(len)];
                int Count = 0;

                Random rnd = new Random();

                for (int i = 0; i < Array.Length; i++)
                {
                    Array[i] = rnd.Next(100);
                }

                for (int i = 0; i < Array.Length; i++)
                {
                    for (int j = 0; j < Array.Length; j++)
                    {
                        if (Array[i] == Array[j])
                            Count++;
                    }
                    Console.WriteLine($"Элемент {Array[i]} встречается в массиве {Count} раз");
                    Count = 0;
                }
            }
            return;
        } 

        static void getStats()
        {
            lock (locker)
            {
                Random rnd = new Random();
                int[] arr = new int[rnd.Next(1, 10)];

                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rnd.Next(100);
                }

                Console.WriteLine($"Поток: {Thread.CurrentThread.Name}");

                Console.WriteLine($"Количество элементов массива = {arr.Length}");
            }
            return;
        } 
    }
}
