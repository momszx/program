using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018.zh2
{
    class Program
    {
        public static Random rnd = new Random();
        public enum BolygoTipus
        {
            TŰZ,
            VÍZ,
            FÖLD
        }
        public class Bolygo 
        {
            public string Bolygómegnevezes;
            public BolygoTipus Bolygótipus;
            public int Bolygóatmero;
        }
        
        static void Main(string[] args)
        {
            List<Bolygo> kavicsok = new List<Bolygo>();
            kavicsok = BolygoGeneralasa(rnd.Next(1, 20), 10000, 30000);
            StatisztikaKeszitese(kavicsok, ConsoleColor.DarkRed);

            foreach (Bolygo d in kavicsok)
            {
                Console.WriteLine("{0} {1} {2}", d.Bolygómegnevezes, d.Bolygótipus, d.Bolygóatmero);
            }
            Console.WriteLine(NevGeneralasa("moxer", "xion"));

            Console.ReadLine();
        }
        public static List<Bolygo> BolygoGeneralasa(int n, int also, int felso) 
        {
            List<Bolygo> visszaList = new List<Bolygo>();
            for (int i = 0; i < n; i++)
            {
                Bolygo generalt = new Bolygo();
                generalt.Bolygómegnevezes = "Generált bolygó " + (i + 1);
                generalt.Bolygótipus = (BolygoTipus)rnd.Next(0, 3);
                generalt.Bolygóatmero = rnd.Next(also, felso + 1);
                visszaList.Add(generalt);
            }
            return visszaList;
        }
        public static BolygoTipus LegnagyobbBolygoTipus(List<Bolygo> inputList) 
        {
            int Sorban = 0;
            int maxAtmero = inputList[0].Bolygóatmero;
            for (int i = 1; i < inputList.Count; i++)
            {
                if (inputList[i].Bolygóatmero > maxAtmero)
                {
                    maxAtmero = inputList[i].Bolygóatmero;
                    Sorban = i;
                }
            }

            return inputList[Sorban].Bolygótipus;
        }

        public static int BolygoDarab(List<Bolygo> inputList, int also, int felso) 
        {
            int db = 0;
            foreach (Bolygo planet in inputList)
            {
                if (planet.Bolygóatmero >= also && planet.Bolygóatmero <= felso)
                {
                    db++;
                }
            }
            return db;
        }

        static void StatisztikaKeszitese(List<Bolygo> inputList, ConsoleColor ccl) 
        {
            Console.ForegroundColor = ccl;
            Console.WriteLine("A legnagyobb bolygó {0} típusú.", LegnagyobbBolygoTipus(inputList));
            Console.WriteLine("15000 és 20000 km átmérősűly bolygók száma {0}", BolygoDarab(inputList, 15000, 20000));
            Console.ResetColor();
        }

        public static string NevGeneralasa(string elso, string masodik) 
        {
            string nev = "";
            string szó2 = masodik[masodik.Length - 1].ToString();
            string szó1 = "";
            for (int i = (elso.Length - 1); i >= 0; i--)
            {
                szó1 += (elso[i].ToString());
            }

            nev = szó2.ToUpper() + szó1.ToLower() + masodik.Length + "B";
            return nev;
        }
    }
}