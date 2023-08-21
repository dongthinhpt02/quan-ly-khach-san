namespace QLHotel
{
    partial class ReportForm
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
            this.DataGridViewReport = new System.Windows.Forms.DataGridView();
            this.ButtonToFile = new System.Windows.Forms.Button();
            this.ButtonPrint = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewReport)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewReport
            // 
            this.DataGridViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewReport.Location = new System.Drawing.Point(-1, 162);
            this.DataGridViewReport.Name = "DataGridViewReport";
            this.DataGridViewReport.RowHeadersWidth = 51;
            this.DataGridViewReport.RowTemplate.Height = 24;
            this.DataGridViewReport.Size = new System.Drawing.Size(1104, 394);
            this.DataGridViewReport.TabIndex = 0;
            // 
            // ButtonToFile
            // 
            this.ButtonToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonToFile.Location = new System.Drawing.Point(251, 58);
            this.ButtonToFile.Name = "ButtonToFile";
            this.ButtonToFile.Size = new System.Drawing.Size(192, 60);
            this.ButtonToFile.TabIndex = 1;
            this.ButtonToFile.Text = "Xuất File Word";
            this.ButtonToFile.UseVisualStyleBackColor = true;
            this.ButtonToFile.Click += new System.EventHandler(this.ButtonToFile_Click);
            // 
            // ButtonPrint
            // 
            this.ButtonPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPrint.Location = new System.Drawing.Point(643, 58);
            this.ButtonPrint.Name = "ButtonPrint";
            this.ButtonPrint.Size = new System.Drawing.Size(205, 60);
            this.ButtonPrint.TabIndex = 2;
            this.ButtonPrint.Text = "In Báo Cáo";
            this.ButtonPrint.UseVisualStyleBackColor = true;
            this.ButtonPrint.Click += new System.EventHandler(this.ButtonPrint_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(24, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "< Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 558);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ButtonPrint);
            this.Controls.Add(this.ButtonToFile);
            this.Controls.Add(this.DataGridViewReport);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewReport;
        private System.Windows.Forms.Button ButtonToFile;
        private System.Windows.Forms.Button ButtonPrint;
        private System.Windows.Forms.Button button3;
    }
}