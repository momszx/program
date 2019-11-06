using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KiirSzal
{
    class Program
    {
        // 100 elemu vektor, toltsuk fel az index ertekeivel
        // 2 szal van, az egyik alulrol, a masik felulrol kezdje kiirni az elemeket
        // 1 2 3 4 5 6 7 8 9 10. akor van vege ha osszeernek. versenyeztetni akarjuk a 2 szalat, melyik agyorsabb, lehet e befolyasolni a gyorsasagot? 

        static int[] array = new int[100];
        static int i = 0;
        static int j = 99;
        static void also()
        {
            //lockolas nelkul nem jo, lockba olyat kjell irni aminek van referenciaja. most minden piros lesz mert mindkettot lockolta es a felso fuggveny nem kapja meg a vezerlest mer lockolva van
            //lock (array)
            //{
            //    while (i < j)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;

            //        Console.WriteLine(i++);
            //    }
            //}

            //lockoljunk belul. nem lehet kevesebbet lockolni. Mindig at kell nezni h minnel kevesebbet lockoljunk.
            // mit lockolunk ha nincs tomb a feladatva?  azt az osytalyt szoktak kiirni amibe a szalas metodusok futnak.
            //lock(typeof(Program)) ugyan azt kell lockolni.

            while (i < j)
            {
                lock (array)
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine(i++);
                }
            }
        }

        static void felso()
        {
            while (i < j)
            {
                lock (array)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    //lockolas nelkull nem jo
                    Console.WriteLine(j--);
                }
            }
        }


        static void Main(string[] args)
        {
            Thread t1 = new Thread(also);
            //prioritas beallitasa. tobbszor nyer a highest, de nem minidg
            t1.Priority = ThreadPriority.Highest;
            Thread t2 = new Thread(felso);
            t2.Priority = ThreadPriority.Lowest;
            t1.Start();
            t2.Start();
            t1.Join(); //joinolok h a vegen irja ki
            t2.Join();
            Console.WriteLine("kesz"); // ezt most elore irja ki. hogy ne igy legyen joinolni kell
            Console.ReadKey();
        }

    }
}
