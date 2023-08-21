
namespace QLHotel
{
    partial class Xuatkho
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
            this.ButtonXuatkho = new System.Windows.Forms.Button();
            this.TextBoxSoluongxuat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboBoxTenthucpham = new System.Windows.Forms.ComboBox();
            this.ButtonHientatcathucpham = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonXuatkho
            // 
            this.ButtonXuatkho.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonXuatkho.Location = new System.Drawing.Point(250, 171);
            this.ButtonXuatkho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonXuatkho.Name = "ButtonXuatkho";
            this.ButtonXuatkho.Size = new System.Drawing.Size(157, 49);
            this.ButtonXuatkho.TabIndex = 11;
            this.ButtonXuatkho.Text = "Xuất kho";
            this.ButtonXuatkho.UseVisualStyleBackColor = true;
            this.ButtonXuatkho.Click += new System.EventHandler(this.ButtonXuatkho_Click);
            // 
            // TextBoxSoluongxuat
            // 
            this.TextBoxSoluongxuat.Location = new System.Drawing.Point(228, 95);
            this.TextBoxSoluongxuat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxSoluongxuat.Name = "TextBoxSoluongxuat";
            this.TextBoxSoluongxuat.Size = new System.Drawing.Size(157, 22);
            this.TextBoxSoluongxuat.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Số lượng xuất ra :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên Thực Phẩm :";
            // 
            // ComboBoxTenthucpham
            // 
            this.ComboBoxTenthucpham.FormattingEnabled = true;
            this.ComboBoxTenthucpham.Location = new System.Drawing.Point(228, 41);
            this.ComboBoxTenthucpham.Name = "ComboBoxTenthucpham";
            this.ComboBoxTenthucpham.Size = new System.Drawing.Size(157, 24);
            this.ComboBoxTenthucpham.TabIndex = 12;
            // 
            // ButtonHientatcathucpham
            // 
            this.ButtonHientatcathucpham.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonHientatcathucpham.Location = new System.Drawing.Point(48, 171);
            this.ButtonHientatcathucpham.Name = "ButtonHientatcathucpham";
            this.ButtonHientatcathucpham.Size = new System.Drawing.Size(147, 48);
            this.ButtonHientatcathucpham.TabIndex = 13;
            this.ButtonHientatcathucpham.Text = "Hiện tất cả thực phẩm";
            this.ButtonHientatcathucpham.UseVisualStyleBackColor = true;
            this.ButtonHientatcathucpham.Click += new System.EventHandler(this.ButtonHientatcathucpham_Click);
            // 
            // Xuatkho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 255);
            this.Controls.Add(this.ButtonHientatcathucpham);
            this.Controls.Add(this.ComboBoxTenthucpham);
            this.Controls.Add(this.ButtonXuatkho);
            this.Controls.Add(this.TextBoxSoluongxuat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Xuatkho";
            this.Text = "Xuatkho";
            this.Load += new System.EventHandler(this.Xuatkho_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonXuatkho;
        private System.Windows.Forms.TextBox TextBoxSoluongxuat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboBoxTenthucpham;
        private System.Windows.Forms.Button ButtonHientatcathucpham;
    }
}