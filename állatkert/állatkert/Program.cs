using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace állatkert
{
    class Program
    {
        public struct allat
        {
            public string Fajtálya;
            public string Neve;
            public int Szül;
            public bool betegE;
        }
        static void Main(string[] args)
        {
            List<allat> allatok = new List<allat>();

            allat állat = new allat();
            állat.Fajtálya = "Tigris";
            állat.Neve = "Sirkán";
            állat.Szül = 1967;
            állat.betegE = false;
            allatok.Add(állat);

            
            állat.Fajtálya = "Tigris";
            állat.Neve = "Cirmi";
            állat.Szül = 2004;
            állat.betegE = false;
            allatok.Add(állat);


            állat.Fajtálya = "Zsiráf";
            állat.Neve = "Malman";
            állat.Szül = 2005;
            állat.betegE = false;
            allatok.Add(állat);


            állat.Fajtálya = "Zebra";
            állat.Neve = "Marty";
            állat.Szül = 2005;
            állat.betegE = true;
            allatok.Add(állat);


            állat.Fajtálya = "Viziló";
            állat.Neve = "Glória";
            állat.Szül = 2005;
            állat.betegE = true;
            allatok.Add(állat);

            Random rnd = new Random();


            állat.Fajtálya = "Pingvin";
            állat.Neve = "Tobi";
            állat.Szül = rnd.Next(1,2018);
            állat.betegE = Convert.ToBoolean(rnd.Next(0,1));
            allatok.Add(állat);

            
            for (int i = 0; i < allatok.Count; i++)
            {
                
                allat tmp = allatok[i];
                tmp.Szül++;
                allatok[i] = tmp;

            }
            Console.WriteLine(allatok.Count);
            for (int i = 0; i < allatok.Count; i++)
            {
                // sajna nem tudtam megcsinálni a legidősebbest :/
            }
            int szamlaló = 0;
            for (int i = 0; i < allatok.Count; i++)
            {
                
                if ((Convert.ToInt32(DateTime.Now.ToString("yyyy"))- allatok[i].Szül) >= 20)
                {
                    szamlaló++;
                    
                }
            }
            Console.WriteLine(szamlaló);
            for (int i = 0; i < allatok.Count; i++)
            {
                if (allatok[i].Neve.Length >= 5)
                {
                    Console.WriteLine(allatok[i].Neve);
                }
            }
            allat csere = allatok[5];
            allat csere2 = allatok[0];
            allatok[5] = csere;
            allatok[0] = csere2;
            for (int i = 0; i < allatok.Count; i++)
            {
                Console.Write("");
                if (allatok[i].betegE == false)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("{0} , ", allatok[i].betegE);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("{0} , ", allatok[i].betegE);
                }
                
            }


            Console.ReadLine();
        }
    }
}
