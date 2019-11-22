using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labda
{
    class Labda
    {
        private int x;

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        private int y;

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        private ConsoleColor szin;

        public ConsoleColor Szin
        {
            get { return szin; }
            set { szin = value; }
        }

        public Labda(int x, int y, ConsoleColor szin)
        {
            this.x = x;
            this.y = y;
            this.szin=szin;
        }
        public void Mozog()
        {
            int vizszintes = 1;
            int fuggoleges = 1;
            while (true)
            {
                if (this.x == 80) vizszintes = vizszintes * -1;
                else if (this.x == 0) vizszintes = 1;
                if (this.y == 25) fuggoleges = fuggoleges * -1;
                else if (this.y == 0) fuggoleges = 1;
                lock (typeof(Console))
                {
                    Console.SetCursorPosition(this.x, this.y);
                    Console.WriteLine(" ");
                    this.x = this.x + vizszintes;
                    this.y = this.y + fuggoleges;
                    Console.ForegroundColor = this.szin;
                    Console.SetCursorPosition(this.x, this.y);
                    Console.WriteLine("*");
                    System.Threading.Thread.Sleep(10);
              }
            }
        }
    }
}
