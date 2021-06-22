using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace praktikaMelkov
{
    class laba21
    {
        public static void print()
        {
            Task fib = new Task(WriteFileFib);

            fib.Start();
            fib.Wait();

            Console.WriteLine("Вывод чисел Фибоначи");

            try
            {
                using (StreamReader sr = new StreamReader("../../../laba_21/fib.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }

                }
                Console.WriteLine("Файл прочитан успешно!!!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Task<uint> simple = new Task<uint>(Simple);

            simple.Start();
            simple.Wait();

            Console.WriteLine("Вывод простых чисел ");
            try
            {
                using (StreamReader sr = new StreamReader("../../../laba_21/simple.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }

                }
                Console.WriteLine("Файл прочитан успешно!!!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine($"Найдено {simple.Result} простых чисел");

        }

        public static void WriteFileFib()
        {
            for (int x = 1; x < 10; x++)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter("../../../laba_21/fib.txt", true))
                    {
                            
                        writer.WriteLine(Fibonachi(x));
                    }
                    Console.WriteLine("Число записало в файл");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return;
        }

        public static uint Simple()
        {
            Console.Write("N = ");
            var n = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("{0} первых простых чисел", n);
            var count = 0u;
            var i = 0u;
            while (count < n)
            {
                if (IsPrimeNumber(i))
                {
                    
                    try
                    {
                        using (StreamWriter writer = new StreamWriter("../../../laba_21/simple.txt", true))
                        {
                            writer.Write(i);
                            if (count < n - 1)
                            {
                                writer.Write(", ");
                            }
                        }
                        Console.WriteLine("Число записало в файл");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    
                    count++;
                }
                i++;
            }
            return count;
        }

        public static bool IsPrimeNumber(uint n)
        {
            var result = true;

            if (n > 1)
            {
                for (var i = 2u; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        result = false;
                        break;
                    }
                }
            }
            else
            {
                result = false;
            }

            return result;
        }

        static int Fibonachi(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            return Fibonachi(n - 1) + Fibonachi(n - 2);
        } 
    }
}
