using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHotel
{
    public partial class EditCustomerForm : Form
    {
        MY_DB mydb = new MY_DB();
        public EditCustomerForm()
        {
            InitializeComponent();
        }
        Room room = new Room();
        KH kh = new KH();
        Card card = new Card();
        private void EditCustomerForm_Load(object sender, EventArgs e)
        {
            ComboBoxSoPhong.DataSource = room.getRoomClear();
            ComboBoxSoPhong.DisplayMember = "SoPhong";
            ComboBoxSoPhong.ValueMember = "SoPhong";
            ComboBoxSoPhong.SelectedItem = "null";
        }

        private void ButtonFind_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TextBoxMaKH.Text);
            SqlCommand command = new SqlCommand("SELECT * FROM KH WHERE MaKH = " + id);
            DataTable table = kh.getKH(command);

            if (table.Rows.Count > 0)
            {
                TextBoxFname.Text = table.Rows[0]["Fname"].ToString();
                TextBoxLname.Text = table.Rows[0]["Lname"].ToString();
                if (table.Rows[0]["gender"].ToString() != "Female")
                {
                    RadioButtonMale.Checked = true;
                }
                else
                {
                    RadioButtonFemale.Checked = true;
                }
                TextBoxCmnd.Text = table.Rows[0]["Cmnd"].ToString();
                TextBoxQuoctich.Text = table.Rows[0]["Quoctich"].ToString();
                dateTimePickerCheckIn.Value = (DateTime)(table.Rows[0]["Checkin"]);
                dateTimePickerCheckOut.Value = (DateTime)(table.Rows[0]["Checkout"]);
                TextBoxSoPhongCu.Text = table.Rows[0]["SoPhong"].ToString();
            }
        }
        private void ButtonEditKH_Click(object sender, EventArgs e)
        {
            string fname = TextBoxFname.Text;
            string lname = TextBoxLname.Text;
            string gender = "Male";
            if (RadioButtonFemale.Checked)
            {
                gender = "Female";
            }
            string cmnd = TextBoxCmnd.Text;
            string quoctich = TextBoxQuoctich.Text;
            DateTime checkin = dateTimePickerCheckIn.Value;
            DateTime checkout = dateTimePickerCheckOut.Value;
            int sophongcu = Convert.ToInt32(TextBoxSoPhongCu.Text);
            int sophong = Convert.ToInt32(ComboBoxSoPhong.SelectedValue);
            try
            {
                int makh = Convert.ToInt32(TextBoxMaKH.Text);
                if(kh.editKH(makh,fname,lname,gender,cmnd,quoctich,checkin,checkout,sophong))
                {
                    MessageBox.Show("Customer Changed", "Edit Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    room.updateRoom(sophong, "Full");
                    room.updateRoom(sophongcu, "Clear");
                    card.deleteThe(sophongcu);
                    AddCardHotelForm addCardHotelForm = new AddCardHotelForm();
                    addCardHotelForm.Show();
                    this.Hide();
                    EditCustomerForm editCustomerForm = new EditCustomerForm();
                    editCustomerForm.Show();
                }
                else
                {
                    MessageBox.Show("Error", "Edit Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Edit Cusmoter", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ButtonShowAllRoom_Click(object sender, EventArgs e)
        {
            ShowFullCustomer showFullCustomer = new ShowFullCustomer();
            showFullCustomer.Show();
        }

        private void ButtonQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ButtonEditKH_Click_1(object sender, EventArgs e)
        {
            KH kh = new KH();
            int makh = Convert.ToInt32(TextBoxMaKH.Text);
            string fname = TextBoxFname.Text;
            string lname = TextBoxLname.Text;
            string gender = "Male";
            if (RadioButtonFemale.Checked)
            {
                gender = "Female";
            }
            string cmnd = TextBoxCmnd.Text;
            string quoctich = TextBoxQuoctich.Text;
            DateTime checkin = dateTimePickerCheckIn.Value;
            DateTime checkout = dateTimePickerCheckOut.Value;
            int sophongcu = Convert.ToInt32(TextBoxSoPhongCu.Text);
            int sophong = Convert.ToInt32(ComboBoxSoPhong.SelectedValue);
            if (checkout.Date > checkin.Date && checkout.Month >= checkin.Month && checkout.Year >= checkin.Year)
            {
                if (kh.editKH(makh,fname,lname,gender,cmnd,quoctich,checkin,checkout,sophong))
                {
                    MessageBox.Show("Customer Edited", "Edit Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    room.updateRoom(sophong, "Full");
                    room.updateRoom(sophongcu, "Clear");
                    this.Hide();
                    EditCustomerForm editCustomerForm = new EditCustomerForm();
                    editCustomerForm.Show();
                }
                else
                {
                    MessageBox.Show("Error", "Edit Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Checkout must be gearter then Checkin", "Invalid Checkout, Checkin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }   
}
