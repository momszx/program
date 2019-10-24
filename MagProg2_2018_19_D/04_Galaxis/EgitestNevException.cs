using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Galaxis
{
    class EgitestNevException : Exception
    {
        public EgitestNevException(string WrongValue)
            : base(string.Format("Hibás név input: {0}", WrongValue))
        {

        }
    }
}
