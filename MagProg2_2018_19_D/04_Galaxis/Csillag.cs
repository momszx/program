using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace _04_Galaxis
{
    class Csillag : Egitest
    {
        #region Statikus mezők és konstansok
        private static string SuffixCsillag = "-CS";
        #endregion

        #region Konstruktorok
        public Csillag(string Azonosito)
            : this(Azonosito, null, 0)
        {
        }
        public Csillag(string Azonosito, string Nev, ushort Eletkor)
            : base(Azonosito, Nev, Eletkor)
        {
            this.Azonosito += SuffixCsillag;
            this.Osztaly = CsillagOsztaly.NEUTRON;
        }
        public Csillag(string Azonosito, string Nev, ushort Eletkor,
            CsillagOsztaly Osztaly, float Atmero)
            : this(Azonosito, Nev, Eletkor)
        {
            this.Osztaly = Osztaly;
            this.Atmero = Atmero;
        }
        #endregion

        #region Mezők és property-k
        public CsillagOsztaly Osztaly { get; set; }

        private float atmero;
        /// <summary>
        /// A csillagok átmérőjét Napátmérőben kell megadni!
        /// </summary>
        public float Atmero
        {
            set
            {
                if (value >= Beallitasok.Default.MinCsillagAtmero && 
                    value <= Beallitasok.Default.MaxCsillagAtmero)
                    atmero = value;
                else throw new Exception("Hibás átmérő!");
            }
            get
            {
                return atmero;
            }
        }
        #endregion

        #region Metódusok és függvények
        public bool Hasonlo(Csillag masik)
        {
            float elteresMax = 
                (Beallitasok.Default.MaxCsillagAtmero-
                Beallitasok.Default.MinCsillagAtmero) * 0.1f;
            if (this.Osztaly == masik.Osztaly &&
                Math.Abs(this.Atmero - masik.Atmero) <= elteresMax)
                return true;
            return false;
        }

        public override Egitest Clone()
        {
            Csillag cs =
                new Csillag(this.Azonosito.Split('-')[1]);
            cs.Nev = this.Nev;
            cs.Eletkor = this.Eletkor;
            cs.Osztaly = this.Osztaly;
            cs.Atmero = this.Atmero;
            return cs;
        }
        #endregion

        #region Megjelenítés
        private static string CsillagOsztalyFormat(CsillagOsztaly Osztaly)
        {
            switch (Osztaly)
            {
                case CsillagOsztaly.VOROSORIAS:
                    return "Vörös óriás";
                case CsillagOsztaly.BARNATORPE:
                    return "Barna törpe";
                case CsillagOsztaly.NEUTRON:
                    return "Neutroncsillag";
                case CsillagOsztaly.HALAL:
                    return "Halálcsillag";
                case CsillagOsztaly.HALAL2:
                    return "Második Halálcsillag";
                case CsillagOsztaly.FEHERORIAS:
                    return "Fehér Óriás";
                default:
                    throw new Exception("Valami nem oké!");
            }
        }
        public override string ToString()
        {
            string minta = "Osztály: {0}\n" +
                "Átmérő: {1} NE\n";
            return base.ToString() +
                string.Format(minta,
                Csillag.CsillagOsztalyFormat(Osztaly),
                Atmero);
        }
        #endregion
    }
}
