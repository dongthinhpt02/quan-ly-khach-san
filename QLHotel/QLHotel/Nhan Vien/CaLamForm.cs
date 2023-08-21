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
    public partial class CaLamForm : Form
    {
        public CaLamForm()
        {
            InitializeComponent();
        }
        MY_DB mydb = new MY_DB();
        NhanVien nv = new NhanVien();
        private void CaLamForm_Load(object sender, EventArgs e)
        {
            DataGridView.DataSource = taoca();
        }
        private DataTable taoca()
        {
            int count = 0;
            DataTable dtAll = new DataTable();
            dtAll.Columns.Add("Day of week").SetOrdinal(0);
            dtAll.Merge(chiaca("'Quan Li'",1));
            dtAll.Merge(chiaca("'Tiep Tan'",1));
            dtAll.Merge(chiaca("'Lao Cong'",1));
            for (int i = 0; i < dtAll.Rows.Count; i++)
            {
                dtAll.Rows[i][0] = "Monday";
                count++;
            }
            dtAll.Merge(chiaca("'Quan Li'", 1));
            dtAll.Merge(chiaca("'Tiep Tan'", 1));
            dtAll.Merge(chiaca("'Lao Cong'", 1));
            for (int i = count; i < dtAll.Rows.Count; i++)
            {
                dtAll.Rows[i][0] = "Tuesday";
                count++;
            }
            dtAll.Merge(chiaca("'Quan Li'", 1));
            dtAll.Merge(chiaca("'Tiep Tan'", 1));
            dtAll.Merge(chiaca("'Lao Cong'", 1));
            for (int i = count; i < dtAll.Rows.Count; i++)
            {
                dtAll.Rows[i][0] = "Wednesday";
                count++;
            }
            dtAll.Merge(chiaca("'Quan Li'", 1));
            dtAll.Merge(chiaca("'Tiep Tan'", 1));
            dtAll.Merge(chiaca("'Lao Cong'", 1));
            for (int i = count; i < dtAll.Rows.Count; i++)
            {
                dtAll.Rows[i][0] = "Thursday";
                count++;
            }
            dtAll.Merge(chiaca("'Quan Li'", 1));
            dtAll.Merge(chiaca("'Tiep Tan'", 1));
            dtAll.Merge(chiaca("'Lao Cong'", 1));
            for (int i = count; i < dtAll.Rows.Count; i++)
            {
                dtAll.Rows[i][0] = "Friday";
                count++;
            }
            dtAll.Merge(chiaca("'Quan Li'", 2));
            dtAll.Merge(chiaca("'Tiep Tan'", 2));
            dtAll.Merge(chiaca("'Lao Cong'", 2));
            for (int i = count; i < dtAll.Rows.Count; i++)
            {
                dtAll.Rows[i][0] = "Saturday";
                count++;
            }
            dtAll.Merge(chiaca("'Quan Li'", 2));
            dtAll.Merge(chiaca("'Tiep Tan'", 2));
            dtAll.Merge(chiaca("'Lao Cong'", 2));
            for (int i = count; i < dtAll.Rows.Count; i++)
            {
                dtAll.Rows[i][0] = "Sunday";
                count++;
            } 
            return dtAll;
        }
        private DataTable chiaca(string role,int a)
        {
            SqlCommand command = new SqlCommand("Select manv as 'Mã NV', honv as 'Họ NV',tennv as 'Tên NV',chucvu as 'Chức vụ' FROM NV where chucvu = " + role, mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table1 = new DataTable();
            adapter.Fill(table1);
            table1.Columns.Add("Ca 1", typeof(string));
            table1.Columns.Add("Ca 2", typeof(string));
            table1.Columns.Add("Ca 3", typeof(string));
            table1.Columns.Add("Ca 4", typeof(string));
            table1.Columns.Add("Ca 5", typeof(string));
            table1.Columns.Add("Ca 6", typeof(string));
            int count = table1.Rows.Count;
            int n = count;
            int[] dsnv = new int[n];
            Random random = new Random();
            int rd = 0;
            int flag = 0;
            foreach (int i in dsnv)
            {
                dsnv[i] = 0;
            }
            if (role == "'Lao Cong'")
            {
                for (int i = 0; i < 3; i++)
                {

                    rd = random.Next(0, count);


                    if (dsnv[rd] > 1 || table1.Rows[rd][4 + i].ToString() == "x")
                    {
                        i = i - 1;
                        continue;
                    }
                    dsnv[rd]++;
                    table1.Rows[rd][4 + i] = "x";
                    flag++;
                    if (flag == 3 || flag == 6 || flag == 9)
                        i = -1;
                }
                if (a == 1)
                {
                    for (int i = 3; i < 6; i++)
                    {
                        rd = random.Next(0, count);
                        dsnv[rd]++;
                        if (dsnv[rd] > 2 || table1.Rows[rd][4 + i].ToString() == "x")
                        {
                            i--;
                            continue;
                        }
                        table1.Rows[rd][4 + i] = "x";
                    }
                }
                else
                {
                    flag = 0;
                    for (int i = 3; i < 6; i++)
                    {
                        for (int j = 0; j < 5; j++)
                            if (dsnv[i] < 0)
                            {
                                rd = i;
                            }
                            else
                                rd = random.Next(0, count);

                        if (dsnv[rd] > 2 || table1.Rows[rd][4 + i].ToString() == "x")
                        {
                            i = i - 1;
                            continue;
                        }
                        dsnv[rd]++;
                        table1.Rows[rd][4 + i] = "x";
                        flag++;
                        if (flag == 3 || flag == 6)
                            i = 2;
                    }
                }    
                
            }
            if (role == "'Quan Li'")
            {
                for (int i = 0; i < 4; i++)
                {
                    rd = random.Next(0, count);
                    if (dsnv[rd] > 1 || table1.Rows[rd][4 + i].ToString() == "x")
                    {
                        i--;
                        continue;
                    }
                    dsnv[rd]++;
                    table1.Rows[rd][4 + i] = "x";
                    
                }
                
            }
            if (role == "'Tiep Tan'")
            {
                for (int i = 0; i < 3; i++)
                {
                    rd = random.Next(0, count);


                    if (dsnv[rd] > 1 || table1.Rows[rd][4 + i].ToString() == "x")
                    {
                        i = i - 1;
                        continue;
                    }
                    dsnv[rd]++;
                    table1.Rows[rd][4 + i] = "x";
                    flag++;
                    if (flag == 3)
                        i = -1;
                }
                for (int i = 4; i < 6; i++)
                {
                    rd = random.Next(0, count);
                    dsnv[rd]++;
                    if (dsnv[rd] > 2 || table1.Rows[rd][4 + i].ToString() == "x")
                    {
                        i--;
                        continue;
                    }
                    table1.Rows[rd][4 + i] = "x";
                }
            }
            return table1;

        }

        NhanVien nhanvien = new NhanVien();
        private void ButtonSaveCa_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in taoca().Rows)
            {
                string day = row[0].ToString();
                int manv = Convert.ToInt32(row[1]);
                string honv = row[2].ToString();
                string tennv = row[3].ToString();
                string chucvu = row[4].ToString();
                string ca1 = row[5].ToString();
                string ca2 = row[6].ToString();
                string ca3 = row[7].ToString();
                string ca4 = row[8].ToString();
                string ca5 = row[9].ToString();
                string ca6 = row[10].ToString();
                if (nhanvien.ThemCa(day,manv,honv,tennv,chucvu,ca1,ca2, ca3, ca4, ca5, ca6))
                {
                    continue;
                }
                else
                {
                    MessageBox.Show("Loi", "Tao ca", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            MessageBox.Show("Tao ca thanh cong", "Tao ca", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CaLamForm caLamForm = new CaLamForm();
            this.Dispose();
            caLamForm.ShowDialog();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Dispose();
            mainForm.ShowDialog();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Delete from Ca", mydb.getConnection);
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                MessageBox.Show("Xoa ca thanh cong", "Xoa ca", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                mydb.closeConnection();
                MessageBox.Show("Xoa ca thanh cong", "Xoa ca", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
