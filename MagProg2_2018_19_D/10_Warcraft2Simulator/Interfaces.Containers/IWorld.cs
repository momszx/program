using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Warcraft2Simulator
{
    interface IWorld
    {
        byte Width { get; }
        byte Height { get; }

        List<IGameObject> TerritoryElements { get; }
        List<ICommunity> Communities { get; }

        void Draw(Graphics g);
        void PlayOneRound();
    }
}
