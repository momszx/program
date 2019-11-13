using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SzalkezelesAlapok2
{
    class Program
    {
        
            static void JustWait()
        {
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(JustWait);
            t1.Start();
            for (int x = 0; x < 5000; x++)
            {
                Console.WriteLine(t1.IsAlive);
            }

        }
    }
}

