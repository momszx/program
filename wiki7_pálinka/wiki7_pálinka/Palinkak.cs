using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wiki7_pálinka
{
    class Palinkak
    {
        private uint alkoholfoka;
        public uint Alkoholfoka
        {
            set
            {
                if (value < 30 || value > 87)
                {
                    throw new Exception("ez biztos nem pálinka");
                }
                alkoholfoka = value;
            }
            get
            {
                return alkoholfoka;
            }
        }

        private string gyumolcs;
        public string Gyumolcs
        {
            set
            {
                if (value.Length < 3 || value.Length > 20)
                {
                    throw new Exception("ilyen gyülölcs nincs");
                }
                gyumolcs = value;
            }
            get
            {
                return gyumolcs;
            }
        }

        private uint mennyiseg;
        public uint Mennyiseg
        {
            set
            {
                if (value < 0 || value > 50)
                {
                    throw new Exception("nem megfelelő adat");
                }
                mennyiseg = value;
            }
            get
            {
                return mennyiseg;
            }
        }

        private DateTime kesziteseve;
        public DateTime Kesziteseve
        {
            set
            {
                kesziteseve = DateTime.Now;
            }
            get
            {
                return kesziteseve;
            }
        }

        private uint ar;
        public uint Ar
        {
            set
            {
                if (value < 50 || value > 1000)
                {
                    throw new Exception("Nem megfelelő ár");
                }
                ar = value;
            }
            get
            {
                return ar;
            }
        }
    }
}
