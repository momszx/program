using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Sockets;

namespace KliensZH
{
    class Komm
    {
        StreamReader sr = null;
        StreamWriter sw = null;
        TcpClient kliens = null;

        public Komm(TcpClient kapcs)
        {
            kliens = kapcs;
            sr = new StreamReader(kliens.GetStream(), Encoding.UTF8);
            sw = new StreamWriter(kliens.GetStream(), Encoding.UTF8);
        }


        public void KommKezd()
        {
            Console.WriteLine(sr.ReadLine());
            string valasz = string.Empty;
            bool end = false;
            while (!end)
            {
                Console.WriteLine("Hívd meg a szerver egyik szolgáltatását(INFO parancs!):");
                sw.WriteLine(Console.ReadLine());
                sw.Flush();
                valasz = sr.ReadLine();
                switch (valasz)
                {
                    case "POSTOK":
                        while (!(valasz == null))
                        {
                            Console.WriteLine(valasz[1]);
                            Console.WriteLine(valasz[2]);
                            Console.WriteLine(valasz[3]);
                            Console.WriteLine(valasz[4]);
                            Console.WriteLine(valasz[5]);
                        }
                        break;


                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(valasz);
                        Console.ResetColor();
                        break;
                }
            }
        }
    }
}
