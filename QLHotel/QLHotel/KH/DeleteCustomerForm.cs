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
    public partial class DeleteCustomerForm : Form
    {
        public DeleteCustomerForm()
        {
            InitializeComponent();
        }
        KH kh = new KH();
        Room room = new Room();
        Card card = new Card();
        private void DeleteCustomerForm_Load(object sender, EventArgs e)
        {

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
                TextBoxSoPhong.Text = table.Rows[0]["SoPhong"].ToString();
            }
        }

        private void ButtonXoaKH_Click(object sender, EventArgs e)
        {
            int sophong = Convert.ToInt32(TextBoxSoPhong.Text);
            try
            {
                int makh = Convert.ToInt32(TextBoxMaKH.Text);
                if (kh.deleteKH(makh))
                {
                    MessageBox.Show("Customer Deleted", "Delete Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    room.updateRoom(sophong, "Clear");
                    card.deleteThe(sophong);
                    this.Hide();
                    DeleteCustomerForm deleteCustomerForm = new DeleteCustomerForm();
                    deleteCustomerForm.Show();
                }
                else
                {
                    MessageBox.Show("Error", "Delete Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Cusmoter", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ButtonQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ButtonShowAllRoom_Click(object sender, EventArgs e)
        {
            ShowFullCustomer showFullCustomer = new ShowFullCustomer();
            showFullCustomer.Show();
        }
    }
}
