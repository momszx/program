﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW_zh
{
    interface IMester :ITanito,IErohasznalo
    {
        ITanito oregTanitvany { get; set; }

        void ErovelHarcol(IErohasznalo ellenseg);
    }
}
