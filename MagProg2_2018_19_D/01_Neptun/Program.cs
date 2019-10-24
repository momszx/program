using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Neptun
{    
    class Program
    {
        static List<Hallgato> Hallgatok = new List<Hallgato>();
        static bool Kilepes = false;

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("*** Neptun ***\n");
            Console.WriteLine("1 - Új hallgató regisztrálása");
            Console.WriteLine("2 - Hallgató módosítása");
            Console.WriteLine("3 - Hallgató törlése");
            Console.WriteLine("4 - Hallgatók listája");
            Console.WriteLine("Esc - Kilépés");
        }
        static void MenuKezeles()
        {
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    HallgatoRegisztralasa();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    break;
                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    HallgatokListaja();
                    break;
                case ConsoleKey.Escape:
                    Kilepes = true;
                    break;
                default:
                    break;
            }
        }

        static void HallgatoRegisztralasa()
        {
            Console.Clear();
            Console.WriteLine("*** Hallgató regisztrálása ***\n");

            Console.Write("Neptun kód: ");

            Hallgato hallgato = new Hallgato(Console.ReadLine());
            
            Console.Write("Név: ");
            hallgato.Nev = Console.ReadLine();            
            int ev, honap, nap;
            Console.WriteLine("Születési dátum: ");
            Console.Write("év: ");
            ev = int.Parse(Console.ReadLine());
            Console.Write("hónap: ");
            honap = int.Parse(Console.ReadLine());
            Console.Write("nap: ");
            nap = int.Parse(Console.ReadLine());
            hallgato.SzuletesiDatum = new DateTime(ev, honap, nap);
            Console.Write("Neme: ");
            hallgato.Nem = (NemiIdentitas)Enum.Parse(typeof(NemiIdentitas), Console.ReadLine(), true);
            Console.Write("Teljesített kreditek: ");
            hallgato.Kreditek = int.Parse(Console.ReadLine());
            
            Hallgatok.Add(hallgato);

            Console.WriteLine("\nSikeres mentés!");
            Console.ReadLine();
        }
        static void HallgatokListaja()
        {
            Console.Clear();
            Console.WriteLine("*** Hallgatók listája ***\n");
            foreach (Hallgato hallgato in Hallgatok)
            {
                //hallgato.Kiir();
                //Console.WriteLine(hallgato.DiakString());
                Console.WriteLine(hallgato);
            }

            Console.WriteLine("Nyomjon enter-t a folytatáshoz!");
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            //Tantargy MagProg2 = new Tantargy();
            //MagProg2.

            Hallgato h = new Hallgato("IKSI78");            
            h.Nev = "Troll Ede";
            //h.Neptunkod = "IKSI78";
            //h.Neptunkod = "IKSI78";
            h.SzuletesiDatum = new DateTime(1987, 5, 4);            
            //h.Eletkor = 32;
            h.Nem = NemiIdentitas.FERFI;
            h.Kreditek = 180;
            Hallgatok.Add(h);

            h = new Hallgato("XXX69X", new DateTime(1956, 10, 23));
            h.Nev = "Geda Gábor";
            //h.Neptunkod = "XXX69X";
            //h.SzuletesiDatum = new DateTime(1956, 10, 23);
            h.Nem = NemiIdentitas.FERFI;
            h.Kreditek = 179;
            Hallgatok.Add(h);

            h = new Hallgato("XX666X");
            h.Nev = "Keresztes Péter";
            //h.Neptunkod = "XX666X";
            h.SzuletesiDatum = new DateTime(1964, 4, 6);
            h.Nem = NemiIdentitas.FERFI;
            h.Kreditek = 180;
            Hallgatok.Add(h);

            do
            {
                Menu();
                MenuKezeles();
            } while (!Kilepes);
        }
    }
}
