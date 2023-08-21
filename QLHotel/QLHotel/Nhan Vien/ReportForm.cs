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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now.AddDays(-1);
            string day = date.DayOfWeek.ToString();
            DataGridViewReport.DataSource = reporttable(day);
        }
        MY_DB mydb = new MY_DB();
        private DataTable reporttable(string day)
        {
            SqlCommand command = new SqlCommand("SELECT DISTINCT ca1,ca2,ca3,ca4,ca5,ca6, Ca.manv as 'Mã NV',honv as 'Họ NV',tennv as 'Tên NV',chucvu as 'Chức vụ', sum(Giolam.giolam) as 'Tổng giờ làm',tong as 'Giờ cần làm' from Giolam,Ca WHERE Giolam.manv = Ca.manv AND Giolam.dayofweek = Ca.dayofweek AND Ca.dayofweek = '" + day + "' GROUP BY Ca.manv,honv,tennv,chucvu,tong,ca1,ca2,ca3,ca4,ca5,ca6;", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            table.Columns.Add("Lương");
            foreach (DataRow row in table.Rows)
            { 
                int count = 0;
                for (int i = 0;i < 6;i++)
                {
                    if (row[i].ToString() == "x")
                        count++;
                }
                row["Giờ cần làm"] = count*4;
                int gcl = int.Parse(row[11].ToString());
                int tgl = int.Parse(row[10].ToString());
                if (row["Chức vụ"].ToString() == "Lao Cong")
                {
                    row["Lương"] = tgl * 40000 + (tgl - gcl) * 80000;
                }
                else
                {
                    row["Lương"] = tgl * 60000 + (tgl - gcl) * 120000;
                }    
            }
            table.Columns.Remove("ca1");
            table.Columns.Remove("ca2");
            table.Columns.Remove("ca3");
            table.Columns.Remove("ca4");
            table.Columns.Remove("ca5");
            table.Columns.Remove("ca6");
            return table;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
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
            p1.Range.Font.Size = 20;
            p1.Range.Font.Bold = 1;
            p1.Range.Text = "BÁO CÁO CUỐI NGÀY";
            p1.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            p1.Range.InsertParagraphAfter();

            var p4 = oDoc.Paragraphs.Add(System.Reflection.Missing.Value);
            p4.Range.Font.Name = "Calibri";
            p4.Range.Font.Size = 14;
            DateTime date = DateTime.Now.AddDays(-1);
            p4.Range.Text = "Ngày: " + date.Day + "/" + date.Month + "/" + date.Year;
            p4.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            p4.Range.InsertParagraphAfter();

            if (DataGridViewReport.Rows.Count != 0)
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

                //save the file
                oDoc.SaveAs2(filename);
            }
        }
        private void ButtonToFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.DefaultExt = "*.docx";
            savefile.Filter = "DOCX files(*.docx)|*.docx";

            if (savefile.ShowDialog() == DialogResult.OK && savefile.FileName.Length > 0)
            {
                Export_Data_To_Word(DataGridViewReport, savefile.FileName);
                MessageBox.Show("File saved!", "Message Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ButtonPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            printDlg.Document = printDoc;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;
            if (printDlg.ShowDialog() == DialogResult.OK) printDoc.Print();
        }
    }
}
