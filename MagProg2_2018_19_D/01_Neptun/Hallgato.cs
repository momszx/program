using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Neptun
{
    class Hallgato
    {
        private Hallgato()
        {
            this.Kreditek = 0;
        }
        public Hallgato(string Neptunkod) 
        {            
            this.Neptunkod = Neptunkod;
        }
        public Hallgato(string Neptunkod, DateTime SzuletesiDatum)
            : this(Neptunkod)
        {            
            this.SzuletesiDatum = SzuletesiDatum;
        }

        private bool neptunkodMegadva = false;
        private string neptunkod;
        public string Neptunkod
        {
            private set
            {
                if (neptunkodMegadva)
                    throw new Exception("A neptunkód már megvan adva!");
                if (value.Length != 6)
                    throw new Exception("A neptunkód hossza 6 karakter!");

                neptunkod = value;
                neptunkodMegadva = true;
            }
            get
            {
                return neptunkod;
            }
        }

        public string Nev;

        private DateTime szuletesiDatum;
        public DateTime SzuletesiDatum
        {
            set
            {
                if ((DateTime.Now - value).TotalDays / 365 >= 17)
                    szuletesiDatum = value;
                else throw new Exception("Hiba: A diákok minimális életkora 17 év!");
            }
            get
            {
                return szuletesiDatum;
            }
        }

        public int Eletkor
        {
            get
            {
                return (int)((DateTime.Now - SzuletesiDatum).TotalDays / 365);
            }
        }

        public NemiIdentitas Nem { set; get; }

        private int kreditek;
        public int Kreditek
        {
            set
            {
                if (value >= 0 && value <= 180)
                    kreditek = value;
                else throw new Exception("Hiba: A kreditek értéke csak 0 és 180 közötti egész lehet!"+
                                         "\nA hibás input: " + value);
            }
            get
            {
                return kreditek;
            }
        }

        public void Kiir()
        {
            Console.WriteLine("Név: {0}", Nev);
            Console.WriteLine("Neptun kód: {0}", Neptunkod);
            Console.WriteLine("Születési dátum: {0}",
                SzuletesiDatum.ToString("yyyy.MM.dd"));
            Console.WriteLine("Teljesített kreditek: {0}", Kreditek);
            Console.WriteLine();
        }
        public string DiakString()
        {
            return string.Format("Név: {0}\n" +
                "Neptun kód: {1}\n" +
                "Születési dátum: {2}\n" +
                "Teljesített kreditek: {3}\n",
                Nev,
                Neptunkod,
                SzuletesiDatum.ToString("yyyy.MM.dd"),
                Kreditek);
        }
        public override string ToString()
        {
            return string.Format("Név: {0}\n" +
                "Neptun kód: {1}\n" +
                "Születési dátum: {2}\n" +
                "Életkor: {3}\n" +
                "Teljesített kreditek: {4}\n",
                Nev,
                Neptunkod,
                SzuletesiDatum.ToString("yyyy.MM.dd"),
                Eletkor,
                Kreditek);
        }
    }
}
