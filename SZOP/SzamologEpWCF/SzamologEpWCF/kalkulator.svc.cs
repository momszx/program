using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SzamologEpWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "kalkulator" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select kalkulator.svc or kalkulator.svc.cs at the Solution Explorer and start debugging.
    public class kalkulator : Ikalkulator
    {
        public void DoWork()
        {
        }

        double Ikalkulator.Kivona(double a, double b)
        {
            return (a - b);
        }

        double Ikalkulator.Osszeadas(double a, double b)
        {
            return (a + b);
        }

        double Ikalkulator.Osztás(double a, double b)
        {
            return (a / b);
        }

        double Ikalkulator.Szorzas(double a, double b)
        {
            return (a * b);
        }
    }
}
