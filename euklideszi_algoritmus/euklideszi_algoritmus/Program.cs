using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace euklideszi_algoritmus
{
    class Tarolo
    {
        public int szam1;// kezdő szám 1
        public int szam2;// kezdő szám 2
        public int szam3;//hányszor
        public int szam4;//maradék

    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Tarolo> P = new List<Tarolo>();
            Console.WriteLine("Add meg az első számot");
            int a = Convert.ToInt32(Console.ReadLine());
            Tarolo L = new Tarolo();
            
            Console.Clear();
            Console.WriteLine("Add meg a második számot");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a < b)
            {
                L.szam1 = b;
                L.szam2 = a;
            }
            else
            {
                L.szam1 = a;
                L.szam2 = b;
            }

            
            L.szam3 = L.szam1 / L.szam2;
            L.szam4 = L.szam1 - (L.szam2 * L.szam3);
            P.Add(L);
            Console.Clear();
            
            
            int i = 0;
            
            bool seged = true;
            do
            {
                Tarolo C = new Tarolo();
                C.szam1 = P[i].szam2;
                C.szam2 = P[i].szam4;
                C.szam3 = C.szam1 / C.szam2;
                C.szam4 = C.szam1 % C.szam2;
                P.Add(C);
                i++;
                if (P[i].szam4 == 0)
                {
                    seged = false;
                }
                
            } while (seged);
            

            

            
            Console.WriteLine("A Legnagyobb közös osztolyuk "+P[i-1].szam4);

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
