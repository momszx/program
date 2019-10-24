using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_LINQ
{
    //class Osztaly<T>
    //{
    //    public T Akarmi { get; set; }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            #region Kiterjesztő metódusok (Extension methods)
            List<int> lista01 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> lista02 = new List<int>() { 2, 4, 6, 8, 10 };
            List<int> lista03 = new List<int>() { 1, 3, 5, 7, 9 };

            lista01.WriteToConsole();
            lista02.WriteToConsole();
            lista03.WriteToConsole();
            Console.WriteLine("Az első lista legnagyobb száma: {0}", lista01.Max());

            //MyStaticMethods.WriteToConsole(lista01);
            //MyStaticMethods.WriteToConsole(lista02);
            //MyStaticMethods.WriteToConsole(lista03);

            Console.WriteLine("troll ede mátyás".AsName());
            Console.WriteLine("TROLL EDE MÁTYÁS".AsName());
            #endregion

            #region LINQ és Lambda kifejezések
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n------------------------------\n");

            List<Person> persons = new List<Person>();
            Person p1 = new Person { Id = 1, Name = "Attila", Age = 25, City = "Budapest", Job = "Devloper", Salary = 540000 }; persons.Add(p1);
            Person p2 = new Person { Id = 2, Name = "Gergő", Age = 26, City = "Miskolc", Job = "IT", Salary = 320000 }; persons.Add(p2);
            Person p3 = new Person { Id = 3, Name = "Szabolcs", Age = 28, City = "Üröm", Job = "Manager", Salary = 780000 }; persons.Add(p3);
            Person p4 = new Person { Id = 4, Name = "David", Age = 26, City = "Budapest", Job = "Trainer", Salary = 410000 }; persons.Add(p4);

            //Ha listaként szeretném megkapni az eredményt, akkor
            //kell a ToList(), mert eredetileg IQueryable vagy
            //IEnumerable az eredmény
            Console.WriteLine("Az összes adat:");
            List<Person> result = (from c in persons
                                   select c).ToList();
            result = persons.Select(c => c).ToList();
            result.WriteToConsole();

            Console.WriteLine("\nÖsszes munkahely: ");
            var jobs = from p in persons
                       select p.Job;
            jobs = persons.Select(p => p.Job);
            foreach (var job in jobs)
                Console.WriteLine(job);
            Console.ForegroundColor = ConsoleColor.Green;
            jobs.ToList().WriteToConsole();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nBudapestiek");
            var pestiek = persons.Where(p => p.City == "Budapest");
            pestiek.ToList().WriteToConsole();

            Console.WriteLine("\n26-nál fiatalabb, budapesti Devloper:");
            var result3 = persons.Where(p => p.Age < 26 &&
                p.City == "Budapest" && p.Job == "Devloper");
            result3 = persons.Where(p => p.Age < 26)
                             .Where(p => p.Job == "Devloper")
                             .Where(p => p.City == "Budapest");
            result3.ToList().WriteToConsole();

            Console.WriteLine("\nLegnagyobb fizetés: {0}",
                persons.Select(p => p.Salary).Max());
            Console.WriteLine("\nLegalacsonyabb fizetés: {0}",
                persons.Min(p => p.Salary));
            Console.WriteLine("\nA 28 évnél fiatalabb budapestiek átlagfizetése: {0}",
                persons.Where(p => p.City == "Budapest")
                       .Where(p => p.Age < 28)
                       .Average(p => p.Salary));
            #endregion

            Console.ReadLine();
        }
    }
}
