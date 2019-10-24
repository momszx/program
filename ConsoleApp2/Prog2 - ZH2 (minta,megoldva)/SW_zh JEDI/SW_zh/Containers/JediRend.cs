using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW_zh
{
    class JediRend
    {
        private List<IErohasznalo> _jedik = new List<IErohasznalo>();
        public List<IErohasznalo> jedik
        {
            get { return _jedik; }
        }
        
        
        public List<IMester> AnakintKozelitoMesterek
        {
            get
            {
                List<IMester> temp = new List<IMester>();
                foreach(IErohasznalo erohasznalo in jedik)
                {
                    if ((erohasznalo is IMester) && (erohasznalo as IMester).midiklorianok > 19000)
                    {
                        temp.Add(erohasznalo as IMester);
                    }
                }
                return temp;
            }
        }
        public void AddJedi(IErohasznalo UjJedi)
        {
            bool VanIlyenJedi = false;
            if (UjJedi.jedi)
            {
                foreach (IErohasznalo erohasznalo in jedik)
                {
                    if (erohasznalo.nev == UjJedi.nev)
                    {
                        VanIlyenJedi = true;
                    }
                }
                if (!VanIlyenJedi)
                {
                    jedik.Add(UjJedi);
                }
            }
        }
    }
}
