using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logika2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("x pozitív literál");
            Console.WriteLine("- negatív literál");
            Console.WriteLine("x nem fordul elő a változó");
            Console.WriteLine("4 karakterből álljon.");
            
          
            bool c1e = true;
            bool c2e = true;
            string c1 = Console.ReadLine();
            while (!(c1.Length == 4))
            {
                Console.WriteLine("Nem jó hossz");
                c1 = Console.ReadLine();
                
            }
            Console.WriteLine("Adja meg a másodikat.");
            string c2 = Console.ReadLine();
            while (!(c2.Length == 4))
            {
                Console.WriteLine("Nem jó hossz");
                c2 = Console.ReadLine();

            }
            foreach (char c in c1)
            {
           
                    if (!(c == '+') && !(c == '-') && !(c == 'x'))
                {
                    Console.WriteLine("Hiba");
                    c1e = false;
                    break;
                    }

            }
            foreach (char c in c2)
            {
                if (!(c == '+') && !(c == '-') && !(c == 'x'))
                {

                    c2e = false;
                    Console.WriteLine("Hiba");
                    break;
                 
                }
              
            }
            int db = 0;//ellentétes literál párok száma
            for (int i = 0; i < c1.Length; i++)
            {
                if ((c2[i] == '-' && c1[i] == '+') || (c1[i] == '-' && c2[i] == '+'))
                {
                    db++;
                }
            }
            if (db >= 2 || !c1e || !c2e)
            {
                Console.WriteLine("Rezolucio nem lehetséges");

            }
            else
            {


                //ha lehetséges , akkor kell a helye , melyik indegyen van az ellentétes literál pár

                string R = "";
                //resolucio
                for (int i = 0; i < c1.Length; i++)
                {



                    if (c1[i].Equals(c2[i]))
                    {
                        R += c1[i];
                    }
                    else if (c1[i].Equals("x"))
                    {
                        R += c2[i];
                    }
                    else if (c2[i].Equals("x"))
                    {
                        R += c1[i];
                    }
                    else if (!(c1[i].Equals(c2[i])))
                    {
                        R += "x";
                    }
                }

                Console.WriteLine(" A Resolvens:{0}", R);
            }
            Console.ReadLine();
        }
    }
}
