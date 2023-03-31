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
    public partial class AverageScore : Form
    {
        public AverageScore()
        {
            InitializeComponent();
        }
        

        SCORE score = new SCORE();

        private void AverageScore_Load(object sender, EventArgs e)
        {
            dataGridView_AverageStudentScore.DataSource = score.getAverageCourse();
        }
    }
}
