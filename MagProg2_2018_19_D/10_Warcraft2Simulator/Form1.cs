using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_Warcraft2Simulator
{
    public partial class Form1 : Form
    {
        public static Random rnd = new Random();

        Graphics g;
        World Azeroth;

        public Form1()
        {
            InitializeComponent();
            Azeroth = new World("Warcraft2_map.txt");

            //8 paraszt
            for (int i = 0; i < 12; i++)
            {
                Azeroth.AddPeasant(Azeroth.Alliance,
                    Azeroth.FreePositions[rnd.Next(Azeroth.FreePositions.Count)],
                    Settings.Default.APeasantMaxHitPoints);
                Azeroth.AddPeon(Azeroth.Horde,
                    Azeroth.FreePositions[rnd.Next(Azeroth.FreePositions.Count)],
                    Settings.Default.APeasantMaxHitPoints);
            }
            //10 harcos
            for (int i = 0; i < 20; i++)
            {
                Azeroth.AddFootman(Azeroth.Alliance,
                    Azeroth.FreePositions[rnd.Next(Azeroth.FreePositions.Count)],
                    Settings.Default.AWarriorMaxHitPoints);
                Azeroth.AddGrunt(Azeroth.Horde,
                    Azeroth.FreePositions[rnd.Next(Azeroth.FreePositions.Count)],
                    Settings.Default.AWarriorMaxHitPoints);
            }

            pbCanvas.Width = Azeroth.Width * Settings.Default.DrawUnit;
            pbCanvas.Height = Azeroth.Height * Settings.Default.DrawUnit + 35;
            this.Width = Azeroth.Width * Settings.Default.DrawUnit;
            this.Height = Azeroth.Height * Settings.Default.DrawUnit + 35;
        }

        private void pbCanvas_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            Azeroth.Draw(g);
            lblHumans.Text = "Humans: " + Azeroth.Alliance.Creatures.Where(c => !c.Dead).Count();
            lblOrcs.Text = "Orcs: " + Azeroth.Horde.Creatures.Where(c => !c.Dead).Count();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (Azeroth.Horde.AllCreaturesDead ||
                Azeroth.Alliance.AllCreaturesDead)
            {
                timer.Stop();
                return;
            }
            Azeroth.PlayOneRound();
            pbCanvas.Refresh();
        }
    }
}
