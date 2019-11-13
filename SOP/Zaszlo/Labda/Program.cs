using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Labda
{
    class Program
    {
        static void Main(string[] args)
        {
            Labda l1 = new Labda(1, 1, ConsoleColor.Red);
            Labda l2 = new Labda(4, 7, ConsoleColor.Green);
            Labda l3 = new Labda(22, 14, ConsoleColor.Blue);
            Labda l4 = new Labda(55, 12, ConsoleColor.DarkYellow);
            Labda l5 = new Labda(32, 20, ConsoleColor.White);

            Thread t1 = new Thread(l1.Mozog);
            Thread t2 = new Thread(l2.Mozog);
            Thread t3 = new Thread(l3.Mozog);
            Thread t4 = new Thread(l4.Mozog);
            Thread t5 = new Thread(l5.Mozog);

            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            t5.Start();
        }
    }
}
