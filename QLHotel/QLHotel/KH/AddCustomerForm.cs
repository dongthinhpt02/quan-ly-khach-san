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
    public partial class AddCustomerForm : Form
    {
        public AddCustomerForm()
        {
            InitializeComponent();
        }
        Room room = new Room();
        private void ButtonThemKH_Click(object sender, EventArgs e)
        {
            KH kh = new KH();
            int makh = Convert.ToInt32(TextBoxMaKH.Text);
            string fname = TextBoxFname.Text;
            string lname = TextBoxLname.Text;
            string gender = "Male";
            if(RadioButtonFemale.Checked)
            {
                gender = "Female";
            }
            string cmnd = TextBoxCmnd.Text;
            string quoctich = TextBoxQuoctich.Text;
            DateTime checkin = dateTimePickerCheckIn.Value;
            DateTime checkout = dateTimePickerCheckOut.Value;
            int sophong = Convert.ToInt32(ComboBoxSoPhong.SelectedValue);
            if (checkout.Date > checkin.Date && checkout.Month >= checkin.Month && checkout.Year >= checkin.Year)
            {
                if (kh.insertKH(makh, fname, lname, gender, cmnd, quoctich, checkin, checkout, sophong))
                {
                    MessageBox.Show("New Customer Add", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    room.updateRoom(sophong, "Full");
                    
                    this.Hide();
                    AddCustomerForm addCustomerForm = new AddCustomerForm();
                    addCustomerForm.Show();
                    AddCardHotelForm addCardHotelForm = new AddCardHotelForm();
                    addCardHotelForm.Show();
                }
                else
                {
                    MessageBox.Show("Error", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Checkout must be gearter then Checkin", "Invalid Checkout, Checkin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        { 
            ComboBoxSoPhong.DataSource = room.getRoomClear();
            ComboBoxSoPhong.DisplayMember = "SoPhong";
            ComboBoxSoPhong.ValueMember = "SoPhong";
            ComboBoxSoPhong.SelectedItem = "null";
        }

        private void ButtonQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ButtonShowFullCustomer_Click(object sender, EventArgs e)
        {
            ShowFullCustomer showFullCustomer = new ShowFullCustomer();
            showFullCustomer.Show();
        }
    }
}
