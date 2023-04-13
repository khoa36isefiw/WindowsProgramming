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
    public partial class ManageScore : Form
    {
        public ManageScore()
        {
            InitializeComponent();
        }

        SCORE score = new SCORE();
        STUDENT student = new STUDENT();
        Course.COURSE course = new Course.COURSE();
        string data = "score2";

        private void ManageScore_Load(object sender, EventArgs e)
        {
            dataGridViewManageResult.DataSource = score.getStudentScore();
            data = "score2";

            cboChooseCourse.DataSource = course.getAllCourses();
            cboChooseCourse.DisplayMember = "label";
            cboChooseCourse.ValueMember = "id";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtScore.Text.Trim() == "")
                {
                    MessageBox.Show("Please Add An Score", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //int studentID = Convert.ToInt32(txtStudentID.Text);
                    string studentID = txtStudentID.Text;
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

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (data == "score2")
            {
                //int student_id = Convert.ToInt32(dataGridViewManageResult.CurrentRow.Cells[0].Value.ToString());
                string student_id = dataGridViewManageResult.CurrentRow.Cells[0].Value.ToString();
                int course_id = Convert.ToInt32(dataGridViewManageResult.CurrentRow.Cells[3].Value.ToString());
                if ((MessageBox.Show("Are you sure you want to delete this course", "Remove Course", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes))
                {
                    if (score.deleteScore(student_id, course_id))
                    {
                        MessageBox.Show("Score Deleted", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridViewManageResult.DataSource = score.getStudentScore();
                    }
                    else
                    {
                        MessageBox.Show("Score Not Deleted", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Chose Score Before Delete!", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAverageScore_Click(object sender, EventArgs e)
        {
            AverageScore averageSCO = new AverageScore();
            averageSCO.Show(this);
        }

        private void btnShowStudents_Click(object sender, EventArgs e)
        {
            data = "student";

            //SqlCommand cmd = new SqlCommand("select ID, FirstName, LastName from student ");
            
            SqlCommand cmd = new SqlCommand("select MSSV, FirstName as 'First Name', LastName as 'Last Name' from student ");


            dataGridViewManageResult.DataSource = student.getStudents(cmd);
        }

        private void btnShowScores_Click(object sender, EventArgs e)
        {
            data = "score2";
            //SqlCommand cmd = new SqlCommand("select student_id, course_id, student_score, description from score2 ");
            dataGridViewManageResult.DataSource = score.getStudentScore();
        }

        private void dataGridViewManageResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getDataFromDatagridView();
        }


        void getDataFromDatagridView()
        {
            if (data == "student")
            {
                txtStudentID.Text = dataGridViewManageResult.CurrentRow.Cells[0].Value.ToString();
            }
            else if (data == "score2")
            {
                txtStudentID.Text = dataGridViewManageResult.CurrentRow.Cells[0].Value.ToString();
                cboChooseCourse.SelectedValue = dataGridViewManageResult.CurrentRow.Cells[3].Value;
            }
        }
    }
}
