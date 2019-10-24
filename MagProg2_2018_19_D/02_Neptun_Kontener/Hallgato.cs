using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Neptun_Kontener
{
    class Hallgato
    {
        public Hallgato(uint Id, string Neptunkod)
        {
            this.Id = Id;
            this.Neptunkod = Neptunkod;            
        }
        public Hallgato(uint Id, string Neptunkod, string Nev)
            :this(Id, Neptunkod)
        {
            this.Nev = Nev;
        }
        public Hallgato(uint Id, string Neptunkod, string Nev, DateTime SzuletesiDatum)
            : this(Id, Neptunkod, Nev)
        {
            this.SzuletesiDatum = SzuletesiDatum;
        }

        public uint Id { get; set; }
        public string Neptunkod { get; set; }
        public string Nev { get; set; }
        public DateTime SzuletesiDatum { get; set; }

    }
}
