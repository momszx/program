using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW_zh
{
    class Program
    {
        static JediRend jediRend;

        static void Main(string[] args)
        {
            jediRend = new JediRend();

            FileFeldolgozas("Jedik.csv");

            Console.WriteLine("A Jedi rend tagjai: ");
            foreach (var jedi in jediRend.jedik)
            {
                Console.WriteLine(jedi.nev);
            }

            Console.WriteLine("A Jedi Anakint közelítő mesterei: ");
            foreach (var jedi in jediRend.AnakintKozelitoMesterek)
            {
                Console.WriteLine(jedi.nev);
            }

            Console.ReadLine();
        }

        public static void FileFeldolgozas(string path)
        {
            string[] Jedik = File.ReadAllLines("Jedik.csv");
            string[] Elemek = null;
            foreach(string sor in Jedik)
            {
                Elemek = sor.Split(';');
                for (int i = 0; i < Elemek.Length; i++)
                {
                    JediMester UjMester = new JediMester(Elemek[0]);
                    if (0 > Convert.ToInt32(Elemek[1]))
                    {
                        UjMester.fenykardSzine = (Szin)0;
                    }
                    else if (Convert.ToInt32(Elemek[1]) > 3)
                    {
                        UjMester.fenykardSzine = (Szin)3;
                    }
                    else
                    {
                        UjMester.fenykardSzine = (Szin)Convert.ToInt32(Elemek[1]);
                    }
                    jediRend.AddJedi(UjMester);
                }
            }
        }
    }
}
