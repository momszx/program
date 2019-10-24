using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_WinFormWarcraft
{
    public class Orc
    {
        private Orc()
        {
            this.Health = 100;
            this.Councilor = false;
            this.Damage = 20;
        }
        public Orc(uint Id, string Name)
            : this()
        {
            this.Id = Id;
            this.Name = Name;
        }
        public Orc(uint Id, string Name, bool Councilor)
            : this(Id, Name)
        {
            this.Councilor = Councilor;
        }
        public Orc(uint Id, string Name,
            int Health, int Damage)
            : this(Id, Name)
        {
            this.Health = Health;
            this.Damage = Damage;
        }

        public uint Id { get; private set; }

        //Legalább 2 tagból áll
        //Elmentés "név" formátumban történjen
        //"TROLL EDE".Split(' ') -> string[] {"TROLL", "EDE"}
        private string name;
        public string Name
        {
            set
            {
                if (!value.Contains(' '))
                    throw new Exception("Hibás név formátum!");
                string[] tagok = value.Split(' ');
                StringBuilder sb = new StringBuilder();
                int t = 0;
                foreach (string tag in tagok)
                {
                    sb.Append(tag[0].ToString().ToUpper());
                    for (int i = 1; i < tag.Length; i++)
                        sb.Append(tag[i].ToString().ToLower());
                    if (t != tagok.Length - 1)
                        sb.Append(' ');
                    t++;
                }
                name = sb.ToString();
            }
            get { return name; }
        }

        //nem mehet 100 fölé
        //Ha 0 alá esik, akkor is 0-t mentünk el
        public int Health { get; set; }

        public bool Dead
        {
            get
            {
                return this.Health <= 0;
            }
        }

        //20 és 45 közötti érték
        public int Damage { get; set; }

        //Ha valakit megválasztanak, akkor az már
        //nem léphet ki a tanácsból
        private bool councilor;
        public bool Councilor
        {
            set
            {
                if (councilor)
                    throw new Exception("Hiba: Ő már tag!");

                if (!councilor)
                    councilor = value;
            }
            get
            {
                return councilor;
            }
        }
    }
}
