using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Warcraft2Simulator
{
    interface IDrawable
    {
        string ImageSource { get; }
        Rotation Rotation { get; set; }

        void Display(Graphics g);
    }
}
