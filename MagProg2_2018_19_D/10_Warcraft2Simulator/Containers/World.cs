using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Warcraft2Simulator
{
    class World : IWorld
    {
        private World()
        {
            territoryElements = new List<IGameObject>();
            communityes = new List<ICommunity>();
            AddCommunity(Race.HUMAN);
            AddCommunity(Race.ORC);
        }
        public World(string MapSource)
            : this()
        {
            ReadMap(MapSource);
        }

        public byte Width
        {
            get;
            private set;
        }

        public byte Height
        {
            get;
            private set;
        }

        private List<IGameObject> territoryElements;
        public List<IGameObject> TerritoryElements
        {
            get { return new List<IGameObject>(territoryElements); }
        }

        private List<ICommunity> communityes;
        public List<ICommunity> Communities
        {
            get { return new List<ICommunity>(communityes); }
        }

        public List<Point> FreePositions
        {
            get
            {
                List<Point> temp = new List<Point>();
                for (int i = 0; i < Width; i++)
                {
                    for (int j = 0; j < Height; j++)
                    {
                        bool free = true;
                        foreach (IGameObject gameObject in territoryElements)
                        {
                            if (!gameObject.Traversable &&
                                gameObject.Position.X == i &&
                                gameObject.Position.Y == j)
                            {
                                free = false;
                                break;
                            }
                        }
                        if (free)
                        {
                            foreach (ICommunity community in communityes)
                            {
                                foreach (ICreature creature in community.Creatures)
                                {
                                    if (creature.Position.X == i &&
                                        creature.Position.Y == j)
                                    {
                                        free = false;
                                        break;
                                    }
                                }
                                if (!free) break;
                            }
                        }
                        if (free)
                            temp.Add(new Point(i, j));
                    }
                }
                return temp;
            }
        }

        private void ReadMap(string MapSource)
        {
            StreamReader sr = new StreamReader(MapSource);
            byte row = 0;
            while (!sr.EndOfStream)
            {
                string text = sr.ReadLine();
                for (int col = 0; col < text.Length; col++)
                {
                    switch (text[col])
                    {
                        case 'T': AddTree(new Point(row, col)); break;
                        case 'G': AddGrass(new Point(row, col)); break;
                        case 'W': AddWater(new Point(row, col)); break;
                        default:
                            break;
                    }
                }
                row++;
            }
            sr.Close();
            this.Width = Convert.ToByte(this.TerritoryElements.Max(p => p.Position.X));
            this.Height = Convert.ToByte(this.TerritoryElements.Max(p => p.Position.Y));
        }

        public void Draw(Graphics g)
        {
            foreach (IGameObject territoryElement in TerritoryElements)
            {
                territoryElement.Display(g);
            }
            foreach (ICommunity community in communityes)
            {
                foreach (ICreature creature in community.Creatures.Where(c => !c.Dead))
                {
                    creature.Display(g);
                }
            }
        }

        public void PlayOneRound()
        {
            foreach (ICommunity community in communityes)
            {
                foreach (ICreature creature in community.Creatures)
                {
                    if (creature is ICreatureMovable)
                        (creature as ICreatureMovable).Move();
                }
            }

            foreach (ICommunity community in communityes)
            {
                foreach (AWarrior warrior in community.Creatures.Where(c => c is AWarrior && !c.Dead))
                {
                    //Az adott harcos keres valakit, akit megüthet
                    switch (warrior.Race)
                    {
                        case Race.HUMAN:
                            foreach (ICreature creature in Horde.Creatures)
                            {
                                if (Math.Abs(creature.Position.X - warrior.Position.X) < warrior.Range &&
                                    Math.Abs(creature.Position.Y - warrior.Position.Y) < warrior.Range)
                                    warrior.Attack(creature);
                            }
                            break;
                        case Race.ORC:
                            foreach (ICreature creature in Alliance.Creatures)
                            {
                                if (Math.Abs(creature.Position.X - warrior.Position.X) < warrior.Range &&
                                    Math.Abs(creature.Position.Y - warrior.Position.Y) < warrior.Range)
                                    warrior.Attack(creature);
                            }
                            break;
                        default:
                            break;
                    }                    
                }
            }
        }

        public void AddCommunity(Race Race)
        {
            switch (Race)
            {
                case Race.HUMAN: communityes.Add(new Alliance()); break;
                case Race.ORC: communityes.Add(new Horde()); break;
                default: break;
            }
        }

        public Horde Horde
        {
            get { return (Horde)Communities.Where(c => c.Race == Race.ORC).First(); }
        }
        public Alliance Alliance
        {
            get { return (Alliance)Communities.Where(c => c.Race == Race.HUMAN).First(); }
        } 

        #region AddTerritoryElements
        private void AddGrass(Point Position)
        {
            this.territoryElements.Add(new Grass(Position));
        }
        private void AddTree(Point Position)
        {
            this.territoryElements.Add(new Tree(Position));
        }
        private void AddWater(Point Position)
        {
            this.territoryElements.Add(new Water(Position));
        }
        #endregion

        #region AddHumans
        public void AddPeasant(Alliance Alliance, Point Position,
            byte HitPoints)
        {
            Alliance.AddPeasant(new Peasant(Position, HitPoints, this));
        }
        public void AddFootman(Alliance Alliance, Point Position,
            byte HitPoints)
        {
            Alliance.AddWarrior(new Footman(Position, HitPoints, this));
        }
        #endregion

        #region AddOrcs
        public void AddPeon(Horde Horde, Point Position,
            byte HitPoints)
        {
            Horde.AddPeasant(new Peon(Position, HitPoints, this));
        }
        public void AddGrunt(Horde Horde, Point Position,
           byte HitPoints)
        {
            Horde.AddWarrior(new Grunt(Position, HitPoints, this));
        }
        #endregion
    }
}
