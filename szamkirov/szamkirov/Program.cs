using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamkirov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gondolj egy számra 0 és 100 között!");

            bool kitalaltam = false;
            int max = 100;
            int min = 0;
            int a = max / 2;


            while (kitalaltam == false)
            {
                Console.Write("Erre gondoltál? : {0} (igen/nem) ", a);
                if (Console.ReadLine().ToLower() == "igen") kitalaltam = true;
                else
                {
                    kitalaltam = false;
                    Console.WriteLine("Nagyobb nála? (igen/nem) ");
                    if (Console.ReadLine().ToLower() == "igen")
                    {
                        min = a;
                        a = (max - a) / 2 + a;
                    }
                    else
                    {
                        max = a;
                        a = min + (max - min) / 2;
                    }
                }

            }

            Console.WriteLine("A gondolt szám: {0}", a);

            Console.ReadKey();
        }
    }
}
