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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nhanVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiepTanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhanVienToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nhanVienToolStripMenuItem
            // 
            this.nhanVienToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLiToolStripMenuItem,
            this.tiepTanToolStripMenuItem});
            this.nhanVienToolStripMenuItem.Name = "nhanVienToolStripMenuItem";
            this.nhanVienToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.nhanVienToolStripMenuItem.Text = "Nhan Vien";
            // 
            // quanLiToolStripMenuItem
            // 
            this.quanLiToolStripMenuItem.Name = "quanLiToolStripMenuItem";
            this.quanLiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.quanLiToolStripMenuItem.Text = "Them NV";
            this.quanLiToolStripMenuItem.Click += new System.EventHandler(this.quanLiToolStripMenuItem_Click);
            // 
            // tiepTanToolStripMenuItem
            // 
            this.tiepTanToolStripMenuItem.Name = "tiepTanToolStripMenuItem";
            this.tiepTanToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tiepTanToolStripMenuItem.Text = "Xoa, Sua NV";
            this.tiepTanToolStripMenuItem.Click += new System.EventHandler(this.tiepTanToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(560, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(288, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "You login as:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nhanVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiepTanToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
    }
}