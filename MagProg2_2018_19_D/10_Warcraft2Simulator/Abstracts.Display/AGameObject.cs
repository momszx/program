using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Warcraft2Simulator
{
    abstract class AGameObject : IGameObject
    {
        public AGameObject(Point Position, string ImageSource,
            bool Traversable)
        {
            this.Position = Position;
            this.Rotation = Rotation.NORTH;
            this.Traversable = Traversable;
            this.ImageSource = ImageSource;
        }
        public AGameObject(Point Position, string ImageSource, 
            bool Traversable, Rotation Rotation)
            :this(Position, ImageSource, Traversable)
        {
            this.Rotation = Rotation;
        }

        public Point Position
        {
            get;
            protected set;
        }

        public bool Traversable { get; private set; }

        private string imageSource;
        public string ImageSource
        {
            private set
            {
                if (File.Exists(value))
                    imageSource = value;
                else throw new FileNotFoundException("File not found", value);
            }
            get { return imageSource; }
        }

        public Rotation Rotation
        {
            get;
            set;
        }

        public void Display(Graphics g)
        {
            Image img = Image.FromFile(ImageSource);
            switch (Rotation)
            {
                case Rotation.NORTH: break;
                case Rotation.EAST: img.RotateFlip(RotateFlipType.Rotate270FlipNone); break;
                case Rotation.SOUTH: img.RotateFlip(RotateFlipType.Rotate180FlipNone); break;
                case Rotation.WEST: img.RotateFlip(RotateFlipType.Rotate90FlipNone); break;
                default: break;
            }
            g.DrawImage(img, new Point(this.Position.X * Settings.Default.DrawUnit,
                                       this.Position.Y * Settings.Default.DrawUnit));
        }        
    }
}
