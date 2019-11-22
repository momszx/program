using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SocClient
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpClient client = new TcpClient("localhost", 50000);
            StreamReader r = new StreamReader(client.GetStream(), Encoding.UTF8);
            StreamWriter w = new StreamWriter(client.GetStream(), Encoding.UTF8);
            bool end = false;
            string message = r.ReadLine();
            Console.WriteLine(message);
            while (!end)
            {
                string command = Console.ReadLine();
                w.WriteLine(command);
                w.Flush();
                message = r.ReadLine();
                Console.WriteLine(message);
                if (message=="OK*")
                {
                    Console.WriteLine("Ez egy többsoros üzenet");
                    while (message != "OK!")
                    {
                        message = r.ReadLine();
                        Console.WriteLine(message);
                    }
                }
                if (command == "BYE")
                    end = true; //http://aries.ektf.hu/~ksanyi/SOP/feladatok.txt 4. feladat + ezt átírni több client-esre
            }
        }
    }
}
