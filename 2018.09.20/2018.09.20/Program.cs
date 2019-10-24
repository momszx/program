using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018._09._20
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a, b, c; // a bool az igaz hamis tipus , az értéke lehet true illetve false 
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        a = (i % 2 == 0);
                        b = (j % 2 == 0);
                        c = (k % 2 == 0);
                        Console.WriteLine("nem {0} vagy {1} és {2} = {3}", a, b, c, !(a || b ) && c);
                    }
                }
                
            }         
          
            a = true;
            b = true;
            c = true;
            Console.WriteLine("({0} <=> {1}) vagy nem {2} = {3}", a, b, c, (a == b || !c));
            Console.ReadLine();

        }
    }
}
