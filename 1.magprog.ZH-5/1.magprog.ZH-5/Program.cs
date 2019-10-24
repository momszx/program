using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.magprog.ZH_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérlek add meg az éves cég jövedelmet ");
            int ev = Convert.ToInt32(Console.ReadLine());
            int havi = ev / 12;
            if (havi >= 250000 * 3)
            {
                Console.WriteLine("rész vehet a cég a kurzuson");

            }
            else
            {
                Console.WriteLine("Nem vehet részt ");
            }
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("kérlek add meg a vezeték neved");
            string vez = Console.ReadLine();
            Console.WriteLine("kérlek add meg a kereszt neved");
            string ker = Console.ReadLine();
            Console.WriteLine("kérlek add meg a kereszt korod");
            int kor = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < kor; i++)
            {
                Console.WriteLine("{0} {1} :[{2}]", vez, ker, kor);
            }
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Hány fok van ? ");
            int fok = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < i + 1; i++)
            {
                if (fok < -40 || fok > 40)
                {
                    Console.WriteLine("Hány fok van ? ");
                    fok = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    break;
                }
            }
            if (fok >= -40 && fok <= 0)
            {
                Console.WriteLine("gyááá hideg van ");
            }
            else if (fok >= 1 && fok <= 15)
            {
                Console.WriteLine("pulcsi");
            }
            else if (fok >= 16 && fok <= 25)
            {
                Console.WriteLine("jóóó idő");
            }
            else if (fok >= 26 && fok <= 40)
            {
                Console.WriteLine("meleg van ");
            }
            Console.ReadLine();
            Console.Clear();
            string[] szoveg = new string[5];
            Console.WriteLine("kérlek add meg az első szót");
            szoveg[0] = Console.ReadLine();
            for (int i = 1; i < 5; )
            {
                Console.WriteLine("Kérlek add meg a "+(i+1)+" elemet");
                szoveg[i] = Console.ReadLine();
                if (szoveg[0].Length > szoveg[i].Length)
                {
                    Console.WriteLine("Hiba");
                    Console.WriteLine("Kérlek add meg a " + (i+1) + " elemet");
                    szoveg[i] = Console.ReadLine();
                }
                else i++;
                    
            }
            Console.WriteLine("k");

            int[] szamok = new int[5];
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                szamok[i] = rnd.Next(49, 101);
            }
            Console.WriteLine(szamok[0]+" "+ szamok[1] + " " + szamok[2] + " " + szamok[3] + " " + szamok[4] );
            Console.WriteLine(szamok.Max());






            Console.ReadLine();
        }
    }
}
