using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19110417.Score
{
    public partial class AddScoreForm : Form
    {
        public AddScoreForm()
        {
            InitializeComponent();
        }
        SCORE score = new SCORE(); 
        COURSE_V1 course = new COURSE_V1(); 
        STUDENT student = new STUDENT();

        private void AddScoreForm_Load(object sender, EventArgs e)
        {
            ComboBoxSelectCourse.DataSource = course.getAllCourses();
            ComboBoxSelectCourse.DisplayMember = "label";
            ComboBoxSelectCourse.ValueMember = "id";
            SqlCommand command = new SqlCommand("SELECT id, fname, lname FROM std"); 
            DataGridViewStudents.DataSource = student.getStudents(command);
        }

        private void DataGridViewStudents_Click(object sender, EventArgs e)
        {
            TextBoxStudentID.Text = DataGridViewStudents.CurrentRow.Cells[0].Value.ToString();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int studentID = Convert.ToInt32(TextBoxStudentID.Text);
                int courseID = Convert.ToInt32(ComboBoxSelectCourse.SelectedValue);
                float scoreValue = float.Parse(TextBoxScore.Text);
                string description = TextBoxDescription.Text;
                if (!score.studentScoreExist(studentID, courseID))
                {
                    if (score.insertScore(studentID, courseID, scoreValue, description))
                        MessageBox.Show("Student Score Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Student Score Not Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("The Score For This Course Are Already Set", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
