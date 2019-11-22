using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace TermeloFOgyaszto
{
    class Program
    {
        static public List<int> puffer = new List<int>();
        static public int counter = 400;
        static public int eddigvolt = 0;

        static public Random rnd = new Random();

        static void Main(string[] args)
        {
            Termelo t1 = new Termelo(3, 200);
            Termelo t2 = new Termelo(5, 100);
            Termelo t3 = new Termelo(7, 100);

            Thread szal1 = new Thread(t1.Termel);
            Thread szal2 = new Thread(t2.Termel);
            Thread szal3 = new Thread(t3.Termel);
            szal1.Start();
            szal2.Start();
            szal3.Start();

            Fogyaszto f1 = new Fogyaszto(ConsoleColor.Red);
            Fogyaszto f2 = new Fogyaszto(ConsoleColor.Yellow);
            Fogyaszto f3 = new Fogyaszto(ConsoleColor.Green);

            Thread szal4 = new Thread(f1.Fogyaszt);
            Thread szal5 = new Thread(f2.Fogyaszt);
            Thread szal6 = new Thread(f3.Fogyaszt);

            szal4.Start();
            szal5.Start();
            szal6.Start();
            szal4.Join();
            szal5.Join();
            szal6.Join();
            Console.ReadLine();
        }
    }

    class Termelo
    {
        public int db;

        public int oszthato;
        public Termelo(int n, int m)
        {
            oszthato = n;
            db = m;
        }

        public void Termel()
        {
            for (int i = 0; i < db; i++)
            {
                Monitor.Enter(Program.puffer);
                while (Program.puffer.Count >= 100)
                {
                    Monitor.Wait(Program.puffer);
                }
                int g = Program.rnd.Next(10000, 80000);
                while (g % oszthato == 0)
                {
                    g = Program.rnd.Next(10000, 80000);
                }
                int sleep = Program.rnd.Next(1, 5);
                Thread.Sleep(sleep);
                Program.puffer.Add(g);
                Monitor.Pulse(Program.puffer);
                Monitor.Exit(Program.puffer);

            }
            Console.WriteLine("A {0}-as szál leállt.", this.oszthato);
        }
    }

    class Fogyaszto
    {
        ConsoleColor c;
        public Fogyaszto(ConsoleColor c)
        {
            this.c = c;
        }

        public void Fogyaszt()
        {

            while (Program.counter > Program.eddigvolt)
            {
                Program.eddigvolt++;
                Monitor.Enter(Program.puffer);
                while (Program.puffer.Count == 0)
                {
                    Monitor.Wait(Program.puffer);
                }
                Console.ForegroundColor = c;
                Console.WriteLine(Program.puffer[0]);
                Program.puffer.RemoveAt(0);
                this.FejreszKiir();
                int sleep = Program.rnd.Next(3, 8);
                Thread.Sleep(sleep);
                Monitor.Pulse(Program.puffer);
                Monitor.Exit(Program.puffer);

            }

            Console.WriteLine("Fogyasztó szál leállt.");
        }

        public void FejreszKiir()
        {
            if (Program.puffer.Count == 0)
                Console.Title = "Üres";
            else
            {
                if (Program.puffer.Count >= 100)
                    Console.Title = Program.puffer.Count.ToString();
                //Console.Title = "Teli";
                else
                    Console.Title = Program.puffer.Count.ToString();
            }
        }
    }

}