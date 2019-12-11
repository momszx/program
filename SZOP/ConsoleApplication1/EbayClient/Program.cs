using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;

namespace EbayClient
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpClient list = new TcpClient("127.0.0.1", 5000);
            StreamReader read = new StreamReader(list.GetStream(), Encoding.UTF8);
            StreamWriter write = new StreamWriter(list.GetStream(), Encoding.UTF8);
            Console.WriteLine("Successfull connection");
            string message = read.ReadLine();
            string command, answer;
            Console.WriteLine("Server message: {0}", message);
            while (true)
            {
                command = Console.ReadLine();
                write.WriteLine(command);
                write.Flush();
                answer = read.ReadLine();
                if (answer == "OK*") {
                    Console.WriteLine(answer);
                    while (answer != "OK!")
                    {
                        answer = read.ReadLine();
                        Console.WriteLine(answer);
                    }
                }
                else Console.WriteLine(answer);
                if (answer == "BYE") break;
            }
        }
    }
}
