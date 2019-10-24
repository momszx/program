using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Warcraft2Simulator
{
    interface IGameObject : IDrawable
    {
        Point Position { get;  }
        bool Traversable { get; }
    }
}
