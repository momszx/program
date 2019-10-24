using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018._11._07
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1
            //Console.WriteLine("Add meg a súlyod ");
            //int súly = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Sportolsz e valamit (True/False)");
            //bool spot = Convert.ToBoolean(Console.ReadLine());
            //if (súly> 120 || ! spot)
            //{
            //    Console.WriteLine("sportolj");
            //}
            //else Console.WriteLine("király");
            #endregion

            #region 2
            //Console.WriteLine("mennyi pénzed van ?");
            //int penz = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("szeretnénk e könyvet venni ? ");
            //bool val = Convert.ToBoolean(Console.ReadLine());
            //if (penz >= 5000 && val)
            //{
            //    Console.WriteLine("irány a bolt ");
            //}
            //else Console.WriteLine("akkor nem ");
            #endregion

            #region 3
            //int szam = 0;
            //do
            //{
            //    Console.WriteLine("add meg a számot ");
            //     szam = Convert.ToInt32(Console.ReadLine());
            //} while (szam< 50 || szam >100 );
            //Console.WriteLine("Na végre");
            #endregion

            #region 4
            //string szöveg = "";
            //do
            //{
            //    Console.WriteLine("add meg a szöveget");
            //    szöveg = Console.ReadLine();

            //} while (szöveg.Length<=5);
            //Console.WriteLine("jár a keksz");
            #endregion

            #region 5
            //while (true)
            //{
            //    Console.WriteLine("JÉJ"); 
            //    Console.WriteLine("JÉÉJ");
            //    Console.WriteLine("JÉÉÉJ");
            //    Console.WriteLine("JÉÉÉÉJ");
            //    Console.WriteLine("JÉÉÉÉÉJ");
            //    Console.WriteLine("JÉÉÉÉÉÉJ");
            //    Console.WriteLine("JÉÉÉÉÉJ");
            //    Console.WriteLine("JÉÉÉÉJ");
            //    Console.WriteLine("JÉÉÉJ");
            //    Console.WriteLine("JÉÉJ"); 
            //    Console.WriteLine("JÉJ");
                
            //}
            #endregion

            #region 6
            //for (int i = 1; i < 11; i++)
            //{
            //    Console.WriteLine("Ugorjak a kövire?");
            //    if (Console.ReadLine() == "igen") continue;
            //    Console.WriteLine(i);
            //}
            #endregion

            #region 7
            //Console.WriteLine("adj meg egy számot");
            //int szam = Convert.ToInt32(Console.ReadLine());
            //int[] tomb = new int[szam];
            //Random rnd = new Random();
            //for (int i = 0; i < tomb.Length; i++)
            //{
            //    tomb[i]= rnd.Next (1010000000);
            //}
            //int max = tomb[0];
            //for (int i = 0; i < tomb.Length; i++)
            //{
            //    if (tomb[i] > max) max = tomb[i];
            //}
            //int min = tomb[0];
            //    for (int i = 0; i < tomb.Length; i++)
            //{
            //    if (tomb[i] < min) min = tomb[i];
            //}
            //    Console.WriteLine(min);
            //    Console.WriteLine(max);

            #endregion

            #region ellenörzöt szám bevitel
            //int szam = 0;
            //Console.WriteLine("adj meg egy számot");
            //while (!int.TryParse(Console.ReadLine(), out szam))
            //{
            //    Console.WriteLine("Hibás adat");
            //}
            

            #endregion

            #region 9
            List<string> nevek = new List<string>();
            nevek.Add("Réka"); 
            nevek.Add("Béla");
            for (int i = 0; i < 111; i++)
            {
                if (i% 2 == 0) nevek.Add("Réka");
                else nevek.Add("Béla");
            }
            for (int i = 0; i < nevek.Count; i++)
            {
                Console.WriteLine(nevek[i]);
            }
            #endregion

            #region
            #endregion
            
            #region
            #endregion

            #region
            #endregion

            Console.ReadLine();
        }
    }
}
