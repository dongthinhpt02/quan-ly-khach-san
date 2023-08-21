
namespace QLHotel
{
    partial class DeleteCustomerForm
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
            this.ButtonQuayLai = new System.Windows.Forms.Button();
            this.ButtonXoaKH = new System.Windows.Forms.Button();
            this.dateTimePickerCheckOut = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerCheckIn = new System.Windows.Forms.DateTimePicker();
            this.TextBoxQuoctich = new System.Windows.Forms.TextBox();
            this.RadioButtonFemale = new System.Windows.Forms.RadioButton();
            this.RadioButtonMale = new System.Windows.Forms.RadioButton();
            this.TextBoxCmnd = new System.Windows.Forms.TextBox();
            this.TextBoxLname = new System.Windows.Forms.TextBox();
            this.TextBoxFname = new System.Windows.Forms.TextBox();
            this.TextBoxMaKH = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonFind = new System.Windows.Forms.Button();
            this.TextBoxSoPhong = new System.Windows.Forms.TextBox();
            this.ButtonShowAllKH = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonQuayLai
            // 
            this.ButtonQuayLai.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonQuayLai.Location = new System.Drawing.Point(533, 285);
            this.ButtonQuayLai.Name = "ButtonQuayLai";
            this.ButtonQuayLai.Size = new System.Drawing.Size(134, 48);
            this.ButtonQuayLai.TabIndex = 44;
            this.ButtonQuayLai.Text = "Quay Lại";
            this.ButtonQuayLai.UseVisualStyleBackColor = true;
            this.ButtonQuayLai.Click += new System.EventHandler(this.ButtonQuayLai_Click);
            // 
            // ButtonXoaKH
            // 
            this.ButtonXoaKH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonXoaKH.Location = new System.Drawing.Point(142, 286);
            this.ButtonXoaKH.Name = "ButtonXoaKH";
            this.ButtonXoaKH.Size = new System.Drawing.Size(137, 47);
            this.ButtonXoaKH.TabIndex = 43;
            this.ButtonXoaKH.Text = "Xóa KH";
            this.ButtonXoaKH.UseVisualStyleBackColor = true;
            this.ButtonXoaKH.Click += new System.EventHandler(this.ButtonXoaKH_Click);
            // 
            // dateTimePickerCheckOut
            // 
            this.dateTimePickerCheckOut.CustomFormat = "M/dd/yyyy HH:mm";
            this.dateTimePickerCheckOut.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerCheckOut.Location = new System.Drawing.Point(522, 118);
            this.dateTimePickerCheckOut.Name = "dateTimePickerCheckOut";
            this.dateTimePickerCheckOut.Size = new System.Drawing.Size(201, 27);
            this.dateTimePickerCheckOut.TabIndex = 41;
            // 
            // dateTimePickerCheckIn
            // 
            this.dateTimePickerCheckIn.CustomFormat = "M/dd/yyyy HH:mm";
            this.dateTimePickerCheckIn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerCheckIn.Location = new System.Drawing.Point(522, 73);
            this.dateTimePickerCheckIn.Name = "dateTimePickerCheckIn";
            this.dateTimePickerCheckIn.Size = new System.Drawing.Size(201, 27);
            this.dateTimePickerCheckIn.TabIndex = 40;
            // 
            // TextBoxQuoctich
            // 
            this.TextBoxQuoctich.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxQuoctich.Location = new System.Drawing.Point(522, 36);
            this.TextBoxQuoctich.Name = "TextBoxQuoctich";
            this.TextBoxQuoctich.Size = new System.Drawing.Size(201, 27);
            this.TextBoxQuoctich.TabIndex = 39;
            // 
            // RadioButtonFemale
            // 
            this.RadioButtonFemale.AutoSize = true;
            this.RadioButtonFemale.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonFemale.Location = new System.Drawing.Point(269, 166);
            this.RadioButtonFemale.Name = "RadioButtonFemale";
            this.RadioButtonFemale.Size = new System.Drawing.Size(80, 23);
            this.RadioButtonFemale.TabIndex = 38;
            this.RadioButtonFemale.TabStop = true;
            this.RadioButtonFemale.Text = "Female";
            this.RadioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // RadioButtonMale
            // 
            this.RadioButtonMale.AutoSize = true;
            this.RadioButtonMale.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonMale.Location = new System.Drawing.Point(179, 166);
            this.RadioButtonMale.Name = "RadioButtonMale";
            this.RadioButtonMale.Size = new System.Drawing.Size(65, 23);
            this.RadioButtonMale.TabIndex = 37;
            this.RadioButtonMale.TabStop = true;
            this.RadioButtonMale.Text = "Male";
            this.RadioButtonMale.UseVisualStyleBackColor = true;
            // 
            // TextBoxCmnd
            // 
            this.TextBoxCmnd.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxCmnd.Location = new System.Drawing.Point(177, 211);
            this.TextBoxCmnd.Name = "TextBoxCmnd";
            this.TextBoxCmnd.Size = new System.Drawing.Size(207, 27);
            this.TextBoxCmnd.TabIndex = 36;
            // 
            // TextBoxLname
            // 
            this.TextBoxLname.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxLname.Location = new System.Drawing.Point(177, 120);
            this.TextBoxLname.Name = "TextBoxLname";
            this.TextBoxLname.Size = new System.Drawing.Size(212, 27);
            this.TextBoxLname.TabIndex = 35;
            // 
            // TextBoxFname
            // 
            this.TextBoxFname.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxFname.Location = new System.Drawing.Point(179, 76);
            this.TextBoxFname.Name = "TextBoxFname";
            this.TextBoxFname.Size = new System.Drawing.Size(205, 27);
            this.TextBoxFname.TabIndex = 34;
            // 
            // TextBoxMaKH
            // 
            this.TextBoxMaKH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxMaKH.Location = new System.Drawing.Point(179, 36);
            this.TextBoxMaKH.Name = "TextBoxMaKH";
            this.TextBoxMaKH.Size = new System.Drawing.Size(100, 27);
            this.TextBoxMaKH.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(419, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 19);
            this.label9.TabIndex = 32;
            this.label9.Text = "Số phòng : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(419, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 19);
            this.label8.TabIndex = 31;
            this.label8.Text = "Check out : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(419, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 19);
            this.label7.TabIndex = 30;
            this.label7.Text = "Check in : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(419, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 19);
            this.label6.TabIndex = 29;
            this.label6.Text = "Quốc tịch :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 19);
            this.label5.TabIndex = 28;
            this.label5.Text = "Cmnd : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 27;
            this.label4.Text = "Giới tính : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 26;
            this.label3.Text = "Tên : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "Họ và tên đệm :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "Mã KH : ";
            // 
            // ButtonFind
            // 
            this.ButtonFind.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonFind.Location = new System.Drawing.Point(285, 34);
            this.ButtonFind.Name = "ButtonFind";
            this.ButtonFind.Size = new System.Drawing.Size(99, 29);
            this.ButtonFind.TabIndex = 49;
            this.ButtonFind.Text = "Tìm kiếm";
            this.ButtonFind.UseVisualStyleBackColor = true;
            this.ButtonFind.Click += new System.EventHandler(this.ButtonFind_Click);
            // 
            // TextBoxSoPhong
            // 
            this.TextBoxSoPhong.Location = new System.Drawing.Point(522, 167);
            this.TextBoxSoPhong.Name = "TextBoxSoPhong";
            this.TextBoxSoPhong.Size = new System.Drawing.Size(200, 22);
            this.TextBoxSoPhong.TabIndex = 50;
            // 
            // ButtonShowAllKH
            // 
            this.ButtonShowAllKH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonShowAllKH.Location = new System.Drawing.Point(325, 286);
            this.ButtonShowAllKH.Name = "ButtonShowAllKH";
            this.ButtonShowAllKH.Size = new System.Drawing.Size(158, 46);
            this.ButtonShowAllKH.TabIndex = 52;
            this.ButtonShowAllKH.Text = "Hiện tất cả KH";
            this.ButtonShowAllKH.UseVisualStyleBackColor = true;
            this.ButtonShowAllKH.Click += new System.EventHandler(this.ButtonShowAllRoom_Click);
            // 
            // DeleteCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 355);
            this.Controls.Add(this.ButtonShowAllKH);
            this.Controls.Add(this.TextBoxSoPhong);
            this.Controls.Add(this.ButtonFind);
            this.Controls.Add(this.ButtonQuayLai);
            this.Controls.Add(this.ButtonXoaKH);
            this.Controls.Add(this.dateTimePickerCheckOut);
            this.Controls.Add(this.dateTimePickerCheckIn);
            this.Controls.Add(this.TextBoxQuoctich);
            this.Controls.Add(this.RadioButtonFemale);
            this.Controls.Add(this.RadioButtonMale);
            this.Controls.Add(this.TextBoxCmnd);
            this.Controls.Add(this.TextBoxLname);
            this.Controls.Add(this.TextBoxFname);
            this.Controls.Add(this.TextBoxMaKH);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DeleteCustomerForm";
            this.Text = "DeleteCustomerForm";
            this.Load += new System.EventHandler(this.DeleteCustomerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonQuayLai;
        private System.Windows.Forms.Button ButtonXoaKH;
        private System.Windows.Forms.DateTimePicker dateTimePickerCheckOut;
        private System.Windows.Forms.DateTimePicker dateTimePickerCheckIn;
        private System.Windows.Forms.TextBox TextBoxQuoctich;
        private System.Windows.Forms.RadioButton RadioButtonFemale;
        private System.Windows.Forms.RadioButton RadioButtonMale;
        private System.Windows.Forms.TextBox TextBoxCmnd;
        private System.Windows.Forms.TextBox TextBoxLname;
        private System.Windows.Forms.TextBox TextBoxFname;
        private System.Windows.Forms.TextBox TextBoxMaKH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonFind;
        private System.Windows.Forms.TextBox TextBoxSoPhong;
        private System.Windows.Forms.Button ButtonShowAllKH;
    }
}