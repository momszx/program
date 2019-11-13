using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzalkezelesAlapok3
{
    class Program
    {
        private ConsoleColor Color;

        public ConsoleColor color
        {
            get { return Color; }
            set { Color= value; }
        }

        private string nev;

        public string Nev
        {
            get { return nev; }
            set { nev = value; }
        }
        public void Kiir()
        {
            Console.ForegroundColor = this.color;
            Console.WriteLine(this.nev);
        }

        static void Main(string[] args)
        {
        }
    }
}
