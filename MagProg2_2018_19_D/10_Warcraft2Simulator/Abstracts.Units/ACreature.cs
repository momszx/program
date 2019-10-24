using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Warcraft2Simulator
{
    abstract class ACreature : AGameObject, ICreature
    {
        public ACreature(Point Position, string ImageSource,
            byte MaxHitPoints, byte HitPoints, byte Armor, Race Race)
            : this(Position, ImageSource, Rotation.NORTH,
                MaxHitPoints, HitPoints, Armor, Race)
        {
        }
        public ACreature(Point Position, string ImageSource, Rotation Rotation,
            byte MaxHitPoints, byte HitPoints, byte Armor, Race Race)
            : base(Position, ImageSource, false, Rotation)
        {
            this.MaxHitPoints = MaxHitPoints;
            this.HitPoints = HitPoints;
            this.Armor = Armor;
            this.Race = Race;
        }

        private byte maxHitPoints;
        public byte MaxHitPoints
        {
            set
            {
                if (value > 0) maxHitPoints = value;
                else throw new Exception("Maximum hitpoints cannot be negative or zero!");
            }
            get { return maxHitPoints; }
        }

        private byte hitPoints;
        public byte HitPoints
        {
            set
            {
                if (value < 0) hitPoints = 0;
                else if (value > MaxHitPoints) hitPoints = MaxHitPoints;
                else hitPoints = value;
            }
            get { return hitPoints; }
        }

        private byte armor;
        public byte Armor
        {
            get
            {
                return armor;
            }
            set
            {
                if (value >= 0) armor = value;
                else throw new Exception("Armor cannot be negative or zero!");
            }
        }

        public bool Dead
        {
            get { return HitPoints == 0; }
        }

        public Race Race
        {
            get;
            private set;
        }

        public virtual void Hurt(byte HitPoints)
        {
            byte totalHitPoints = HitPoints - Armor > 0 ?
                Convert.ToByte(HitPoints - Armor) :
                Convert.ToByte(0);
            if (this.HitPoints - (HitPoints - Armor) > 0)
                this.HitPoints = Convert.ToByte(this.HitPoints - totalHitPoints);
            else this.HitPoints = Convert.ToByte(0);
        }
    }
}
