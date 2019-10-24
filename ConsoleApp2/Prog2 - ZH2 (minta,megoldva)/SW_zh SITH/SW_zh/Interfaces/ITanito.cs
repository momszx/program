using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW_zh
{
    interface ITanito:IErohasznalo
    {
        IErohasznalo tanitvany { get; set; }

        void FenykarddalHarcol(IErohasznalo ellenseg);
    }
}
