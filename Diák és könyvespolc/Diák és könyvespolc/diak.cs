using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diák_és_könyvespolc
{
    class diak
    {
        private int eletkor;
        public int Eletkor
        {
            set
            {
                if (value <18 || value > 60)
                {
                    throw new Exception("nem megfelelő eletkor");
                }
                eletkor = value;
            }
            get
            {
                return eletkor;
            }
        }

        private string szak;
        public string Szak
        {
            set
            {
                szak = value;
            }
            get
            {
                return szak;
            }
        }

        private string neve;
        public string Neve
        {
            set
            {
                if(value.Length<3|| value.Length > 50)
                {
                    throw new Exception("nem megfelelő névhosz");
                }
            }
            get
            {
                return neve;
            }
        }
    }
}
