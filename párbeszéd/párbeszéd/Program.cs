using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace párbeszéd
{
    class Program
    {
        static void Main(string[] args)
        {
            string e = "Esik az eső";
            string f = "Fúj a szél";
            Console.WriteLine("Gépeld be a válaszodat");
            Console.WriteLine("Esik az eső");
            Console.WriteLine("Fúj a szél");
            string s = Console.ReadLine();
            s = s.Trim();
            s = s.ToLower();
            if (s.Substring(0, 2) == "es")
            {
                Console.WriteLine("Vigyél esernyőt");
                s = s.Remove(0, j.Length);
            }
            if (s.Substring(0, 2) == "fú")
            {
                Console.WriteLine("Vigyél széldzseki");
                s = s.Remove(0, j.Length);
            }

            Console.ReadLine();

        }
    }
}
