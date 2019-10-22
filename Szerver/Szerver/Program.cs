using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Configuration;
using System.Net.Sockets;
using System.IO;

namespace Szerver
{
    class Program
    {
        static void Main(string[] args)
        {
            IPHostEntry cimek = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in cimek.AddressList)
            {
                Console.WriteLine(ip);
            }
            string ipcim = ConfigurationManager.AppSettings["ip-cim"];
            int port = int.Parse(ConfigurationManager.AppSettings["port"]);

            IPAddress Address = IPAddress.Parse(ipcim);
            TcpListener listener = new TcpListener(Address, port);
            listener.Start();
            TcpClient client = listener.AcceptTcpClient();
            StreamReader sr = new StreamReader(client.GetStream(), Encoding.UTF8);
            StreamWriter sw = new StreamWriter(client.GetStream(), Encoding.UTF8);
            Console.WriteLine(ipcim+":"+port);
            sw.WriteLine("Üdv a szerveren");
            sw.Flush();
            string tagolando = sr.ReadLine();
            List<string> kliensValasz = new List<string>(tagolando.Split('|'));
            switch (kliensValasz[0])
            {
                case "OSZTAS":
                    int szam2 = Convert.ToInt32(kliensValasz[2]);
                    if (szam2==0)
                    {
                        sw.WriteLine("ERR|Nullával nem tudok osztani!");
                        sw.Flush();
                    }
                    else
                    {
                        int szam1 = Convert.ToInt32(kliensValasz[1]);
                        int vissza = szam1 / szam2;
                        sw.WriteLine("OK*|A kért eredmény|"+vissza);
                        sw.Flush();
                    }
                    break;
                case "BYE":
                    sw.WriteLine("BYE");
                    sw.Flush();
                    break;
                default:
                    sw.WriteLine("");
                    sw.Flush();
                    break;
            }


            Console.ReadLine();
        }
    }
}
