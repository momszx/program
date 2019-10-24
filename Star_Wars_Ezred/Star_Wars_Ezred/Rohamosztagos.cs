using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star_Wars_Ezred
{
    class Rohamosztagos
    {
        private static Random rnd = new Random();
        private Rohamosztagos(uint Azonosito)
        {
            this.Azonosito = Azonosito;
            this.Kikepzesideje = (uint)Settings1.Default.KikepzesidejeMAx;
            this.Clon = rnd.NextDouble() < 3 / 5;
            if (Clon)
            {
                this.SugarvetoSzine = SugarvetoSzine.PIROS;
            }
            else
            {
                this.SugarvetoSzine = (SugarvetoSzine)(rnd.Next(0, 3));
            }
        }
        public Rohamosztagos(uint Azonosito,string Nev,uint Kikepzesideje):this(Azonosito)
        {
            this.Nev = Nev;
            this.Kikepzesideje = Kikepzesideje;
        }
        public Rohamosztagos(uint Azonosito, string Nev, uint Kikepzesideje,bool Clon, SugarvetoSzine sugarvetoSzine) 
        {
            this.Azonosito = Azonosito;
            this.Nev = Nev;
            this.Kikepzesideje = Kikepzesideje;
            this.Clon = Clon;
            this.SugarvetoSzine = Clon ? SugarvetoSzine.PIROS : SugarvetoSzine;
        }

        private uint azonosito;
        public uint Azonosito
        {
            private set
            {
                if (value >= Settings1.Default.AzonositoMin)
                {
                    azonosito = value;
                }
                else
                {
                    throw new Exception("Hibás Azonosító");
                }
            }
            get
            {
                return azonosito;
            }
        }

        private string nev;
        public string Nev
        {
            protected set
            {
                if (value == null)
                {
                    throw new Exception("A név nem lehet üres");
                }
                else if (value.Length < 6)
                {
                    throw new Exception("Hibás név hossz");
                }
                else
                {
                    nev = value;
                }
            }
            get
            {
                return nev;
            }
        }

        private uint kikepzesideje;
        public uint Kikepzesideje
        {
            set
            {
                if (kikepzesideje > value || value < Settings1.Default.KikepzesidejeMin || value > Settings1.Default.KikepzesidejeMAx)
                {
                    throw new Exception("Hibás kiképzési idő");
                }
                else
                {
                    kikepzesideje = value;
                }
            }
            get
            {
                return kikepzesideje;
            }
        }

        public SugarvetoSzine SugarvetoSzine { get; set; }

        private bool Beallitva = false;
        private bool clon;
        public bool Clon
        {
            set
            {
                if (!Beallitva)
                {
                    throw new Exception("Már nem lehet módositani");
                }
                else
                {
                    Beallitva = true;
                    clon = value;
                }
            }
            get
            {
                return clon;
            }
        }

        private string SugarvetoSzineFormat(SugarvetoSzine szin)
        {
            switch (szin)
            {
                case SugarvetoSzine.KEK:
                    return "Kék";
                case SugarvetoSzine.ZOLD:
                    return "Zöld";
                case SugarvetoSzine.PIROS:
                    return "Piros";
                default:
                    throw new Exception("Hiba");
            }
        }

        public override string ToString()
        {
            string minta = "Azonosító: {0}\nNév: {1}\nKikepzés ideje: {2}\nSugarvető szine: {3}\n{4}lon";
            return string.Format(minta, Azonosito,Nev,Kikepzesideje,SugarvetoSzineFormat(SugarvetoSzine),Clon?"K":"Nem K");
        }
    }
}
