using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            string[] fajok = new string[] { "keszeg", "busa", "harcsa", "ponty", "sügér" };
            List<Hal> L = new List<Hal>();
            for (int i = 0; i < 100; i++)
            {
                Hal p = new Hal();
                p.suly = rnd.Next(15, 250) / 10.0;
                p.ragadozo = (rnd.Next(1, 100) > 90);
                p.magas = rnd.Next(0, 11) * 10;
                p.melyseg = rnd.Next(5, 21) * 10;
                p.halfaj = fajok[rnd.Next(0, fajok.Length)];
                L.Add(p);
            }
            // ---
            int ragadozo_db = 0;
            foreach (Hal p in L)
            {
                if (p.ragadozo) ragadozo_db++;
            }
            Console.WriteLine("ragadozok={0} db, novenyevok={1} db", ragadozo_db, L.Count - ragadozo_db);
            // ---
            Hal m = L[0];
            foreach (Hal p in L)
                if (p.suly > m.suly) m = p;
            Console.WriteLine("legsulyosabb hal egy {1}, {0} kg", m.suly, m.halfaj);
            // ---
            int db = 0;
            foreach (Hal p in L)
                if (p.magas <= 110 && 110 <= p.magas + p.melyseg) db++;
            Console.WriteLine("Osszesen {0} db hal képes 110 cm mélységben úszni", db);
            // ---
            List<Hal> N = new List<Hal>(); // megevett novenyevok
            for (int i = 0; i < 100; i++)
            {
                int k = rnd.Next(L.Count);
                int l = rnd.Next(L.Count);
                if (k == l) continue;
                Hal p = L[k];
                Hal r = L[l];
                if (p.ragadozo == true && r.ragadozo == false) talanMegeszi(p, r, L, N);
                else if (p.ragadozo == false && r.ragadozo == true) talanMegeszi(r, p, L, N);
            }
            Console.WriteLine("osszesen {0} db novenyevot ettek meg", N.Count);
            double sum = 0;
            foreach (Hal p in N)
                sum += p.suly;
            Console.WriteLine("a megevett novenyevok osszsulya = {0} kg", sum);
            // --
            Console.Write("<Enter> a befejezéshez");
            Console.ReadLine();
        }
        //.......................................................................................................................
        static void talanMegeszi(Hal ragadozo, Hal novenyevo, List<Hal> elok, List<Hal> megettek)
        {
            bool megeszi = false;
            bool benne =
                 (ragadozo.magas <= novenyevo.magas && novenyevo.magas <= ragadozo.magas + ragadozo.melyseg)
                  ||
                 (novenyevo.magas <= ragadozo.magas && ragadozo.magas <= novenyevo.magas + novenyevo.melyseg);
            if (benne && rnd.Next(1, 100) < 30) megeszi = true;
            if (megeszi)
            {
                elok.Remove(novenyevo);
                megettek.Add(novenyevo);
                ragadozo.suly = ragadozo.suly + ragadozo.suly * 0.08; // 8% plusz
            }
        }
        //.......................................................................................................................
    }
}
