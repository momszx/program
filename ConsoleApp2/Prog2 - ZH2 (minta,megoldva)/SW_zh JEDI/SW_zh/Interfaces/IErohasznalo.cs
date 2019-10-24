using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW_zh
{
    interface IErohasznalo
    {
        string nev { get; set; }
        int midiklorianok { get; }
        bool jedi { get; set; }
        Szin fenykardSzine { get; set; }
        ITanito mester { get; }
    }
}
