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
    public partial class MainFormRoomAndGuest : Form
    {
        public MainFormRoomAndGuest()
        {
            InitializeComponent();
        }
        Room room = new Room();
        private void MainFormRoomAndGuest_Load(object sender, EventArgs e)
        {
            
        }

        private void thêmKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomerForm = new AddCustomerForm();
            addCustomerForm.Show();
        }

        private void chỉnhSửaKHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCustomerForm editCustomerForm = new EditCustomerForm();
            editCustomerForm.Show();
        }

        private void xóaKHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteCustomerForm deleteCustomerForm = new DeleteCustomerForm();
            deleteCustomerForm.Show();
        }

        private void hiệnTấtCảKHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFullCustomer showFullCustomer = new ShowFullCustomer();
            showFullCustomer.Show();
        }

        private void thêmPhòngMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRoomForm addRoomForm = new AddRoomForm();
            addRoomForm.Show();
        }

        private void chỉnhSửaPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditRoomForm editRoomForm = new EditRoomForm();
            editRoomForm.Show();
        }

        private void xóaPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteRoomForm deleteRoomForm = new DeleteRoomForm();
            deleteRoomForm.Show();
        }

        private void hiệnTấtCảPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFullRoom showFullRoom = new ShowFullRoom();
            showFullRoom.Show();
        }

        private void ButtonGoiDichVu_Click(object sender, EventArgs e)
        {
            Hoadondichvu hoadondichvu = new Hoadondichvu();
            hoadondichvu.Show();
        }

        private void ButtonCheckoutchokhach_Click(object sender, EventArgs e)
        {
            Checkout checkout = new Checkout();
            checkout.Show();
        }

        private void kiểmTraVàInDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoanhThuForm doanhThuForm = new DoanhThuForm();
            doanhThuForm.Show();
        }

        private void nhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nhapkho nhapkho = new Nhapkho();
            nhapkho.Show();
        }

        private void xuấtKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Xuatkho xuatkho = new Xuatkho();
            xuatkho.Show();
        }

        private void kiểmTraKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kiemtranhapxuat kiemtranhapxuat = new Kiemtranhapxuat();
            kiemtranhapxuat.Show();
        }
    }
}
