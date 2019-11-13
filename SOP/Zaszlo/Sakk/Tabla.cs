using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakk
{
    class Tabla
    {
        private ConsoleColor szin;

        public ConsoleColor Szin
        {
            get { return szin; }
            set { szin = value; }
        }

        private int[,] tabla;

        public void FelsoKitolt()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        lock (typeof(Console))
                        {

                            Console.SetCursorPosition(i + 1, j + 1);
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.WriteLine(" ");
                        }
                    }
                    
                }
            }
        }
        public void AlsoKitolt()
        {
            for (int i = 7; i >= 0; i--)
            {
                for (int j = 4; j < 8; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        lock (typeof(Console))
                        {

                            Console.SetCursorPosition(i + 1, j + 1);
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.WriteLine(" ");
                        }
                    }
                }
            }
        }
    }
}
