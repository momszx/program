using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _03_WinFormWarcraft
{
    public partial class MainWindow : Form
    {
        public static Horde horde = new Horde();

        private void DgvOrcsInit()
        {
            dgvOrcs.Rows.Clear();
            dgvOrcs.Columns.Clear();
            dgvOrcs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.Name = "Id";
            colId.HeaderText = "Id";
            colId.Width = 50;
            colId.Visible = false;
            dgvOrcs.Columns.Add(colId);

            DataGridViewTextBoxColumn colName = new DataGridViewTextBoxColumn();
            colName.Name = "Name";
            colName.HeaderText = "Name";
            colName.Width = 200;
            dgvOrcs.Columns.Add(colName);

            DataGridViewTextBoxColumn colHealth = new DataGridViewTextBoxColumn();
            colHealth.Name = "Health";
            colHealth.HeaderText = "Health";
            colHealth.Width = 70;
            dgvOrcs.Columns.Add(colHealth);

            DataGridViewCheckBoxColumn colDead = new DataGridViewCheckBoxColumn();
            colDead.Name = "Dead";
            colDead.HeaderText = "Dead";
            dgvOrcs.Columns.Add(colDead);
        }
        private void DgvOrcsDataUpdate()
        {
            dgvOrcs.Rows.Clear();
            foreach (Orc orc in horde.Orcs)
            {
                dgvOrcs.Rows.Add(orc.Id,
                    orc.Name,
                    orc.Health,
                    orc.Dead);
            }
        }
        private void HordeTempData()
        {
            horde.AddOrc("Troll Doomhammer", 100, 45);
            horde.AddOrc("Geda Bloodminer", 76, 31);
            horde.AddOrc("Kusper Moonwalker", 0, 35);
            horde.AddOrc("Kovásznai Silentkiller", 87, 42);
        }

        public MainWindow()
        {
            InitializeComponent();

            if (!Directory.Exists(Settings.Default.DirectoryImges))
                Directory.CreateDirectory(Settings.Default.DirectoryImges);

            HordeTempData();
            DgvOrcsInit();
            DgvOrcsDataUpdate();

            lblTitle.Text += " v.1.0.00";
        }

        private void btnAddOrc_Click(object sender, EventArgs e)
        {
            AddOrcForm addOrc = new AddOrcForm();
            addOrc.ShowDialog();
            DgvOrcsDataUpdate();
        }

        private void dgvOrcs_DoubleClick(object sender, EventArgs e)
        {
            uint Id = Convert.ToUInt32(
                dgvOrcs.SelectedRows[0].Cells["Id"].Value.ToString());
            DisplayOrcForm displayOrc = new DisplayOrcForm(Id);
            displayOrc.ShowDialog();
        }
    }
}
