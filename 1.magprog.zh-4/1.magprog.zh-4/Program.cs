using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.magprog.zh_4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int osszeg = 0;
            int db = 0;
            int szam = 0;
            int tag = 0;

            for (int i = 0; i < 10; i++)
            {
                
                szam = Convert.ToInt32(Console.ReadLine());
                osszeg = szam + osszeg;
                if (osszeg <= 200)
                {
                    if (!(szam % 2 != 0))
                    {
                        db++;
                    }

                    tag++;

                }
                else
                {
                    if (!(szam % 2 != 0))
                    {
                        db++;
                    }
                    tag++;
                    break;
                }

                
            }
            Console.WriteLine("Meg adot páros számok : {0}", db);
            Console.WriteLine("Meg adot összes szám : {0}", tag);
            Console.WriteLine("Meg adot számok összege : {0}", osszeg);


            Console.ReadLine();
        }
    }
}
