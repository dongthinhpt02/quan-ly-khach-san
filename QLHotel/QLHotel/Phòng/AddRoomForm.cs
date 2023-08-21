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
    public partial class AddRoomForm : Form
    {
        public AddRoomForm()
        {
            InitializeComponent();
        }
        LoaiPhong loaiphong = new LoaiPhong();
        Room room = new Room();
        private void ButtonAddRoom_Click(object sender, EventArgs e)
        {
            int roomid = Convert.ToInt32(TextBoxRoomID.Text);
            string loaiphong = (string)(ComboBoxRoom.SelectedValue);
            string tinhtrang = "Clear";
            if (RadioButtonFull.Checked)
            {
                tinhtrang = "Full";
            }
            int sophong = Convert.ToInt32(TextBoxRoomNumber.Text);
            if (room.checkidRoom(roomid))
            {
                if(room.insertRoom(roomid,loaiphong,tinhtrang,sophong))
                {
                    MessageBox.Show("New Room Inserted", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Room Is Not Inserted", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("This Room ID Already Exists", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddRoomForm_Load(object sender, EventArgs e)
        {
            ComboBoxRoom.DataSource = loaiphong.getallLoaiPhong();
            ComboBoxRoom.DisplayMember = "TenLoaiPhong";
            ComboBoxRoom.ValueMember = "TenLoaiPhong";
            ComboBoxRoom.SelectedItem = "null";
        }
    }
}
