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
    public partial class ShowFullRoom : Form
    {
        public ShowFullRoom()
        {
            InitializeComponent();
        }
        Room room = new Room();
        private void ShowFullRoom_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = room.getfullroom();
            dataGridView1.ReadOnly = true;
        }
    }
}
