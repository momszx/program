using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_WinFormWarcraft
{
    public partial class DisplayOrcForm : Form
    {
        Orc orc;
        public DisplayOrcForm(uint Id)
        {
            InitializeComponent();
            
            foreach (Orc o in MainWindow.horde.Orcs)
            {
                if (o.Id == Id)
                    orc = o;
            }

            if (orc != null)
            {
                lblNameData.Text = orc.Name;
                lblHealthData.Text = orc.Health.ToString();
                lblDamageData.Text = orc.Damage.ToString();
                lblDeadData.Text = orc.Dead ? "Yes" : "No";

                string[] files = Directory.GetFiles(Settings.Default.DirectoryImges);
                string fileName = string.Empty;
                foreach (string f in files)
                {
                    if (f.Contains(Settings.Default.ImagesPrefix + orc.Id))
                        fileName = f;
                }

                if (fileName != string.Empty)
                {
                    Image img = Image.FromFile(fileName);
                    pgProfilePicture.Image = img;
                }
               
            }
        }
    }
}
