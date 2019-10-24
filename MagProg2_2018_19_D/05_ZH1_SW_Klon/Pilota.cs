using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ZH1_SW_Klon
{
    class Pilota : Rohamosztagos
    {
        public Pilota(uint Azonosito, string Nev, uint KikepzesIdeje)
            : this(Azonosito, Nev, KikepzesIdeje, SugarvetoSzine.PIROS, true)
        {
        }
        public Pilota(uint Azonosito, string Nev, uint KikepzesIdeje,
            SugarvetoSzine SugarvetoSzin, bool Klon)
            : base(Azonosito, Nev, KikepzesIdeje, SugarvetoSzin, Klon)
        {
            this.Nev = this.Nev + " " + Beallitasok.Default.PilotaSuffix;
        }
        public Pilota(uint Azonosito, string Nev, uint KikepzesIdeje,
            SugarvetoSzine SugarvetoSzin, bool Klon, 
            Jarmu MitVezet, byte BalesetekSzama)
            : this(Azonosito, Nev, KikepzesIdeje, SugarvetoSzin, Klon)
        {
            this.MitVezet = MitVezet;
            this.BalesetekSzama = BalesetekSzama;
        }

        public Jarmu MitVezet { get; set; }
        public byte BalesetekSzama { get; set; }
    }
}
