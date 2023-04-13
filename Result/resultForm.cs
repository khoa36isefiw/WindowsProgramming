using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20110375_HuynhDangKhoa_LoginForm.Result
{
    public partial class resultForm : Form
    {
        public resultForm()
        {
            InitializeComponent();
        }
        Course.COURSE course = new Course.COURSE();
        Score.SCORE score = new Score.SCORE();
        STUDENT student = new STUDENT();
        MY_DB mydb = new MY_DB();
        private void resultForm_Load(object sender, EventArgs e)
        {
            dataGridView_ResultStudent.DataSource = score.getAllCourseScoreAndResult();
            //dataGridView_ResultStudent.AutoSize = true;
            dataGridView_ResultStudent.Columns[0].HeaderText = "Student ID";
            dataGridView_ResultStudent.Columns[1].HeaderText = "First Name";
            dataGridView_ResultStudent.Columns[2].HeaderText = "Last Name";
        }
    }
}
