using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace praktikaMelkov
{
    class laba9
    {
        public static void print()
        {
            Ex1();
        }

        struct Women
        {
            public const int age = 35;
            public string name;
            public byte sisi;
            public enum Demands
            {
                Age = 19,
                Pis = 15,
                growth = 183

            }
            public bool women(string name, double sisi)
            {
                if (sisi >= 2)
                {
                    this.name = name;
                    this.sisi = sisi;
                    return true;
                }
                return false;
            }
            public static string CreateWomen()
            {
                string[] subNames = new string[] { "Григорьева", "Пономарёва", "Герасимова", "Королёва", "Мелкова", "Захарова", "Романова", "Сергеева", "Сорокина", "Яковлева", "Алексеева", "Беляева", "Степанова", "Титова", "Андреева", "Комарова", "Баранова", "Васильева", "Морозова", "Волкова", "Петрова", "Киселёва", "Павлова" };
                string[] names = new string[] { "Алекстанда", "Полина", "Катя", "Владислава", "Влада", "Настя", "Маргарита", "Кира", "Даша", "Валентина", "Ира", "Аня", "Валя", "Ростислава" };
                string name = subNames[new Random().Next(0, subNames.Length - 1)] + " " + names[new Random().Next(0, names.Length - 1)];
                return name;
            }
        }
        struct Men
        {
            public byte age = 25;
            public string name;
            public byte pis;
            public double growtn;
            public enum Demands
            {
                Age = 17,
                Sisi = 2,
                growtn = 160

            }
            public bool men(string name, byte pis, byte age)
            {
                if (pis >= 7.5)
                {
                    this.name = name;
                    this.pis = pis;
                    this.age = age;
                    return true;
                }
                return false;
            }
            public bool iSisi(Women women)
            {
                return women.sisi > Convert.ToByte(Demands.Sisi);
            }
            public bool iAge(Women women)
            {
                return women.sisi > Convert.ToByte(Demands.Sisi);
            }
            public bool i(Women women)
            {
                return women.sisi > Convert.ToByte(Demands.Sisi);
            }
            public static string CreateMen()
            {
                string[] subNames = new string[] { "Григорьев", "Пономарёв", "Герасимов", "Королёв", "Борисов", "Захаров", "Романов", "Сергеев", "Сорокин", "Яковлев", "Алексеев", "Беляев", "Степанов", "Титов", "Андреев", "Комаров", "Баранов", "Васильев", "Морозов", "Волков", "Петров", "Киселёв", "Павлов" };
                string[] names = new string[] { "Алекстанд", "Павел", "Дмитрий", "Владислав", "Владимир", "Денис", "Роман", "Кирилл", "Данил", "Валентин", "Илья", "Андрей", "Фёдор", "Ростисла" };
                string name = subNames[new Random().Next(0, subNames.Length - 1)] + " " + names[new Random().Next(0, names.Length - 1)];
                return name;
            }
        }

        


            
            public static int CreateMark()
            {
                Random rnd = new Random();
                return rnd.Next(4, 11);
            }
            public static void Ex1()
            {
                Console.Write("Введите количество абитуриентов: ");
                int n = int.Parse(Console.ReadLine());
                Abiturient[] abiturients = new Abiturient[n];
                University[] unic = new University[25];
                int j = 0;
                for (int i = 0; i < n; i++)
                {
                    abiturients[i] = new Abiturient();
                    abiturients[i].SetName = CreateAbiturient();
                    abiturients[i].SetSubject_1 = CreateMark();
                    abiturients[i].SetSubject_2 = CreateMark();
                    abiturients[i].SetSubject_3 = CreateMark();
                    abiturients[i].SetAvg = (abiturients[i].SetSubject_3 + abiturients[i].SetSubject_2 + abiturients[i].SetSubject_1) / 3;

                }
                for (int i = 0; i < n; i++)
                {
                    if (j == 25)
                    {
                        Console.WriteLine("Места закончились, набор закрыт!");
                        break;
                    }
                    if (unic[j].university(abiturients[i].SetName, abiturients[i].SetAvg))
                    {
                        unic[j].university(abiturients[i].SetName, abiturients[i].SetAvg);
                        j++;
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Абитуриент : " + abiturients[i].SetName);
                    Console.WriteLine("Оценки по трём предметам " + abiturients[i].SetSubject_1 + " " + abiturients[i].SetSubject_2 + " " + abiturients[i].SetSubject_1);
                }

                for (int i = 0; i < 25; i++)
                {
                    Console.WriteLine("Абитуриент : " + unic[i].name + " Средний балл " + unic[i].avg);
                }
             
            } 

    }
}

