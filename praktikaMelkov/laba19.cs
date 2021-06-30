using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace praktikaMelkov
{
    class laba19
    {
        public static void print()
        {
            List<MARSH> marshes = new List<MARSH>();

            for (int i = 0; i < 8; i++)
            {
                marshes.Add(
                    new MARSH
                    {
                        StartPathName = Melkov.Read("Введите название начального пути"),
                        EndPathName = Melkov.Read("Введите название конечного пути"),
                        Number = int.Parse(Melkov.Read("Введите номер маршрута"))
                    }
                );
                Console.Clear();
            }
            marshes = (from m in marshes
                       orderby m.Number
                       select m).ToList();

            int n = int.Parse(Melkov.Read("Введите номер маршрута который хотите найти"));

            MARSH marsh = (from m in marshes
                           where m.Number == n
                           select m).First();

            try
            {
                marsh.ToString();
            }
            catch (Exception)
            {
                Console.WriteLine("Маршрутов не найдено");
            }
            
            return;
        }

        struct MARSH
        {
            public string StartPathName { get; set; }

            public string EndPathName { get; set; }

            public int Number { get; set; }

            public override string ToString()
            {
                return $"Маршрут {Number} - {StartPathName} - {EndPathName} ";
            }
        }

        abstract class Vehicle
        {
            public int Price { get; set; }

            public double Speed { get; set; }

            public int Age { get; set; }

            public double PosX { get; set; }

            public double PosY { get; set; }

            public void SetSpeed(double speed)
            {
                this.Speed = speed;
                return;
            } 

        }

        class Plan : Vehicle
        {
            public double Height { get; set; }

            public int Passengers { get; set; }
        }

        class Car : Vehicle
        {

        }

        class Ship : Vehicle
        {
            public int Port { get; set; }

            public int Passengers { get; set; }

            public double PosZ { get; set; }
        }
    }
}
