using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Sakk
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabla t1 = new Tabla();
            Thread a1 = new Thread(t1.FelsoKitolt);
            Thread a2 = new Thread(t1.AlsoKitolt);

            a1.Start();
            a2.Start();
            Console.ReadLine();
        }
    }
}
