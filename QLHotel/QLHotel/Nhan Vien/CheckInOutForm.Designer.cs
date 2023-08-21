namespace QLHotel
{
    partial class CheckInOutForm
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
            this.components = new System.ComponentModel.Container();
            this.ButtonCheckIn = new System.Windows.Forms.Button();
            this.ButtonCheckOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.ButtonEditInfo = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.PictureBoxUsername = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxUsername)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonCheckIn
            // 
            this.ButtonCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCheckIn.Location = new System.Drawing.Point(118, 162);
            this.ButtonCheckIn.Name = "ButtonCheckIn";
            this.ButtonCheckIn.Size = new System.Drawing.Size(187, 72);
            this.ButtonCheckIn.TabIndex = 0;
            this.ButtonCheckIn.Text = "Check In";
            this.ButtonCheckIn.UseVisualStyleBackColor = true;
            this.ButtonCheckIn.Click += new System.EventHandler(this.ButtonCheckIn_Click);
            // 
            // ButtonCheckOut
            // 
            this.ButtonCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCheckOut.Location = new System.Drawing.Point(457, 162);
            this.ButtonCheckOut.Name = "ButtonCheckOut";
            this.ButtonCheckOut.Size = new System.Drawing.Size(187, 72);
            this.ButtonCheckOut.TabIndex = 0;
            this.ButtonCheckOut.Text = "Check Out";
            this.ButtonCheckOut.UseVisualStyleBackColor = true;
            this.ButtonCheckOut.Click += new System.EventHandler(this.ButtonCheckOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(598, 50);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(46, 17);
            this.labelRole.TabIndex = 11;
            this.labelRole.Text = "label1";
            // 
            // ButtonEditInfo
            // 
            this.ButtonEditInfo.AutoSize = true;
            this.ButtonEditInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEditInfo.Location = new System.Drawing.Point(650, 67);
            this.ButtonEditInfo.Name = "ButtonEditInfo";
            this.ButtonEditInfo.Size = new System.Drawing.Size(81, 17);
            this.ButtonEditInfo.TabIndex = 9;
            this.ButtonEditInfo.Text = "Edit my info";
            this.ButtonEditInfo.Click += new System.EventHandler(this.ButtonEditInfo_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(598, 12);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(12, 17);
            this.labelUsername.TabIndex = 10;
            this.labelUsername.Text = "l";
            // 
            // PictureBoxUsername
            // 
            this.PictureBoxUsername.Location = new System.Drawing.Point(479, 12);
            this.PictureBoxUsername.Name = "PictureBoxUsername";
            this.PictureBoxUsername.Size = new System.Drawing.Size(113, 72);
            this.PictureBoxUsername.TabIndex = 8;
            this.PictureBoxUsername.TabStop = false;
            // 
            // CheckInOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.ButtonEditInfo);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.PictureBoxUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonCheckOut);
            this.Controls.Add(this.ButtonCheckIn);
            this.Name = "CheckInOutForm";
            this.Text = "CheckInOutForm";
            this.Load += new System.EventHandler(this.CheckInOutForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxUsername)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCheckIn;
        private System.Windows.Forms.Button ButtonCheckOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label ButtonEditInfo;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.PictureBox PictureBoxUsername;
    }
}