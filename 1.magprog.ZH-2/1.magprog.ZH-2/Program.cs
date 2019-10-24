using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.magprog.ZH_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adj meg 2 egész számot");
            int szamA = Convert.ToInt32(Console.ReadLine());
            int szamB = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < 1;)
            {
                if (szamA >= szamB)
                {
                    Console.WriteLine("Kérlek nagyobb számot addj meg ");
                    szamB = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    i++;
                }
            }
            int darab=0;
            for (int i = szamA; i < szamB; i++)
            {
                Console.Write(i + " ");
                if (i%2!=0)
                {
                    darab++;
                    
                }
          
            }
            Console.WriteLine(" ");
            Console.Write(darab);
            Console.ReadLine();
        }
    }
}
