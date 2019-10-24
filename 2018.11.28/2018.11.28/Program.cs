using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018._11._28
{
    class Program
    {
        static Random rnd = new Random();
        static void összegkiír(int a , int b)
        {
            Console.WriteLine(a+b);
        }
        static void Main(string[] args)
        {
            
            összegkiír(5,2);
            logika(false, true);
            int szam = rnd.Next(1, 50);
            valami("szöveg", szam);
            int[] tömb = new int[30];
            for (int i = 0; i < tömb.Length; i++)
            {
                tömb[i] = rnd.Next(1, 101);
            }
            int max = tömb[0];
            for (int i = 1; i < tömb.Length; i++)
            {
                if (max < tömb[i])
                {
                    max = tömb[i];
                    
                }
            }
            Console.WriteLine(max);
            int min = tömb[0];
            for (int i = 1; i < tömb.Length; i++)
            {
                if (min > tömb[i])
                {
                    min = tömb[i];

                }
            }
            Console.WriteLine(min);

            int eredmény = összegez(1, 5);

            Console.WriteLine(eredmény);
            List<int> szamok = new List<int>();
            for (int i = 0; i < 50; i++)
			{
			 szamok.Add(rnd.Next(1,101));
			}
            int db = __I__(szamok);
            Console.WriteLine(db);
            Console.ReadLine();
            
        }
        static void logika(bool a, bool b)
        {
            Console.WriteLine((a||b)&&b);
        }
        static void valami(string s, int db)
        {
            for (int i = 0; i < db; i++)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine(db);
            Console.ReadLine();
            Console.Clear();
        }
        static int összegez(int a, int b)
        {
            
            return a + b;
        }
        static int __I__(List<int> szamok)
        {
            int db = 0;
            for (int i = 0; i < 50; i++)
            {
                if (szamok[i] % 5 == 0 && szamok[i] % 6 == 0) db++;
 
            }
            return db;
        }

    }

}
