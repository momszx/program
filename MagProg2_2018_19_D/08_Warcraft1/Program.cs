using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Warcraft1
{
    class Program
    {
        static void Main(string[] args)
        {            
            //Console.ForegroundColor = ConsoleColor.Green;
            //Ork o1 = new Ork();
            //Console.WriteLine("Klasszikus ork");
            //Console.WriteLine(o1.Eletero);
            //Console.WriteLine(o1.Regeneralodik());
            //Console.WriteLine(o1.Eletero);

            Console.ForegroundColor = ConsoleColor.Yellow;
            OrkParaszt o2 = new OrkParaszt();
            Console.WriteLine("\nOrk paraszt");
            Console.WriteLine(o2.Eletero);
            Console.WriteLine(o2.Regeneralodik());
            Console.WriteLine(o2.Eletero);

            Console.ForegroundColor = ConsoleColor.Cyan;
            OrkHarcos o3 = new OrkHarcos();
            Console.WriteLine("\nOrk harcos");
            Console.WriteLine(o3.Eletero);
            Console.WriteLine(o3.Regeneralodik());
            Console.WriteLine(o3.Eletero);

            Console.ReadLine();
        }
    }
}
