using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Warcraft1
{
    class Paraszt : Ork
    {
        public override string Etkezik()
        {
            return "A parasztja le ül enni egy köre és harap egyet a hagymából";
        }

        public override string Pihen()
        {
            return "Zzzzzzzzzzzzzzzzzzzzzzzzzzzz";
        }
    }
}
