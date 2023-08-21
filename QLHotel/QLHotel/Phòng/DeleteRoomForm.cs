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
    public partial class DeleteRoomForm : Form
    {
        public DeleteRoomForm()
        {
            InitializeComponent();
        }
        Room room = new Room();
        LoaiPhong loaiphong = new LoaiPhong();
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void ButtonDeleteRoom_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(TextBoxRoomID.Text);
                if ((MessageBox.Show("Are You Sure You Want To Delete This Room", "Delete Room", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (room.deleteRoom(id))
                    {
                        MessageBox.Show("Room Deleted", "Deleted Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        DeleteRoomForm deleteRoomForm = new DeleteRoomForm();
                        deleteRoomForm.Show();
                        
                    }
                    else
                    {
                        MessageBox.Show("Room Not Deleted", "Delete Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please Try Again", "Delete Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TextBoxRoomID.Text);
            SqlCommand command = new SqlCommand("SELECT * FROM ROOM WHERE PHONGID = " + id);
            DataTable table = room.getRoom(command);
            if (table.Rows.Count > 0)
            {
                TextBoxRoomNumber.Text = table.Rows[0]["SoPhong"].ToString();
                ComboBoxRoom.SelectedValue = table.Rows[0]["LoaiPhongID"].ToString();
                if (table.Rows[0]["TinhTrang"].ToString() == "Trống")
                {
                    RadioButtonClear.Checked = true;
                }
                else
                {
                    RadioButtonFull.Checked = true;
                }
            }
        }

        private void DeleteRoomForm_Load(object sender, EventArgs e)
        {
            ComboBoxRoom.DataSource = loaiphong.getallLoaiPhong();
            ComboBoxRoom.DisplayMember = "TenLoaiPhong";
            ComboBoxRoom.ValueMember = "LoaiPhongID";
            ComboBoxRoom.SelectedItem = "null";
        }

        private void LabelShowFullRoom_Click(object sender, EventArgs e)
        {
            ShowFullRoom showFullRoom = new ShowFullRoom();
            showFullRoom.Show();
        }
    }
}
