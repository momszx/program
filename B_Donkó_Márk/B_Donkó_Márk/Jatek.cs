using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Donkó_Márk
{
    class Jatek
    {
        protected Jatek(int Azonosito, Gyarto gyarto)
        {
            this.Azonosito = Azonosito;
            this.gyarto = gyarto;
        }
        public Jatek(int Azonosito, Gyarto gyarto, int Ar, int Minimumeletkor)
        {
            this.Azonosito = Azonosito;
            this.gyarto = gyarto;
            this.Ar = Ar;
            this.Minimumeletkor = Minimumeletkor;
        }

        private int azonosito;
        protected int Azonosito
        {
            set
            {
                if (value < Settings.Default.Azonosito)
                {
                    throw new Exception("Hibás azonositó");
                }
                else
                {
                    azonosito = value;
                }
            }
            get
            {
                return azonosito;
            }
        }

        public Gyarto gyarto { get; set; }
        private static string Gyartoformat(Gyarto gyarto)
        {
            switch (gyarto)
            {
                case Gyarto.LEGO:
                    return "Lego";
                case Gyarto.MATTEL:
                    return "Mattel";
                case Gyarto.FORMATEX:
                    return "Formatex";
                case Gyarto.HASBRO:
                    return "Hasbro";
                case Gyarto.FISCHERPRICE:
                    return "Fischerprice";
                default:
                    throw new Exception("Hiba");
            }
        }

        private int ar;
        public int Ar
        {
            set
            {
                if (value < 0)
                {
                    throw new Exception("Az ár nem lehet nullánál kissebb");
                }
                if (ar == 0)
                {
                    ar = value;
                }
                else if (value > (ar * Settings.Default.Arcsokentesmax) || value < (ar * Settings.Default.Arnovelesmax))
                {
                    ar = value;
                }
                else
                {
                    throw new Exception("Hibas ar modositas");
                }
            }
            get
            {
                return ar;
            }
        }

        private int minimumeletkor;
        public int Minimumeletkor
        {
            set
            {
                if (value >= 0)
                {
                    minimumeletkor = value;
                }
                else
                {
                    throw new Exception("Hibas eletkor");
                }
            }
            get
            {
                return minimumeletkor;
            }
        }

        public override string ToString()
        {

            string minta = "Azonosito: {1}\nGyártó: {2}\nÁr: {3}\nMinimum ajanlot életkor: {4}";
            return string.Format(minta, Azonosito, Gyartoformat(gyarto), Ar, Minimumeletkor);
        }

    }
}
