using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace életkor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem irja be a életkorát");
            int eletkor = Convert.ToInt32(Console.ReadLine());
            if (eletkor < 0) { Console.WriteLine("Valamit elgépelt" ); }
            Console.WriteLine("Milyen nemzetiségű vagy");
            string nemzet = Console.ReadLine();
            if (nemzet == "magyar") { Console.WriteLine("Szia"); }
            else Console.WriteLine("Hi");
            if (eletkor > 0 && eletkor < 18) { Console.WriteLine("Kiskorú ..I.."); }
            Console.ReadKey();
        }
    }
}
