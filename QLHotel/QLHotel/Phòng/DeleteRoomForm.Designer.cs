
namespace QLHotel
{
    partial class DeleteRoomForm
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
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.TextBoxRoomID = new System.Windows.Forms.TextBox();
            this.TextBoxRoomNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonDeleteRoom = new System.Windows.Forms.Button();
            this.RadioButtonFull = new System.Windows.Forms.RadioButton();
            this.RadioButtonClear = new System.Windows.Forms.RadioButton();
            this.ComboBoxRoom = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelShowFullRoom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Location = new System.Drawing.Point(317, 36);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(91, 28);
            this.ButtonSearch.TabIndex = 38;
            this.ButtonSearch.Text = "Search";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // TextBoxRoomID
            // 
            this.TextBoxRoomID.Location = new System.Drawing.Point(163, 39);
            this.TextBoxRoomID.Name = "TextBoxRoomID";
            this.TextBoxRoomID.Size = new System.Drawing.Size(139, 22);
            this.TextBoxRoomID.TabIndex = 37;
            // 
            // TextBoxRoomNumber
            // 
            this.TextBoxRoomNumber.Location = new System.Drawing.Point(163, 94);
            this.TextBoxRoomNumber.Name = "TextBoxRoomNumber";
            this.TextBoxRoomNumber.Size = new System.Drawing.Size(139, 22);
            this.TextBoxRoomNumber.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 19);
            this.label4.TabIndex = 35;
            this.label4.Text = "Mã Phòng : ";
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCancel.Location = new System.Drawing.Point(236, 280);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(120, 38);
            this.ButtonCancel.TabIndex = 34;
            this.ButtonCancel.Text = "Quay Lại";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonDeleteRoom
            // 
            this.ButtonDeleteRoom.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDeleteRoom.Location = new System.Drawing.Point(39, 280);
            this.ButtonDeleteRoom.Name = "ButtonDeleteRoom";
            this.ButtonDeleteRoom.Size = new System.Drawing.Size(140, 38);
            this.ButtonDeleteRoom.TabIndex = 33;
            this.ButtonDeleteRoom.Text = "Xóa Phòng";
            this.ButtonDeleteRoom.UseVisualStyleBackColor = true;
            this.ButtonDeleteRoom.Click += new System.EventHandler(this.ButtonDeleteRoom_Click);
            // 
            // RadioButtonFull
            // 
            this.RadioButtonFull.AutoSize = true;
            this.RadioButtonFull.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonFull.Location = new System.Drawing.Point(284, 210);
            this.RadioButtonFull.Name = "RadioButtonFull";
            this.RadioButtonFull.Size = new System.Drawing.Size(101, 23);
            this.RadioButtonFull.TabIndex = 32;
            this.RadioButtonFull.TabStop = true;
            this.RadioButtonFull.Text = "Có Người ";
            this.RadioButtonFull.UseVisualStyleBackColor = true;
            // 
            // RadioButtonClear
            // 
            this.RadioButtonClear.AutoSize = true;
            this.RadioButtonClear.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonClear.Location = new System.Drawing.Point(164, 210);
            this.RadioButtonClear.Name = "RadioButtonClear";
            this.RadioButtonClear.Size = new System.Drawing.Size(69, 23);
            this.RadioButtonClear.TabIndex = 31;
            this.RadioButtonClear.TabStop = true;
            this.RadioButtonClear.Text = "Trống";
            this.RadioButtonClear.UseVisualStyleBackColor = true;
            // 
            // ComboBoxRoom
            // 
            this.ComboBoxRoom.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxRoom.FormattingEnabled = true;
            this.ComboBoxRoom.Location = new System.Drawing.Point(163, 149);
            this.ComboBoxRoom.Name = "ComboBoxRoom";
            this.ComboBoxRoom.Size = new System.Drawing.Size(139, 27);
            this.ComboBoxRoom.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 29;
            this.label3.Text = "Tình trạng : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "Loại Phòng : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "Số Phòng : ";
            // 
            // LabelShowFullRoom
            // 
            this.LabelShowFullRoom.AutoSize = true;
            this.LabelShowFullRoom.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelShowFullRoom.Location = new System.Drawing.Point(161, 64);
            this.LabelShowFullRoom.Name = "LabelShowFullRoom";
            this.LabelShowFullRoom.Size = new System.Drawing.Size(141, 19);
            this.LabelShowFullRoom.TabIndex = 39;
            this.LabelShowFullRoom.Text = "Hiện tất cả phòng !!";
            this.LabelShowFullRoom.Click += new System.EventHandler(this.LabelShowFullRoom_Click);
            // 
            // DeleteRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 346);
            this.Controls.Add(this.LabelShowFullRoom);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.TextBoxRoomID);
            this.Controls.Add(this.TextBoxRoomNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonDeleteRoom);
            this.Controls.Add(this.RadioButtonFull);
            this.Controls.Add(this.RadioButtonClear);
            this.Controls.Add(this.ComboBoxRoom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DeleteRoomForm";
            this.Text = "DeleteRoomForm";
            this.Load += new System.EventHandler(this.DeleteRoomForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.TextBox TextBoxRoomID;
        private System.Windows.Forms.TextBox TextBoxRoomNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonDeleteRoom;
        private System.Windows.Forms.RadioButton RadioButtonFull;
        private System.Windows.Forms.RadioButton RadioButtonClear;
        private System.Windows.Forms.ComboBox ComboBoxRoom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelShowFullRoom;
    }
}