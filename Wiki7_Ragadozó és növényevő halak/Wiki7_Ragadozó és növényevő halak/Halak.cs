using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiki7_Ragadozó_és_növényevő_halak
{
    class Halak
    {
        private double weight=0;
        public double Weight
        {
            get
            {
                if (weight == 0) throw new Exception("még nincs beállítva");
                return weight;
            }
            set
            {
                if (value < 0.5 || value > 40) throw new Exception("Nem jó a súly adat!");
                if (weight == 0) weight = value;
                else
                {
                    double arany = value * 100 / weight;
                    if (0.9 <= arany && arany <= 1.1) weight = value;
                    else throw new Exception("Ennyivel nem ugorhat meg a sulya!");
                }
            }
        }
    

        private bool predator;
        private bool predatorset = false ;
        public bool Predator
        {
            set
            {
                if (predatorset == true)
                {
                    throw new Exception("Már be van állítva nem lehetséges módosítani");
                }
                predatorset = true;
                predator = value;
            }
            get
            {
                if (predatorset == false)
                {
                    throw new Exception("Nincs adat meg adva!");
                }
                return predator;
            }
        }

        private uint top;
        public uint Top
        {
            set
            {
                if (value < 0 || value > 400)
                {
                    throw new Exception("Nem megfelelő érték!");
                }
                else
                {
                    top = value;
                }
            }
            get
            {
                return top;
            }
        }

        private uint depth;
        public uint Depth
        {
            set
            {
                if( value<10|| value > 400)
                {
                    throw new Exception("Nem megfelelő érték!");
                }
                else
                {
                    depth = value;
                }
            }
            get
            {
                return depth;
            }
        }

        private string halfaj=null;
        public string Halfaj
        {
            set
            {
                if (value.Length<3|| value.Length > 30)
                {
                    throw new Exception("nem megfelelő hossz ");
                }
                halfaj = value;
            }
            get
            {
                if (halfaj == null)
                {
                    throw new Exception("Nincs adat megadva");
                }
                return halfaj;
            }
        }
    }
}
