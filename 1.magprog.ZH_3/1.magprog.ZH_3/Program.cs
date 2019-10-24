using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.magprog.ZH_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg a dinók számát ");
            int szam = 0;
            while (!int.TryParse(Console.ReadLine(), out szam))
            {
                Console.WriteLine("hibaaaaaa!!!!!!!");
                Console.WriteLine("adj meg egy számot");
            }
            string[] nev = new string[szam];
            Console.WriteLine("Kérlek add meg a neveiket");

            for (int i = 0; i < szam;)
            {
                nev[i] = Console.ReadLine();
                if (nev[i].Length <= 3)
                {
                    Console.WriteLine("hibás adat");
                    Console.WriteLine("addmeg a szöveget");
                    nev[i] = Console.ReadLine();
                }
                else i++;
                
            }
            for (int i = 0; i < szam; i++)
            {
                
                Console.WriteLine(i+1+ ".dinó neve : "+nev[i]);
               
            }

            Console.ReadLine();
            
        }
    }
}
