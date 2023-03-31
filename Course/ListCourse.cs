using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20110375_HuynhDangKhoa_LoginForm.Course
{
    public partial class ListCourse : Form
    {
        public ListCourse()
        {
            InitializeComponent();
        }

        private void ListCourse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSVDataSetFull.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.qLSVDataSetFull.Course);

        }

        

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Course.frmEditCourse edit = new frmEditCourse();
            edit.Show(this);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Course.frmRemovecourse remove = new Course.frmRemovecourse();
            remove.Show(this);
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            this.courseTableAdapter.Fill(this.qLSVDataSetFull.Course);
        }
    }
}
