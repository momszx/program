using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vatera2
{
    public class Termékek :MarshalByRefObject
    {
        public static int NEXTID = 1;

        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string termeknev;

        public string Termeknev
        {
            get { return termeknev; }
            set { termeknev = value; }
        }

        private int ar;

        public int Ar
        {
            get { return ar; }
            set { ar = value; }
        }

        private string tulajdonos;

        public string Tulajdonos
        {
            get { return tulajdonos; }
            set { tulajdonos = value; }
        }

        private string licitvezeto;

        public string Licitvezeto
        {
            get { return licitvezeto; }
            set { licitvezeto = value; }
        }

        public override string ToString()
        {
            return String.Format("{0}{1}{2}{3}", termeknev, ar, tulajdonos, licitvezeto);
        }

        public Termékek(string Termeknev , int Ar ,string Tulajdonos)
        {
            this.ID = NEXTID;
            NEXTID++;
            this.Termeknev = Termeknev;
            this.Ar = Ar;
            this.Tulajdonos = Tulajdonos;
        }

        public Termékek()
        {

        }


    }
}
