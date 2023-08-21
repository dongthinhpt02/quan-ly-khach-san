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
    public partial class EditUserForm : Form
    {
        public EditUserForm()
        {
            InitializeComponent();
        }
        NguoiDung user = new NguoiDung();
        ChucVu chucvu = new ChucVu();
        private void EditUserForm_Load(object sender, EventArgs e)
        {
        }

        private void ButtonFind_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TextBoxID.Text);
            SqlCommand command = new SqlCommand(" SELECT * FROM login WHERE id =" + id);
            DataTable table = user.getUser(command);
            if (table.Rows.Count > 0)
            {
                TextBoxFname.Text = table.Rows[0]["f_name"].ToString();
                TextBoxLname.Text = table.Rows[0]["l_name"].ToString();
                TextBoxUsername.Text = table.Rows[0]["uname"].ToString();
                TextBoxPassword.Text = table.Rows[0]["pwd"].ToString();
                byte[] pic = (byte[])table.Rows[0]["fig"];
                MemoryStream picture = new MemoryStream(pic);
                PictureBoxUser.Image = Image.FromStream(picture);
            }
            else
                MessageBox.Show("not found", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TextBoxID.Text);
            string fname = TextBoxFname.Text;
            string lname = TextBoxLname.Text;
            string uname = TextBoxUsername.Text;
            string pwd = TextBoxPassword.Text;
            MemoryStream pic = new MemoryStream();
            if (verif())
            {
                if (!user.usernameExist(uname, "edit", id))
                {
                    PictureBoxUser.Image.Save(pic, PictureBoxUser.Image.RawFormat);
                    if (user.updateUser(id, fname, lname, uname, pwd, pic))
                    {
                        MessageBox.Show("Dang ki thanh cong", "Register User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Loi!", "Register User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Nguoi dung nay da ton tai!", "Register User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Con o trong!", "Register User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            bool verif()
            {
                if ((TextBoxFname.Text.Trim() == "") || (TextBoxLname.Text.Trim() == "") || (TextBoxUsername.Text.Trim() == "") || (TextBoxPassword.Text.Trim() == "") || (PictureBoxUser.Image == null))
                    return false;
                else
                    return true;
            }
        }

        private void ButtonUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                PictureBoxUser.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
