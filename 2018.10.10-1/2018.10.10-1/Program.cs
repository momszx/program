using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018._10._10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //int[] szamok = new int[3];
            //szamok[0] = 15;
            //szamok[1] = 20;
            //szamok[2] = 25;

            //Console.WriteLine(" 0. index {0} | 1. index: {1} | 2.  index : {2}",
            //szamok[0],szamok[1],szamok[2]);
            #endregion
            #region
            //string[] nevek = new string[4];
            //Console.WriteLine(" Add meg az 1. nevet");
            //nevek[0] = Console.ReadLine();

            //Console.WriteLine(" Add meg az 2. nevet");
            //nevek[1] = Console.ReadLine();

            //Console.WriteLine(" Add meg az 3. nevet");
            //nevek[2] = Console.ReadLine();

            //Console.WriteLine(" Add meg az 4. nevet");
            //nevek[3] = Console.ReadLine();

            //Console.Write("1. név {0}",nevek[0]);

            //Console.Write(" | 2. név {0}", nevek[1]);

            //Console.Write(" | 3. név {0}", nevek[2]);

            //Console.Write(" | 4. név {0}", nevek[3]);
            #endregion
            #region
            //int[] szamok = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //Console.WriteLine("A legkissebb eleme: " +szamok.Min());
            //Console.WriteLine("A legkissebb eleme: " +szamok.Max());
            //Console.WriteLine("Az elemek összege: " + szamok.Sum());
            //Console.WriteLine("Hány elemű a tömb: " +szamok.Length);
            #endregion
            #region
            //Console.WriteLine("Add meg a max számot");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.Clear;
            //for (int i = 0; i < a; i++)
            //{

            //    for (int j = 0; j < a; j++)
            //    {
            //        int[] proba = new int[a];
            //        proba[j] = i;
            //        Console.WriteLine(proba[j]);
            //        break;
            //    }

            //}
            #endregion
            #region
            //int szum = 0;
            //for (int i = 0; i < 101; i++)
            //{
            //    szum += i;
            //}
            //Console.WriteLine("A 1. 100 szám összege: " + szum);
            #endregion
            #region
            //int a = 0;
            //int b = 1;
            //Console.Write("{0},{1},", a, b);

            //int c = a + b;
            //for (int i = 0; i < i + 1; i++)
            //{
            //    a = b;
            //    b = c;

            //    c = a + b;
            //    Console.Write("{0},", c);
            //}
            #endregion
            #region
            //int i = 0;
            //while (i < i+1) 
            //{
            //    Console.WriteLine("|");
            //    Console.WriteLine("o");
            //    Console.WriteLine(i);
            //}
            #endregion
            #region
            int a = 3;
            int b = 7;
            Console.Write(a + " " + b + " ");

            int c = 0;
            int i = 3;

            while ( i <8)
            {
                if (i % 2 == 0)
                {
                    c = (a - b) * 2;
                }
                else
                {
                    c = (a + b) / 2;
                }
                a = b;
                b = c;
                Console.Write(c + " ");
                i++;
            }
            #endregion
            Console.ReadLine();
        }
    }
}
