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
    public partial class Hientatcathucpham : Form
    {
        public Hientatcathucpham()
        {
            InitializeComponent();
        }
        Thucpham thucpham = new Thucpham();
        private void Hientatcathucpham_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = thucpham.getallThucpham();
            dataGridView1.ReadOnly = true;
        }
    }
}
