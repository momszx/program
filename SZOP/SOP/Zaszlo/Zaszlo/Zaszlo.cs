using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaszlo
{
    class Zaszlo
    {
        Random rnd = new Random();
        private int y1;

        public int Y1
        {
            get { return y1; }
            set { y1 = value; }
        }
        private int y2;

        public int Y2
        {
            get { return y2; }
            set { y2 = value; }
        }

        private ConsoleColor szin;

        public ConsoleColor Szin
        {
            get { return szin; }
            set { szin = value; }
        }

        private int csillagokszama;

        public int Csillagokszama
        {
            get { return csillagokszama; }
            set { csillagokszama = value; }
        }
        public Zaszlo(int y1,int y2,ConsoleColor szin, int csillagokszama)
        {
            this.y1 = y1;
            this.y2 = y2;
            this.szin = szin;
            this.csillagokszama=csillagokszama;
        }

        public void Kirajzol()
        {
            for (int i = 0; i < csillagokszama; i++)
            {
                lock (typeof(Console))
                {
                    Console.ForegroundColor = this.szin;
                    Console.SetCursorPosition(rnd.Next(0, 80), rnd.Next(this.y1, this.y2));
                    Console.WriteLine("*");
                }
            }
        }
    }
}
