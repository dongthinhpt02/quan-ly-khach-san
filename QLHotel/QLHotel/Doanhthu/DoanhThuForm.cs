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
    public partial class DoanhThuForm : Form
    {
        public DoanhThuForm()
        {
            InitializeComponent();
        }
        Doanhthu doanhthu = new Doanhthu();
        private void DoanhThuForm_Load(object sender, EventArgs e)
        {          
            dataGridView1.DataSource = doanhthu.getalldoanhthu();
            dataGridView1.ReadOnly = true;
        }
        private void fillGrid1(SqlCommand command)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.DataSource = doanhthu.getdoanhthu1(command);
            dataGridView1.AllowUserToAddRows = false;
        }

        private void ButtonTimkiem_Click(object sender, EventArgs e)
        {
            string abc = textBox1.Text;
            SqlCommand command = new SqlCommand("SELECT ngaythangnam as 'Ngày tháng năm', Sum(tien) as 'Tổng tiền' FROM Doanhthu WHERE ngaythangnam like '%" + (string)abc  + "%' GROUP BY ngaythangnam");
            fillGrid1(command);
        }
    }
}
