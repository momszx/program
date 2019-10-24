using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace star_wars
{
    class Rend
    {
        List<Erofelhasznalo> Lista = new List<Erofelhasznalo>();
        public int KardszinDb(Kardszin kardszin)
        {
            int db = 0;
            foreach(Erofelhasznalo e in Lista)
            {
                if (e.Kardszine == kardszin)
                {
                    db++;
                }
            }
            return db;
        }
        public int TanitvanyDb
        {
            get
            {
                int db = 0;
                foreach(Erofelhasznalo e in Lista)
                {
                    if(e is Tanitvany)
                    {
                        db++;
                    }
                }
                return db;
            }
        }
        public int Kezpetsegiszintosszeg
        {
            get
            {
                int osszeg = 0;
                foreach(Erofelhasznalo e in Lista)
                {
                    if(e is Tanitvany)
                    {
                        osszeg += (e as Tanitvany).Kepzetsegszint;
                    }
                }
                return osszeg;
            }
        }
    }
}
