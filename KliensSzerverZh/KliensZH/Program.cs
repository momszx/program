﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Configuration;

namespace KliensZH
{
    class Program
    {
        static void Main(string[] args)
        {
            string ip = ConfigurationManager.AppSettings["IP"];
            int port = int.Parse(ConfigurationManager.AppSettings["PORT"]);

            TcpClient csatlakozas = new TcpClient(ip, port);
            Komm beszelgetes = new Komm(csatlakozas);
            beszelgetes.KommKezd();
            Console.ReadLine();
        }
    }
}
