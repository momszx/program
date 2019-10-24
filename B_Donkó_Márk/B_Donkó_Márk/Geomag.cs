using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Donkó_Márk
{
    class Geomag: Jatek
    {
        private Geomag(int Azonosito, Gyarto gyarto,string Keszletneve) : base(Azonosito, Gyarto.FORMATEX) { }
         
        public Geomag(int Azonosito, Gyarto gyarto, int Ar, int Minimumeletkor, string Keszletneve, int Elemszam, Mintazat mintazat) : base(Azonosito, Gyarto.FORMATEX, Ar, Minimumeletkor)
        {
            this.Keszletneve = Keszletneve;
            this.Elemszam = Elemszam;
            this.mintazat = mintazat;
        }

        private string keszletneve;
        public string Keszletneve
        {
            set
            {
                if(value==null|| value.Length < 4)
                {
                    throw new Exception("Hibas nev");
                }
                else
                {
                    keszletneve = value;
                }
            }
            get
            {
                return keszletneve;
            }
        }

        private int elemszam;
        public int Elemszam
        {
            set
            {
                if (value < 30 || value % 2 != 0)
                {
                    throw new Exception("Hibas elemszam");
                }
                else
                {
                    elemszam = value;
                }
            }
            get
            {
                return elemszam;
            }
        }

        public Mintazat mintazat { get; set; }
        private static string Mintazatformat(Mintazat mintazat)
        {
            switch (mintazat)
            {
                case Mintazat.GLITTER:
                    return "Glitter";
                case Mintazat.COLOR:
                    return "Color";
                case Mintazat.MECHANICS:
                    return "Mechanics";
                case Mintazat.GLOW:
                    return "Glow";
                default:
                    throw new Exception("Hiba");
            }
        }

        public override string ToString()
        {
            string minta = "\nKeszlet neve: {0}\nElemszám: {1}\nMintázat: {2}";
            return base.ToString() + string.Format(minta, Keszletneve, Elemszam, Mintazatformat(mintazat));
        }
    }
}
