using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Warcraft2Simulator
{
    class Peon: APeasant
    {
        public Peon(Point Position, byte HitPoints, IWorld World)
            :base(Position, Settings.Default.PeonImageSource, 
            HitPoints, Race.ORC, World)
        {

        }
    }
}
