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
        public Hallgato(string Neptunkod):this()
        {
            
            this.Neptunkod = Neptunkod;
        }
        public Hallgato(string Neptunkod,DateTime SzuletesiDatum)
            :this(Neptunkod)
        {
            
            this.SzuleresiDatum = SzuletesiDatum;
        }
        private bool NeptunkodMegadva = false;
        private string neptunkod;
        public string Nev;
        private DateTime szuletesiDatum;
        private NemiIdentitas nem;
        private int kreditek;

        public int Kreditek
        {
            set
            {
                if (value >= 0 && value<= 180)
                {
                    kreditek = value;
                }
                else throw new Exception("Hiba: A kreditek értéke 0 és 180 közötti egész lehet !"+"\nA hibás input:"+value);
                
            }
            get
            {
                return kreditek;
            }
        }

        public string Neptunkod
        {
            private set
            {
                if (NeptunkodMegadva)
                    throw new Exception("A neptunkód már meg van adva!");
                if (value.Length != 6)
                    throw new Exception("A neptunkód hossza a 6 karakter!");
                neptunkod = value;
                NeptunkodMegadva = true;
            }
            get
            {
                return neptunkod;
            }
        }

        public NemiIdentitas Nem { set; get; }

        public DateTime SzuleresiDatum
        {
            set
            {
                if ((DateTime.Now - value).TotalDays / 365 >= 17)
                {
                    szuletesiDatum = value;
                }
                else throw new Exception("Hiba: A Diákok minimális életkora 17");
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
                return (int)(DateTime.Now - SzuleresiDatum).TotalDays / 365;
            }
        }
        
        public void Kiir()
        {
        
                Console.WriteLine("Név: {0}", Nev);
                Console.WriteLine("Neptun Kód: {0}", Neptunkod);
                Console.WriteLine("Születési datum: {0}", szuletesiDatum.ToString("yyyy.MM.dd"));
                Console.WriteLine("teljesített kreditek: {0}", Kreditek);
                Console.ReadLine();
            
        }

        public string DiakString()
        {
            return string.Format("Nev: {0}\n" + "Neptun Kód: {1}\n" + "Születési datum: {2}\n" + "teljesített kreditek: {3}",Nev,Neptunkod,szuletesiDatum.ToString("yyy.MM.dd"),Kreditek);

        }

        public override string ToString()
        {
            return string.Format("Nev: {0}\n" + "Neptun Kód: {1}\n" + "Életkor: {2}\n" + "Születési datum:{3}\n" + "teljesített kreditek: {4}", Nev, Neptunkod,Eletkor , szuletesiDatum.ToString("yyy.MM.dd"), Kreditek);
        }
    }
}
