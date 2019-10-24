using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Neptun_Kontener
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EKE\n");
            Egyetem EKE = new Egyetem();    

            //EKE.Hallgatok.Add(new Hallgato(1, "IKSI78"));
            EKE.AddHallgato("Troll Ede", new DateTime(1987,5,4));
            EKE.AddHallgato("Geda Gábor", new DateTime(1963, 10, 6));
            EKE.AddHallgato("Keresztes Péter", new DateTime(1975, 6, 3));            

            foreach (Hallgato hallgato in EKE.Hallgatok)
            {
                Console.WriteLine(hallgato.Id);
                Console.WriteLine(hallgato.Neptunkod);
                Console.WriteLine(hallgato.Nev);
                Console.WriteLine(hallgato.SzuletesiDatum.ToShortDateString());
                Console.WriteLine();
            }

            Console.WriteLine("\nSárospatak\n");
            Egyetem SP = new Egyetem();

            SP.AddHallgato("Kovács Géza", new DateTime(1976, 7, 3));
            SP.AddHallgato("Lakatos Bendegúz", new DateTime(1983, 11, 21));

            foreach (Hallgato hallgato in SP.Hallgatok)
            {
                Console.WriteLine(hallgato.Id);
                Console.WriteLine(hallgato.Neptunkod);
                Console.WriteLine(hallgato.Nev);
                Console.WriteLine(hallgato.SzuletesiDatum.ToShortDateString());
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
