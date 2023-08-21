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
    public partial class HoadonphongForm : Form
    {
        public HoadonphongForm()
        {
            InitializeComponent();
        }
        Room room = new Room();
        KH kh = new KH();
        MY_DB mydb = new MY_DB();
        Card card = new Card();
        Hoadonphong hoadonphong = new Hoadonphong();
        private void HoadonphongForm_Load(object sender, EventArgs e)
        {
            ComboBoxRoomID.DataSource = room.getRoomNumberFull();
            ComboBoxRoomID.DisplayMember = "Sophong";
            ComboBoxRoomID.ValueMember = "Sophong";
            ComboBoxRoomID.SelectedItem = "null";
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            int sophong = Convert.ToInt32(ComboBoxRoomID.SelectedValue);

     


            SqlCommand command = new SqlCommand("SELECT Checkin,Checkout FROM KH WHERE Sophong = " +sophong);
            DataTable table = kh.getKH(command);
            if (table.Rows.Count > 0)
            {
                dateTimePickerCheckin.Value = (DateTime)(table.Rows[0]["Checkin"]);
                dateTimePickerCheckout.Value = (DateTime)(table.Rows[0]["Checkout"]);
            }
            double songayo = (dateTimePickerCheckout.Value.Date - dateTimePickerCheckin.Value.Date).TotalDays;
            TextBoxSongayo.Text = (songayo.ToString());
           
            double songayothucte = (DateTime.Now.Date - dateTimePickerCheckin.Value.Date).TotalDays;
            TextBoxSongayothucte.Text = (songayothucte.ToString());
            double sogiotre = 0;
            if (DateTime.Now.Date <= dateTimePickerCheckout.Value.Date || DateTime.Now.Hour <= dateTimePickerCheckout.Value.Hour)
            {
                sogiotre = 0;
                TextBoxSogiotre.Text = (sogiotre.ToString());
            }
            else if(DateTime.Now.Date >= dateTimePickerCheckout.Value.Date)
            {
                sogiotre = DateTime.Now.Hour - dateTimePickerCheckout.Value.Hour;
                sogiotre = Math.Abs(sogiotre);
                TextBoxSogiotre.Text = (sogiotre.ToString());
            }
     
            SqlCommand command1 = new SqlCommand("SELECT LoaiPhong.LoaiPhongID, LoaiPhong.Giatien, Room.Sophong FROM LoaiPhong,Room WHERE LoaiPhong.Tenloaiphong = Room.LoaiPhongID and Sophong = " + sophong, mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command1);
            DataTable table1 = new DataTable();
            adapter.Fill(table1);
            if (table1.Rows.Count > 0)
            {
                double thanhtien = Convert.ToInt32(table1.Rows[0]["Giatien"].ToString());
                TextBoxTienphong1ngay.Text = (thanhtien.ToString());
                TextBoxTienphongbandau.Text = (thanhtien * songayo).ToString();
                if(songayo > songayothucte)
                {
                    songayothucte = songayo;
                    TextBoxThanhtien.Text = (songayothucte * thanhtien).ToString();
                    TextBoxSongayothucte.Text = (songayothucte).ToString();
                    label5.Text = ("Vì khách checkin sớm nên tính tiền phòng theo số ngày ở ban đầu ");
                }
                if (sogiotre <= 3)
                {
                    TextBoxThanhtien.Text = (songayothucte * thanhtien).ToString();
                    labelchuthich.Text = "Khách trả phòng đúng hạn";
                }else if(sogiotre > 3 && sogiotre <= 4)
                {
                    double thanhtien1 = (songayothucte * thanhtien)*1.5;
                    TextBoxThanhtien.Text = (thanhtien1).ToString();
                    labelchuthich.Text = "Khách trả phòng quá 3 tiếng phạt thêm nửa tiền phòng";
                }
                else if(sogiotre > 4)
                {
                    double thanhtien2 = (songayothucte * thanhtien) * 2;
                    TextBoxThanhtien.Text = (thanhtien2).ToString();
                    labelchuthich.Text = "Khách trả phòng quá 4 tiếng phạt gấp đôi tiền phòng";
                }
            }
        }

        private void ButtonThemhoadonphong_Click(object sender, EventArgs e)
        {
            int sophong = Convert.ToInt32(ComboBoxRoomID.SelectedValue);
            DateTime checkin = dateTimePickerCheckin.Value;
            DateTime checkout = dateTimePickerCheckout.Value;
            double songayothucte = Convert.ToDouble(TextBoxSongayothucte.Text);
            double sogiotre = Convert.ToDouble(TextBoxSogiotre.Text);
            double tienphong1ngay = Convert.ToDouble(TextBoxTienphong1ngay.Text);
            double thanhtien = Convert.ToDouble(TextBoxThanhtien.Text);
            if (hoadonphong.checkidRoom(sophong))
            {
                if (hoadonphong.inserthoadonphong(sophong, checkin, checkout, songayothucte, sogiotre, tienphong1ngay, thanhtien))
                {
                    MessageBox.Show("New Bill Room Inserted", "Bill Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Hoadon hoadon = new Hoadon();
                    hoadon.Show();
                }
                else
                {
                    MessageBox.Show("New Bill Room Is Not Inserted", "Bill Room", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("This Bill Room Number Already Exists", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
    }
}
