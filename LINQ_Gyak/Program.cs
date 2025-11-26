using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Gyak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 5, 8, 12, 17, 20, 25, 30 };
            var words = new List<string> { "alma", "körte", "banán", "szilva", "eper", "kiwi" };

            var people = new List<Person>
            {
                new Person("Anna", 25, "Budapest"),
                new Person("Béla", 17, "Miskolc"),
                new Person("Csilla", 32, "Debrecen"),
                new Person("Dávid", 40, "Miskolc"),
                new Person("Eszter", 29, "Győr"),
                new Person("Ferenc", 17, "Budapest")
            };


            Console.WriteLine();

            // 1.
            Console.WriteLine();
            Console.WriteLine("1. Feladat. Az összes páros szám:");
            var paros = numbers.Where(x => x % 2 == 0);
            foreach (var x in paros) { Console.Write(x + ", "); }
            Console.WriteLine();

            // 2.
            Console.WriteLine();
            Console.WriteLine("2. Feladat. A 10-nél nagyobb számok:");
            var nagyobb10 = numbers.Where(x => x > 10);
            foreach (var x in nagyobb10) { Console.Write(x + ", "); }
            Console.WriteLine();

            // 3.
            Console.WriteLine();
            Console.WriteLine("3. Feladat. Több mint 4 karakter hosszú szavak:");
            var hosszabb4 = words.Where(x => x.Length > 4);
            foreach (var x in hosszabb4) { Console.Write(x + ", "); }
            Console.WriteLine();

            // 4.
            Console.WriteLine();
            Console.WriteLine("4. Feladat. Emberek, akik elmúltak 18 évesek:");
            var plusz18 = people.Where(x => x.Age > 18);
            foreach (var x in plusz18) { Console.WriteLine(x.Name + ", " + x.Age); }
            Console.WriteLine();

            // 5.
            Console.WriteLine("5. Feladat. A számok növekvő sorrendbe");
            var novekvo = numbers.OrderBy(x => x);
            foreach (var x in novekvo) { Console.Write(x + ", "); }
            Console.WriteLine();

            // 6.
            Console.WriteLine();
            Console.WriteLine("6. Feladat. A számok csökkenő sorrendbe");
            var csokkeno = numbers.OrderByDescending(x => x);
            foreach (var x in csokkeno) { Console.Write(x + ", "); };
            Console.WriteLine();

            Console.WriteLine();
        }

        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Address { get; set; }

            public Person(string name, int age, string address)
            {
                Name = name;
                Age = age;
                Address = address;
            }
        }

    }
}
    