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
    public partial class AddOrcForm : Form
    {
        public AddOrcForm()
        {
            InitializeComponent();
        }

        public void btnSave_Click(object sender, EventArgs e)
        {
            MainWindow.horde.AddOrc(tbName.Text,
                (int)nudHealth.Value,
                (int)nudDamage.Value);

            if (tbImage.Text != string.Empty)
            {
                uint Id = MainWindow.horde.Orcs.Last().Id;
                string extension = tbImage.Text.Split('.').Last();
                string fileName = Settings.Default.ImagesPrefix + Id + "." + extension;
                File.Copy(tbImage.Text,
                    Path.Combine(Settings.Default.DirectoryImges, fileName), true);
            }
            MessageBox.Show("Save successful!");
            this.Close();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Images|*.bmp;*.jpg;*.jpeg;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tbImage.Text = openFileDialog.FileName;
            }
        }
    }
}
