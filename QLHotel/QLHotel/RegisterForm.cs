using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHotel
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        NguoiDung user = new NguoiDung();
        ChucVu chucvu = new ChucVu();
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
                int roleid = (int)comboBoxChucVu.SelectedValue;
                if (!user.usernameExist(uname, "register", id))
                {
                    PictureBoxUser.Image.Save(pic, PictureBoxUser.Image.RawFormat);
                    if (user.insertUser(id, fname, lname, uname, pwd, pic, roleid))
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

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            comboBoxChucVu.DataSource = chucvu.getRole(Globals.GlobalUserID);
            comboBoxChucVu.DisplayMember = "name";
            comboBoxChucVu.ValueMember = "id";
        }

        private void LableBack_Click(object sender, EventArgs e)
        {
            Close();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
