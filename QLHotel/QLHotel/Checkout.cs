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
    public partial class Checkout : Form
    {
        public Checkout()
        {
            InitializeComponent();
        }
        KH kh = new KH();
        Card card = new Card();
        private void ButtonFind_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TextBoxMaKH.Text);
            SqlCommand command = new SqlCommand("SELECT * FROM KH WHERE MaKH = " + id);
            DataTable table = kh.getKH(command);

            if (table.Rows.Count > 0)
            {
                TextBoxFname.Text = table.Rows[0]["Fname"].ToString();
                TextBoxLname.Text = table.Rows[0]["Lname"].ToString();
                if (table.Rows[0]["Gender"].ToString() == "Male")
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
                TextBoxSoPhong.Text = table.Rows[0]["SoPhong"].ToString();
            }
        }

        private void ButtonCheckTheID_Click(object sender, EventArgs e)
        {
            int sp = Convert.ToInt32(TextBoxSoPhong.Text);
            SqlCommand command = new SqlCommand("SELECT Checkin, Checkout FROM The WHERE Sophong = "+sp);
            DataTable table = card.getngaythe(command);
            if (table.Rows.Count > 0)
            {
                dateTimePickerCheckintrenthe.Value = (DateTime)(table.Rows[0]["Checkin"]);
                dateTimePickerCheckouttrenthe.Value = (DateTime)(table.Rows[0]["Checkout"]);
            }
        }

        private void ButtonShowAllRoom_Click(object sender, EventArgs e)
        {
            ShowFullCustomer showFullCustomer = new ShowFullCustomer();
            showFullCustomer.Show();
        }

        private void ButtonCheckout_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TextBoxMaKH.Text);
            int sp = Convert.ToInt32(TextBoxSoPhong.Text);
            if (dateTimePickerCheckIn.Value.Date == dateTimePickerCheckintrenthe.Value.Date && dateTimePickerCheckIn.Value.Month == dateTimePickerCheckintrenthe.Value.Month && dateTimePickerCheckIn.Value.Year == dateTimePickerCheckintrenthe.Value.Year && dateTimePickerCheckOut.Value.Date == dateTimePickerCheckouttrenthe.Value.Date && dateTimePickerCheckOut.Value.Month == dateTimePickerCheckouttrenthe.Value.Month && dateTimePickerCheckOut.Value.Year == dateTimePickerCheckouttrenthe.Value.Year && dateTimePickerCheckOut.Value.Hour == dateTimePickerCheckouttrenthe.Value.Hour)
            {
                MessageBox.Show("You can checkout for guests", "Checkout", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                
                HoadonphongForm hoadonphongForm = new HoadonphongForm();
                hoadonphongForm.Show();
            }
            else if(dateTimePickerCheckOut.Value > dateTimePickerCheckouttrenthe.Value)
            {
                MessageBox.Show("Checkout on card must be less then or equal to Checkout ", "Checkout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(dateTimePickerCheckIn.Value != dateTimePickerCheckintrenthe.Value)
            {
                MessageBox.Show("Checkin on card must be equal to Checkin ", "Checkout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void Checkout_Load(object sender, EventArgs e)
        {
            
        }

    }
}
