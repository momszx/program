using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018._11._14
{
    class Program
    {
        public struct Auto
        {
            public string gyarto;
            public string tipus;
            public int tankMeret;
        }
        public struct Ember
        {
            public string neve;
            public int kor;
        }
        public struct Állatok
        {
            public string faj;
            public int labak;
        }
        static void Main(string[] args)
        {
            #region 1. F
            //List<string> nevek = new List<string>();
            //List<int> eletkor =new List<int>();
            //int versenyzoszama=1;
            //while (Console.ReadLine() != "Vége")
            //{
            //    Console.WriteLine("Add meg a {0}. versenyző nevét: ",versenyzoszama);
            //    nevek.Add(Console.ReadLine());
            //    Console.WriteLine("Add meg a {0}. versenyző életkorát: ", versenyzoszama);
            //    eletkor.Add(Convert.ToInt32(Console.ReadLine()));
            //    versenyzoszama++;
            //}
            //Console.WriteLine("Zárva");
            #endregion
            #region 2.F
            //Auto a1 = new Auto();
            //a1.gyarto = "Audi";
            //a1.tipus = "TT";
            //a1.tankMeret = 5000;

            //Auto a2 = new Auto();
            //a2.gyarto = "Mazda";
            //a2.tipus = "RX8";
            //a2.tankMeret = 45;

            //List<Auto> autok = new List<Auto>();
            //autok.Add(a1);
            //autok.Add(a2);

            //Console.WriteLine(autok[0].gyarto);
            //Console.WriteLine(autok[0].tipus);
            //Console.WriteLine(autok[0].tankMeret);
            #endregion

            #region 3.F
            //List<Ember> ember = new List<Ember>();
            //int versenyzoszama = 1;
            //while (Console.ReadLine() !="Vége")
            //{
            //    Ember e1 =new Ember();
            //    Console.WriteLine("Add meg a {0}. versenyző nevét: ",versenyzoszama);
            //    e1.neve = Console.ReadLine();
            //    Console.WriteLine("Add meg a {0}. versenyző életkorát: ", versenyzoszama);
            //    e1.kor = Convert.ToInt32(Console.ReadLine());
            //    versenyzoszama++;
            //    ember.Add(e1);
            //}

            #endregion
            #region 4.F
            List<Állatok> allat = new List<Állatok>();
            while (Console.ReadLine() !="Vége")
            {
                Állatok Á1 = new Állatok();
                Console.WriteLine("Állat faja ?");
                Á1.faj = Console.ReadLine();
                Console.WriteLine("Hány lába van?");
                Á1.labak = Convert.ToInt32(Console.ReadLine());
                

            }
            Állatok Á2 = new Állatok();
            Á2.faj = "Delfin";
            Á2.labak = 20;
            
            Console.WriteLine(Á2.faj);
            Console.WriteLine(Á2.labak);

            #endregion
            #region 5.F
            int a = 5;
            int b = 10;
            int csere = b;
            b=a;
            a = csere;
            Console.WriteLine(a);
            Console.WriteLine(b);
            #endregion
            Console.ReadLine();
        }
    }
}
