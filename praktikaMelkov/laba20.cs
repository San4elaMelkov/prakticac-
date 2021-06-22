using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace praktikaMelkov
{
    class laba20
    {
        static XElement root;
        static XDocument xdoc;
        static string path;
        public static void print()
        {
            path = "../../../laba20.xml";

            xdoc = XDocument.Load(path);
            root = xdoc.Element("buses");

            Show();

            Console.Write("Введите данные автобуса, который нужно удалить: ");
            Delete(Console.ReadLine());

            Show();

            Add();

            Show();

            Console.Write("Введите данные автобуса, который нужно изменить: ");
            Rename(Console.ReadLine());

            Show();
        }

        static void Show()
        {
            Console.WriteLine("_____________________________________");
            foreach (XElement xe in root.Elements("bus").ToList())
            {
                Bus book = new Bus();

                book.Number = xe.Attribute("number").Value;
                book.Date = xe.Element("date").Value;
                book.Destination = xe.Element("destination").Value;

                Console.WriteLine($"{book.Number} {book.Destination} {book.Date}");
            }
            return;
        }

        static void Delete(string number)
        {
            foreach (XElement xe in root.Elements("bus").ToList())
            {
                if (xe.Attribute("number").Value == number)
                {
                    xe.Remove();
                }
            }
            xdoc.Save(path);
        }

        static void Rename(string _name)
        {
            Console.Write("Номер: ");
            string number = Console.ReadLine();
            Console.Write("Дата прохождения то: ");
            string date = Console.ReadLine();
            Console.Write("Пункт назначения: ");
            string destination = Console.ReadLine();

            foreach (XElement xe in root.Elements("bus").ToList())
            {
                if (xe.Attribute("number").Value == _name)
                {
                    xe.Attribute("number").Value = number;
                    xe.Element("date").Value = date;
                    xe.Element("destination").Value = destination;
                }
            }
            xdoc.Save(path);
        }

        static void Add()
        {
            Console.WriteLine("Введите данные автобуса, который нужно добавить");
            Console.Write("Номер: ");
            string number = Console.ReadLine();
            Console.Write("Дата прохождения то: ");
            string date = Console.ReadLine();
            Console.Write("Пункт назначения: ");
            string destination = Console.ReadLine();
            root.Add(new XElement("bus", new XAttribute("number", number), new XElement("date", date), new XElement("destination", destination)));
            xdoc.Save(path);
        }

        public class Bus
        {
            public string Number { get; set; }
            public string Date { get; set; }
            public string Destination { get; set; }
        }
    }
}
