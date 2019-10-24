using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Warcraft2Simulator
{
    class Peasant : APeasant
    {
        public Peasant(Point Position, byte HitPoints, IWorld World)
            :base(Position, Settings.Default.PeasantImageSource, 
            HitPoints, Race.HUMAN, World)
        {

        }
    }
}
