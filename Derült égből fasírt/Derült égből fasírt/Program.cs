using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Derült_égből_fasírt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esik az eső? (igen/nem)");
            if (Console.ReadLine() == "igen") { Console.WriteLine("Akkor ma rossz idő van "); }
            else Console.WriteLine("Akkor irány a szabad!" );
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("mennyi fasírt van ? ");
            int fasirt = Convert.ToInt32(Console.ReadLine());
            if (fasirt <= 0) { Console.WriteLine("Nem megyek"); }
            else if (fasirt < 10) { Console.WriteLine("hmm, még átgondolom"); }
            else Console.WriteLine("már indulok is");
            Console.ReadLine();
        }
    }
}
