
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
            this.TextBoxChucVu = new System.Windows.Forms.TextBox();
            this.TextBoxSDT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxTienChi = new System.Windows.Forms.TextBox();
            this.TextBoxCaLam = new System.Windows.Forms.TextBox();
            this.TextBoxTienThu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã NV : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ Nv : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên NV : ";
            // 
            // TextBoxMaNV
            // 
            this.TextBoxMaNV.Location = new System.Drawing.Point(127, 32);
            this.TextBoxMaNV.Name = "TextBoxMaNV";
            this.TextBoxMaNV.Size = new System.Drawing.Size(128, 22);
            this.TextBoxMaNV.TabIndex = 6;
            this.TextBoxMaNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxMaNV_KeyPress);
            // 
            // TextBoxHoNV
            // 
            this.TextBoxHoNV.Location = new System.Drawing.Point(127, 84);
            this.TextBoxHoNV.Name = "TextBoxHoNV";
            this.TextBoxHoNV.Size = new System.Drawing.Size(235, 22);
            this.TextBoxHoNV.TabIndex = 7;
            // 
            // TextBoxTenNV
            // 
            this.TextBoxTenNV.Location = new System.Drawing.Point(127, 135);
            this.TextBoxTenNV.Name = "TextBoxTenNV";
            this.TextBoxTenNV.Size = new System.Drawing.Size(235, 22);
            this.TextBoxTenNV.TabIndex = 8;
            // 
            // ButtonTimKiem
            // 
            this.ButtonTimKiem.Location = new System.Drawing.Point(273, 30);
            this.ButtonTimKiem.Name = "ButtonTimKiem";
            this.ButtonTimKiem.Size = new System.Drawing.Size(101, 26);
            this.ButtonTimKiem.TabIndex = 13;
            this.ButtonTimKiem.Text = "Tìm Kiếm";
            this.ButtonTimKiem.UseVisualStyleBackColor = true;
            this.ButtonTimKiem.Click += new System.EventHandler(this.ButtonTimKiem_Click);
            // 
            // ButtonChinhSua
            // 
            this.ButtonChinhSua.Location = new System.Drawing.Point(243, 294);
            this.ButtonChinhSua.Name = "ButtonChinhSua";
            this.ButtonChinhSua.Size = new System.Drawing.Size(131, 51);
            this.ButtonChinhSua.TabIndex = 19;
            this.ButtonChinhSua.Text = "Chỉnh sửa";
            this.ButtonChinhSua.UseVisualStyleBackColor = true;
            this.ButtonChinhSua.Click += new System.EventHandler(this.ButtonChinhSua_Click);
            // 
            // ButtonXoa
            // 
            this.ButtonXoa.Location = new System.Drawing.Point(422, 294);
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
            this.label4.Location = new System.Drawing.Point(31, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Giới tính : ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RadioButtonNu);
            this.panel1.Controls.Add(this.RadioButtonNam);
            this.panel1.Location = new System.Drawing.Point(125, 180);
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
            // TextBoxChucVu
            // 
            this.TextBoxChucVu.Location = new System.Drawing.Point(528, 31);
            this.TextBoxChucVu.Name = "TextBoxChucVu";
            this.TextBoxChucVu.Size = new System.Drawing.Size(173, 22);
            this.TextBoxChucVu.TabIndex = 31;
            // 
            // TextBoxSDT
            // 
            this.TextBoxSDT.Location = new System.Drawing.Point(528, 135);
            this.TextBoxSDT.Name = "TextBoxSDT";
            this.TextBoxSDT.Size = new System.Drawing.Size(173, 22);
            this.TextBoxSDT.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(443, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 30;
            this.label8.Text = "SĐT : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(443, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Chức vụ : ";
            // 
            // TextBoxTienChi
            // 
            this.TextBoxTienChi.Location = new System.Drawing.Point(528, 233);
            this.TextBoxTienChi.Name = "TextBoxTienChi";
            this.TextBoxTienChi.Size = new System.Drawing.Size(173, 22);
            this.TextBoxTienChi.TabIndex = 26;
            // 
            // TextBoxCaLam
            // 
            this.TextBoxCaLam.Location = new System.Drawing.Point(528, 84);
            this.TextBoxCaLam.Name = "TextBoxCaLam";
            this.TextBoxCaLam.Size = new System.Drawing.Size(173, 22);
            this.TextBoxCaLam.TabIndex = 27;
            // 
            // TextBoxTienThu
            // 
            this.TextBoxTienThu.Location = new System.Drawing.Point(528, 180);
            this.TextBoxTienThu.Name = "TextBoxTienThu";
            this.TextBoxTienThu.Size = new System.Drawing.Size(173, 22);
            this.TextBoxTienThu.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(433, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Tiền chi : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(434, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Tiền thu : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(443, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "Ca làm : ";
            // 
            // XoaSuaNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 395);
            this.Controls.Add(this.TextBoxChucVu);
            this.Controls.Add(this.TextBoxSDT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextBoxTienChi);
            this.Controls.Add(this.TextBoxCaLam);
            this.Controls.Add(this.TextBoxTienThu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
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
        private System.Windows.Forms.TextBox TextBoxChucVu;
        private System.Windows.Forms.TextBox TextBoxSDT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBoxTienChi;
        private System.Windows.Forms.TextBox TextBoxCaLam;
        private System.Windows.Forms.TextBox TextBoxTienThu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}