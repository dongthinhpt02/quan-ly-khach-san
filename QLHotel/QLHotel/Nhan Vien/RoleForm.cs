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
    public partial class RoleForm : Form
    {
        public RoleForm()
        {
            InitializeComponent();
        }

        private void RoleForm_Load(object sender, EventArgs e)
        {
            ComboBoxRoleEdit.DataSource = chucvu.getRole(Globals.GlobalUserID);
            ComboBoxRoleEdit.DisplayMember = "name";
            ComboBoxRoleEdit.ValueMember = "id";

            ComboBoxRoleRemove.DataSource = chucvu.getRole(Globals.GlobalUserID);
            ComboBoxRoleRemove.DisplayMember = "name";
            ComboBoxRoleRemove.ValueMember = "id";
        }
        ChucVu chucvu = new ChucVu();
        private void ButtonAddRole_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TextBoxRoleID.Text);
            string rname = TextBoxRoleName.Text;
            int userid = Globals.GlobalUserID;
            if (!chucvu.roleExist(rname, "add", userid, id))
            {
                if (chucvu.insertRole(id, rname, userid))
                {
                    MessageBox.Show("New Role Added", "Add Role", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Add Role", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("This ID Role and Role Name Already Exist, Try Another Ones", "Invalid ID And Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonEditRole_Click(object sender, EventArgs e)
        {
            string rname = TextBoxNewRName.Text;
            try
            {
                int roleid = (int)ComboBoxRoleEdit.SelectedValue;
                if (chucvu.updateRole(roleid, rname))
                {
                    MessageBox.Show("Role Info Updated", "Edit Role", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Edit Role", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Edit Role", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonRemoveRole_Click(object sender, EventArgs e)
        {
            try
            {
                int roleid = (int)ComboBoxRoleRemove.SelectedValue;
                if ((MessageBox.Show("Are You Sure You Want To Delete This Role?", "Delete Role", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (chucvu.deleteRole(roleid))
                    {
                        MessageBox.Show("Role Deleted", "Delete Role", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Role Not Deleted", "Delete Role", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Remove Role", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComboBoxRoleRemove_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
