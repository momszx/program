using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Configuration;
using System.Net.Sockets;
using System.IO;

namespace Kliens
{
    class Program
    {
        static void Main(string[] args)
        {
            string ipcim = ConfigurationManager.AppSettings["ip-cim"];
            int port = int.Parse(ConfigurationManager.AppSettings["port"]);
            TcpClient client = new TcpClient(ipcim, port);
            StreamWriter sw = new StreamWriter(client.GetStream(), Encoding.UTF8);
            StreamReader sr = new StreamReader(client.GetStream(), Encoding.UTF8);
            Console.WriteLine(sr.ReadLine());
            sw.WriteLine(Console.ReadLine());
            sw.Flush();
            string tagolando = sr.ReadLine();
            
            List<string> szerverValasz = new List<string>(tagolando.Split('|'));
            switch (szerverValasz[0])
            {
                case "OK":
                    Console.WriteLine("OK");
                    break;
                case "ERR":
                    Console.WriteLine("ERR|"+szerverValasz[1]);
                    
                    break;
                case "OK*":
                    Console.WriteLine(szerverValasz[1]);
                    Console.WriteLine(szerverValasz[2]);
                    break;
                case "BYE":
                    Console.WriteLine("Kilépés");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fatal Error");
                    for (int i = 0; i < 10; i++)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    break;
            }
            Console.ReadLine();
        }
    }
}
