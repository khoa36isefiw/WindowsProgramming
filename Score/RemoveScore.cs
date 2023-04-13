using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20110375_HuynhDangKhoa_LoginForm.Score
{
    public partial class RemoveScore : Form
    {
        public RemoveScore()
        {
            InitializeComponent();
        }

        SCORE score = new SCORE();
        STUDENT student = new STUDENT();

        private void RemoveScore_Load(object sender, EventArgs e)
        {
            dataGridView_ScoreStudent.DataSource = score.getStudentScore();
        }


        private void btnRemoveScore_Click(object sender, EventArgs e)
        {
            //int student_id = Convert.ToInt32(dataGridView_ScoreStudent.CurrentRow.Cells[0].Value.ToString());
            string student_id = (dataGridView_ScoreStudent.CurrentRow.Cells[0].Value.ToString());
            int course_id = Convert.ToInt32(dataGridView_ScoreStudent.CurrentRow.Cells[3].Value.ToString());

            if ((MessageBox.Show("Are you sure you want to delete this score", "Remove Score", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes))
            {
                if (score.deleteScore(student_id, course_id))
                {
                    MessageBox.Show("Score Deleted", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView_ScoreStudent.DataSource = score.getStudentScore();
                }
                else
                {
                    MessageBox.Show("Score Not Deleted", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
