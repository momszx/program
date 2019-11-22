using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Zaszlo
{
    class Program
    {
        static void Main(string[] args)
        {
            Zaszlo z1 = new Zaszlo(0, 7, ConsoleColor.Red, 5000);
            Zaszlo z2 = new Zaszlo(7, 14, ConsoleColor.White, 5000);
            Zaszlo z3 = new Zaszlo(14, 21, ConsoleColor.Green, 5000);

            Thread t1 = new Thread(z1.Kirajzol);
            Thread t2 = new Thread(z2.Kirajzol);
            Thread t3 = new Thread(z3.Kirajzol);

            t1.Start();
            t2.Start();
            t3.Start();

            Console.ReadLine();
        }
    }
}
