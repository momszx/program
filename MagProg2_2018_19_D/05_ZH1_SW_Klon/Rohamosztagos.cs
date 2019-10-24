using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ZH1_SW_Klon
{
    class Rohamosztagos
    {
        private static Random rnd = new Random();

        #region Konstruktorok
        private Rohamosztagos(uint Azonosito)
        {
            this.Azonosito = Azonosito;
            this.KikepzesIdeje = (uint)Beallitasok.Default.KikepzesIdejeMax;
            this.Klon = rnd.NextDouble() < 3d / 5;
            if (Klon)
                this.SugarvetoSzin = SugarvetoSzine.PIROS;
            else this.SugarvetoSzin = (SugarvetoSzine)rnd.Next(0, 3);
        }
        public Rohamosztagos(uint Azonosito, string Nev, uint KikepzesIdeje)
            : this(Azonosito)
        {
            this.Nev = Nev;
            this.KikepzesIdeje = KikepzesIdeje;
        }
        public Rohamosztagos(uint Azonosito, string Nev, uint KikepzesIdeje,
            SugarvetoSzine SugarvetoSzin, bool Klon)
        {
            this.Azonosito = Azonosito;
            this.Nev = Nev;
            this.KikepzesIdeje = KikepzesIdeje;
            this.Klon = Klon;
            this.SugarvetoSzin = Klon ? SugarvetoSzine.PIROS : SugarvetoSzin;
        }
        #endregion

        #region Mezők és property-k
        private uint azonosito;
        public uint Azonosito
        {
            private set
            {
                if (value >= Beallitasok.Default.AzonositoMin)
                    azonosito = value;
                else
                    throw new Exception("Hibás azonosító!");
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
                    throw new Exception("A név nem lehet null");
                if (value.Length < Beallitasok.Default.NevHossz)
                    throw new Exception("A név legalább 6 karakter hosszú");
                nev = value;
            }
            get
            {
                return nev;
            }
        }

        private uint kikepzesIdeje;
        public uint KikepzesIdeje
        {
            set
            {
                if (value >= Beallitasok.Default.KikepzesIdejeMin
                    && value <= Beallitasok.Default.KikepzesIdejeMax
                    && kikepzesIdeje >= value)
                    kikepzesIdeje = value;
                else throw new Exception("Hiba!");
            }
            get { return kikepzesIdeje; }
        }

        private bool klonbeallitva = false;
        private bool klon;
        public bool Klon
        {
            private set
            {
                if (!klonbeallitva)
                    klon = value;
                else
                    throw new Exception("Hiba: A klón értéke nem változhat.");
            }
            get
            {
                return klon;
            }
        }

        public SugarvetoSzine SugarvetoSzin { get; set; }
        #endregion

        #region Megjelenítés
        private string SugarvetoSzinFormat(SugarvetoSzine szin)
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
                    throw new Exception("Utólag megadott szín");
            }
        }
        public override string ToString()
        {
            string minta = "Azonosító: {0}\n" +
                        "Név: {1}\n" +
                        "{2}lón\n" +
                        "Sugárvető színe: {3}\n";
            return string.Format(minta,
                Azonosito,
                Nev,
                Klon ? "K" : "Nem k",
                SugarvetoSzinFormat(SugarvetoSzin));
        }
        #endregion
    }
}
