using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace TermeloEloszto
{

    class General
    {
        public int maxdb;
        public int oszt;
        public int db = 0;

        public General(int maxdb, int oszt)
        {
            this.maxdb = maxdb;
            this.oszt = oszt;
        }

        public void csinald()
        {
            while (db < maxdb)
            {
                int x = sorsol();
                Program.Hozzaad(x);
                db++;
                Program.osszsorsolt++;
            }

            lock (typeof(Program))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(oszt + "-as típusú szál leállt");
            }
        }

        public int sorsol()                 // bármelyik száltól is jut el ida, az azokhoz tartozó feltételek szerint fog számot sorsolni
        {
            int x = 0;
            do
            {
                x = Program.rnd.Next(10000, 80000);
            }
            while (x % oszt != 0);

            return x;
        }

    }

    class Program
    {
        public static Random rnd = new Random();
        public static List<int> puffer = new List<int>(20);         // feladatban volt megadva, hogy a puffer csak 20 elemű lehet
        public static int osszsorsolt = 0;
        public static int maxossz = 1200;

        static public void Hozzaad(int x)
        {
            Monitor.Enter(puffer);
            while (puffer.Count >= 20)
            {
                Monitor.Wait(puffer);
            }
            puffer.Add(x);

            Monitor.Pulse(puffer);
            Monitor.Exit(puffer);
            System.Threading.Thread.Sleep(8);
        }

        static public int Kivesz()
        {
            Monitor.Enter(puffer);
            while (puffer.Count == 0)
            {
                Monitor.Wait(puffer);
            }

            int szam = puffer[0];
            puffer.RemoveAt(0);

            Monitor.Pulse(puffer);
            Monitor.Exit(puffer);
            return szam;
        }

        static void sarganKiir()
        {
            while (osszsorsolt != Program.maxossz || puffer.Count != 0)
            {
                lock (typeof(Program))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(" " + Kivesz() + " ");
                    Console.WriteLine();
                }
                System.Threading.Thread.Sleep(18);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Az sárga szál leállt.");
        }

        static void pirosanKiir()
        {
            while (osszsorsolt != Program.maxossz || puffer.Count != 0)
            {
                lock (typeof(Program))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" " + Kivesz() + " ");
                    Console.WriteLine();
                }
                System.Threading.Thread.Sleep(18);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Az piros szál leállt.");
        }


        static void Main(string[] args)
        {
            var ottel = new General(400, 5);
            //ottel.db = 400;
            //ottel.oszt = 5;
            var ot = new Thread(ottel.csinald);

            var harommal = new General(500, 3);
            //harommal.db = 500;
            //harommal.oszt = 3;
            var harom = new Thread(harommal.csinald);

            var hettel = new General(300, 7);
            //hettel.db = 300;
            //hettel.oszt = 7;
            var het = new Thread(hettel.csinald);

            Thread sarga = new Thread(sarganKiir);
            Thread piros = new Thread(pirosanKiir);


            ot.Start();
            harom.Start();
            het.Start();
            sarga.Start();
            piros.Start();

            ot.Join();
            harom.Join();
            het.Join();
            sarga.Join();
            piros.Join();



            Console.ReadLine();


        }
    }
}