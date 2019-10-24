using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW_zh
{
    class JediMester : AMester
    {
        public JediMester(string nev) :base(nev,true)
        {
            
        }

        public override void ErovelHarcol(IErohasznalo ellenseg)
        {
            Console.WriteLine("{0} az erőt felhasználva mentálisan harcol {1} ellen.",
                this.nev, ellenseg.nev);
        }
    }
}
