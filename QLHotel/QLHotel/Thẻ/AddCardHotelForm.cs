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
    public partial class AddCardHotelForm : Form
    {
        public AddCardHotelForm()
        {
            InitializeComponent();
        }
        Room room = new Room();
        private void AddCardHotelForm_Load(object sender, EventArgs e)
        {
            ComboBoxRoomNumber.DataSource = room.getRoomNumberFull();
            ComboBoxRoomNumber.DisplayMember = "SoPhong";
            ComboBoxRoomNumber.ValueMember = "SoPhong";
            ComboBoxRoomNumber.SelectedItem = "null";
        }
        private void ButtonAddCard_Click(object sender, EventArgs e)
        {
            Card the = new Card();
            int sophong = Convert.ToInt32(ComboBoxRoomNumber.SelectedValue);
            DateTime checkin = dateTimePickerCheckin.Value;
            DateTime checkout = dateTimePickerCheckout.Value;
            if(the.checkidroom(sophong) && checkout.Date > checkin.Date && checkout.Month >= checkin.Month && checkout.Year >= checkin.Year)
            {
                if ((the.insertThe(sophong, checkin, checkout)))
                {
                    MessageBox.Show("New Card Inserted", "Add Card", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Card Is Not Inserted", "Add Card", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if(!the.checkidroom(sophong))
            {
                MessageBox.Show("Room had card", "Add Card", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Checkin, checkout are not available", "Add Card", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    
        }
    }
}
