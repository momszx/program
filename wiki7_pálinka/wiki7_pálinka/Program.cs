using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wiki7_pálinka
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            List<Palinkak> P = new List<Palinkak>();
            string[] gyumolcsok = new string[] { "alma", "körte", "dió" ,"barack", "szilva"};
            for (int i = 0; i < 20; i++)
            {
                Palinkak L = new Palinkak();
                L.Alkoholfoka = (uint) rnd.Next(30, 87);
                L.Gyumolcs = gyumolcsok[rnd.Next(gyumolcsok.Length)];
                L.Mennyiseg = (uint)rnd.Next(50);
                L.Kesziteseve = DateTime.Now;
                L.Ar = (uint)rnd.Next(50, 1000);
                P.Add(L);
            }
            Console.WriteLine("Ösz pálinka {0}", sum(P));
            List<Palinkak> megitt = Megitt(P);
            uint megitt_ = 0;
            for (int i = 0; i < megitt.Count; i++)
            {
                megitt_ += megitt[i].Mennyiseg;
            }
            uint Megittar = megittar(megitt);


            Console.WriteLine("Az elfogyott pálinka {0} L és a bevétel {1} Ft " ,megitt_/10 , Megittar);
            Console.ReadLine();
        }
        static uint megittar(List<Palinkak> megitt)
        {
            uint megittar = 0;
            List<Palinkak> megitt_ = megitt;
            foreach (Palinkak item in megitt_)
            {
                megittar = item.Mennyiseg * item.Ar;
            }
            
            return megittar;

        }

        static List<Palinkak> Megitt (List<Palinkak> P) 
        {
            List<Palinkak> meglevo = P;
            List<Palinkak> elfogyott=new List<Palinkak>();
            int index = 0;
            for (int i = 0; i < 20; i++)
            {
                index = rnd.Next(meglevo.Count);
                meglevo[index].Mennyiseg = meglevo[index].Mennyiseg / 2;
                elfogyott.Add(meglevo[index]);
            }
            return elfogyott;

        }

        static uint sum (List<Palinkak> P)
        {
            uint sum = 0;
            foreach (Palinkak item in P)
            {
                sum += item.Mennyiseg;
            }

            return sum;
        }
    }
}
