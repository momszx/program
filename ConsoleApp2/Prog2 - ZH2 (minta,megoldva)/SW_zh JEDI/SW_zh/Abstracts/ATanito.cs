using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW_zh
{
    abstract class ATanito : AErohasznalo, ITanito
    {
        public ATanito(string nev, bool jedi, int midiklorianok) : base(nev, jedi)
        {
            
        }

        public IErohasznalo tanitvany { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void FenykarddalHarcol(IErohasznalo erohasznalo)
        {
            throw new NotImplementedException();
        }
    }
}
