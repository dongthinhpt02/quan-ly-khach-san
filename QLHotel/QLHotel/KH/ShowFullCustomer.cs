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
    public partial class ShowFullCustomer : Form
    {
        public ShowFullCustomer()
        {
            InitializeComponent();
        }
        KH kh = new KH();
        private void ShowFullCustomer_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = kh.getfullcustomer();
            dataGridView1.ReadOnly = true;
        }
    }
}
