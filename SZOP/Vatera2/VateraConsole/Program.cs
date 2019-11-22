using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VateraConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Info;
            List<Vatera2.Termékek> termekek;
            Vatera2.ISzolgaltatos szolga = (Vatera2.ISzolgaltatos)Activator.GetObject(typeof(Vatera2.ISzolgaltatos), "tcp:\\127.0.0.1:1111");
            string id = szolga.Peldanykero();
            Vatera2.ISzolgaltatos egyedi = (Vatera2.ISzolgaltatos)Activator.GetObject(typeof(Vatera2.ISzolgaltatos), "tcp:\\127.0.0.1:1111");
            bool vege = false;
            string[] atm;
            string keres;
            while (!vege)
            {
                Console.WriteLine("Hívja meg a szolgaltatasat");
                keres = Console.ReadLine();
                atm = keres.Split('|');
                switch (atm[0])
                {
                    case "INFO":
                        Info = egyedi.Szolgaltatasok();
                        for (int i = 0; i < Info.Count; i++)
                        {
                            Console.WriteLine(Info[i]);
                        }
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
