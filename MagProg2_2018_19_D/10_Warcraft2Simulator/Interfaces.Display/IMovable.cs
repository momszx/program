using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Warcraft2Simulator
{
    interface IMovable : IGameObject
    {
        byte MovementSpeed { get; }
        IWorld World { get; }

        void Move();
    }
}
