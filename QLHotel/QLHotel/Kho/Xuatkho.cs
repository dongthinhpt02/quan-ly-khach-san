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
    public partial class Xuatkho : Form
    {
        public Xuatkho()
        {
            InitializeComponent();
        }
        Thucpham thucpham = new Thucpham();
        private void Xuatkho_Load(object sender, EventArgs e)
        {
            ComboBoxTenthucpham.DataSource = thucpham.getallThucpham();
            ComboBoxTenthucpham.DisplayMember = "Tenthucpham";
            ComboBoxTenthucpham.ValueMember = "Tenthucpham";
            ComboBoxTenthucpham.SelectedItem = "null";
        }
        Xuatkhoclass xuatkhoclass = new Xuatkhoclass();
        private void ButtonXuatkho_Click(object sender, EventArgs e)
        {
            string tenthucpham = (string)ComboBoxTenthucpham.SelectedValue;
            int soluong = (int)Convert.ToInt32(TextBoxSoluongxuat.Text);
            if(xuatkhoclass.insertxuatkho(tenthucpham,soluong))
            {
                MessageBox.Show("Food Exported", "Export Food", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Xuatkho xuatkho = new Xuatkho();
                xuatkho.Show();
            }
            else
            {
                MessageBox.Show("Error", "Export Food", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonHientatcathucpham_Click(object sender, EventArgs e)
        {
            Hientatcathucpham hientatcathucpham = new Hientatcathucpham();
            hientatcathucpham.Show();
        }
    }
}
