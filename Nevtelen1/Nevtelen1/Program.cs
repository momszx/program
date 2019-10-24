using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nevtelen1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region első feladat 
            //string nev = "Márk";
            //Console.Write("Név: ");
            //Console.WriteLine(nev);

            //string varos = "Farmos";
            //Console.Write("Város: ");
            //Console.WriteLine(varos);

            //int eletkor = 19;
            //Console.Write("Kor: ");
            //Console.WriteLine(eletkor);

            #endregion
            #region második feladat 
            //int a = 3;
            //int b = 5;
            //int c = a + b;
            //Console.WriteLine("3+2=5");
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);

            //Console.WriteLine("{0} + {1} = {2}",a,b,c);
            //Console.WriteLine("{0} - {1} = {2}",a,b,a-b);
            //Console.WriteLine("{0} * {1} = {2}",a,b,a*b);
            //Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
            //Console.WriteLine("{0} % {1} = {2}", a, b, a % b);
            #endregion
            #region feladat 3
            //Console.WriteLine("Add meg a neved");
            //string nev = (Console.ReadLine());

            //Console.WriteLine("A beírt név: {0} ", nev);

            //Console.WriteLine("Add meg a a városod");
            //string varos = (Console.ReadLine());

            //Console.WriteLine("A beírt város: {0} ", varos);

            //Console.WriteLine("Add meg az életkorod");
            //int eletkor = Convert.ToInt32(Console.ReadLine());
            ////int eletkor2 = int.Parse(Console.ReadLine());


            //Console.WriteLine("A beírt életkor: {0} ", eletkor);

            //Console.WriteLine("Esik az eső? ");
            //bool esikazeso = Convert.ToBoolean(Console.ReadLine());

            //Console.WriteLine("{0} esik az eső",esikazeso);

            #endregion
            #region negyedik feladat
            //int c = Convert.ToInt32(Console.ReadLine());
            //double f = (c * 1.8) + 32 ;
            //Console.WriteLine("Az eredmény : {0} ", f);
            #endregion
            
            Console.WriteLine("Elért pontszám: ");
            int elert = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Max pontszám");
            int max = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Százalékos eredményed: {0}%", ((double)elert / max) * 100);

            Console.ReadLine();

                
        }
    }
}
