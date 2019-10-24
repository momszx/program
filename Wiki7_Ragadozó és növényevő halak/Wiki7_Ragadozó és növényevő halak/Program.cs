using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiki7_Ragadozó_és_növényevő_halak
{
    class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            string[] HallFajta = new string[] { "keszeg", "busa", "harcsa", "ponty", "sügér" };
            List<Halak> L = new List<Halak>();
            for (int i = 0; i < 100; i++)
            {
                Halak p = new Halak();
                p.Weight = rnd.Next(15, 250) / 10.0;
                p.Predator = rnd.Next(1 , 100) > 90;
                p.Top = (uint)rnd.Next(0,11) * 10;
                p.Depth = (uint)rnd.Next(5, 21) * 10;
                p.Halfaj = HallFajta[rnd.Next(0, HallFajta.Length)];
                L.Add(p);
            }
            int predato_Count = 0;
            foreach (Halak p in L)
            {
                if (p.Predator)
                {
                    predato_Count++;
                }
            }
            Console.WriteLine("Ragadozó: {0} , nem az {1}" ,predato_Count,(L.Count-predato_Count));
            Halak m = L[0];
            foreach (Halak p in L)
            {
                if (p.Weight > m.Weight)
                {
                    m = p;
                }
            }
            Console.WriteLine("A legnehezebb hal súlya "+m.Weight+" fajtálya "+m.Halfaj);
            int count = 0;
            foreach  (Halak p in L)
            {
                if (p.Top <= 110 && 110 <= p.Top + p.Depth)
                {
                    count++;
                }
            }
            Console.WriteLine(count +" hal képes képes 110cm mélyégben úszni");
            List<Halak> N = new List<Halak>();
            for (int i = 0; i < 100; i++)
            {
                int k = rnd.Next(L.Count);
                int l = rnd.Next(L.Count);
                if (k == l) continue;
                Halak p = L[k];
                Halak r = L[l];
                if(p.Predator ==true&& r.Predator == false)
                {
                    talanMegeszi(p, r, L, N);
                }
                else if (p.Predator == false && r.Predator == true)
                {
                    talanMegeszi(r, p, L, N);
                }
            }
            Console.WriteLine("összesen {0} db növényevöt ettek meg", N.Count);
            double sum = 0;
            foreach (Halak p in N)
            {
                sum += p.Weight;
            }
            Console.WriteLine("megevett növény evők súlya " + sum);
            Console.ReadLine();


        }
        static void talanMegeszi(Halak ragadozo, Halak novenyevo, List<Halak> elok, List<Halak> megettek)
        {
            bool megeszi = false;
            bool benne =
                 (ragadozo.Top <= novenyevo.Top && novenyevo.Top <= ragadozo.Top + ragadozo.Depth)
                  ||
                 (novenyevo.Top <= ragadozo.Top && ragadozo.Top <= novenyevo.Top + novenyevo.Depth);
            if (benne && rnd.Next(1, 100) < 30) megeszi = true;
            if (megeszi)
            {
                elok.Remove(novenyevo);
                megettek.Add(novenyevo);
                ragadozo.Weight = ragadozo.Weight + ragadozo.Weight * 0.08; // 8% plusz
            }
        }
    }
}
