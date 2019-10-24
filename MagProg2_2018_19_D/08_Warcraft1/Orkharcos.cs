using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Warcraft1
{
    class OrkHarcos : Ork
    {
        public new static int GYOGYULASEGYKORBEN = 20;

        public override int GyogyulasEgykorben
        {
            get
            {
                return OrkHarcos.GYOGYULASEGYKORBEN;
            }
        }

        public override string Etkezik()
        {
            return "Letépi ellenfele fejét, és az orrán keresztül kiszívja az agyvelejét.";
        }
        public override string Pihen()
        {
            return "Zzz...";
        }
    }
}
