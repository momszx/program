using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Neptun_Kontener
{
    class Egyetem
    {
        private static uint Id = 1;
        private static uint NeptunkodHossz = 6;
        private static string ABC = "0123456789QWERTZUIOPASDFGHJKLYXCVBNM";
        private Random rnd = new Random();

        public Egyetem()
        {
            //this.Id = 1;
            this.hallgatok = new List<Hallgato>();
        }

        private List<Hallgato> hallgatok;
        public List<Hallgato> Hallgatok
        {
            get
            {
                //List<Hallgato> temp = new List<Hallgato>();
                //foreach (Hallgato hallgato in hallgatok)
                //    temp.Add(hallgato);
                //return temp;
                return new List<Hallgato>(hallgatok);
            }
        }
        private List<string> Neptunkodok
        {
            get
            {
                List<string> temp = new List<string>();
                foreach (Hallgato hallgato in hallgatok)
                    temp.Add(hallgato.Neptunkod);
                return temp;
            }
        }

        public void AddHallgato(string Nev, DateTime SzuletesiDatum)
        {
            this.hallgatok.Add(
                new Hallgato(Id, GenerateUniqueNeptunkod(),
                    Nev, SzuletesiDatum));
            Id++;
        }

        private string GenerateNeptunkod()
        {
            StringBuilder nk = new StringBuilder();
            nk.Append(ABC[rnd.Next(10, ABC.Length)]);
            for (int i = 0; i < NeptunkodHossz - 1; i++)
                nk.Append(ABC[rnd.Next(ABC.Length)]);
            return nk.ToString();
        }
        private string GenerateUniqueNeptunkod()
        {
            string neptKod;
            do
            {
                neptKod = GenerateNeptunkod();
            } while (Neptunkodok.Contains(neptKod));
            return neptKod;
        }
    }
}
