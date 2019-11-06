using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Kliens
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
            string[] valaszparameterei;
            bool end = false;
            while (!end)
            {
                Console.WriteLine("Hívd meg a szerver egyik szolgáltatását(INFO parancs!):");
                sw.WriteLine(Console.ReadLine());
                sw.Flush();
                valasz = sr.ReadLine();
                valaszparameterei = valasz.Split('|');
                switch (valaszparameterei[0])
                {
                    case "TERMÉKEK":

                        break;
                    case "BYE":
                        Console.WriteLine(valaszparameterei[1]);
                        end = true;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(valaszparameterei[0]);
                        Console.ResetColor();
                        break;
                }
            }
        }

    }
}
