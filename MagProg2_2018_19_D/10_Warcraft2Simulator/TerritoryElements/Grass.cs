﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Warcraft2Simulator
{
    class Grass: AGameObject
    {
        public Grass(Point Position)
            :base(Position, Settings.Default.GrassImageSource, true)
        {

        }
    }
}
