using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Warcraft2Simulator
{
    abstract class AWarrior : ACreatureMovable, IWarrior
    {
        public AWarrior(Point Position, string ImageSource, byte HitPoints,
            Race Race, IWorld World)
            :base(Position, ImageSource, Rotation.NORTH,
             Settings.Default.AWarriorMaxHitPoints,
             HitPoints, Settings.Default.AWarriorArmor,
            Race, Settings.Default.AWarriorMovementSpeed, World)
        {
            this.BasicDamage = Settings.Default.AWarriorDamage;
            this.Range = Settings.Default.AWarriorRange;
        }

        public byte BasicDamage
        {
            get;
            private set;
        }

        public byte Range
        {
            get;
            private set;
        }

        public byte SecondaryAttack
        {
            get;
            private set;
        }

        public void Attack(ICreature Creature)
        {
            if (Math.Abs(Creature.Position.X - this.Position.X) > Range ||
                Math.Abs(Creature.Position.Y - this.Position.Y) > Range)
                throw new Exception("...");
            if (this.Race == Creature.Race)
                throw new Exception("...");
            Creature.Hurt(this.BasicDamage);
        }
    }
}
