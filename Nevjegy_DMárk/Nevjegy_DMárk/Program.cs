using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nevjegy_DMárk
{
    class Program
    {
        static void Main(string[] args)
        {
            //adatok
            #region 
            Console.WriteLine("Kérlek add meg a neved.");
            string nev = Console.ReadLine();
            Console.WriteLine("Kérlek add meg a telefonszámodat.");
            string tel = Console.ReadLine();
            Console.WriteLine("Kérlek add meg az e-mail címed.");
            string mail = Console.ReadLine();
            Console.Write("Adatok feldolgozása...");
            Console.Clear();
            #endregion 
            //nevjegy
            #region 
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("/~~~~~~~~~~~~~~~~~~~\\");
            Console.Write("|");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(nev);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("|");
            Console.Write("|");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(tel);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("|");
            Console.Write("|");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(mail);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("|");
            Console.WriteLine("\\~~~~~~~~~~~~~~~~~~~/");




            #endregion




            Console.ReadKey();
        }
    }
}
