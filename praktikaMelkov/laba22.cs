using System;
using System.Collections.Generic;
using System.Text;

namespace praktikaMelkov
{
    class laba22
    {
        public static void print()
        {
            Car auto = new Car(10, "Tesla", new PetrolMove());
            auto.Move();
            auto.Fuel = new ElectricMove();
            auto.Move();
        }

        interface IFuel
        {
            void Move();
        }

        class Car
        {
            protected int passengers;
            protected string model;

            public Car(int num, string model, IFuel fuel)
            {
                this.passengers = num;
                this.model = model;
                Fuel = fuel;
            }
            public IFuel Fuel { private get; set; }
            public void Move()
            {
                Fuel.Move();
            }
        }

        class PetrolMove : IFuel
        {
            public void Move()
            {
                Console.WriteLine("Двигаюсь на бензине");
            }
        }

        class GasMove : IFuel
        {
            public void Move()
            {
                Console.WriteLine("Двигаюсь на газу");
            }
        }

        class ElectricMove : IFuel
        {
            public void Move()
            {
                Console.WriteLine("Двигаюсь на электричестве");
            }
        }

        class DieselMove : IFuel
        {
            public void Move()
            {
                Console.WriteLine("Двигаюсь на дизеле");
            }
        }

        class HybridMove : IFuel
        {
            public void Move()
            {
                Console.WriteLine("Двигаюсь на всех видах топлива");
            }
        }


    }
}
