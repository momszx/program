using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW_zh
{
    
    abstract class AErohasznalo : IErohasznalo
    {
        Random rnd = new Random();
        public AErohasznalo(string nev,bool jedi)
        {
            this.nev = nev;
            this.jedi = jedi;
            this.midiklorianok = rnd.Next(2000, 22000);
        }

        private string Nev;
        public string nev
        {
            set
            {
                if(value==null|| value.Length < 3)
                {
                    throw new Exception("Hibás név hossz");
                }
                else
                {
                    Nev = value;
                }
            }
            get
            {
                return Nev;
            }
        }

        private int Midiklorianok;
        public int midiklorianok
        {
            set
            {
                if(2000>value||22000< value)
                {
                    throw new Exception("Hibás Midiklorian szint");
                }
                else
                {
                    Midiklorianok = value;
                }
            }
            get
            {
                return Midiklorianok;
            }
        }

        private bool Jedi;
        public bool jedi
        {
            get
            {
                return Jedi;
            }
            set
            {
                Jedi = value;
            }

        }

        private Szin FenykardSzine;
        public Szin fenykardSzine
        {
            set
            {
                FenykardSzine = value;
            }
            get
            {
                return FenykardSzine;
            }
       
        }

        public ITanito mester
        {
            get;set;
        }
    }
}
