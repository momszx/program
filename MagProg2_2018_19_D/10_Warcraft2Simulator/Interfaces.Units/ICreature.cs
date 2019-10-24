using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Warcraft2Simulator
{
    interface ICreature : IGameObject
    {
        byte MaxHitPoints { get; }
        byte HitPoints { get; }
        byte Armor { get; }
        bool Dead { get; }
        Race Race { get; }

        void Hurt(byte HitPoints);
    }
}
