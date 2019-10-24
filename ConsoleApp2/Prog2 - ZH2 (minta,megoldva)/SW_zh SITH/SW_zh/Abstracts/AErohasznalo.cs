using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW_zh
{
    abstract class AErohasznalo : IErohasznalo
    {
        static Random rnd = new Random();
        public AErohasznalo(string nev, bool jedi)
        {
            this.nev = nev;
            this.jedi = jedi;
            midiklorian = rnd.Next(2000, 22000);
        }

        private string Nev;
        public string nev
        {
            get
            {
                return Nev;
            }
            set
            {
                if(!(value==null&& value.Length > 2))
                {
                    Nev = value;
                }
                else
                {
                    throw new Exception("Hibás név");
                }
            }
        }

        private int Midiklorian;
        public int midiklorian
        {
            get
            {
                return Midiklorian;
            }
            set
            {
                if (value > 2000 || value <= 22000)
                {
                    Midiklorian = value;
                }
                else
                {
                    throw new Exception("Hibás midiklorian szám");
                }
            }
        }

        public bool jedi { get; set; }
        public Szin fenykardSzine { get; set; }

        public ITanito mester { get; set; }
    }
}
