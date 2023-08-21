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
    public partial class TiepTanForm : Form
    {
        public TiepTanForm()
        {
            InitializeComponent();
        }
        MY_DB mydb = new MY_DB();
        private void ButtonQLPhong_Click(object sender, EventArgs e)
        {
            MainFormRoomAndGuest mainForm = new MainFormRoomAndGuest();
            mainForm.ShowDialog();
        }

        private void ButtonQuanLi_Click(object sender, EventArgs e)
        {
            QuanLyNV quanLyNV = new QuanLyNV();
            quanLyNV.ShowDialog();
        }

        private void ButtonCheckIO_Click(object sender, EventArgs e)
        {
            CheckInOutForm checkInOutForm = new CheckInOutForm();
            checkInOutForm.ShowDialog();
        }

        private void ButtonTC_Click(object sender, EventArgs e)
        {
            ThuChiForm thuChiForm = new ThuChiForm();
            thuChiForm.ShowDialog();
        }

        private void TiepTanForm_Load(object sender, EventArgs e)
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
    }
}
