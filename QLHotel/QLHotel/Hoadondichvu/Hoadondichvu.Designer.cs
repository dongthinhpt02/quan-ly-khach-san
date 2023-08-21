
namespace QLHotel
{
    partial class Hoadondichvu
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
            this.ButtonCallService = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboBoxService = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBoxRoomNumber = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxGiatiendichvu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonCallService
            // 
            this.ButtonCallService.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCallService.Location = new System.Drawing.Point(136, 282);
            this.ButtonCallService.Name = "ButtonCallService";
            this.ButtonCallService.Size = new System.Drawing.Size(144, 45);
            this.ButtonCallService.TabIndex = 9;
            this.ButtonCallService.Text = "Gọi dịch vụ";
            this.ButtonCallService.UseVisualStyleBackColor = true;
            this.ButtonCallService.Click += new System.EventHandler(this.ButtonCallService_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên dịch vụ :";
            // 
            // ComboBoxService
            // 
            this.ComboBoxService.FormattingEnabled = true;
            this.ComboBoxService.Location = new System.Drawing.Point(192, 129);
            this.ComboBoxService.Name = "ComboBoxService";
            this.ComboBoxService.Size = new System.Drawing.Size(176, 24);
            this.ComboBoxService.TabIndex = 7;
            this.ComboBoxService.SelectedIndexChanged += new System.EventHandler(this.ComboBoxService_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Số phòng : ";
            // 
            // ComboBoxRoomNumber
            // 
            this.ComboBoxRoomNumber.FormattingEnabled = true;
            this.ComboBoxRoomNumber.Location = new System.Drawing.Point(192, 62);
            this.ComboBoxRoomNumber.Name = "ComboBoxRoomNumber";
            this.ComboBoxRoomNumber.Size = new System.Drawing.Size(176, 24);
            this.ComboBoxRoomNumber.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Giá tiền dịch vụ :";
            // 
            // TextBoxGiatiendichvu
            // 
            this.TextBoxGiatiendichvu.Location = new System.Drawing.Point(192, 197);
            this.TextBoxGiatiendichvu.Name = "TextBoxGiatiendichvu";
            this.TextBoxGiatiendichvu.Size = new System.Drawing.Size(176, 22);
            this.TextBoxGiatiendichvu.TabIndex = 11;
            // 
            // Hoadondichvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 360);
            this.Controls.Add(this.TextBoxGiatiendichvu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ButtonCallService);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComboBoxService);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBoxRoomNumber);
            this.Name = "Hoadondichvu";
            this.Text = "Hoadondichvu";
            this.Load += new System.EventHandler(this.Hoadondichvu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCallService;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboBoxService;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBoxRoomNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxGiatiendichvu;
    }
}