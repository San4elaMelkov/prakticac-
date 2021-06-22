using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace praktikaMelkov
{
    class laba17
    {
        public static void print()
        {
            List<int> mass = new List<int>();

            try
            {
                using (StreamReader sr = new StreamReader("../../../laba_17/laba17.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {

                            if (line.Length > 1 && line[line.Length - 1] == ' ')
                            {
                                line = line.Remove(line.Length - 1);
                            }

                            string[] numbers = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                            foreach (var numb in numbers)
                            {
                                mass.Add(int.Parse(numb));
                            }
                        
                        
                    }

                }
                Console.WriteLine("Файл прочитан успешно!!!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                using (StreamWriter writer = new StreamWriter("../../../laba_17/laba17.txt"))
                {
                    foreach (var numb in mass)
                    {
                        writer.Write($"{(numb*2)} ");
                    }
                }
                Console.WriteLine("Файл заполнен");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            return;
        } 
    }
}
