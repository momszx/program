using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vatera2;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace VateraRTC_Szerver
{
    class Komm : Vatera2.Termékek, Vatera2.ISzolgaltatos
    {
        static List<string> szolgaltatasok = new List<string>() { "LOGIN|fnev|jelszo|" };
        static List<Vatera2.Termékek> termekek = new List<Termékek>();
        bool bejelentkezve = false;
        string felhasznalo = string.Empty;
        

        public string Bejelentkezes(string fnev, string jelszo)
        {
            throw new NotImplementedException();
        }

        public string Licit(int id, int ar)
        {
            throw new NotImplementedException();
        }

        public string Logout()
        {
            throw new NotImplementedException();
        }

        public List<Termékek> Osszestermek()
        {
            throw new NotImplementedException();
        }

        public string Peldanykero()
        {
            string id = Guid.NewGuid().ToString();
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(Komm), id,WellKnownObjectMode.Singleton);
            return id;
        }

        public List<string> Szolgaltatasok()
        {
            throw new NotImplementedException();
        }

        public string TermekHozzaAd(int termekAr, string termekNev)
        {
            throw new NotImplementedException();
        }
    }
}
