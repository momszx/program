using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Warcraft2Simulator
{
    class ACreatureMovable : ACreature, ICreatureMovable
    {
        private static Random rnd = new Random();

        public ACreatureMovable(Point Position, string ImageSource, Rotation Rotation,
            byte MaxHitPoints, byte HitPoints, byte Armor, Race Race,
            byte MovementSpeed, IWorld World)
            : base(Position, ImageSource, Rotation, MaxHitPoints, HitPoints, Armor, Race)
        {
            this.MovementSpeed = MovementSpeed;
            this.World = World;
        }

        public byte MovementSpeed
        {
            private set;
            get;
        }

        public IWorld World
        {
            private set;
            get;
        }

        public void Move()
        {
            byte attempts = 0;
            do
            {
                byte xLeftBound = this.Position.X < MovementSpeed ?
                    Convert.ToByte(0) :
                    Convert.ToByte(this.Position.X - MovementSpeed);
                byte yBottomBound = this.Position.Y < MovementSpeed ?
                   Convert.ToByte(0) :
                   Convert.ToByte(this.Position.Y - MovementSpeed);
                byte xRightBound = this.Position.X > this.World.Width - this.MovementSpeed ?
                    this.World.Width :
                    Convert.ToByte(this.Position.X + MovementSpeed + 1);
                byte yTopBound = this.Position.Y > this.World.Height - this.MovementSpeed ?
                    this.World.Height :
                    Convert.ToByte(this.Position.Y + MovementSpeed + 1);

                Point newPosition = new Point(rnd.Next(xLeftBound, xRightBound),
                                              rnd.Next(yBottomBound, yTopBound));

                bool IsNewPositionUsed = false;
                foreach (var territoryElement in this.World.TerritoryElements)
                {
                    //Csak akik nem ráléphetők!!!!!!
                    if (!territoryElement.Traversable &&
                        territoryElement.Position.X == newPosition.X &&
                        territoryElement.Position.Y == newPosition.Y)
                    {
                        IsNewPositionUsed = true;
                        break;
                    }
                }
                if (!IsNewPositionUsed)
                {
                    foreach (ICommunity community in this.World.Communities)
                    {
                        foreach (ICreature creature in community.Creatures)
                        {
                            if (creature.Position.X == newPosition.X &&
                                creature.Position.Y == newPosition.Y)
                            {
                                IsNewPositionUsed = true;
                                break;
                            }
                        }
                        if (IsNewPositionUsed)
                            break;
                    }
                }

                if (!IsNewPositionUsed)
                {
                    this.Position = newPosition;
                    break;
                }
                else attempts++;
            } while (attempts <= Math.Pow(2 * MovementSpeed + 1, 2) - 1);
        }
    }
}
