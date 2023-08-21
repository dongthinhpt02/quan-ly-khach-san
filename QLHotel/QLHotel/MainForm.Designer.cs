namespace QLHotel
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nhanVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiepTanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyNVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caLamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baoCaoCuoiNgayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonEditInfo = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.PictureBoxUsername = new System.Windows.Forms.PictureBox();
            this.labelRole = new System.Windows.Forms.Label();
            this.ButtonQuanLiPhong = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxUsername)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhanVienToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(979, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // nhanVienToolStripMenuItem
            // 
            this.nhanVienToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLiToolStripMenuItem,
            this.tiepTanToolStripMenuItem,
            this.quanLyNVToolStripMenuItem,
            this.caLamToolStripMenuItem,
            this.baoCaoCuoiNgayToolStripMenuItem});
            this.nhanVienToolStripMenuItem.Name = "nhanVienToolStripMenuItem";
            this.nhanVienToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.nhanVienToolStripMenuItem.Text = "Nhân Viên";
            // 
            // quanLiToolStripMenuItem
            // 
            this.quanLiToolStripMenuItem.Name = "quanLiToolStripMenuItem";
            this.quanLiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.quanLiToolStripMenuItem.Text = "Thêm NV";
            this.quanLiToolStripMenuItem.Click += new System.EventHandler(this.quanLiToolStripMenuItem_Click);
            // 
            // tiepTanToolStripMenuItem
            // 
            this.tiepTanToolStripMenuItem.Name = "tiepTanToolStripMenuItem";
            this.tiepTanToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tiepTanToolStripMenuItem.Text = "Xóa, Sửa NV";
            this.tiepTanToolStripMenuItem.Click += new System.EventHandler(this.tiepTanToolStripMenuItem_Click);
            // 
            // quanLyNVToolStripMenuItem
            // 
            this.quanLyNVToolStripMenuItem.Name = "quanLyNVToolStripMenuItem";
            this.quanLyNVToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.quanLyNVToolStripMenuItem.Text = "Quản Lý NV";
            this.quanLyNVToolStripMenuItem.Click += new System.EventHandler(this.quanLyNVToolStripMenuItem_Click);
            // 
            // caLamToolStripMenuItem
            // 
            this.caLamToolStripMenuItem.Name = "caLamToolStripMenuItem";
            this.caLamToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.caLamToolStripMenuItem.Text = "Ca Làm";
            this.caLamToolStripMenuItem.Click += new System.EventHandler(this.caLamToolStripMenuItem_Click);
            // 
            // baoCaoCuoiNgayToolStripMenuItem
            // 
            this.baoCaoCuoiNgayToolStripMenuItem.Name = "baoCaoCuoiNgayToolStripMenuItem";
            this.baoCaoCuoiNgayToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.baoCaoCuoiNgayToolStripMenuItem.Text = "Báo Cáo Cuối Ngày";
            this.baoCaoCuoiNgayToolStripMenuItem.Click += new System.EventHandler(this.baoCaoCuoiNgayToolStripMenuItem_Click);
            // 
            // ButtonEditInfo
            // 
            this.ButtonEditInfo.AutoSize = true;
            this.ButtonEditInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEditInfo.Location = new System.Drawing.Point(651, 86);
            this.ButtonEditInfo.Name = "ButtonEditInfo";
            this.ButtonEditInfo.Size = new System.Drawing.Size(81, 17);
            this.ButtonEditInfo.TabIndex = 5;
            this.ButtonEditInfo.Text = "Edit my info";
            this.ButtonEditInfo.Click += new System.EventHandler(this.ButtonEditInfo_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(599, 31);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(12, 17);
            this.labelUsername.TabIndex = 6;
            this.labelUsername.Text = "l";
            // 
            // PictureBoxUsername
            // 
            this.PictureBoxUsername.Location = new System.Drawing.Point(480, 31);
            this.PictureBoxUsername.Name = "PictureBoxUsername";
            this.PictureBoxUsername.Size = new System.Drawing.Size(113, 72);
            this.PictureBoxUsername.TabIndex = 2;
            this.PictureBoxUsername.TabStop = false;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(599, 69);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(46, 17);
            this.labelRole.TabIndex = 7;
            this.labelRole.Text = "label1";
            // 
            // ButtonQuanLiPhong
            // 
            this.ButtonQuanLiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonQuanLiPhong.Location = new System.Drawing.Point(480, 165);
            this.ButtonQuanLiPhong.Name = "ButtonQuanLiPhong";
            this.ButtonQuanLiPhong.Size = new System.Drawing.Size(274, 108);
            this.ButtonQuanLiPhong.TabIndex = 8;
            this.ButtonQuanLiPhong.Text = "Quản Lí Phòng";
            this.ButtonQuanLiPhong.UseVisualStyleBackColor = true;
            this.ButtonQuanLiPhong.Click += new System.EventHandler(this.ButtonQuanLiPhong_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 33);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLHotel.Properties.Resources.background_đẹp_5_1024x597;
            this.ClientSize = new System.Drawing.Size(979, 478);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonQuanLiPhong);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.ButtonEditInfo);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.PictureBoxUsername);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.BackgroundImageChanged += new System.EventHandler(this.MainForm_BackgroundImageChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxUsername)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nhanVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiepTanToolStripMenuItem;
        private System.Windows.Forms.Label ButtonEditInfo;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.PictureBox PictureBoxUsername;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.ToolStripMenuItem quanLyNVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caLamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baoCaoCuoiNgayToolStripMenuItem;
        private System.Windows.Forms.Button ButtonQuanLiPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}