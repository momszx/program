using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Warcraft2Simulator
{
    class ACommunity : ICommunity
    {
        public ACommunity(Race Race)
        {
            this.Race = Race;
            this.creatures = new List<ICreature>();
        }

        public Race Race
        {
            get;
            private set;
        }

        private List<ICreature> creatures;
        public List<ICreature> Creatures
        {
            get { return new List<ICreature>(creatures); }
        }

        public void AddPeasant(APeasant peasant)
        {
            this.creatures.Add(peasant);
        }
        public void AddWarrior(AWarrior warrior)
        {
            this.creatures.Add(warrior);
        }

        public bool AllCreaturesDead
        {
            get
            {
                return creatures.Where(c => !c.Dead).Count() == 0;
            }
        }
    }
}
