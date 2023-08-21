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
    public partial class ThemNV : Form
    {
        public ThemNV()
        {
            InitializeComponent();
        }



        private void ButtonThem_Click(object sender, EventArgs e)
        {
            NhanVien nhanvien = new NhanVien();
            int manv = Convert.ToInt32(TextBoxMaNV.Text);
            string honv = TextBoxHoNV.Text;
            string tennv = TextBoxTenNV.Text;
            string gioitinh = "Nam";
            if (RadioButtonNu.Checked)
            {
                gioitinh = "Nu";
            }
            string sdt = TextBoxSDT.Text;
            string chucvu = TextBoxChucVu.Text;
            string diachi = TextBoxDiaChi.Text;
            string quequan = TextBoxQueQuan.Text;
            string cmnd = TextBoxCMND.Text;
            if (verif())
            {
                if (nhanvien.themNV(manv, honv, tennv, gioitinh, sdt, chucvu, diachi, quequan, cmnd))
                {
                    MessageBox.Show("Da them NV", "Them NV", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Loi", "Them NV", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Co o trong", "Them NV", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        bool verif()
        {
            if ((TextBoxHoNV.Text.Trim() == "") || (TextBoxTenNV.Text.Trim() == "") || (TextBoxSDT.Text.Trim() == "") || (TextBoxChucVu.Text.Trim() == "") || (TextBoxDiaChi.Text.Trim() == "") || (TextBoxQueQuan.Text.Trim() == "") || (TextBoxCMND.Text.Trim() == ""))
                return false;
            else
                return true;
        }

        private void ButtonThoat_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void ThemNV_Load(object sender, EventArgs e)
        {

        }
    }
}
