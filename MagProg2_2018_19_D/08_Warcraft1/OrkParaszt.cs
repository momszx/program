using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Warcraft1
{
    class OrkParaszt : Ork
    {
        public override string Etkezik()
        {
            return "A parasztja leül enni egy kőre egy kis földet";
        }

        public override string Pihen()
        {
            return "Zzzzzzzzzzz";
        }
    }
}
