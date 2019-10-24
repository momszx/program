using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW_zh
{
    class SithTorzs
    {
        private List<IErohasznalo> _sithek = new List<IErohasznalo>();
        public List<IErohasznalo> sithek
        {
            get { return _sithek; }
        }
        public void AddSith(IErohasznalo UjSith)
        {
            bool SzerepelE = false;
            if (!(UjSith.jedi))
            {
                foreach (IErohasznalo erohasznalo in sithek)
                {
                    if (erohasznalo.nev == UjSith.nev)
                    {
                        SzerepelE = true;
                    }
                    
                }
                if (!(SzerepelE))
                {
                    sithek.Add(UjSith);
                }
            }
        }

        public List<IMester> PlagueistMegsemKozelitoMesterek
        {
            get
            {
                List<IMester> temp = new List<IMester>();
                foreach (IErohasznalo erohasznalo in sithek)
                {
                    if((erohasznalo is IMester)&&(erohasznalo as IMester).midiklorian < 12000)
                    {
                        temp.Add(erohasznalo as IMester);
                    }
                }
                return temp;
            }
        }
    }
}
