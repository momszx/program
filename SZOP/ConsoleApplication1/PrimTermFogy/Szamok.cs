using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace PrimTermFogy
{
    class Szamok
    {
        public static List<int> list = new List<int>();
        public static int termoDb = 0;

        public static void Insert(int szam) {
            lock (list)
            {
                list.Add(szam);
            }
        }

        public static void TermeloCsokkent() {
            lock (typeof(Szamok))
            {
                termoDb--;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Egy termelő leállt!");
                Console.ResetColor();

                if (termoDb == 0)
                {
                    lock (list)
                    {
                        Monitor.PulseAll(list);
                    }
                }
            }
        }
    }
}
