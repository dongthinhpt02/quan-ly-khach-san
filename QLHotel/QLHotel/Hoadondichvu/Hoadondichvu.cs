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
    public partial class Hoadondichvu : Form
    {
        public Hoadondichvu()
        {
            InitializeComponent();
        }
        Room room = new Room();
        Service service = new Service();
        private void Hoadondichvu_Load(object sender, EventArgs e)
        {
            ComboBoxRoomNumber.DataSource = room.getRoomFull();
            ComboBoxRoomNumber.DisplayMember = "SoPhong";
            ComboBoxRoomNumber.ValueMember = "SoPhong";
            ComboBoxRoomNumber.SelectedItem = "null";

            ComboBoxService.DataSource = service.getdichvu();
            ComboBoxService.DisplayMember = "Tendichvu";
            ComboBoxService.ValueMember = "Tendichvu";
            ComboBoxService.SelectedItem = "null";
        }

        private void ComboBoxService_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string tendichvu = (string)ComboBoxService.SelectedValue;
                DataTable table = new DataTable();
                table = service.getgiatien(tendichvu);
                TextBoxGiatiendichvu.Text = table.Rows[0][1].ToString();
            }
            catch
            {

            }
        }

        private void ButtonCallService_Click(object sender, EventArgs e)
        {
            int sophong = Convert.ToInt32(ComboBoxRoomNumber.SelectedValue);
            string tendichvu = (string)ComboBoxService.SelectedValue;
            int giatien = Convert.ToInt32(TextBoxGiatiendichvu.Text);
            if(service.insertdichvu(sophong,tendichvu,giatien))
            {
                MessageBox.Show("New Bill Service Add", "Add Bill Service", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error", "Add Bill Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
