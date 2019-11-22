using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Socket1
{

    class Product
    {
        string code;
        string name;
        int price;
        string user;
        public Product(string c, string n, int p)
        {
            this.code = c;
            this.name = n;
            this.price = p;
        }
        public string Code
        {
            get { return this.code; }
        }

        public string Name
        {
            get { return this.name; }
        }
        public int Price
        {
            get { return this.price; }
        }
        public string User
        {
            get { return this.user; }
            set { this.user = value; }
        }
    }
    class ClientCom
    {
        StreamReader r = null;
        StreamWriter w = null;
        static List<Product> product = new List<Product>();
        string User = null;
        public ClientCom(TcpClient client)
        {
            r = new StreamReader(client.GetStream(), Encoding.UTF8);
            w = new StreamWriter(client.GetStream(), Encoding.UTF8);
        }
        public void CommStart()
        {
            w.WriteLine("Vatera Server v1.1");
            w.Flush();
            bool end = false;
            while (!end)
            {
                string command = r.ReadLine(); 
                string[] temp = command.Split('|');
                switch (temp[0])
                {
                    case "LIST": List(); break;
                    case "LOGIN": Login(temp[1], temp[2]);  break;
                    case "ADD": Add(temp[1], temp[2], int.Parse(temp[3])); break;
                    case "LICIT": Licit(temp[1], int.Parse(temp[2]));break;
                    case "BYE": end = true; w.WriteLine("BYE"); break;
                    default: w.WriteLine("ERR|Unknown command"); break;
                }
                w.Flush();
            }
        }
        void List()
        { 
            w.WriteLine("OK*");
            lock (product)
            {
                foreach (Product temp in product)
                    w.WriteLine(temp.Code + " " + temp.Name + " " + temp.Price.ToString() + " " + temp.User);
            }
            w.WriteLine("OK!");
        }
        void Login(string name, string passwd)
        {
            w.WriteLine("OK"); //Biztos jó a név és a jelszó..
            this.User = name;
        }

        void Add(string c, string n, int price)
        { 
           //Benne van-e már a listában? Ha nincs akkor felvisszük
            if (this.User == null)
                w.WriteLine("ERR|Log in, please");
            else
            {
                lock (product)
                {
                    int i = 0;
                    for (i = 0; i < product.Count && c != product[i].Code; i++) ;
                    if (i >= product.Count)
                    {
                        Product p = new Product(c, n, price);
                        p.User = this.User;
                        product.Add(p);
                        w.WriteLine("OK");
                    }
                    else
                        w.WriteLine("ERR|Already exist");
                }
            }
        }
        void Licit(string c, int price)
        {
            if (this.User == null)
                w.WriteLine("ERR|Log in, please");
            else
            {
                lock (product)
                {
                    int i = 0;
                    for (i = 0; i < product.Count && c != product[i].Code; i++) ;
                    if (i < product.Count) //megtaláltuk
                    {
                        if (price < product[i].Price)
                            w.WriteLine("ERR|Low bid");
                        else
                        {
                            Product temp = new Product(product[i].Code, product[i].Name, price);
                            temp.User = this.User;
                            product.RemoveAt(i);
                            product.Add(temp);
                            w.WriteLine("OK");
                        }
                    }
                }
            }
        }
    }
    class Program
    {
        static string ipadd = "127.0.0.1";
        static int port = 50000;
        static IPAddress ip = null;
        static TcpListener list = null;
           
        static void Comm()
        {
            while (true)
            {
                TcpClient client = list.AcceptTcpClient();
                ClientCom cl1 = new ClientCom(client);
                Thread t1 = new Thread(cl1.CommStart);
                t1.Start();
            }
        }
        static void Main(string[] args)
        {
            ip=IPAddress.Parse(ipadd);
            list = new TcpListener(ip, port);
            list.Start();
            Comm();
            Console.WriteLine("Ennyi volt");
        }
    }
}

/*
 * 
 * 1. 1x-re ehy kliens tud kiszolgálni: a. N. Fibo. b. N darab Fibo. c. Számjegyek összegét adja vissza.
 * 2- TM feladat. Korábbit felhasználva kell megcsináli
 * 3- Az első feladatot kell átírni több kliensre. 
 * */
