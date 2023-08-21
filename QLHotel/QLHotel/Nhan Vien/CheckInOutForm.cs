using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHotel
{
    public partial class CheckInOutForm : Form
    {
        public CheckInOutForm()
        {
            InitializeComponent();
            
            
        }
        MY_DB mydb = new MY_DB();
        NhanVien nhanvien = new NhanVien();
        DateTime checkin;
        DateTime checkout;
        private void ButtonCheckIn_Click(object sender, EventArgs e)
        {
            checkin = DateTime.Now;
            MessageBox.Show("Check in thanh cong", "Check in", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonCheckOut_Click(object sender, EventArgs e)
        {
            checkout = DateTime.Now;
            int time = timespan();
            MessageBox.Show("Check out thanh cong! Thoi gian lam viec cua ban la: " + time, "Check out", MessageBoxButtons.OK, MessageBoxIcon.Information);
            int manv = Globals.GlobalUserID;
            int giolam = time;
            DateTime date = DateTime.Now;
            string day = date.DayOfWeek.ToString();
            if (nhanvien.Themgiolam(manv,giolam,day))
            {
                MessageBox.Show("Check out thanh cong! Thoi gian lam viec cua ban la: " + time, "Check out", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Loi", "Check out", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    

        }
        private int timespan()
        {
            TimeSpan span = checkout.Subtract(checkin);
            int hours = span.Hours;
            if (span.Minutes > 55)
            {
                hours++;
            }
            return hours;
        }
        private void giolam()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT  FROM login,role WHERE login.Id = @uid AND role.id = login.roleid ", mydb.getConnection);
            command.Parameters.Add("@uid", SqlDbType.Int).Value = Globals.GlobalUserID;
            adapter.SelectCommand = command;
            adapter.Fill(table);
        }
        private void CheckInOutForm_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT name,uname,fig FROM login,role WHERE login.Id = @uid AND role.id = login.roleid ", mydb.getConnection);
            command.Parameters.Add("@uid", SqlDbType.Int).Value = Globals.GlobalUserID;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if ((table.Rows.Count > 0))
            {
                byte[] pic = (byte[])table.Rows[0]["fig"];
                MemoryStream picture = new MemoryStream(pic);
                PictureBoxUsername.Image = Image.FromStream(picture);
                PictureBoxUsername.SizeMode = PictureBoxSizeMode.StretchImage;
                labelUsername.Text = "Welcome Back (" + table.Rows[0]["uname"].ToString() + ")";
                labelRole.Text = "You login as " + table.Rows[0]["name"].ToString();
            }
            timer1.Start();
            label2.Text = DateTime.Now.DayOfWeek.ToString() + ", " + DateTime.Now.ToString("MMMM") + " " + DateTime.Now.Day.ToString() + ", " + DateTime.Now.Year.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
        }

        private void ButtonEditInfo_Click(object sender, EventArgs e)
        {
            EditUserForm editUserForm = new EditUserForm();
            editUserForm.ShowDialog();
        }
    }
}
