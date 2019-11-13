using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SzalkezelesAlapok4
{
    class Program
    {
        static void Main(string[] args)
        {
            Összeadás o = new Összeadás();
            Thread t1 = new Thread(o.Alsofele);
            Thread t2 = new Thread(o.felsofele);
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
            Console.WriteLine(o.osszeg);
            Console.ReadLine();
        }
    }
}
