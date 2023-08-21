
namespace QLHotel
{
    partial class XoaSuaNV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxMaNV = new System.Windows.Forms.TextBox();
            this.TextBoxHoNV = new System.Windows.Forms.TextBox();
            this.TextBoxTenNV = new System.Windows.Forms.TextBox();
            this.ButtonTimKiem = new System.Windows.Forms.Button();
            this.ButtonChinhSua = new System.Windows.Forms.Button();
            this.ButtonXoa = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RadioButtonNu = new System.Windows.Forms.RadioButton();
            this.RadioButtonNam = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxChucVu = new System.Windows.Forms.TextBox();
            this.TextBoxSDT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TextBoxCMND = new System.Windows.Forms.TextBox();
            this.TextBoxDiaChi = new System.Windows.Forms.TextBox();
            this.TextBoxQueQuan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã NV : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ Nv : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên NV : ";
            // 
            // TextBoxMaNV
            // 
            this.TextBoxMaNV.Location = new System.Drawing.Point(162, 63);
            this.TextBoxMaNV.Name = "TextBoxMaNV";
            this.TextBoxMaNV.Size = new System.Drawing.Size(128, 22);
            this.TextBoxMaNV.TabIndex = 6;
            this.TextBoxMaNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxMaNV_KeyPress);
            // 
            // TextBoxHoNV
            // 
            this.TextBoxHoNV.Location = new System.Drawing.Point(162, 115);
            this.TextBoxHoNV.Name = "TextBoxHoNV";
            this.TextBoxHoNV.Size = new System.Drawing.Size(235, 22);
            this.TextBoxHoNV.TabIndex = 7;
            // 
            // TextBoxTenNV
            // 
            this.TextBoxTenNV.Location = new System.Drawing.Point(162, 166);
            this.TextBoxTenNV.Name = "TextBoxTenNV";
            this.TextBoxTenNV.Size = new System.Drawing.Size(235, 22);
            this.TextBoxTenNV.TabIndex = 8;
            // 
            // ButtonTimKiem
            // 
            this.ButtonTimKiem.Location = new System.Drawing.Point(308, 61);
            this.ButtonTimKiem.Name = "ButtonTimKiem";
            this.ButtonTimKiem.Size = new System.Drawing.Size(101, 26);
            this.ButtonTimKiem.TabIndex = 13;
            this.ButtonTimKiem.Text = "Tìm Kiếm";
            this.ButtonTimKiem.UseVisualStyleBackColor = true;
            this.ButtonTimKiem.Click += new System.EventHandler(this.ButtonTimKiem_Click);
            // 
            // ButtonChinhSua
            // 
            this.ButtonChinhSua.Location = new System.Drawing.Point(278, 325);
            this.ButtonChinhSua.Name = "ButtonChinhSua";
            this.ButtonChinhSua.Size = new System.Drawing.Size(131, 51);
            this.ButtonChinhSua.TabIndex = 19;
            this.ButtonChinhSua.Text = "Chỉnh sửa";
            this.ButtonChinhSua.UseVisualStyleBackColor = true;
            this.ButtonChinhSua.Click += new System.EventHandler(this.ButtonChinhSua_Click);
            // 
            // ButtonXoa
            // 
            this.ButtonXoa.Location = new System.Drawing.Point(457, 325);
            this.ButtonXoa.Name = "ButtonXoa";
            this.ButtonXoa.Size = new System.Drawing.Size(117, 51);
            this.ButtonXoa.TabIndex = 20;
            this.ButtonXoa.Text = "Xóa";
            this.ButtonXoa.UseVisualStyleBackColor = true;
            this.ButtonXoa.Click += new System.EventHandler(this.ButtonXoa_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Giới tính : ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RadioButtonNu);
            this.panel1.Controls.Add(this.RadioButtonNam);
            this.panel1.Location = new System.Drawing.Point(160, 211);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 35);
            this.panel1.TabIndex = 22;
            // 
            // RadioButtonNu
            // 
            this.RadioButtonNu.AutoSize = true;
            this.RadioButtonNu.Location = new System.Drawing.Point(98, 7);
            this.RadioButtonNu.Name = "RadioButtonNu";
            this.RadioButtonNu.Size = new System.Drawing.Size(47, 21);
            this.RadioButtonNu.TabIndex = 15;
            this.RadioButtonNu.TabStop = true;
            this.RadioButtonNu.Text = "Nữ";
            this.RadioButtonNu.UseVisualStyleBackColor = true;
            // 
            // RadioButtonNam
            // 
            this.RadioButtonNam.AutoSize = true;
            this.RadioButtonNam.Checked = true;
            this.RadioButtonNam.Location = new System.Drawing.Point(3, 7);
            this.RadioButtonNam.Name = "RadioButtonNam";
            this.RadioButtonNam.Size = new System.Drawing.Size(58, 21);
            this.RadioButtonNam.TabIndex = 9;
            this.RadioButtonNam.TabStop = true;
            this.RadioButtonNam.Text = "Nam";
            this.RadioButtonNam.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(478, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Chức vụ : ";
            // 
            // TextBoxChucVu
            // 
            this.TextBoxChucVu.Location = new System.Drawing.Point(563, 62);
            this.TextBoxChucVu.Name = "TextBoxChucVu";
            this.TextBoxChucVu.Size = new System.Drawing.Size(100, 22);
            this.TextBoxChucVu.TabIndex = 33;
            // 
            // TextBoxSDT
            // 
            this.TextBoxSDT.Location = new System.Drawing.Point(563, 160);
            this.TextBoxSDT.Name = "TextBoxSDT";
            this.TextBoxSDT.Size = new System.Drawing.Size(164, 22);
            this.TextBoxSDT.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(478, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 40;
            this.label8.Text = "SĐT : ";
            // 
            // TextBoxCMND
            // 
            this.TextBoxCMND.Location = new System.Drawing.Point(563, 253);
            this.TextBoxCMND.Name = "TextBoxCMND";
            this.TextBoxCMND.Size = new System.Drawing.Size(164, 22);
            this.TextBoxCMND.TabIndex = 37;
            // 
            // TextBoxDiaChi
            // 
            this.TextBoxDiaChi.Location = new System.Drawing.Point(563, 115);
            this.TextBoxDiaChi.Name = "TextBoxDiaChi";
            this.TextBoxDiaChi.Size = new System.Drawing.Size(164, 22);
            this.TextBoxDiaChi.TabIndex = 38;
            // 
            // TextBoxQueQuan
            // 
            this.TextBoxQueQuan.Location = new System.Drawing.Point(563, 204);
            this.TextBoxQueQuan.Name = "TextBoxQueQuan";
            this.TextBoxQueQuan.Size = new System.Drawing.Size(164, 22);
            this.TextBoxQueQuan.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(474, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 36;
            this.label6.Text = "Số CMND : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(474, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "Quê quán : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(479, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 17);
            this.label9.TabIndex = 35;
            this.label9.Text = "Địa chỉ : ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 39);
            this.button1.TabIndex = 46;
            this.button1.Text = "< Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // XoaSuaNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 395);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextBoxSDT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TextBoxCMND);
            this.Controls.Add(this.TextBoxDiaChi);
            this.Controls.Add(this.TextBoxQueQuan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TextBoxChucVu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonXoa);
            this.Controls.Add(this.ButtonChinhSua);
            this.Controls.Add(this.ButtonTimKiem);
            this.Controls.Add(this.TextBoxTenNV);
            this.Controls.Add(this.TextBoxHoNV);
            this.Controls.Add(this.TextBoxMaNV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "XoaSuaNV";
            this.Text = "XoaSuaNV";
            this.Load += new System.EventHandler(this.XoaSuaNV_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox TextBoxMaNV;
        public System.Windows.Forms.TextBox TextBoxHoNV;
        public System.Windows.Forms.TextBox TextBoxTenNV;
        public System.Windows.Forms.Button ButtonTimKiem;
        public System.Windows.Forms.Button ButtonChinhSua;
        public System.Windows.Forms.Button ButtonXoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton RadioButtonNu;
        private System.Windows.Forms.RadioButton RadioButtonNam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBoxChucVu;
        private System.Windows.Forms.TextBox TextBoxSDT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TextBoxCMND;
        private System.Windows.Forms.TextBox TextBoxDiaChi;
        private System.Windows.Forms.TextBox TextBoxQueQuan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}