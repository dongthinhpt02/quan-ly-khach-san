﻿
namespace QLHotel
{
    partial class Nhapkho
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
            this.TextBoxID = new System.Windows.Forms.TextBox();
            this.TextBoxTenthucpham = new System.Windows.Forms.TextBox();
            this.TextBoxSoluongnhap = new System.Windows.Forms.TextBox();
            this.Buttonthemthucpham = new System.Windows.Forms.Button();
            this.ButtonShowAllThucPham = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "STT :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Thực Phẩm :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lương nhập :";
            // 
            // TextBoxID
            // 
            this.TextBoxID.Location = new System.Drawing.Point(206, 45);
            this.TextBoxID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxID.Name = "TextBoxID";
            this.TextBoxID.Size = new System.Drawing.Size(154, 27);
            this.TextBoxID.TabIndex = 3;
            // 
            // TextBoxTenthucpham
            // 
            this.TextBoxTenthucpham.Location = new System.Drawing.Point(203, 97);
            this.TextBoxTenthucpham.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxTenthucpham.Name = "TextBoxTenthucpham";
            this.TextBoxTenthucpham.Size = new System.Drawing.Size(157, 27);
            this.TextBoxTenthucpham.TabIndex = 4;
            // 
            // TextBoxSoluongnhap
            // 
            this.TextBoxSoluongnhap.Location = new System.Drawing.Point(203, 149);
            this.TextBoxSoluongnhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxSoluongnhap.Name = "TextBoxSoluongnhap";
            this.TextBoxSoluongnhap.Size = new System.Drawing.Size(157, 27);
            this.TextBoxSoluongnhap.TabIndex = 5;
            // 
            // Buttonthemthucpham
            // 
            this.Buttonthemthucpham.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buttonthemthucpham.Location = new System.Drawing.Point(209, 239);
            this.Buttonthemthucpham.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Buttonthemthucpham.Name = "Buttonthemthucpham";
            this.Buttonthemthucpham.Size = new System.Drawing.Size(151, 46);
            this.Buttonthemthucpham.TabIndex = 6;
            this.Buttonthemthucpham.Text = "Thêm Thực Phẩm";
            this.Buttonthemthucpham.UseVisualStyleBackColor = true;
            this.Buttonthemthucpham.Click += new System.EventHandler(this.Buttonthemthucpham_Click);
            // 
            // ButtonShowAllThucPham
            // 
            this.ButtonShowAllThucPham.Location = new System.Drawing.Point(27, 239);
            this.ButtonShowAllThucPham.Name = "ButtonShowAllThucPham";
            this.ButtonShowAllThucPham.Size = new System.Drawing.Size(139, 46);
            this.ButtonShowAllThucPham.TabIndex = 7;
            this.ButtonShowAllThucPham.Text = "Hiện tất cả thực phẩm";
            this.ButtonShowAllThucPham.UseVisualStyleBackColor = true;
            this.ButtonShowAllThucPham.Click += new System.EventHandler(this.ButtonShowAllThucPham_Click);
            // 
            // Nhapkho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 311);
            this.Controls.Add(this.ButtonShowAllThucPham);
            this.Controls.Add(this.Buttonthemthucpham);
            this.Controls.Add(this.TextBoxSoluongnhap);
            this.Controls.Add(this.TextBoxTenthucpham);
            this.Controls.Add(this.TextBoxID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Nhapkho";
            this.Text = "Nhapkho";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxID;
        private System.Windows.Forms.TextBox TextBoxTenthucpham;
        private System.Windows.Forms.TextBox TextBoxSoluongnhap;
        private System.Windows.Forms.Button Buttonthemthucpham;
        private System.Windows.Forms.Button ButtonShowAllThucPham;
    }
}