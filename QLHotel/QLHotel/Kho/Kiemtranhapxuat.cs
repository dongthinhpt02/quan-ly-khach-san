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
    public partial class Kiemtranhapxuat : Form
    {
        public Kiemtranhapxuat()
        {
            InitializeComponent();
        }
        Thucpham thucpham = new Thucpham();
        private void fillGrid1(SqlCommand command)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.DataSource = thucpham.getthucpham(command);
            dataGridView1.AllowUserToAddRows = false;
        }
        private void fillGrid2(SqlCommand command)
        {
            dataGridView2.ReadOnly = true;
            dataGridView2.RowTemplate.Height = 40;
            dataGridView2.DataSource = thucpham.getthucpham(command);
            dataGridView2.AllowUserToAddRows = false;
        }
        
        private void ButtonKiemtra_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT Tenthucpham as 'Tên thực phẩm' , Soluongnhap as 'Số lượng nhập' FROM Kho WHERE Tenthucpham like '%" + (string)ComboBoxTenthucpham.SelectedValue + "%'");
            fillGrid1(command);
            SqlCommand command1 = new SqlCommand("SELECT Tenthucpham as 'Tên thực phẩm', Soluongxuatkho as 'Số lượng xuất kho' FROM Xuatkho WHERE Tenthucpham like '%" + (string)ComboBoxTenthucpham.SelectedValue + "%'");
            fillGrid2(command1);
            int a= 0;
            for(int i = 0; i <= dataGridView1.RowCount - 1;i++)
            {
                a = a + int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
            }
            label2.Text = ("Tổng số " + ComboBoxTenthucpham.SelectedValue + " nhập kho "+ a);
            int b = 0;
            for(int i = 0; i <= dataGridView2.RowCount - 1; i++)
            {
                b = b + int.Parse(dataGridView2.Rows[i].Cells[1].Value.ToString());
            }
            label3.Text = ("Tổng số " + ComboBoxTenthucpham.SelectedValue + " xuất kho " + b);
        }
        private void Kiemtranhapxuat_Load(object sender, EventArgs e)
        {
            ComboBoxTenthucpham.DataSource = thucpham.getallThucpham();
            ComboBoxTenthucpham.DisplayMember = "Tenthucpham";
            ComboBoxTenthucpham.ValueMember = "Tenthucpham";
            ComboBoxTenthucpham.SelectedItem = "null";

            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.DataSource = thucpham.getallThucphamnhap();
            dataGridView1.AllowUserToAddRows = false;

            dataGridView2.ReadOnly = true;
            dataGridView2.RowTemplate.Height = 40;
            dataGridView2.DataSource = thucpham.getallThucphamxuat();
            dataGridView2.AllowUserToAddRows = false;
        }
    }
}
