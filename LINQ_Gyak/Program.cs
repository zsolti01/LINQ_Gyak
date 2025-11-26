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
            Console.WriteLine("5. Feladat. A számok növekvő sorrendbe:");
            var novekvo = numbers.OrderBy(x => x);
            foreach (var x in novekvo) { Console.Write(x + ", "); }
            Console.WriteLine();

            // 6.
            Console.WriteLine();
            Console.WriteLine("6. Feladat. A számok csökkenő sorrendbe:");
            var csokkeno = numbers.OrderByDescending(x => x);
            foreach (var x in csokkeno) { Console.Write(x + ", "); };
            Console.WriteLine();

            // 7.
            Console.WriteLine();
            Console.WriteLine("7. Feladat. Az emberek életkor szerint rendezve:");
            var eletkorSzerint = people.OrderBy(x => x.Age);
            foreach (var x in eletkorSzerint) { Console.WriteLine(x.Name + ", " + x.Age); };

            // 8.
            Console.WriteLine();
            Console.WriteLine("8. Feladat. A szavak abc sorrendbe, majd hossz szerint:");
            var abcSzavak = words.OrderBy(x => x);
            foreach (var x in abcSzavak) { Console.Write(x + ", "); }
            var hosszSzavak = words.OrderBy(x => x.Length);
            Console.WriteLine();
            foreach (var x in hosszSzavak) { Console.Write(x + ", "); }
            Console.WriteLine();

            // 9.
            Console.WriteLine();
            Console.WriteLine("9. Feladat. Minden szám a négyzetén:");
            var szavakNegyzete = numbers.Select(x => x * x);
            foreach (var x in szavakNegyzete) { Console.Write(x + ", "); }
            Console.WriteLine();

            // 10.
            Console.WriteLine();
            Console.WriteLine("10. Feladat. Nagybetűs szavak:");
            var nagybetus = words.Select(x => x.ToUpper());
            foreach (var x in nagybetus) { Console.Write(x + ", "); };
            Console.WriteLine();

            // 11.
            Console.WriteLine();
            Console.WriteLine("11. Feladat. Új lista csak a felhasználók neveivel:");
            var ujlista = people.Select(x => x.Name);
            foreach (var x in ujlista) { Console.Write(x + ", "); }
            Console.WriteLine();

            // 12.
            Console.WriteLine();
            Console.WriteLine("12. Feladat. Új lista csak a nevekkel és életkorokkal:");
            var ujlista2 = people.Select(x => new {x.Name, x.Age});
            foreach (var x in ujlista2) { Console.WriteLine(x.Name + ", " + x.Age); }
            Console.WriteLine();

            // 13.
            Console.WriteLine("13. Feladat. A számok összege:");
            var osszeg = numbers.Sum();
            Console.WriteLine(osszeg);
            Console.WriteLine();

            // 14.
            Console.WriteLine("14. Feladat. A legnagyobb szám:");
            var legnagyobb = numbers.Max();
            Console.WriteLine(legnagyobb);
            Console.WriteLine();

            // 15.
            Console.WriteLine("15. Feladat. Hány szó tartalmaz 'a' betűt:");
            var vanA = words.Where(x => x.Contains('a'));
            int db = vanA.Count();
            Console.WriteLine(db);
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
    