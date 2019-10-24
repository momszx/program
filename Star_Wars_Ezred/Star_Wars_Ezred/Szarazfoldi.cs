using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star_Wars_Ezred
{
    class Szarazfoldi : Rohamosztagos
    {
        private bool tiszt;
        public bool Tiszt
        {
            set
            {
                if (Clon)
                {
                    tiszt = false;
                }
                else
                {
                    if (!tiszt)
                    {
                        tiszt = value;
                    }
                }
            }
        }
    }
}
