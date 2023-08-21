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
    public partial class EditRoomForm : Form
    {
        public EditRoomForm()
        {
            InitializeComponent();
        }
        LoaiPhong loaiphong = new LoaiPhong();
        Room room = new Room();
        private void EditRoomForm_Load(object sender, EventArgs e)
        { 
            ComboBoxRoom.DataSource = loaiphong.getallLoaiPhong();
            ComboBoxRoom.DisplayMember = "TenLoaiPhong";
            ComboBoxRoom.ValueMember = "LoaiPhongID";
            ComboBoxRoom.SelectedItem = "null";
        }

        private void ButtonEditRoom_Click(object sender, EventArgs e)
        {
            int sophong = Convert.ToInt32(TextBoxRoomNumber.Text);
            string loaiphong = (string)(ComboBoxRoom.SelectedValue);
            string tinhtrang = "Clear";
            if (RadioButtonFull.Checked)
            {
                tinhtrang = "Full";
            }
            try
            {
                int phongid = Convert.ToInt32(TextBoxRoomID.Text);
                if (room.editRoom(phongid, loaiphong, tinhtrang, sophong))
                {
                    MessageBox.Show("New Room Inserted", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Room Is Not Inserted", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TextBoxRoomID.Text);
            SqlCommand command = new SqlCommand("SELECT * FROM ROOM WHERE PHONGID = " +id);
            DataTable table = room.getRoom(command);
            if(table.Rows.Count > 0)
            {
                TextBoxRoomNumber.Text = table.Rows[0]["SoPhong"].ToString();
                ComboBoxRoom.SelectedValue = table.Rows[0]["LoaiPhongID"].ToString();
                if(table.Rows[0]["TinhTrang"].ToString()=="Clear")
                {
                    RadioButtonClear.Checked = true;
                }
                else
                {
                    RadioButtonFull.Checked = true;
                }    
            }
        }

        private void LabelShowFullRoom_Click(object sender, EventArgs e)
        {
            ShowFullRoom showFullRoom = new ShowFullRoom();
            showFullRoom.Show();
        }
    }
}
