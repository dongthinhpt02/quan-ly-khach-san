
namespace QLHotel
{
    partial class AddCardHotelForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ComboBoxRoomNumber = new System.Windows.Forms.ComboBox();
            this.dateTimePickerCheckin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerCheckout = new System.Windows.Forms.DateTimePicker();
            this.ButtonAddCard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số phòng : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày Checkin : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày Checkout : ";
            // 
            // ComboBoxRoomNumber
            // 
            this.ComboBoxRoomNumber.FormattingEnabled = true;
            this.ComboBoxRoomNumber.Location = new System.Drawing.Point(189, 62);
            this.ComboBoxRoomNumber.Name = "ComboBoxRoomNumber";
            this.ComboBoxRoomNumber.Size = new System.Drawing.Size(110, 24);
            this.ComboBoxRoomNumber.TabIndex = 5;
            // 
            // dateTimePickerCheckin
            // 
            this.dateTimePickerCheckin.CustomFormat = "M/dd/ yyyy hh:mm";
            this.dateTimePickerCheckin.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerCheckin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerCheckin.Location = new System.Drawing.Point(189, 115);
            this.dateTimePickerCheckin.Name = "dateTimePickerCheckin";
            this.dateTimePickerCheckin.Size = new System.Drawing.Size(184, 27);
            this.dateTimePickerCheckin.TabIndex = 6;
            // 
            // dateTimePickerCheckout
            // 
            this.dateTimePickerCheckout.CustomFormat = "M/dd/yyyy HH:mm";
            this.dateTimePickerCheckout.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerCheckout.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerCheckout.Location = new System.Drawing.Point(189, 167);
            this.dateTimePickerCheckout.Name = "dateTimePickerCheckout";
            this.dateTimePickerCheckout.Size = new System.Drawing.Size(184, 27);
            this.dateTimePickerCheckout.TabIndex = 7;
            // 
            // ButtonAddCard
            // 
            this.ButtonAddCard.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddCard.Location = new System.Drawing.Point(131, 246);
            this.ButtonAddCard.Name = "ButtonAddCard";
            this.ButtonAddCard.Size = new System.Drawing.Size(147, 44);
            this.ButtonAddCard.TabIndex = 8;
            this.ButtonAddCard.Text = "Thêm Thẻ";
            this.ButtonAddCard.UseVisualStyleBackColor = true;
            this.ButtonAddCard.Click += new System.EventHandler(this.ButtonAddCard_Click);
            // 
            // AddCardHotelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 320);
            this.Controls.Add(this.ButtonAddCard);
            this.Controls.Add(this.dateTimePickerCheckout);
            this.Controls.Add(this.dateTimePickerCheckin);
            this.Controls.Add(this.ComboBoxRoomNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "AddCardHotelForm";
            this.Text = "AddCardHotelForm";
            this.Load += new System.EventHandler(this.AddCardHotelForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ComboBoxRoomNumber;
        private System.Windows.Forms.DateTimePicker dateTimePickerCheckin;
        private System.Windows.Forms.DateTimePicker dateTimePickerCheckout;
        private System.Windows.Forms.Button ButtonAddCard;
    }
}