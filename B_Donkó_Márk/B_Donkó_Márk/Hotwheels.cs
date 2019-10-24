using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Donkó_Márk
{
    class Hotwheels:Jatek
    {
        public Hotwheels(int Azonosito, Gyarto gyarto, int Ar, int Minimumeletkor, string Keszletneve, bool Csakauto, bool Csakpalya, Eroforras eroforras) : base(Azonosito, Gyarto.MATTEL, Ar, Minimumeletkor)
        {
            this.Keszletneve = Keszletneve;
            this.Csakauto = Csakauto;
            this.Csakpalya = Csakpalya;
            this.eroforras = eroforras;
        }

        private string keszletneve;
        public string Keszletneve
        {
            set
            {
                if (value == null || value.Length < 4)
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

        private static bool seged = false;
        private bool csakauto;
        public bool Csakauto
        {
            set
            {
                csakauto = value;
                if (value)
                {
                    seged = value;
                }
            }
            get
            {
                return csakauto;
            }
        }

        private bool csakpalya;
        public bool Csakpalya
        {
            set
            {
                if (value = true && seged)
                {
                    Csakauto = false;
                    csakpalya = false;
                }
            }
            get
            {
                return csakpalya;
            }
        }

        public Eroforras eroforras { get; set; }
        private static string Eroforrasformat (Eroforras eroforras)
        {
            switch (eroforras)
            {
                case Eroforras.KONEKTOR:
                    return "Konektor";
                case Eroforras.ELEM:
                    return "Elem";
                case Eroforras.BEFOTTESGUMI:
                    return "Befottesgumi";
                case Eroforras.KEZI:
                    return "Kezi";
                default:
                    throw new Exception("Hiba");
            }
        }

        public override string ToString()
        {
            string minta = "\nKeszlet neve: {0}\nAuto:: {1}\nPálya {2}\nEroforras: {3}";
            return base.ToString() + string.Format(minta, Keszletneve, Csakauto, Csakpalya, Eroforrasformat(eroforras));
        }
    }
}
