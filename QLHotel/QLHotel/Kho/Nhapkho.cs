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
    public partial class Nhapkho : Form
    {
        public Nhapkho()
        {
            InitializeComponent();
        }
        Thucpham thucpham = new Thucpham();
        private void Buttonthemthucpham_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TextBoxID.Text);
            string tenthucpham = TextBoxTenthucpham.Text;
            int sl = Convert.ToInt32(TextBoxSoluongnhap.Text);
            if(thucpham.insertThucpham(id,tenthucpham,sl))
            {
                MessageBox.Show("New Food Added", "Add Food", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Nhapkho nhapkho = new Nhapkho();
                nhapkho.Show();
            }
            else
            {
                MessageBox.Show("Error", "Add Food", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonShowAllThucPham_Click(object sender, EventArgs e)
        {
            Hientatcathucpham hientatcathucpham = new Hientatcathucpham();
            hientatcathucpham.Show();
        }
    }
}
