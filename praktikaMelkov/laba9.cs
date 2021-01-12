using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace praktikaMelkov
{
    class laba9
    {

        public static void print()
        {
            foreach (Bride bride in Brides)
            {
                foreach (BrideGroome groome in Grooms)
                {
                    if (groome.Age >= bride.prop.Age)
                        bride.Priority[groome.Id]++;
                    if (groome.Weight >= bride.prop.Weight)
                        bride.Priority[groome.Id]++;
                    if (groome.Growth >= bride.prop.Growth)
                        bride.Priority[groome.Id]++;
                    if (groome.Alcohol == bride.prop.Alcohol)
                        bride.Priority[groome.Id]++;
                    if (groome.Smoking == bride.prop.Smoking)
                        bride.Priority[groome.Id]++;
                    if (groome.BodyType == bride.prop.BodyType)
                        bride.Priority[groome.Id]++;
                    //женихи
                    if (bride.Age >= groome.prop.Age)
                        groome.Priority[bride.Id]++;
                    if (bride.Weight >= groome.prop.Weight)
                        groome.Priority[bride.Id]++;
                    if (bride.Growth >= groome.prop.Growth)
                        groome.Priority[bride.Id]++;
                    if (bride.Alcohol == groome.prop.Alcohol)
                        groome.Priority[bride.Id]++;
                    if (bride.Smoking == groome.prop.Smoking)
                        groome.Priority[bride.Id]++;
                    if (bride.BodyType == groome.prop.BodyType)
                        groome.Priority[bride.Id]++;
                }
            }
            Melkov.Whait("Женихи");
            foreach (Bride bride in Brides)
            {
                Console.WriteLine($"Рекомедуемые женихи {bride.Name}:\n");
                foreach (BrideGroome groome in Grooms)
                {
                    if (bride.Priority[groome.Id] > 2)
                    {
                        groome.PrintInfo();
                    }
                }
                Console.WriteLine("___________________________");
            }
            Melkov.Whait("Невесты");
            foreach (BrideGroome groome in Grooms)
            {
                Console.WriteLine($"Рекомедуемые невесты {groome.Name}:\n");
                foreach (Bride bride in Brides)
                {
                    if (groome.Priority[bride.Id] > 2)
                    {
                        bride.PrintInfo();
                    }
                }
                Console.WriteLine("___________________________");
            }



        }
        private static Bride[] Brides = GetBrides();
        public static Bride[] GetBrides()
        {
            return new Bride[] {
                new Bride().Create(0),
                new Bride().Create(1)
            };
        }
        private static BrideGroome[] Grooms = GetGroome();
        public static BrideGroome[] GetGroome()
        {
            return new BrideGroome[] {
                new BrideGroome().Create(0),
                new BrideGroome().Create(1),
                new BrideGroome().Create(2),

            };
        }
        public enum Alcohol
        {
            Alcoholic,
            Moderately,
            NotDrinking
        }
        public enum BodyType
        {
            Fat,
            Сommon,
            Thin,
            Sports
        }
        public enum Smoking
        {
            Smokes,
            Negative,
            Neutral
        }
        public abstract class Joven
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public int Weight { get; set; }
            public int Growth { get; set; }
            public Alcohol Alcohol { get; set; }
            public Smoking Smoking { get; set; }
            public BodyType BodyType { get; set; }
            public int[] Priority { get; set; } = new int[9999];
            public void PrintInfo()
            {
                Console.WriteLine($"Фамилия Имя: {this.Name}\n" +
                    $"Возраст: {this.Age} лет\n" +
                    $"Вес: {this.Weight} кг\n" +
                    $"Рост: {this.Growth} см\n" +
                    $"Отношение к алкоголю: {this.Alcohol}\n" +
                    $"Отношение к курению: {this.Smoking}\n" +
                    $"Телосложение: {this.BodyType}\n\n");
            }
            public class PropBride
            {
                public int Age { get; set; }
                public int Weight { get; set; }
                public int Growth { get; set; }
                public Alcohol Alcohol { get; set; }
                public Smoking Smoking { get; set; }
                public BodyType BodyType { get; set; }
                public PropBride Create()
                {
                    this.Age = new Random().Next(18, 60);
                    this.Weight = new Random().Next(40, 120);
                    this.Growth = new Random().Next(150, 220);
                    this.Alcohol = (Alcohol)new Random().Next(Enum.GetNames(typeof(Alcohol)).Length);
                    this.Smoking = (Smoking)new Random().Next(Enum.GetNames(typeof(Alcohol)).Length);
                    this.BodyType = (BodyType)new Random().Next(Enum.GetNames(typeof(Alcohol)).Length);
                    return this;
                }

            }

        }
        public class Bride: Joven
        {
            private string[] subNames = new string[] { "Григорьева", "Пономарёва", "Герасимова", "Королёва", "Мелкова", "Захарова", "Романова", "Сергеева", "Сорокина", "Яковлева", "Алексеева", "Беляева", "Степанова", "Титова", "Андреева", "Комарова", "Баранова", "Васильева", "Морозова", "Волкова", "Петрова", "Киселёва", "Павлова" };
            private string[] names = new string[] { "Алекстанда", "Полина", "Катя", "Владислава", "Влада", "Настя", "Маргарита", "Кира", "Даша", "Валентина", "Ира", "Аня", "Валя", "Ростислава" };
            
            public PropBride prop = new PropBride().Create();
            public Bride Create(int id)
            {
                this.Id = id;
                this.Name = this.subNames[new Random().Next(0, this.subNames.Length - 1)] + " " + this.names[new Random().Next(0, this.names.Length - 1)];
                this.Age = new Random().Next(18, 60);
                this.Weight = new Random().Next(40,120);
                this.Growth = new Random().Next(150, 220);
                this.Alcohol = (Alcohol)new Random().Next(Enum.GetNames(typeof(Alcohol)).Length);
                this.Smoking = (Smoking)new Random().Next(Enum.GetNames(typeof(Alcohol)).Length);
                this.BodyType = (BodyType)new Random().Next(Enum.GetNames(typeof(Alcohol)).Length);
                return this;
            }
            
        }
        public class BrideGroome: Joven
        {
            string[] subNames = new string[] { "Григорьев", "Пономарёв", "Герасимов", "Королёв", "Борисов", "Захаров", "Романов", "Сергеев", "Сорокин", "Яковлев", "Алексеев", "Беляев", "Степанов", "Титов", "Андреев", "Комаров", "Баранов", "Васильев", "Морозов", "Волков", "Петров", "Киселёв", "Павлов" };
            string[] names = new string[] { "Алекстанд", "Павел", "Дмитрий", "Владислав", "Владимир", "Денис", "Роман", "Кирилл", "Данил", "Валентин", "Илья", "Андрей", "Фёдор", "Ростисла" };
            public PropBride prop = new PropBride().Create();
            public BrideGroome Create(int id)
            {
                this.Id = id;
                this.Name = this.subNames[new Random().Next(0, this.subNames.Length - 1)] + " " + this.names[new Random().Next(0, this.names.Length - 1)];
                this.Age = new Random().Next(18, 60);
                this.Weight = new Random().Next(40, 120);
                this.Growth = new Random().Next(150, 220);
                this.Alcohol = (Alcohol)new Random().Next(Enum.GetNames(typeof(Alcohol)).Length);
                this.Smoking = (Smoking)new Random().Next(Enum.GetNames(typeof(Alcohol)).Length);
                this.BodyType = (BodyType)new Random().Next(Enum.GetNames(typeof(Alcohol)).Length);
                return this;
            }
        }

    }
}

