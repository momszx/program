using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ZH1_SW_Klon
{
    class Szarazfoldi : Rohamosztagos
    {
        public Szarazfoldi(uint Azonosito, string Nev, uint KikepzesIdeje)
            : this(Azonosito, Nev, KikepzesIdeje, SugarvetoSzine.PIROS, true)
        {
        }
        public Szarazfoldi(uint Azonosito, string Nev, uint KikepzesIdeje,
            SugarvetoSzine SugarvetoSzin, bool Klon)
            : base(Azonosito, Nev, KikepzesIdeje, SugarvetoSzin, Klon)
        {
            this.Nev = Beallitasok.Default.SzarazfoldiPrefix + " " + this.Nev;
        }
        public Szarazfoldi(uint Azonosito, string Nev, uint KikepzesIdeje,
            SugarvetoSzine SugarvetoSzin, bool Klon, bool Tiszt, Sisak Sisak,
            int TalatiPontossag)
            : this(Azonosito, Nev, KikepzesIdeje, SugarvetoSzin, Klon)
        {
            this.Tiszt = Tiszt;
            this.Sisak = Sisak;
            this.TalalatiPontossag = TalalatiPontossag;
        }


        private bool tiszt;
        public bool Tiszt
        {
            get
            {
                return tiszt;
            }
            set
            {
                if (Klon)
                    tiszt = false;
                else
                    if (!Tiszt)
                        tiszt = value;
            }
        }

        public Sisak Sisak { get; set; }

        private int talalatiPontossag;
        public int TalalatiPontossag
        {
            set
            {
                if (value >= Beallitasok.Default.TalalatiPontossagMin &&
                    value <= Beallitasok.Default.TalalatiPontossagMax)
                    talalatiPontossag = value;
                else
                    throw new Exception("Hibás érétk");
            }
            get
            {
                return talalatiPontossag;
            }
        }

        public void SisakCsere(Sisak Sisak)
        {
            if (!(this.Sisak == Sisak.EBREDOEROS &&
                    Sisak == Sisak.KLASSZIKUS))
                this.Sisak = Sisak;
        }

        private static string SisakFormat(Sisak Sisak)
        {
            switch (Sisak)
            {
                case Sisak.KLASSZIKUS:
                    return "Klasszikus";
                case Sisak.EBREDOEROS:
                    return "Ébredőerős";
                case Sisak.FELDERITO:
                    return "Felderítő";
                default:
                    throw new Exception("Új sisak.");
            }
        }

        public override string ToString()
        {
            string minta = "{0}iszt\n" +
                "Találati pontosság: {1}\n" +
                "Sisak: {2}\n";
            return base.ToString() +
                string.Format(minta,
                Tiszt ? "T" : "Nem t",
                SisakFormat(Sisak));
        }
    }
}
