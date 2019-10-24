using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018._11._21
{
    class Program
    {
        public class PC
        {
            public int RAM;
            public string ProciTipus;
        }
        static Random rnd = new Random();
        public enum napok
        {
            Hétfő,Kedd,Szerda,Csütörtök,Péntek,Szombat,Vasárnap
        }
        static void üdvözlés()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("Üdvözöllek a programban");
            Console.WriteLine("-----------------------");
        }
        static void elköszönés()
        {
            Console.WriteLine("---------");
            Console.WriteLine("Csáóóóóóó");
            Console.WriteLine("---------");
        }
        static void TombKiíras(int[] tomb)
        {

        }
            
        static void Main(string[] args)
        {
            #region 1F
            //List<PC> gépek = new List<PC>();
            
            //for (int i = 0; i < 5; i++)
            //{
            //    PC atm = new PC();
            //    atm.RAM = rnd.Next(1, 17);
            //    atm.ProciTipus = "-";
            //    gépek.Add(atm);
            //}

            #endregion
            #region 2
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("{0}. gépnek {1} GB Ramja van és {2} processzora " ,i+1,gépek[i].RAM, gépek[i].ProciTipus);
            //}
            #endregion
            //Console.WriteLine("");
            #region 3
            //int szamlaló = 1;
            //foreach  (PC p in gépek)
            //{
            //    Console.WriteLine("{0}. gépnek {1} GB Ramja van és {2} processzora  ", szamlaló, p.RAM, p.ProciTipus);
            //    szamlaló++;
            //}
            #endregion
            //Console.WriteLine("");
            #region 4
            //for (int i = 0; i < 5; i++)
            //{
            //    gépek[i].RAM = gépek[i].RAM * 2;
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("{0}. gépnek {1} GB Ramja van és {2} processzora ", i + 1, gépek[i].RAM, gépek[i].ProciTipus);
            //}
            #endregion
            //Console.WriteLine("");
            #region 5
            //napok maiNap = napok.Szerda;
            //napok fasit = (napok)4;
            //napok véletlen = (napok)rnd.Next(1, 7);
            //Console.WriteLine(maiNap);
            //Console.WriteLine(fasit);
            //Console.WriteLine(véletlen);
            //if (véletlen == napok.Hétfő) Console.WriteLine("Hétfő van");
            //else Console.WriteLine("Nem Hétfő van ");
            
            #endregion
            #region 6
            üdvözlés();
            int[] tomb = new int[] { 1, 2, 3 };
            for (int i = 0; i < tomb.Length; i++)
            {
                if (i == tomb.Length - 1)
                {
                    Console.WriteLine(tomb[i]);
                }
                else
                {
                    Console.Write(tomb[i] + ",");
                }

            }
            int[] tomb2 = new int[] { 32, 15, 132,1,8643,21,68432,1 };
            TombKiíras(tomb2);
            

            elköszönés();
#endregion 


            Console.ReadLine();
        }
    }
}
