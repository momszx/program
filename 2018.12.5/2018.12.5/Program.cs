using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018._12._5
{
    class Program
    {//Óra első része: Referencia VS érték típusok. Szövegkezelés
        static int nagyobb(int a, int b)
        {
            if (a > b) return a;
            else return b;
        }

        static void Kiir(string[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i].Length == 5) return;

                Console.WriteLine(tomb[i]);
            }
        }

        static void Kiir(int a)
        {
            return;
            Console.WriteLine(a);
            Console.WriteLine();
        }

        static void Novel(ref int a)
        {
            a += 1;
            Console.WriteLine("Az eljárásban az érték: " + a);
        }

        static void Feltolt(int[] tomb)
        {
            Random rnd = new Random();
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.Next(101);
            }
        }

        static string Reverse(string szoveg)
        {
            string atmeneti = "";
            for (int i = szoveg.Length - 1; i >= 0; i--)
            {
                atmeneti += szoveg[i];
            }
            return atmeneti;
        }

        //Feladat:
        //Függvény, aminek a visszatérési értéke szöveg
        //Paraméterben kap 2 szöveget
        //A visszatérési értéket úgy állítja elő:
        //->Leírja a második szöveg karaktereinek számát
        //Hozzáfűzi az első szöveg megfordítottját
        //Hozzáfűzi a második szöveget csupa nagybetűvel
        //Hozzáfűz egy X-et
        static string valami(string a, string b)
        {
            string visszaad = "";

            visszaad += b.Length;

            for (int i = a.Length - 1; i >= 0; i++)
            {
                visszaad += a[i];
            }

            visszaad += b.ToUpper();

            visszaad += "X";

            return visszaad;
        }

        static void Main(string[] args)
        {
            int a = 5;
            Novel(ref a);
            Console.WriteLine("A fõprogramban az érték: " + a);

            Console.WriteLine(Reverse("almafa"));

            int[] tomb = new int[50];
            Feltolt(tomb);

            string szoveg = "MÁRK";
            szoveg = szoveg.ToLower();

            char kicsi = 'a';
            string nagy = kicsi.ToString().ToUpper();

            Console.WriteLine(szoveg);
            Console.ReadLine();
        }

        //Óra második része (Közös függvények írása
        public class Cipo
        {
            public int ar;
            public SZIN szin;
            public int meret;
        }

        public enum SZIN
        {
            FEHER,
            FEKETE,
            SZURKE
        }

        static List<Cipo> CipokGeneralasa(int n)
        {
            Random rnd = new Random();
            List<Cipo> cipok = new List<Cipo>();

            for (int i = 0; i < n; i++)
            {
                Cipo c = new Cipo();
                c.ar = rnd.Next(5000, 50000);
                c.szin = (SZIN)rnd.Next(3);
                c.meret = rnd.Next(30, 40);
                //c.szin = (SZIN)(3);
                cipok.Add(c);
            }

            return cipok;
        }

        static Cipo legnagyobbCipo(List<Cipo> cipok)
        {
            Cipo legnagyobb = cipok[0];
            for (int i = 1; i < cipok.Count; i++)
            {
                if (legnagyobb.meret < cipok[i].meret) legnagyobb = cipok[i];
            }

            return legnagyobb;
        }

        //static SZIN legdragabbCipoSzinE(List<Cipo> cipok)
        //{
        //    int maxI = 0;
        //    for (int i = 1; i < cipok.Count; i++)
        //    {
        //        if (cipok[maxI].ar < cipok[i].ar) maxI = i;
        //    }

        //    return cipok[maxI].szin;
        //}

        static SZIN legdragabbCipoSzinE(List<Cipo> cipok)
        {
            Cipo maxCipo = cipok[0];
            for (int i = 1; i < cipok.Count; i++)
            {
                if (maxCipo.ar < cipok[i].ar) maxCipo = cipok[i];
            }

            return maxCipo.szin;
        }
        
    }
}
