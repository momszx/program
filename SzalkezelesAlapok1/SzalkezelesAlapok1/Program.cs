using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SzalkezelesAlapok1
{
    class Program
    {
        static void writey()
        {
            for (int i = 0; i < 5000; i++)
            {
                Console.WriteLine("Y");
            }
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(writey);
            t1.Start();
            for (int x = 0; x < 5000; x++)
            {
                Console.WriteLine("X");
            }

        }
    }
}
