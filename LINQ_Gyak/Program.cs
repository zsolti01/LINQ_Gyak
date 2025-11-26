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
            Console.WriteLine("1. Feladat. Az összes páros szám kiírása:");
            var paros = numbers.Where(x => x % 2 == 0);
            foreach (var x in paros) { Console.Write(x); }
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
    