using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20110375_HuynhDangKhoa_LoginForm.Forms
{
    public partial class frmAddCourse : Form
    {
        public frmAddCourse()
        {
            InitializeComponent();
        }

        private void frmAddCourse_Load(object sender, EventArgs e)
        {

        }

         
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {


                int id = Convert.ToInt32(txtCourseID.Text);
                string name = txtCourseName.Text;
                int hrs = Convert.ToInt32(txtCourseTime.Text);
                string description = txtCourseDescription.Text;

                Course.COURSE course = new Course.COURSE();

                if (name.Trim() == "")
                {
                    MessageBox.Show("Vui Lòng Điền Tên Của Course", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else 
                {
                    if (hrs <= 10)
                    {
                        MessageBox.Show("Thời Lượng Khóa Học Phải 10!", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (!course.checkCCourseName(name, id))
                    {
                        if (course.insertCourse(id, name, hrs, description))
                        {
                            MessageBox.Show("Thêm Course Thành Công!", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Thêm Course Không Thành Công!", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Course Đã Tồn Tại!", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                }

              
            }
            catch { MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

            //int id = Convert.ToInt32(txtCourseID.Text);
            //string nameCourse = txtCourseName.Text;
            //int hourse = Convert.ToInt32(txtCourseTime.Text);
            //string description = txtCourseDescription.Text;
            //try
            //{
            //    if (verif())
            //    {
            //        int num = -1;
            //        if (txtCourseName.Text.Trim() == "")
            //        {
            //            MessageBox.Show("Add a Course Name", "Add Course ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //        }
            //        else if (!Int32.TryParse(txtCourseID.Text, out num))
            //        {
            //            MessageBox.Show("Please Add An Integer For Course's ID", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        }
            //        else if (course.checkCCourseName(nameCourse, id ))
            //        {

            //            if (hourse < 10)
            //            {
            //                MessageBox.Show("Period Require At Least 10 ", "Add Course ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //            }
            //            else
            //            {

            //                    if (course.insertCourse(id, nameCourse, hourse, description))
            //                    {
            //                        MessageBox.Show("New Course Insert", "Add Course ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                    }
            //                    else
            //                    {
            //                        MessageBox.Show("Course Not Insert", "Add Course ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                    }

            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("This Course Name Already Exists", "Add Course ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Empty Fields", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message);
            //}

        }
        bool verif()
        {
            if (txtCourseID.Text.Trim() == "" || txtCourseName.Text.Trim() == "")
                return false;
            else
                return true;

        }
    }
    
}
