using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Warcraft2Simulator
{
    class APeasant : ACreatureMovable, IPeasant
    {
        public APeasant(Point Position, string ImageSource, byte HitPoints,
            Race Race, IWorld World)
            :base(Position, ImageSource, Rotation.NORTH,
            Settings.Default.APeasantMaxHitPoints, HitPoints, 
            Settings.Default.APeasantArmor, Race, 
            Settings.Default.APeasantMovementSpeed, World)
        {

        }
    }
}
