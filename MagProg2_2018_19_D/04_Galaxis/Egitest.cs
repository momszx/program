using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace _04_Galaxis
{
    class Egitest
    {
        private static string PrefixEgitest = "E-";        

        public Egitest(string Azonosito)
        {
            this.Azonosito = PrefixEgitest + Azonosito;
        }
        /// <summary>
        /// Az adott osztály legbővebb konstruktora
        /// </summary>
        /// <param name="Azonosito">Öt jegyű számokat tartalmazó szöveg</param>
        /// <param name="Nev">Lehet null, de ha nem, akkor legalább 2 karakter</param>
        /// <param name="Eletkor">Az életkor millió években értendő</param>
        public Egitest(string Azonosito,
            string Nev, ushort Eletkor)
            : this(Azonosito)
        {
            this.Nev = Nev;
            this.Eletkor = Eletkor;
        }

        private string azonosito;
        public string Azonosito
        {
            protected set
            {
                if (value != null && value.Length >= 5)
                    azonosito = value;
                else throw new Exception("Hibás azonosító!");
            }
            get
            {
                return azonosito;
            }
        }

        private string nev;
        public string Nev
        {
            set
            {
                if (value == null || value.Length >= 2)
                    nev = value;
                else throw new EgitestNevException(value);
            }
            get
            {
                return nev;
            }
        }

        private ushort eletkor;
        /// <summary>
        /// Az életkor millió években értendő
        /// </summary>
        public ushort Eletkor
        {
            set
            {
                if (value <= Beallitasok.Default.MaxEgitestEletkor)
                    eletkor = value;
                else throw new EgitestEletkorTulNagyException(value);
            }
            get
            {
                return eletkor;
            }
        }

        public virtual Egitest Clone()
        {
            Egitest e = 
                new Egitest(this.Azonosito.Split('-')[1]);
            e.Nev = this.Nev;
            e.Eletkor = this.Eletkor;
            return e;
        }

        public override string ToString()
        {
            string minta = "Azonosító: {0}\n" +
                "Név: {1}\n" +
                "Életkor: {2} millió év\n";
            return string.Format(minta,
                Azonosito,
                Nev == null ? "-" : Nev,
                Eletkor);
        }
    }
}
