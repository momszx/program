using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018._10._17_1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //int szam =0;
            //int osszeg = 0;
            
            //while (osszeg < 100)
            //{
            //    Console.WriteLine("kérek egy számot");
            //    szam = Convert.ToInt32(Console.ReadLine());
            //    osszeg = osszeg + szam;
            //}
            //Console.WriteLine("Az összeg "+ osszeg );
         
            #endregion
            #region
            //int[] szamok = new int[3];
            //szamok[0] = 15;
            //szamok[1] = 20;
            //szamok[2] = 30;
            //Console.WriteLine("{0} | {1} | {2}",szamok[2],szamok[1],szamok[0]);
            #endregion

            #region
            //for (int i = 0; i < szamok.Length; i++)
            //{
            //    Console.WriteLine(szamok[i]);
            //}

            #endregion

            #region
            //string[] szoveg = new string[5];
            //for (int i = 0; i < szoveg.Length; i++)
            //{
            //    Console.WriteLine("Kérlek add meg a szöveget");
            //    szoveg[i] = Console.ReadLine();
            //}
            //Console.Clear();
            //Console.WriteLine("Eltárolva");
            //for (int i = 0; i < szoveg.Length; i++)
            //{
            //    Console.WriteLine("A megadot szöveget : " + szoveg[i]);
            //}


            #endregion

            #region veletlen számok generálása !!!
            //Random rnd = new Random();
            //Console.WriteLine("Kérlek add meg hány számot szeretnél");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Kérlek add meg hogy mettől ...");
            //int c = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("meddig");
            //int d = Convert.ToInt32(Console.ReadLine());
            //Console.Clear();
            //for (int i = 0; i < b; i++)
            //{
            //    Console.WriteLine(rnd.Next(c, d));
            //}

            #endregion

            #region
            //Random rnd = new Random();
            //Console.WriteLine(rnd.Next(25, 51)*2);


            #endregion

            #region
            //int[] szam = new int[50];
            //Random rnd = new Random();
            //for (int i = 0; i < szam.Length; i++)
            //{
            //    szam[i] = rnd.Next(0, 101);
            //}
            //for (int d = 0; d < szam.Length; d++)
            //{
            //    Console.WriteLine(szam[d]);
            //}

            #endregion

            #region
            //Console.WriteLine("addmeg a számot");
            //int szam= Convert.ToInt32(Console.ReadLine());
            //while (szam < 50 || szam > 60)
            //{
            //    Console.WriteLine("hibás adat");
            //    Console.WriteLine("addmeg a számot");
            //    szam = Convert.ToInt32(Console.ReadLine());
            //}
            #endregion

            #region
            //Console.WriteLine("addmeg a szöveget");
            //string szoveg = Console.ReadLine();
            
            //while (szoveg.Length<3)
            //{
            //    Console.WriteLine("hibás adat");
            //    Console.WriteLine("addmeg a szöveget");
            //    szoveg = Console.ReadLine();
            //}
            //Console.WriteLine("jár a keksz"
            //    );

            #endregion
            #region ZHban lesz!!
            //Console.WindowHeight = 16;
            //Console.WindowWidth = 32;

            //Console.WriteLine("adj meg egy számot");
            //int szam = 0;
            //while (!int.TryParse(Console.ReadLine(),out szam))
            //{
            //    Console.WriteLine("hibaaaaaa!!!!!!!");
            //    Console.WriteLine("adj meg egy számot");
            //}

            #endregion

            #region
            Console.WriteLine("adj meg egy számot");
            int szam = 0;
            while (!int.TryParse(Console.ReadLine(), out szam)|| szam<=0)
            {
               Console.WriteLine("hibaaaaaa!!!!!!!");
               Console.WriteLine("adj meg egy számot");
            }
            #endregion
            Console.ReadLine();
        }
    }
}
