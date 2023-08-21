namespace QLHotel
{
    partial class RoleForm
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.ComboBoxRoleRemove = new System.Windows.Forms.ComboBox();
            this.ButtonRemoveRole = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TextBoxRoleID = new System.Windows.Forms.TextBox();
            this.TextBoxRoleName = new System.Windows.Forms.TextBox();
            this.ButtonAddRole = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ComboBoxRoleEdit = new System.Windows.Forms.ComboBox();
            this.TextBoxNewRName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ButtonEditRole = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.ComboBoxRoleRemove);
            this.panel4.Controls.Add(this.ButtonRemoveRole);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(39, 326);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(347, 88);
            this.panel4.TabIndex = 8;
            // 
            // ComboBoxRoleRemove
            // 
            this.ComboBoxRoleRemove.FormattingEnabled = true;
            this.ComboBoxRoleRemove.Location = new System.Drawing.Point(151, 17);
            this.ComboBoxRoleRemove.Name = "ComboBoxRoleRemove";
            this.ComboBoxRoleRemove.Size = new System.Drawing.Size(121, 24);
            this.ComboBoxRoleRemove.TabIndex = 4;
            this.ComboBoxRoleRemove.SelectedIndexChanged += new System.EventHandler(this.ComboBoxRoleRemove_SelectedIndexChanged);
            // 
            // ButtonRemoveRole
            // 
            this.ButtonRemoveRole.Location = new System.Drawing.Point(139, 60);
            this.ButtonRemoveRole.Name = "ButtonRemoveRole";
            this.ButtonRemoveRole.Size = new System.Drawing.Size(75, 23);
            this.ButtonRemoveRole.TabIndex = 1;
            this.ButtonRemoveRole.Text = "Xoa";
            this.ButtonRemoveRole.UseVisualStyleBackColor = true;
            this.ButtonRemoveRole.Click += new System.EventHandler(this.ButtonRemoveRole_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Chon Chuc Vu:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.TextBoxRoleID);
            this.panel3.Controls.Add(this.TextBoxRoleName);
            this.panel3.Controls.Add(this.ButtonAddRole);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(39, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(346, 117);
            this.panel3.TabIndex = 9;
            // 
            // TextBoxRoleID
            // 
            this.TextBoxRoleID.Location = new System.Drawing.Point(152, 52);
            this.TextBoxRoleID.Name = "TextBoxRoleID";
            this.TextBoxRoleID.Size = new System.Drawing.Size(73, 22);
            this.TextBoxRoleID.TabIndex = 3;
            // 
            // TextBoxRoleName
            // 
            this.TextBoxRoleName.Location = new System.Drawing.Point(151, 17);
            this.TextBoxRoleName.Name = "TextBoxRoleName";
            this.TextBoxRoleName.Size = new System.Drawing.Size(74, 22);
            this.TextBoxRoleName.TabIndex = 3;
            // 
            // ButtonAddRole
            // 
            this.ButtonAddRole.Location = new System.Drawing.Point(139, 80);
            this.ButtonAddRole.Name = "ButtonAddRole";
            this.ButtonAddRole.Size = new System.Drawing.Size(75, 23);
            this.ButtonAddRole.TabIndex = 1;
            this.ButtonAddRole.Text = "Them";
            this.ButtonAddRole.UseVisualStyleBackColor = true;
            this.ButtonAddRole.Click += new System.EventHandler(this.ButtonAddRole_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Ma Chuc Vu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ten Chuc Vu:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ComboBoxRoleEdit);
            this.panel2.Controls.Add(this.TextBoxNewRName);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.ButtonEditRole);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(39, 178);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(347, 122);
            this.panel2.TabIndex = 10;
            // 
            // ComboBoxRoleEdit
            // 
            this.ComboBoxRoleEdit.FormattingEnabled = true;
            this.ComboBoxRoleEdit.Location = new System.Drawing.Point(151, 11);
            this.ComboBoxRoleEdit.Name = "ComboBoxRoleEdit";
            this.ComboBoxRoleEdit.Size = new System.Drawing.Size(121, 24);
            this.ComboBoxRoleEdit.TabIndex = 4;
            // 
            // TextBoxNewRName
            // 
            this.TextBoxNewRName.Location = new System.Drawing.Point(151, 45);
            this.TextBoxNewRName.Name = "TextBoxNewRName";
            this.TextBoxNewRName.Size = new System.Drawing.Size(153, 22);
            this.TextBoxNewRName.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Nhap Ten Moi:";
            // 
            // ButtonEditRole
            // 
            this.ButtonEditRole.Location = new System.Drawing.Point(139, 83);
            this.ButtonEditRole.Name = "ButtonEditRole";
            this.ButtonEditRole.Size = new System.Drawing.Size(75, 23);
            this.ButtonEditRole.TabIndex = 1;
            this.ButtonEditRole.Text = "Sua";
            this.ButtonEditRole.UseVisualStyleBackColor = true;
            this.ButtonEditRole.Click += new System.EventHandler(this.ButtonEditRole_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Chon Chuc Vu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Chuc Vu";
            // 
            // RoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Name = "RoleForm";
            this.Text = "RoleForm";
            this.Load += new System.EventHandler(this.RoleForm_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox ComboBoxRoleRemove;
        private System.Windows.Forms.Button ButtonRemoveRole;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TextBoxRoleID;
        private System.Windows.Forms.TextBox TextBoxRoleName;
        private System.Windows.Forms.Button ButtonAddRole;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox ComboBoxRoleEdit;
        private System.Windows.Forms.TextBox TextBoxNewRName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ButtonEditRole;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
    }
}