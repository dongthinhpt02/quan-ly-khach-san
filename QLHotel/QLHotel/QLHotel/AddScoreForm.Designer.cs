namespace _19110417.Score
{
    partial class AddScoreForm
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
            this.StudentID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxStudentID = new System.Windows.Forms.TextBox();
            this.TextBoxScore = new System.Windows.Forms.TextBox();
            this.TextBoxDescription = new System.Windows.Forms.TextBox();
            this.ComboBoxSelectCourse = new System.Windows.Forms.ComboBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.DataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.myDBDataSet5 = new _19110417.myDBDataSet5();
            this.stdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stdTableAdapter = new _19110417.myDBDataSet5TableAdapters.stdTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentID
            // 
            this.StudentID.AutoSize = true;
            this.StudentID.Location = new System.Drawing.Point(54, 32);
            this.StudentID.Name = "StudentID";
            this.StudentID.Size = new System.Drawing.Size(78, 17);
            this.StudentID.TabIndex = 0;
            this.StudentID.Text = "Student ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select Course:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Score:";
            // 
            // TextBoxStudentID
            // 
            this.TextBoxStudentID.Location = new System.Drawing.Point(135, 32);
            this.TextBoxStudentID.Name = "TextBoxStudentID";
            this.TextBoxStudentID.Size = new System.Drawing.Size(100, 22);
            this.TextBoxStudentID.TabIndex = 1;
            // 
            // TextBoxScore
            // 
            this.TextBoxScore.Location = new System.Drawing.Point(135, 114);
            this.TextBoxScore.Name = "TextBoxScore";
            this.TextBoxScore.Size = new System.Drawing.Size(100, 22);
            this.TextBoxScore.TabIndex = 1;
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.Location = new System.Drawing.Point(135, 152);
            this.TextBoxDescription.Multiline = true;
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.Size = new System.Drawing.Size(185, 124);
            this.TextBoxDescription.TabIndex = 1;
            // 
            // ComboBoxSelectCourse
            // 
            this.ComboBoxSelectCourse.FormattingEnabled = true;
            this.ComboBoxSelectCourse.Location = new System.Drawing.Point(135, 69);
            this.ComboBoxSelectCourse.Name = "ComboBoxSelectCourse";
            this.ComboBoxSelectCourse.Size = new System.Drawing.Size(121, 24);
            this.ComboBoxSelectCourse.TabIndex = 2;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(172, 303);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.ButtonAdd.TabIndex = 3;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // DataGridViewStudents
            // 
            this.DataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewStudents.Location = new System.Drawing.Point(377, 24);
            this.DataGridViewStudents.Name = "DataGridViewStudents";
            this.DataGridViewStudents.RowHeadersWidth = 51;
            this.DataGridViewStudents.RowTemplate.Height = 24;
            this.DataGridViewStudents.Size = new System.Drawing.Size(392, 350);
            this.DataGridViewStudents.TabIndex = 4;
            this.DataGridViewStudents.Click += new System.EventHandler(this.DataGridViewStudents_Click);
            // 
            // myDBDataSet5
            // 
            this.myDBDataSet5.DataSetName = "myDBDataSet5";
            this.myDBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stdBindingSource
            // 
            this.stdBindingSource.DataMember = "std";
            this.stdBindingSource.DataSource = this.myDBDataSet5;
            // 
            // stdTableAdapter
            // 
            this.stdTableAdapter.ClearBeforeFill = true;
            // 
            // AddScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataGridViewStudents);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.ComboBoxSelectCourse);
            this.Controls.Add(this.TextBoxDescription);
            this.Controls.Add(this.TextBoxScore);
            this.Controls.Add(this.TextBoxStudentID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StudentID);
            this.Name = "AddScoreForm";
            this.Text = "AddScoreForm";
            this.Load += new System.EventHandler(this.AddScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StudentID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxStudentID;
        private System.Windows.Forms.TextBox TextBoxScore;
        private System.Windows.Forms.TextBox TextBoxDescription;
        private System.Windows.Forms.ComboBox ComboBoxSelectCourse;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.DataGridView DataGridViewStudents;
        private myDBDataSet5 myDBDataSet5;
        private System.Windows.Forms.BindingSource stdBindingSource;
        private myDBDataSet5TableAdapters.stdTableAdapter stdTableAdapter;
    }
}