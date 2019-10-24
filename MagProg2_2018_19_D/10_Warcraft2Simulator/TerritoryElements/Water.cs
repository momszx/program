using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Warcraft2Simulator
{
    class Water : AGameObject
    {
        public Water(Point Position)
            :base(Position, Settings.Default.WaterImageSource, false)
        {

        }
    }
}
