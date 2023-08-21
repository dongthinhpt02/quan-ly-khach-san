using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHotel
{
    public partial class XoaSuaNV : Form
    {
        public XoaSuaNV()
        {
            InitializeComponent();
        }
        NhanVien nhanvien = new NhanVien();
        private void XoaSuaNV_Load(object sender, EventArgs e)
        {

        }

        private void ButtonTimKiem_Click(object sender, EventArgs e)
        {

            int manv = int.Parse(TextBoxMaNV.Text);
            SqlCommand command = new SqlCommand("SELECT manv,honv,tennv,gioitinh,sdt,chucvu,diachi,quequan,cmt FROM NV WHERE manv =" + manv);
            DataTable table = nhanvien.layNV(command);
            if (table.Rows.Count > 0)
            {
                TextBoxHoNV.Text = table.Rows[0]["honv"].ToString();
                TextBoxTenNV.Text = table.Rows[0]["tennv"].ToString();
                if (table.Rows[0]["gioitinh"].ToString() == "Nu")
                    RadioButtonNu.Checked = true;
                else
                    RadioButtonNam.Checked = true;
                TextBoxSDT.Text = table.Rows[0]["sdt"].ToString();
                TextBoxChucVu.Text = table.Rows[0]["chucvu"].ToString();
                TextBoxDiaChi.Text = table.Rows[0]["diachi"].ToString();
                TextBoxQueQuan.Text = table.Rows[0]["quequan"].ToString();
                TextBoxCMND.Text = table.Rows[0]["cmt"].ToString();
            }
            else
                MessageBox.Show("khong tim thay", "Tim kiem NV", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void TextBoxMaNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void ButtonXoa_Click(object sender, EventArgs e)
        {

            try
            {
                int manv = Convert.ToInt32(TextBoxMaNV.Text);
                if ((MessageBox.Show("Ban co chac muon xoa NV nay khong?", "Xoa NV", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (nhanvien.XoaNV(manv))
                    {
                        MessageBox.Show("Da Xoa NV", "Xoa NV", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TextBoxMaNV.Text = "";
                        TextBoxHoNV.Text = "";
                        TextBoxTenNV.Text = "";
                        TextBoxSDT.Text = "";
                        TextBoxChucVu.Text = "";
                        TextBoxDiaChi.Text = "";
                        TextBoxQueQuan.Text = "";
                        TextBoxCMND.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Chua xoa NV", "Xoa NV", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Vui long nhap dung ma NV!", "Xoa NV", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ButtonChinhSua_Click(object sender, EventArgs e)
        {
            int manv;
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
                try
                {
                    manv = Convert.ToInt32(TextBoxMaNV.Text);
                    if (nhanvien.CapNhatNV(manv, honv, tennv, gioitinh, sdt, chucvu, diachi, quequan, cmnd))
                    {
                        MessageBox.Show("Da cap nhat NV", "Cap Nhat NV", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Loi", "Cap Nhat NV", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Cap Nhat NV", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Co o trong", "Cap Nhat NV", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        bool verif()
        {
            if ((TextBoxHoNV.Text.Trim() == "") || (TextBoxTenNV.Text.Trim() == "") || (TextBoxSDT.Text.Trim() == "") || (TextBoxChucVu.Text.Trim() == "") || (TextBoxDiaChi.Text.Trim() == "") || (TextBoxQueQuan.Text.Trim() == "") || (TextBoxCMND.Text.Trim() == ""))
                return false;
            else
                return true;
        }

        private void XoaSuaNV_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
