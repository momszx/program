using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace _04_Galaxis
{
    class Bolygo : Egitest
    {
        public Bolygo(string Azonosito)
            : this(Azonosito, null, 0)
        {
        }
        public Bolygo(string Azonosito, string Nev, ushort Eletkor)
            : base(Azonosito, Nev, Eletkor)
        {
            this.Azonosito += "-B";
            this.KeringesiTavolsag = 0.37f;
            this.Osztaly = BolygoOsztaly.GAZ;
        }
        public Bolygo(string Azonosito, string Nev, ushort Eletkor,
            BolygoOsztaly Osztaly, float KeringesiTavolsag)
            : this(Azonosito, Nev, Eletkor)
        {
            this.Osztaly = Osztaly;
            this.KeringesiTavolsag = KeringesiTavolsag;
        }

        public BolygoOsztaly Osztaly { get; set; }
        public static string BolygoOsztalyFormat(BolygoOsztaly Osztaly)
        {
            switch (Osztaly)
            {
                case BolygoOsztaly.GAZ:
                    return "Gázbolygó";
                case BolygoOsztaly.TORPE:
                    return "Törpebolygó";
                case BolygoOsztaly.KOZET:
                    return "Kőzetbolygó";
                case BolygoOsztaly.EXO:
                    return "Exobolygó";
                default:
                    throw new Exception("Utólag definiált bolygóosztály!");
            }
        }

        private float keringesiTavolsag;
        /// <summary>
        /// A keringési távolságot CsE-ben mérjük!
        /// </summary>
        public float KeringesiTavolsag
        {
            set
            {
                if (value >= 0.37 && value <= 30.07)
                    keringesiTavolsag = value;
                else throw new BolygoKeringesiTavolsagException(value);
            }
            get
            {
                return keringesiTavolsag;
            }
        }

        public bool Foldszeru
        {
            get
            {
                if (this.keringesiTavolsag >= 0.9 &&
                    this.keringesiTavolsag <= 1.1)
                    return true;
                return false;
            }
        }

        public override Egitest Clone()
        {
            //Bolygo bolygo = new Bolygo(this.Azonosito.Split('-')[1]);
            //bolygo.Nev = this.Nev;
            //bolygo.Eletkor = this.Eletkor;
            //bolygo.Osztaly = this.Osztaly;
            //bolygo.KeringesiTavolsag = this.KeringesiTavolsag;
            //return bolygo;
            return (Bolygo)this.MemberwiseClone();
        }

        public override string ToString()
        {
            string minta = "Osztály: {0}\n" +
                "Keringési távolság: {1} CsE\n";
            return base.ToString() +
                string.Format(minta,
                BolygoOsztalyFormat(Osztaly),
                KeringesiTavolsag);
        }
    }
}
