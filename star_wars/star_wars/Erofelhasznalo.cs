using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace star_wars
{
    class Erofelhasznalo
    {
        private int azonosito;
        public int Azonosito
        {
            private set
            {
                if (0 < value)
                {
                    azonosito = value;
                }
                else throw new Exception("Hibás Azonosító");
            }
            get
            {
                return azonosito;
            }
        }

        private string nev;
        public string Nev
        {
           private set
            {
                if (!(value == null || value.Length > 3))
                {
                    throw new Exception("Hibás név formátum ");
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

        private uint midiklorianszam;
        public uint Midikolrianszam
        {
            set
            {
                if((value<=5000 || value > 70000))
                {
                    throw new Exception("Hibás érték");
                }
                else
                {
                    midiklorianszam = value;
                }
            }
            get
            {
                return  midiklorianszam;
            }
        }

        private bool oldalvalasztva = false;
        private bool oldal;
        public bool Oldal
        {
            set
            {
                if (!oldalvalasztva)
                {
                    oldal = value;
                    oldalvalasztva = true;
                }
                else
                {
                    throw new Exception("Oldal már nem módosítható");
                }
            }
            get
            {
                return oldal;
            }
        }

        
        public Kardszin Kardszine
        {
            set;
            get;
        }
        private static string KardszineFormat(Kardszin Kardszine)
        {
            switch (Kardszine)
            {
                case Kardszin.FEHER:
                    return "Fehér";
                case Kardszin.KEK:
                    return "Kék";
                case Kardszin.ZOLD:
                    return "Zöld";
                case Kardszin.SARGA:
                    return "Sarga";
                case Kardszin.LILA:
                    return "Lila";
                case Kardszin.PIROS:
                    return "Piros";
                default:
                    throw new Exception("Ilyan kard szín nem létezhet");
            }

        }

        

        public Erofelhasznalo(int azonosito, string nev, uint midiklorianszam, bool oldal, Kardszin kardszine)
        {
            this.Azonosito = azonosito;
            this.Nev = nev;
            this.Midikolrianszam = midiklorianszam;
            this.Oldal = oldal;
            this.Kardszine = this.Oldal ? kardszine:Kardszin.PIROS;
        }
        public Erofelhasznalo(int azonosito, string nev, uint midiklorianszam)
        {
            this.Azonosito = azonosito;
            this.Nev = nev;
            this.Midikolrianszam = midiklorianszam;
        }
        private Erofelhasznalo(int azonosito, string nev) : this(azonosito, nev, 5000, false, Kardszin.PIROS) { }

        public override string ToString()
        {
            string minta = "Azonosító: {0}\nNeve: {1}\nMidiklorianok száma: {2}\n{3}oldal használó \nKardszíne: {4} ";
            return string.Format(minta, Azonosito, Nev, Midikolrianszam, Oldal ? "Vilagos" : "Sötét", KardszineFormat(Kardszine));
        }



    }
}
