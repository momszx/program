using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace órai
{
    class Program
    {
        static void Main(string[] args)
        {
            #region negyedik feladat
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine("Szeretem a lamantínokat!");
                i++;
            }


            #endregion

            #region ötödik feladat
            int a = 0;
            while (a < 11)
            {
                if (i % 2 == 0) Console.WriteLine(a);
                a++;
            }


            #endregion

            #region hatodik feladat
            int b = 50;
            while (b <= 60)
            {
                if (i % 2 != 0) Console.WriteLine(b);
                b++;
            }


            #endregion
            #region hetedik feladat

            int szum = 0;
            int c = 0;
            while (c <= 100)
            {
                szum += i;
                c++;
            }
            
            Console.WriteLine("A számok összege: " + szum);

            #endregion

            #region nyolcadik feladat

            int a1 = 0;
            int b1 = 1;
            Console.Write("{0}, {1}, ", a1, b1);

            int c1 = 0;
            int i1 = 0;
            while (i1 < 13)
            {
                c1 = a1 + b1;
                a1 = b1;
                b1 = c1;
                Console.Write("{0}, ", c1);
                i1++;
            }
           

            #endregion

            Console.ReadLine();
        }
    }
}
