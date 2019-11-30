using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SzamologEpWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "Ikalkulator" in both code and config file together.
    [ServiceContract]
    public interface Ikalkulator
    {
        [OperationContract]
        public double Osszeadas(double a, double b);
        [OperationContract]
        public double Kivona(double a, double b);
        [OperationContract]
        public double Szorzas(double a, double b);
        [OperationContract]
        public double Osztás(double a, double b);
    }
}
