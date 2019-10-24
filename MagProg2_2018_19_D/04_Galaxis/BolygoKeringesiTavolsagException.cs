using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Galaxis
{
    class BolygoKeringesiTavolsagException : Exception
    {
        public BolygoKeringesiTavolsagException(float WrongValue)
            :base(string.Format("Nem megfelelő keringési távolság: {0}", WrongValue))
        {
            this.KeringesiTavolsagRosszErtek = WrongValue;
        }

        public float KeringesiTavolsagRosszErtek { get; private set; }
    }
}
