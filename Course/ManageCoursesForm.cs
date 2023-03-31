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
    public partial class ManageCoursesForm : Form
    {
        Course.COURSE course = new Course.COURSE();
        int pos;
        public ManageCoursesForm()
        {
            InitializeComponent();
        }

        void reloadListBoxData()
        {
            listBoxCourse.DataSource = course.getAllCourses();
            listBoxCourse.ValueMember = "id";
            listBoxCourse.DisplayMember = "label";
            listBoxCourse.SelectedItem = null;

            lblTotalCourse.Text = ("Total Course: " + course.totalCourse());
        }


        // dùng datarow để lấy dữ liệu của hàng table
        void showData (int index)
        {
            try
            {
                DataRow dr = course.getAllCourses().Rows[index];
                
                listBoxCourse.SelectedIndex = index;
                txtCourseID.Text = dr.ItemArray[0].ToString();
                txtCourseName.Text = dr.ItemArray[1].ToString();
                numericUpDownPeriod.Value = int.Parse(dr.ItemArray[2].ToString());
                txtCourseDescription.Text = dr.ItemArray[3].ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message);
            }

        }

        private void listBoxCourse_Click(object sender, EventArgs e)
        {
            DataRowView datarView = (DataRowView)listBoxCourse.SelectedItem;
            pos = listBoxCourse.SelectedIndex;
            showData(pos);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {


                int id = Convert.ToInt32(txtCourseID.Text);
                string name = txtCourseName.Text;
                int hrs = (int)numericUpDownPeriod.Value;
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

                            // clear fields
                            txtCourseID.Text = "";
                            txtCourseDescription.Text = "";
                            numericUpDownPeriod.Value = 10;
                            txtCourseName.Text = "";

                            reloadListBoxData();
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

        private void btnEdit_Click(object sender, EventArgs e)
        {

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
                    int id = Convert.ToInt32(txtCourseID.Text);


                    //Lấy lại phần kiểm tra tên course
                    if (!course.checkCourseID(id))
                    {
                        MessageBox.Show("This Course Name Does Not Exist", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else if (course.updateCourse(id, name, hrs, descr))
                    {
                        MessageBox.Show("Course Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reloadListBoxData();
                    }
                    else
                    {
                        MessageBox.Show("Course Not Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    pos = 0;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            pos = 0;
            showData(pos);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(pos < course.getAllCourses().Rows.Count -1) {
                pos += 1;
                showData(pos);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if(pos > 0)
            {
                pos -= 1;
                showData(pos);
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            pos = course.getAllCourses().Rows.Count - 1;
            showData(pos);
        }

        private void ManageCoursesForm_Load(object sender, EventArgs e)
        {

            reloadListBoxData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            reloadListBoxData();
        }
    }
}
