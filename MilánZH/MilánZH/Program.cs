using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilánZH
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> homersekletek = new List<double>();
            HomersekletekBekerese(homersekletek,10,0.0,40.0);
            Console.ReadKey();
        }

        static void HomersekletekBekerese(List<double> homersekletek,int n,double also ,double felso)
        {
            int i=0;
            double seged = 0;
            while (!(i==n))
            {
                Console.WriteLine("Kérlek add meg a(z) {0}. számot ",i+1);
                while(!double.TryParse(Console.ReadLine(),out seged))
                {
                    Console.WriteLine("Hülye vagy ? ez nem konvertálható ...");
                    Console.WriteLine("Kérlek add meg a(z) {0}. számot ", i + 1);
                }
                if (seged <= also || seged >= felso)
                {
                    Console.WriteLine("Kérlek {0} és {1} közötti értéket adj meg",also,felso);
                }
                else
                {
                    homersekletek.Add(seged);
                    i++;
                    Console.WriteLine("{0}. hőmérséklet sikeresen bekérve",i);
                }
            }
        }
        //while (!int.TryParse(Console.ReadLine(), out szam))
        //    {
        //        Console.WriteLine("hibaaaaaa!!!!!!!");
        //        Console.WriteLine("adj meg egy számot");
        //    }
}
}
