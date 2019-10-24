using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Galaxis
{
    class EgitestEletkorTulNagyException : Exception
    {
        public EgitestEletkorTulNagyException(ushort WrongValue)
            : base(string.Format("Túl nagy életkor: {0}", WrongValue))
        {

        }
    }
}
