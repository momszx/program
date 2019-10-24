using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW_zh
{
    class SithNagyur : AMester
    {
        public SithNagyur(string nev) : base(nev, false)
        {
            this.fenykardSzine = Szin.PIROS;
        }

        public override void ErovelHarcol(IErohasznalo ellenseg)
        {
            Console.WriteLine("{0} az erőt felhasználva áramot fejlesztve küzd {1} ellen.",
                this.nev, ellenseg.nev);
        }
    }
}
