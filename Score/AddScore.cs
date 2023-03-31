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

namespace _20110375_HuynhDangKhoa_LoginForm.Score
{
    public partial class AddScore : Form
    {
        SCORE score = new SCORE();
        Course.COURSE course = new Course.COURSE();
        STUDENT student = new STUDENT();


        public AddScore()
        {
            InitializeComponent();
        }

        private void AddScore_Load(object sender, EventArgs e)
        {
            //Lấy thông tin all course và display vào combobox
            cboChooseCourse.DataSource = course.getAllCourses();
            cboChooseCourse.DisplayMember = "label";
            cboChooseCourse.ValueMember = "id";

            //
            SqlCommand command = new SqlCommand("SELECT ID, FirstName, LastName FROM student");
            dataGridView_Score.DataSource = student.getStudents(command);

        }

        private void btnAddScore_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtScore.Text.Trim() == "")
                {
                    MessageBox.Show("Please Add An Score", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int studentID = Convert.ToInt32(txtStudentID.Text);
                    int courseID = Convert.ToInt32(cboChooseCourse.SelectedValue);
                    float scoreValue = float.Parse(txtScore.Text);
                    string description = txtCourseDescription.Text;
                    if (scoreValue >= 0 && scoreValue <= 10)
                    {
                        //Check if the score is already set for student on this course
                        if (!score.studentScoreExist(studentID, courseID))
                        {
                            if (score.insertScore(studentID, courseID, scoreValue, description))
                                MessageBox.Show("Score Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show("Score Not Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                            MessageBox.Show("The Score For This Course Are Already Set", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("The Score Must Between 0 And 10!", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    }

        private void dataGridView_Score_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_Score_Click(object sender, EventArgs e)
        {
            txtStudentID.Text = dataGridView_Score.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
