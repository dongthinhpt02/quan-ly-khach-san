using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHotel
{
    public partial class MainForm : Form
    {
        public MainForm(string role)
        {
            InitializeComponent();
            label1.Text = role;
        }

        public void quanLiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemNV themNV = new ThemNV();
            themNV.Show(this);
        }

        public void MainForm_Load(object sender, EventArgs e)
        {
            if (label1.Text != "Quan Li")
                quanLiToolStripMenuItem.Enabled = false;
        }

        private void tiepTanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XoaSuaNV xoaSuaNV = new XoaSuaNV();
            xoaSuaNV.Show(this);
        }
    }
}
