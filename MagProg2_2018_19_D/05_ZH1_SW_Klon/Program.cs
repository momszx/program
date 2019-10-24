using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ZH1_SW_Klon
{
    class Program
    {
        static void Main(string[] args)
        {
            Ezred Sasok = new Ezred(false);

            //Adatok feltöltése véletlen értékekkel

            Console.WriteLine("Az ezredben {0} tiszt van.",
                Sasok.TisztekSzama);

            List<Pilota> ATATVezetok = Sasok.PilotakAdottJarmuvel(Jarmu.ATAT);
            Pilota LegkevesebbBalesetes = ATATVezetok.FirstOrDefault();
            foreach (Pilota p in ATATVezetok)
            {
                if (p.BalesetekSzama < LegkevesebbBalesetes.BalesetekSzama)
                    LegkevesebbBalesetes = p;
            }
            Console.WriteLine(LegkevesebbBalesetes);

            Console.ReadLine();
        }
    }
}
