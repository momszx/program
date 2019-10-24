using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW_zh
{
    abstract class AMester : AErohasznalo, ITanito, IMester
    {
        public AMester(string nev , bool jedi): base(nev, jedi)
        {

        }

        private ITanito _oregTanitvany;
        public ITanito oregTanitvany
        {
            get
            {
                return _oregTanitvany;
            }

            set
            {
                _oregTanitvany = value;
            }
        }

        private IErohasznalo _tanitvany;
        public IErohasznalo tanitvany
        {
            get
            {
                return _tanitvany;
            }

            set
            {
                _tanitvany = value;
            }
        }

        public abstract void ErovelHarcol(IErohasznalo ellenseg);

        public virtual void FenykarddalHarcol(IErohasznalo ellenseg)
        {
            if (ellenseg.jedi != this.jedi)
                Console.WriteLine("{0} fénykarddal harcol {1} ellen", this.nev,
                ellenseg.nev);
        }
    }
}
