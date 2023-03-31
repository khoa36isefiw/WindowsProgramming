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
    public partial class frmEditCourse : Form
    {
        Course.COURSE course = new Course.COURSE();
        public frmEditCourse()
        {
            InitializeComponent();
        }

        private void frmEditCourse_Load(object sender, EventArgs e)
        {
            //Dùng Combobox lấy tên Course 
            cboSelectCourse.DataSource = course.getAllCourses();
            cboSelectCourse.DisplayMember = "label";
            cboSelectCourse.ValueMember = "id";
            cboSelectCourse.SelectedItem = null;
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            /*string name = txtCourseName.Text;
            int period = (int)numericUpDownPeriod.Value;
            string description = txtCourseDescription.Text;
            int id = (int)cboSelectCourse.SelectedValue;

            if (checkInput())
            {
                if (!course.checkCCourseName(name, id))
                {
                    MessageBox.Show("Course Không Tồn Tại!", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (course.updateCourse(id, name, period, description))
                {
                    MessageBox.Show("Cập nhật Course Thành Công!", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fillCombobox(cboSelectCourse.SelectedIndex);
                }
                else
                {
                    MessageBox.Show("Cap nhat that bai !", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }*/

            try
            {
                if (txtCourseName.Text.Trim() == "")
                {
                    MessageBox.Show("Add a Course Name", "Add Course ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if ((int)numericUpDownPeriod.Value < 10)
                {
                    MessageBox.Show("Period Require At Least 10 ", "Add Course ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string name = txtCourseName.Text;
                    int hrs = (int)numericUpDownPeriod.Value;
                    string descr = txtCourseDescription.Text;
                    int id = (int)cboSelectCourse.SelectedValue;

                    //Lấy lại phần kiểm tra tên course
                    if (!course.checkCourseID(id))
                    {
                        MessageBox.Show("This Course Name Does Not Exist", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else if (course.updateCourse(id, name, hrs, descr))
                    {
                        MessageBox.Show("Course Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillCombobox(cboSelectCourse.SelectedIndex);
                    }
                    else
                    {
                        MessageBox.Show("Course Not Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }



        private bool checkInput()
        {
            string name = txtCourseName.Text;
            int period = (int)numericUpDownPeriod.Value;
            string description = txtCourseDescription.Text;
            int id = (int)cboSelectCourse.SelectedValue;

            if (name.Trim() == "")
            {
                MessageBox.Show("Vui lòng điền tên của Course", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            if (period < 10)
            {
                MessageBox.Show("Period time phải > 10 !", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        public void fillCombobox(int index)
        {
            cboSelectCourse.DataSource = course.getAllCourses();
            cboSelectCourse.DisplayMember = "label";
            cboSelectCourse.ValueMember = "id";
            cboSelectCourse.SelectedItem = index;
            //cboSelectCourse.SelectedItem = null;

        }

        private void cboSelectCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(cboSelectCourse.SelectedValue);
                DataTable table = new DataTable();
                table = course.getCourseByID(id);
                txtCourseName.Text = table.Rows[0][1].ToString();
                numericUpDownPeriod.Value = Int32.Parse(table.Rows[0][2].ToString());
                txtCourseDescription.Text = table.Rows[0][3].ToString();


            }
            catch (Exception err)
            {
                //MessageBox.Show("Vui chọn Course", "Edit Course", 
                //    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
