using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace star_wars
{
    class Tanitvany : Erofelhasznalo
    {
        private int tincsh;
        public int Tincsh
        {
            set
            {
                if (!(value == 5 || value == 15 || value == 0))
                {
                    throw new Exception("Hibás tincs méret");
                }
                else
                {
                    tincsh = value;
                }
            }
            get
            {
                return tincsh;
            }
        }

        private int kepzetsegszint;
        public int Kepzetsegszint
        {
            set
            {
                if((value<0|| value > 100))
                {
                    throw new Exception("Hibás képzetsegi szint");
                }
                else
                {
                    kepzetsegszint = value;
                }
            }
            get
            {
                return kepzetsegszint;
            }
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

        public Tanitvany (int azonosito, string nev, uint midiklorianszam, bool oldal, Kardszin kardszine, int tincsh , int kepzetsegszint):base( azonosito,  "Ifjú"+nev,  midiklorianszam, oldal,  kardszine)
        {
            this.Tincsh = tincsh;
            this.Kepzetsegszint = kepzetsegszint;
            
        }
        public Tanitvany(int azonosito, string nev, uint midiklorianszam, bool oldal, Kardszin kardszine, int tincsh): this(azonosito, nev, midiklorianszam, oldal, kardszine, tincsh) { }

        public Tanitvany(int azonosito, string nev, uint midiklorianszam, bool oldal, Kardszin kardszine) : this(azonosito, nev, midiklorianszam, oldal, kardszine, 10) { }
        public override string ToString()
        {
            string minta = "\nTincs hossza: {0}\nKépzetségi szintje{1}";
            return base.ToString() +string.Format(minta, Tincsh,Kepzetsegszint);
        }
    }
}
