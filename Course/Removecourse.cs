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
    public partial class frmRemovecourse : Form
    {
        Course.COURSE course = new Course.COURSE();
        public frmRemovecourse()
        {
            InitializeComponent();
        }

        private void frmRemovecourse_Load(object sender, EventArgs e)
        {
           
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string message = "Bạn có thực sự muốn xóa không?";
            string title = "Remove Course";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
            try
            {
                if (result == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(txtCourseID.Text);

                    DataTable table = course.getCourseByID(id);
                    if (table.Rows.Count > 0)
                    {
                        if (course.deleteCourse(id))
                        {
                            MessageBox.Show("Xóa Course Thành Công: " + txtCourseID.Text, "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không Tìm Thấy Course ID", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    txtCourseID.Text = null;
                }
            }
            catch
            {
                MessageBox.Show("Hãy Vui Lòng Điền Course ID", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtCourseID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)  // 8 là phím Backspace
            {
                // Nếu không phải số thì chặn sự kiện KeyPress
                MessageBox.Show("Chỉ được nhập số!", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }
    }
}
