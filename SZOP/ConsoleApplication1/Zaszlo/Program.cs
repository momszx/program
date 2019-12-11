using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Zaszlo
{
    class Pontok
    {
        class szinesSav
        {
            static Random rnd = new Random();
            public ConsoleColor szine;
            public int y1;
            public int y2;
            public int db;

            public szinesSav(ConsoleColor szine, int y1, int y2, int db)
            {
                this.szine = szine;
                this.y1 = y1;
                this.y2 = y2;
                this.db = db;

            }

            public void kirajzol()
            {
                for (int i = 0; i < db; i++)
                {
                    int x = rnd.Next(0, 80);
                    int y = rnd.Next(y1, y2);
                    lock (typeof(Program))
                    {
                        Console.ForegroundColor = szine;
                        Console.SetCursorPosition(x, y);
                        Console.Write('*');
                    }
                }
            }
        }

        class Program
        {
            static void Main(string[] args)
            {

                szinesSav p1 = new szinesSav(ConsoleColor.Red, 0, 7, 1500000);
                szinesSav p2 = new szinesSav(ConsoleColor.White, 7, 14, 1500000);
                szinesSav p3 = new szinesSav(ConsoleColor.Green, 14, 21, 1500000);

                //p1.kirajzol();
                //p2.kirajzol();
                //p3.kirajzol();

                Thread.Sleep(2000);
                //Console.Clear();

                Thread t = new Thread(p1.kirajzol);
                Thread t2 = new Thread(p2.kirajzol);
                Thread t3 = new Thread(p3.kirajzol);
                t.Start();
                t2.Start();
                t3.Start();

                t.Join();
                t2.Join();
                t3.Join();

                Console.ReadLine();
            }
        }
    }
}
