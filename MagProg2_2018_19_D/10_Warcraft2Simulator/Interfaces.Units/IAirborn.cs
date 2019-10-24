using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Warcraft2Simulator
{
    interface IAirborn : ICreatureFlying
    {
        byte ShootRange { get; }

        void Shoot(ICreature Creature);
    }
}
