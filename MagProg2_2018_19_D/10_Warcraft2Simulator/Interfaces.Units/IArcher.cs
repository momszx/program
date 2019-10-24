using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Warcraft2Simulator
{
    interface IArcher : ICreatureMovable, IWarrior
    {
        byte BowNumbers { get; set; }
        byte BowRange { get; }

        void Shoot(ICreature Creature);
    }
}
