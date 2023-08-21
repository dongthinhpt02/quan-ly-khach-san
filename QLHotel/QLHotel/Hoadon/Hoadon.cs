using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace QLHotel
{
    public partial class Hoadon : Form
    {
        public Hoadon()
        {
            InitializeComponent();
        }
        Room room = new Room();
        Hoadonphong hoadonphong = new Hoadonphong();
        Service service = new Service();
        Tonghoadon tonghoadon = new Tonghoadon();
        Doanhthu doanhthu = new Doanhthu();
        KH kh = new KH();
        Card card = new Card();
        private void Hoadon_Load(object sender, EventArgs e)
        {
            ComboBoxRoomID.DataSource = room.getRoomNumberFull();
            ComboBoxRoomID.DisplayMember = "Sophong";
            ComboBoxRoomID.ValueMember = "Sophong";
            ComboBoxRoomID.SelectedItem = "null";
        }
        private void fillGrid1(SqlCommand command)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.DataSource = hoadonphong.gethoadonphong(command);
            dataGridView1.AllowUserToAddRows = false;
        }
        private void fillGrid2(SqlCommand command)
        {
            dataGridView2.ReadOnly = true;
            dataGridView2.RowTemplate.Height = 40;
            dataGridView2.DataSource = service.gethoadondichvu(command);
            dataGridView2.AllowUserToAddRows = false;
        }
        private void ButtonTimkiem_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT Hoadonphong.SoPhong as 'Số Phòng', Room.LoaiPhongID as 'Loại Phòng' , Hoadonphong.Thanhtien as 'Tổng tiền phòng' FROM Hoadonphong,Room WHERE Hoadonphong.SoPhong = Room.SoPhong and Hoadonphong.SoPhong like '%" + ComboBoxRoomID.SelectedValue + "%'");
            fillGrid1(command);
            SqlCommand command1 = new SqlCommand("SELECT SoPhong as 'Số Phòng', Tendichvu as 'Tên dịch vụ', Giatien as 'Giá tiền dịch vụ'  FROM Hoadondichvu WHERE SoPhong like '%" + ComboBoxRoomID.SelectedValue + "%'");
            fillGrid2(command1);
            int a = 0;
            for (int i = 0; i <= dataGridView1.RowCount - 1; i++)
            {
                a = a + int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
            }
            label2.Text = ("Tiền phòng số " + ComboBoxRoomID.SelectedValue + " là ");
            label4.Text = a.ToString();
            int b = 0;
            for (int i = 0; i <= dataGridView2.RowCount - 1; i++)
            {
                b = b + int.Parse(dataGridView2.Rows[i].Cells[2].Value.ToString());
            }
            label3.Text = ("Tổng tiền dịch vụ phòng " + ComboBoxRoomID.SelectedValue + " là ");
            label5.Text = b.ToString();
            label6.Text = ("Tổng tiền của phòng " + ComboBoxRoomID.SelectedValue + " là ");
            label7.Text = (a + b).ToString();
        }

        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            object oMissing = System.Reflection.Missing.Value;
            object oMissing1 = System.Reflection.Missing.Value;
            Word.Document oDoc = new Word.Document();
            oDoc.Application.Visible = true;
            object oEndOfDoc = "\\endofdoc";
            //page orintation
            oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;
            var p2 = oDoc.Paragraphs.Add(System.Reflection.Missing.Value);
            p2.Range.Font.Name = "Calibri";
            p2.Range.Font.Size = 30;
            p2.Range.Font.Bold = 1;
            p2.Range.Font.Color = Word.WdColor.wdColorBlue;
            p2.Range.Text = "Khách sạn Xiao";
            p2.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            p2.Range.InsertParagraphAfter();

            oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;
            var p3 = oDoc.Paragraphs.Add(System.Reflection.Missing.Value);
            p3.Range.Font.Name = "Calibri";
            p3.Range.Font.Size = 14;
            p3.Range.Font.Bold = 1;
            p3.Range.Text = "Địa chỉ: 1 Võ Văn Ngân - Linh Chiểu - Thủ Đức - TPHCM \nSố điện thoại: 03564874894 \nWebsite: www.khachsannt.com";
            p3.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            p3.Range.InsertParagraphAfter();

            var p5 = oDoc.Paragraphs.Add(System.Reflection.Missing.Value);
            p5.Range.Font.Name = "Calibri";
            p5.Range.Font.Size = 20;
            p5.Range.Font.Bold = 0;
            p5.Range.Text = "-------------------------------------------------------------------------------------------------";
            p5.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            p5.Range.InsertParagraphAfter();

            var p1 = oDoc.Paragraphs.Add(System.Reflection.Missing.Value);
            p1.Range.Font.Name = "Calibri";
            p1.Range.Font.Size = 25;
            p1.Range.Font.Bold = 1;
            p1.Range.Text = "Hóa đơn phòng " + ComboBoxRoomID.SelectedValue;
            p1.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            p1.Range.InsertParagraphAfter();

            var p4 = oDoc.Paragraphs.Add(System.Reflection.Missing.Value);
            p4.Range.Font.Name = "Calibri";
            p4.Range.Font.Size = 14;
            p4.Range.Text = "Ngày: " + DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;
            p4.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            p4.Range.InsertParagraphAfter();

            if (dataGridView2.Rows.Count != 0)
            {
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;
                Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

                //add rows
                int r = 0;
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    for (r = 0; r <= RowCount - 1; r++)
                    {
                        DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                    } //end row loop
                } //end column loop


                dynamic oRange = oDoc.Bookmarks.get_Item(ref oEndOfDoc​).Range;
                string oTemp = "";
                for (r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        oTemp = oTemp + DataArray[r, c] + "\t";

                    }
                }

                //table format
                oRange.Text = oTemp;

                object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;

                oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                      Type.Missing, Type.Missing, ref ApplyBorders,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);

                oRange.Select();

                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();

                //header row style
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Times New Roman";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

                //add header row manually

                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                }

                //table style 
                oDoc.Application.Selection.Tables[1].set_Style("Grid Table 4 - Accent 5");
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                //header text
                var p6 = oDoc.Paragraphs.Add(System.Reflection.Missing.Value);
                p6.Range.Font.Name = "Calibri";
                p6.Range.Font.Size = 14;
                p6.Range.Font.Bold = 1;
                p6.Range.Text = "\nTổng dịch vụ: " + label5.Text;
                p6.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
                p6.Range.InsertParagraphAfter();

                var p7 = oDoc.Paragraphs.Add(System.Reflection.Missing.Value);
                p7.Range.Font.Name = "Calibri";
                p7.Range.Font.Size = 14;
                p7.Range.Font.Bold = 1;
                p7.Range.Text = "Tiền phòng: " + label4.Text;
                p7.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
                p7.Range.InsertParagraphAfter();

                var p8 = oDoc.Paragraphs.Add(System.Reflection.Missing.Value);
                p8.Range.Font.Name = "Calibri";
                p8.Range.Font.Size = 14;
                p8.Range.Font.Bold = 1;
                p8.Range.Font.Italic = 1;
                p8.Range.Text = "Tổng: " + label7.Text;
                p8.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
                p8.Range.InsertParagraphAfter();

                var pa = oDoc.Paragraphs.Add(System.Reflection.Missing.Value);
                pa.Range.Font.Name = "Calibri";
                pa.Range.Font.Size = 20;
                pa.Range.Font.Bold = 0;
                pa.Range.Text = "-------------------------------------------------------------------------------------------------";
                pa.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                pa.Range.InsertParagraphAfter();


                var pc = oDoc.Paragraphs.Add(System.Reflection.Missing.Value);
                pc.Range.Font.Name = "Calibri";
                pc.Range.Font.Size = 14;
                pc.Range.Font.Bold = 1;
                pc.Range.Text = "                     Khách hàng                                                                                                                      Người lập hóa đơn             ";
                pc.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;

                //save the file
                oDoc.SaveAs2(filename);
            }
        }
        private void ButtonThemHoadon_Click(object sender, EventArgs e)
        {
            string ngaythangnam = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;
            int sophong = Convert.ToInt32(ComboBoxRoomID.SelectedValue);
            int tien = Convert.ToInt32(label7.Text);
            if (doanhthu.insertdoanhthu(ngaythangnam,sophong,tien))
            {
                MessageBox.Show("New Revenue Inserted", "Add Revenue", MessageBoxButtons.OK, MessageBoxIcon.Information);
                kh.deleteKHtheosophong(sophong);
                room.updateRoom(sophong, "Clear");
                hoadonphong.deletehoadonphong(sophong);
                service.deletedichvu(sophong);
                card.deleteThe(sophong);
                this.Hide();
                Hoadon hoadon = new Hoadon();
                hoadon.Show();
            }
            else
            {
                MessageBox.Show("Revenue Is Not Inserted", "Add Revenue", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonInHoaDon_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.DefaultExt = "*.docx";
            savefile.Filter = "DOCX files(*.docx)|*.docx";

            if (savefile.ShowDialog() == DialogResult.OK && savefile.FileName.Length > 0)
            {
                Export_Data_To_Word(dataGridView2, savefile.FileName);
                MessageBox.Show("File saved!", "Message Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
