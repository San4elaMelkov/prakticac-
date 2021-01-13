using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace praktikaMelkov
{
    class laba10
    {
        public static void print()
        {
            StudentViewer viewer = new StudentViewer(3);
            double total = TotalCost(viewer, 35.0, 1);
            Console.WriteLine($"Посещений: {viewer.visits}");
            Console.WriteLine($"Скидка: {viewer.discount}");
            Console.WriteLine($"Итоговая стоимость: {total}");
        }
        public static double TotalCost(Viewer viewer, double cost, int ticket)
        {
            viewer.visits += ticket;
            return viewer.Cost(cost);
        }
        public interface Viewer
        {
            int visits { get; set; }
            double discount { get; set; }

            void Visit()
            {
                this.visits++;
            }
            abstract double Cost(double cost);
        }
        class RegularViewer : Viewer
        {
            public int visits
            {
                get { return visits; }
                set
                {
                    if (value < 1000)
                        this.visits = value; 
                }
            }
            public RegularViewer(int visit)
            {
                this.visits = visit;
            }
            public double discount {
                get
                {
                    return discount;
                }
                set
                {
                    if (this.visits % 10 == 0 && this.discount <= 20)
                    {
                        this.discount++;
                    }
                }
            }
            public double Cost(double cost)
            {
                return (cost * discount) / 100;
            }
        }
        class StudentViewer : Viewer
        {
            private int Visits;
            public int visits
            {
                get { return this.Visits; }
                set
                {
                    if (value < 100)
                    {
                        this.Visits = value;
                        this.discount = 1; 
                    }
                        
                }
            }
            public StudentViewer(int visit)
            {
                this.Visits = visit;
            }
            private int Discount;
            public double discount
            {
                get
                {
                    return this.Discount;
                }
                set
                {
                    if (this.visits % 4 == 0 && this.Discount != 50)
                    {
                        this.Discount = 50;
                    }
                }
            }
            public double Cost(double cost)
            {
                return cost * this.Visits - ((cost*this.Visits * this.Discount) / 100);
            }
        }
    }
}
