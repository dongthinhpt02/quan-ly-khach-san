namespace QLHotel
{
    partial class LoginForm
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
            this.TextBoxUsername = new System.Windows.Forms.TextBox();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.radioButtonQuanLi = new System.Windows.Forms.RadioButton();
            this.radioButtonTiepTan = new System.Windows.Forms.RadioButton();
            this.radioButtonLaoCong = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonGiamDoc = new System.Windows.Forms.RadioButton();
            this.labelRegister = new System.Windows.Forms.Label();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.Location = new System.Drawing.Point(324, 114);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(212, 22);
            this.TextBoxUsername.TabIndex = 2;
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLogin.Location = new System.Drawing.Point(286, 224);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(108, 40);
            this.ButtonLogin.TabIndex = 3;
            this.ButtonLogin.Text = "Login";
            this.ButtonLogin.UseMnemonic = false;
            this.ButtonLogin.UseVisualStyleBackColor = true;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCancel.Location = new System.Drawing.Point(451, 224);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(97, 40);
            this.ButtonCancel.TabIndex = 3;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // radioButtonQuanLi
            // 
            this.radioButtonQuanLi.AutoSize = true;
            this.radioButtonQuanLi.Checked = true;
            this.radioButtonQuanLi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonQuanLi.Location = new System.Drawing.Point(19, 13);
            this.radioButtonQuanLi.Name = "radioButtonQuanLi";
            this.radioButtonQuanLi.Size = new System.Drawing.Size(89, 24);
            this.radioButtonQuanLi.TabIndex = 4;
            this.radioButtonQuanLi.TabStop = true;
            this.radioButtonQuanLi.Text = "Quản Lí";
            this.radioButtonQuanLi.UseVisualStyleBackColor = true;
            // 
            // radioButtonTiepTan
            // 
            this.radioButtonTiepTan.AutoSize = true;
            this.radioButtonTiepTan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTiepTan.Location = new System.Drawing.Point(133, 13);
            this.radioButtonTiepTan.Name = "radioButtonTiepTan";
            this.radioButtonTiepTan.Size = new System.Drawing.Size(95, 24);
            this.radioButtonTiepTan.TabIndex = 4;
            this.radioButtonTiepTan.Text = "Tiếp Tân";
            this.radioButtonTiepTan.UseVisualStyleBackColor = true;
            // 
            // radioButtonLaoCong
            // 
            this.radioButtonLaoCong.AutoSize = true;
            this.radioButtonLaoCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonLaoCong.Location = new System.Drawing.Point(258, 13);
            this.radioButtonLaoCong.Name = "radioButtonLaoCong";
            this.radioButtonLaoCong.Size = new System.Drawing.Size(102, 24);
            this.radioButtonLaoCong.TabIndex = 4;
            this.radioButtonLaoCong.Text = "Lao Công";
            this.radioButtonLaoCong.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.radioButtonQuanLi);
            this.panel1.Controls.Add(this.radioButtonTiepTan);
            this.panel1.Controls.Add(this.radioButtonGiamDoc);
            this.panel1.Controls.Add(this.radioButtonLaoCong);
            this.panel1.Location = new System.Drawing.Point(166, 295);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 46);
            this.panel1.TabIndex = 5;
            // 
            // radioButtonGiamDoc
            // 
            this.radioButtonGiamDoc.AutoSize = true;
            this.radioButtonGiamDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonGiamDoc.Location = new System.Drawing.Point(371, 13);
            this.radioButtonGiamDoc.Name = "radioButtonGiamDoc";
            this.radioButtonGiamDoc.Size = new System.Drawing.Size(105, 24);
            this.radioButtonGiamDoc.TabIndex = 4;
            this.radioButtonGiamDoc.Text = "Giám Đốc";
            this.radioButtonGiamDoc.UseVisualStyleBackColor = true;
            // 
            // labelRegister
            // 
            this.labelRegister.AutoSize = true;
            this.labelRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegister.Location = new System.Drawing.Point(12, 406);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(227, 25);
            this.labelRegister.TabIndex = 6;
            this.labelRegister.Text = "Đăng Kí Tài Khoản >>";
            this.labelRegister.Click += new System.EventHandler(this.labelRegister_Click);
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Location = new System.Drawing.Point(324, 161);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(212, 22);
            this.TextBoxPassword.TabIndex = 7;
            this.TextBoxPassword.Click += new System.EventHandler(this.TextBoxPassword_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = global::QLHotel.Properties.Resources._360_F_119115529_mEnw3lGpLdlDkfLgRcVSbFRuVl6sMDty;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.labelRegister);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonLogin);
            this.Controls.Add(this.TextBoxUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxUsername;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.RadioButton radioButtonQuanLi;
        private System.Windows.Forms.RadioButton radioButtonTiepTan;
        private System.Windows.Forms.RadioButton radioButtonLaoCong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelRegister;
        private System.Windows.Forms.RadioButton radioButtonGiamDoc;
        private System.Windows.Forms.TextBox TextBoxPassword;
    }
}