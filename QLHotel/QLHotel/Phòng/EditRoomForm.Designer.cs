
namespace QLHotel
{
    partial class EditRoomForm
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
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonEditRoom = new System.Windows.Forms.Button();
            this.RadioButtonFull = new System.Windows.Forms.RadioButton();
            this.RadioButtonClear = new System.Windows.Forms.RadioButton();
            this.ComboBoxRoom = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxRoomNumber = new System.Windows.Forms.TextBox();
            this.TextBoxRoomID = new System.Windows.Forms.TextBox();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.LabelShowFullRoom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCancel.Location = new System.Drawing.Point(264, 285);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(120, 38);
            this.ButtonCancel.TabIndex = 21;
            this.ButtonCancel.Text = "Quay Lại";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // ButtonEditRoom
            // 
            this.ButtonEditRoom.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEditRoom.Location = new System.Drawing.Point(23, 285);
            this.ButtonEditRoom.Name = "ButtonEditRoom";
            this.ButtonEditRoom.Size = new System.Drawing.Size(140, 38);
            this.ButtonEditRoom.TabIndex = 20;
            this.ButtonEditRoom.Text = "Chỉnh Sửa Phòng";
            this.ButtonEditRoom.UseVisualStyleBackColor = true;
            this.ButtonEditRoom.Click += new System.EventHandler(this.ButtonEditRoom_Click);
            // 
            // RadioButtonFull
            // 
            this.RadioButtonFull.AutoSize = true;
            this.RadioButtonFull.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonFull.Location = new System.Drawing.Point(283, 213);
            this.RadioButtonFull.Name = "RadioButtonFull";
            this.RadioButtonFull.Size = new System.Drawing.Size(101, 23);
            this.RadioButtonFull.TabIndex = 18;
            this.RadioButtonFull.TabStop = true;
            this.RadioButtonFull.Text = "Có Người ";
            this.RadioButtonFull.UseVisualStyleBackColor = true;
            // 
            // RadioButtonClear
            // 
            this.RadioButtonClear.AutoSize = true;
            this.RadioButtonClear.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonClear.Location = new System.Drawing.Point(163, 213);
            this.RadioButtonClear.Name = "RadioButtonClear";
            this.RadioButtonClear.Size = new System.Drawing.Size(69, 23);
            this.RadioButtonClear.TabIndex = 17;
            this.RadioButtonClear.TabStop = true;
            this.RadioButtonClear.Text = "Trống";
            this.RadioButtonClear.UseVisualStyleBackColor = true;
            // 
            // ComboBoxRoom
            // 
            this.ComboBoxRoom.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxRoom.FormattingEnabled = true;
            this.ComboBoxRoom.Location = new System.Drawing.Point(162, 152);
            this.ComboBoxRoom.Name = "ComboBoxRoom";
            this.ComboBoxRoom.Size = new System.Drawing.Size(139, 27);
            this.ComboBoxRoom.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tình trạng : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Loại Phòng : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Số Phòng : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 19);
            this.label4.TabIndex = 23;
            this.label4.Text = "Mã Phòng : ";
            // 
            // TextBoxRoomNumber
            // 
            this.TextBoxRoomNumber.Location = new System.Drawing.Point(162, 97);
            this.TextBoxRoomNumber.Name = "TextBoxRoomNumber";
            this.TextBoxRoomNumber.Size = new System.Drawing.Size(139, 22);
            this.TextBoxRoomNumber.TabIndex = 24;
            // 
            // TextBoxRoomID
            // 
            this.TextBoxRoomID.Location = new System.Drawing.Point(162, 42);
            this.TextBoxRoomID.Name = "TextBoxRoomID";
            this.TextBoxRoomID.Size = new System.Drawing.Size(139, 22);
            this.TextBoxRoomID.TabIndex = 25;
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Location = new System.Drawing.Point(316, 39);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(91, 28);
            this.ButtonSearch.TabIndex = 26;
            this.ButtonSearch.Text = "Search";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // LabelShowFullRoom
            // 
            this.LabelShowFullRoom.AutoSize = true;
            this.LabelShowFullRoom.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelShowFullRoom.Location = new System.Drawing.Point(160, 67);
            this.LabelShowFullRoom.Name = "LabelShowFullRoom";
            this.LabelShowFullRoom.Size = new System.Drawing.Size(141, 19);
            this.LabelShowFullRoom.TabIndex = 27;
            this.LabelShowFullRoom.Text = "Hiện tất cả phòng !!";
            this.LabelShowFullRoom.Click += new System.EventHandler(this.LabelShowFullRoom_Click);
            // 
            // EditRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 365);
            this.Controls.Add(this.LabelShowFullRoom);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.TextBoxRoomID);
            this.Controls.Add(this.TextBoxRoomNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonEditRoom);
            this.Controls.Add(this.RadioButtonFull);
            this.Controls.Add(this.RadioButtonClear);
            this.Controls.Add(this.ComboBoxRoom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditRoomForm";
            this.Text = "EditRoomForm";
            this.Load += new System.EventHandler(this.EditRoomForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonEditRoom;
        private System.Windows.Forms.RadioButton RadioButtonFull;
        private System.Windows.Forms.RadioButton RadioButtonClear;
        private System.Windows.Forms.ComboBox ComboBoxRoom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxRoomNumber;
        private System.Windows.Forms.TextBox TextBoxRoomID;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.Label LabelShowFullRoom;
    }
}