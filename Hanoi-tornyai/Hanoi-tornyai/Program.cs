using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanoi_tornyai
{
    class Program
    {
        public static void Main(String[] args)
        {
            char kiindulas = 'A'; // start tower in output
            char veg = 'C'; // end tower in output
            char seged = 'B'; // temporary tower in output
            int totalDisks = 10; // number of disks

            solveTowers(totalDisks, kiindulas, veg, seged);
            Console.Read();
        }

        private static void solveTowers(int n, char kiindulas, char veg, char seged)
        {
            if (n > 0)
            {
                solveTowers(n - 1, kiindulas, seged, veg);
                Console.WriteLine(n+". Korong mozgatva " + kiindulas + "-ró/ől " + veg +"-ra/e");
                solveTowers(n - 1, seged, veg, kiindulas);

            }
        }
    }

}
