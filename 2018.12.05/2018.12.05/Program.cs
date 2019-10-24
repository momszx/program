using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018._12._05
{
    class Program
    {

        static string viszszöveg(string szöveg)
        {
            
            string segéd = "";
            for (int i = szöveg.Length-1; i >=0; i--)
            {
                segéd += szöveg[i];

            }
            return segéd;
        }
        static void kiírás(string[] szövegek)
        {
            for (int i = 0; i < szövegek.Length; i++)
            {
                if (szövegek[i].Length == 5)
                {
                    return;
                }
                Console.WriteLine(szövegek[i]);
            }
        }
        static void Kiir(int a)
        {
            return;
            
        }
        static void Novel(int a)
        {
            a += 1;
            Console.WriteLine(a);
        }
        static void Main(string[] args)
        {
            
            string[] szövegek = new string[51];
            
            for (int i = 0; i < 50; i++)
            {
                szövegek[i] = "cica";
            }
            szövegek[51] = "cicááák";

            string szöveg = "alma";
            viszszöveg(szöveg);
            

            Console.WriteLine();
            string szöveg2 = "márk";
            szöveg2 = szöveg2.ToUpper();

            char kicsi = 'a';
            string nagy = kicsi.ToString().ToUpper();


            Console.ReadLine();
        }
    }
}
