using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logika
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int a = 0; a < 2; a++)
                {
                    bool b = Convert.ToBoolean(i);
                    bool c = Convert.ToBoolean(a);
                    Console.WriteLine("{0}  {1} {2}",b,c,!b || c);
                }
            }
            int x = 0;
            bool y = Convert.ToBoolean(x);
            Console.WriteLine(y);
            Console.ReadLine();
        }
    }
}
