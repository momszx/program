using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verem
{
    class Elem<T>
    {
        private T[] adat;
        public T[] Adat
        {
            get { return adat; }
            set { adat = value; }
        }

        private int elemszam;
        public int Elemszam
        {
            get { return elemszam; }
            set { elemszam = value; }
        }

        int maxMeret;
        public int Maxmeret
        {
            get { return maxMeret; }
            set { maxMeret = value; }
        }

        public Elem(int Maxdb)
        {
            Elemszam = 0;
            Maxmeret = Maxdb;
            Adat = new T[Maxdb];
        }
        public void Push (T ertek)
        {
            if (Elemszam == Maxmeret)
            {
                throw new IndexOutOfRangeException();
            }
            Adat[elemszam] = ertek;
            elemszam++;
        }
        public T Peek()
        {
            if (Elemszam == 0)
            {
                throw new IndexOutOfRangeException();
            }
            Elemszam--;
            return Adat[Elemszam];
        }
    }
}
