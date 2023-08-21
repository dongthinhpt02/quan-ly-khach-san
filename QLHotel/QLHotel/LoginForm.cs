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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = "";
            if (radioButtonGiamDoc.Checked)
            {
                query = "SELECT * FROM GiamDoc WHERE username = @User AND password = @Pass";
            }
            else 
            {
                query = "SELECT id,roleid,uname,pwd FROM login WHERE uname = @User AND pwd = @Pass";
            }
            
            if (verif())
            {
                SqlCommand command = new SqlCommand(query, db.getConnection);
                command.Parameters.Add("@User", SqlDbType.VarChar).Value = TextBoxUsername.Text;
                command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = TextBoxPassword.Text;
                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0 && radioButtonGiamDoc.Checked)
                {
                    RoleForm roleForm = new RoleForm();
                    roleForm.ShowDialog();
                }
                else if (table.Rows.Count > 0)
                {
                    int userid = Convert.ToInt16(table.Rows[0][0].ToString());
                    Globals.SetGlobalUserID(userid);
                    
                    if (radioButtonQuanLi.Checked && table.Rows[0][1].ToString() == "1")
                    {
                        this.Hide();
                        MainForm mainForm = new MainForm();
                        mainForm.ShowDialog();
                    }
                    else if (radioButtonLaoCong.Checked && table.Rows[0][1].ToString() == "3")
                    {
                        this.Hide();
                        CheckInOutForm checkInOutForm = new CheckInOutForm();
                        checkInOutForm.ShowDialog();
                    }
                    else if (radioButtonTiepTan.Checked && table.Rows[0][1].ToString() == "2")
                    {
                        this.Hide();
                        TiepTanForm tiepTanForm = new TiepTanForm();
                        tiepTanForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username Or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }    
                }
                else
                {
                    MessageBox.Show("Invalid Username Or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        bool verif()
        {
            if ((TextBoxUsername.Text.Trim() == "") || (TextBoxPassword.Text.Trim() == ""))
                return false;
            else
                return true;
        }
        private void globalint()
        { 
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void TextBoxPassword_Click(object sender, EventArgs e)
        {
            TextBoxPassword.Text = "";

            TextBoxPassword.ForeColor = Color.Black;

            TextBoxPassword.PasswordChar = '●';
        }

        private void labelRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            this.Hide();
            registerForm.ShowDialog();
        }
    }
}
