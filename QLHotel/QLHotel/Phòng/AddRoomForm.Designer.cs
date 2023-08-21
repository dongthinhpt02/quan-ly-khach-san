
namespace QLHotel
{
    partial class AddRoomForm
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
            this.TextBoxRoomID = new System.Windows.Forms.TextBox();
            this.ComboBoxRoom = new System.Windows.Forms.ComboBox();
            this.RadioButtonClear = new System.Windows.Forms.RadioButton();
            this.RadioButtonFull = new System.Windows.Forms.RadioButton();
            this.ButtonEditRoom = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxRoomNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Phòng : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loại Phòng : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tình trạng : ";
            // 
            // TextBoxRoomID
            // 
            this.TextBoxRoomID.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxRoomID.Location = new System.Drawing.Point(190, 47);
            this.TextBoxRoomID.Name = "TextBoxRoomID";
            this.TextBoxRoomID.Size = new System.Drawing.Size(138, 27);
            this.TextBoxRoomID.TabIndex = 4;
            // 
            // ComboBoxRoom
            // 
            this.ComboBoxRoom.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxRoom.FormattingEnabled = true;
            this.ComboBoxRoom.Location = new System.Drawing.Point(188, 149);
            this.ComboBoxRoom.Name = "ComboBoxRoom";
            this.ComboBoxRoom.Size = new System.Drawing.Size(139, 27);
            this.ComboBoxRoom.TabIndex = 5;
            // 
            // RadioButtonClear
            // 
            this.RadioButtonClear.AutoSize = true;
            this.RadioButtonClear.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonClear.Location = new System.Drawing.Point(189, 210);
            this.RadioButtonClear.Name = "RadioButtonClear";
            this.RadioButtonClear.Size = new System.Drawing.Size(69, 23);
            this.RadioButtonClear.TabIndex = 6;
            this.RadioButtonClear.TabStop = true;
            this.RadioButtonClear.Text = "Trống";
            this.RadioButtonClear.UseVisualStyleBackColor = true;
            // 
            // RadioButtonFull
            // 
            this.RadioButtonFull.AutoSize = true;
            this.RadioButtonFull.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonFull.Location = new System.Drawing.Point(309, 210);
            this.RadioButtonFull.Name = "RadioButtonFull";
            this.RadioButtonFull.Size = new System.Drawing.Size(101, 23);
            this.RadioButtonFull.TabIndex = 7;
            this.RadioButtonFull.TabStop = true;
            this.RadioButtonFull.Text = "Có Người ";
            this.RadioButtonFull.UseVisualStyleBackColor = true;
            // 
            // ButtonEditRoom
            // 
            this.ButtonEditRoom.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEditRoom.Location = new System.Drawing.Point(63, 276);
            this.ButtonEditRoom.Name = "ButtonEditRoom";
            this.ButtonEditRoom.Size = new System.Drawing.Size(127, 38);
            this.ButtonEditRoom.TabIndex = 9;
            this.ButtonEditRoom.Text = "Thêm Phòng";
            this.ButtonEditRoom.UseVisualStyleBackColor = true;
            this.ButtonEditRoom.Click += new System.EventHandler(this.ButtonAddRoom_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCancel.Location = new System.Drawing.Point(252, 276);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(120, 38);
            this.ButtonCancel.TabIndex = 10;
            this.ButtonCancel.Text = "Quay Lại";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Số Phòng : ";
            // 
            // TextBoxRoomNumber
            // 
            this.TextBoxRoomNumber.Location = new System.Drawing.Point(190, 98);
            this.TextBoxRoomNumber.Name = "TextBoxRoomNumber";
            this.TextBoxRoomNumber.Size = new System.Drawing.Size(138, 22);
            this.TextBoxRoomNumber.TabIndex = 12;
            // 
            // AddRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 358);
            this.Controls.Add(this.TextBoxRoomNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonEditRoom);
            this.Controls.Add(this.RadioButtonFull);
            this.Controls.Add(this.RadioButtonClear);
            this.Controls.Add(this.ComboBoxRoom);
            this.Controls.Add(this.TextBoxRoomID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddRoomForm";
            this.ShowIcon = false;
            this.Text = "AddRoomForm";
            this.Load += new System.EventHandler(this.AddRoomForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxRoomID;
        private System.Windows.Forms.ComboBox ComboBoxRoom;
        private System.Windows.Forms.RadioButton RadioButtonClear;
        private System.Windows.Forms.RadioButton RadioButtonFull;
        private System.Windows.Forms.Button ButtonEditRoom;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBoxRoomNumber;
    }
}