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
        static SithTorzs sithTorzs;

        static void Main(string[] args)
        {
            sithTorzs = new SithTorzs();

            FileFeldolgozas("Sithek.csv");

            Console.WriteLine("A Sith törzs tagjai: ");
            foreach (var sith in sithTorzs.sithek)
            {
                Console.WriteLine(sith.nev);
            }

            Console.WriteLine();
            Console.WriteLine("A Sith törzs Darth Plagueis-t meg sem közelítő mesterei: ");
            foreach (var sith in sithTorzs.PlagueistMegsemKozelitoMesterek)
            {
                Console.WriteLine(sith.nev + ": " + sith.midiklorian);
            }

            Console.ReadLine();
        }

        public static void FileFeldolgozas(string path)
        {
            string[] sithek = File.ReadAllLines("Sithek.csv");
            string[] Elemek = null;
            foreach (var sor in sithek)
            {
                Elemek = sor.Split(';');
                for (int i = 0; i < Elemek.Length; i++)
                {
                    SithNagyur UjSithNagyur = new SithNagyur(Elemek[0]);
                    if (2000 > Convert.ToInt32(Elemek[1]))
                    {
                        UjSithNagyur.midiklorian = 2000;
                    }
                    else if (21999 < Convert.ToInt32(Elemek[1]))
                    {
                        UjSithNagyur.midiklorian = 21999;
                    }
                    else
                    {
                        UjSithNagyur.midiklorian= Convert.ToInt32(Elemek[1]);
                    }
                    sithTorzs.AddSith(UjSithNagyur);

                }
            }
            
        }
    }
}
