using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.magprog.ZH
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Szereted a fasírtot ? (true/false)");
            bool fasirt = Convert.ToBoolean(Console.ReadLine());
            if (fasirt== true)
            {
                Console.WriteLine("Mennyi fasirtot szeretnél vacsorára ?");
                int darab = Convert.ToInt32(Console.ReadLine());
                int num = 1;
                while (num <= darab)
                {
                    Console.WriteLine("o");
                    num++;
                }
                if (darab >= 0 && darab < 10)
                {
                    Console.WriteLine("Te nem vagy igazi fasírt imádó");

                }
                else if (darab >= 10 && darab < 20)
                {
                    Console.WriteLine("Te vagy az emberem");
                }
                else if (darab <= 20)
                {
                    Console.WriteLine("sör has helyett fasirt has");
                }
            }    
            else
            {
                Console.WriteLine("csalódtam benned :(");
            }
                Console.WriteLine();
            Console.ReadLine();
        }
    }
}
