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
            Console.WriteLine("1-új halgató regisztálása");
            Console.WriteLine("2-Halgató módosítása");
            Console.WriteLine("3-Halgato törlése");
            Console.WriteLine("4-Halgatók listázása");
            Console.WriteLine("Esc - kilépés");
        }
        static void MenuKezelese()
        {
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    HallgatokRegisztralasa();
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


            }
        }
        static void HallgatokListaja()
        {
            Console.WriteLine("*** Halgatók Listálya ***");
            foreach (Hallgato hallgato in Hallgatok)
            {

                Console.WriteLine(hallgato);
                Console.ReadLine();
            }
        }
        static void HallgatokRegisztralasa()
        {
            Console.Clear();
            Console.WriteLine("*** Halgatók regisztralása ***\n");
            Console.WriteLine("Neptun kód:");
            
            Hallgato hallgato = new Hallgato(Console.ReadLine());
            Console.WriteLine("Név:");
            hallgato.Nev = Console.ReadLine();
            
            int ev, honap, nap;
            Console.WriteLine("Születési datum");
            Console.WriteLine("Év:");
            ev = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Honap:");
            honap = int.Parse(Console.ReadLine());
            Console.WriteLine("Nap:");
            nap = int.Parse(Console.ReadLine());
            hallgato.SzuleresiDatum = new DateTime(ev, honap, nap);
            Console.WriteLine("Neme: ");
            hallgato.Nem = (NemiIdentitas)Enum.Parse(typeof(NemiIdentitas), Console.ReadLine(), true);
            Console.WriteLine("Teljesített Kreditek:");
            hallgato.Kreditek = int.Parse(Console.ReadLine());
            Hallgatok.Add(hallgato);
            Console.WriteLine("\nSikeres mentés!");
            Console.ReadLine();

        }



        static void Main(string[] args)
        {
            //Hallgato H1 = new Hallgato();
            //H1.Neptunkod = "IKSI78";
            //H1.Nev = "Troll Ede";
            //H1.szuletesiDatum = new DateTime(1987, 5, 4);
            //H1.Nem = NemiIdentitas.FERFI;
            //H1.Kreditek = 180;

            //Hallgato H2 = new Hallgato();
            //H2.Neptunkod = "GVLNGW";
            //H2.Nev = "Donkó Márk";
            //H2.szuletesiDatum = new DateTime(1999, 7, 16);
            //H2.Nem = NemiIdentitas.FERFI;
            //H2.Kreditek = 22;
            Hallgato h = new Hallgato("asd000", new DateTime(1999, 07, 16));
            h.Nev = "Béla";
            //h.Neptunkod = "asd000";
            //h.SzuleresiDatum = new DateTime(1999, 07, 16);
           
            h.Nem = NemiIdentitas.FERFI;
            
            h.Kreditek = 10;
            Hallgatok.Add(h);
            
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            
            do
            {
                Menu();
                MenuKezelese();
                    
            } while (!Kilepes);

        }
    }
}
