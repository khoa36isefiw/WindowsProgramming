using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _20110375_HuynhDangKhoa_LoginForm.Course
{
    public partial class ManageCoursesForm : Form
    {
        Course.COURSE course = new Course.COURSE();
        MY_DB mydb = new MY_DB();
        int pos;
        public ManageCoursesForm()
        {
            InitializeComponent();
        }

        private void ManageCoursesForm_Load(object sender, EventArgs e)
        {

            reloadListBoxData();
            
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
                cboSemester.SelectedItem = dr.ItemArray[4].ToString();
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
                string semester = cboSemester.SelectedItem.ToString();

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
                        if (course.insertCourse(id, name, hrs, description, semester))
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

        // update information of Course
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
                    string semester = cboSemester.SelectedItem.ToString();


                    //Lấy lại phần kiểm tra tên course
                    if (!course.checkCourseID(id))
                    {
                        MessageBox.Show("This Course Name Does Not Exist", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else if (course.updateCourse(id, name, hrs, descr, semester))
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

      
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            reloadListBoxData();
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

        private void listBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //int lastSelectedIndex = -1;
        //private void cboSemester_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    // Kiểm tra xem lựa chọn mới có khác với lựa chọn trước đó hay không
        //    if (cboSemester.SelectedIndex != lastSelectedIndex)
        //    {
        //        // Lưu lại lựa chọn mới
        //        lastSelectedIndex = cboSemester.SelectedIndex;

        //        // Xóa các mục hiện tại trong ListBox
        //        //listBoxCourse.Items.Clear();
        //    }
        //    // Thêm các mục mới vào ListBox dựa trên lựa chọn của người dùng
        //    else if (cboSemester.SelectedIndex == 0)
        //    {

        //        SqlDataReader dr;

        //        SqlCommand cmd = new SqlCommand("Select label from Course where semester = 'HK1' ", mydb.getConnection);
        //        mydb.openConnection();
        //        cmd.ExecuteNonQuery();

        //        dr = cmd.ExecuteReader();
        //        AutoCompleteStringCollection col = new AutoCompleteStringCollection();
        //        while (dr.Read())
        //        {
        //            listBoxCourse.Items.Add(dr.GetString(0));
        //        }
        //        dr.Close();
        //        mydb.closeConnection();
        //        lastSelectedIndex = -1; // xóa khi người dùng cố chọn lại Semester

        //    }
        //    else if (cboSemester.SelectedIndex == 1)
        //    {
        //        SqlDataReader dr;

        //        SqlCommand cmd = new SqlCommand("Select label from Course where semester = 'HK2' ", mydb.getConnection);
        //        mydb.openConnection();
        //        cmd.ExecuteNonQuery();

        //        dr = cmd.ExecuteReader();
        //        AutoCompleteStringCollection col = new AutoCompleteStringCollection();
        //        while (dr.Read())
        //        {
        //            listBoxCourse.Items.Add(dr.GetString(0));
        //        }
        //        dr.Close();
        //        mydb.closeConnection();
        //        lastSelectedIndex = -1; // xóa khi người dùng cố chọn lại Semester
        //    }
        //}

        private void listBoxCourse_DoubleClick(object sender, EventArgs e)
        {
            // get the selected item from the list box
            #region  Cheat
            //string selectedItem = listBoxCourse.Text;

            //FormCourseStudentList frmCourseList = new FormCourseStudentList();
            //Label label = new Label();
            //label.Text = "Selected Course: " + selectedItem;
            //label.Location = new Point(20, 15);
            //label.AutoSize = true;
            //label.ForeColor = Color.DarkRed;
            //label.Font.Bold.ToString();
            //frmCourseList.Controls.Add(label);

            //frmCourseList.ShowDialog();
            #endregion

            FormCourseStudentList frmCourseList = new FormCourseStudentList();
            frmCourseList.txtCourseName2.Text = txtCourseName.Text;
            frmCourseList.lblShow.Text = cboSemester.SelectedItem.ToString();
            frmCourseList.ShowDialog();


            /*
             
                CourseStudentList course = new CourseStudentList();
                course.textBoxCourseName.Text = textBoxLabel.Text;
                course.labelShowSemeter.Text = comboBoxSemester.SelectedItem.ToString();
                course.ShowDialog();
             
             */
        }

        private void cboSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
