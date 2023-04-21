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

namespace _20110375_HuynhDangKhoa_LoginForm.Forms
{
    public partial class SelectedCourse : Form
    {
        MY_DB mydb = new MY_DB();
        STUDENT student = new STUDENT();

        private int lastSelectedIndex;  // flag phát hiện nếu người dùng chọn nhiều làn vào trên cbo

        public SelectedCourse()
        {
            InitializeComponent();
        }

        private void AddCourseForm_Load(object sender, EventArgs e)
        {
            
            listBoxAvailableCourse.Items.Clear();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBoxAvailableCourse.Items.Count; i++)
            {
                // Kiểm tra xem phần tử có được chọn hay không
                if (listBoxAvailableCourse.GetSelected(i))
                {
                    // Nếu phần tử chưa tồn tại trong ListBox bên phải, thêm vào ListBox bên phải
                    if (!listBoxSelectedCourse.Items.Contains(listBoxAvailableCourse.Items[i]))
                    {
                        listBoxSelectedCourse.Items.Add(listBoxAvailableCourse.Items[i]);
                    }
                }
            }
        }

        private void txtStudentId_TextChanged(object sender, EventArgs e)
        {
            //"SELECT * FROM student Where FirstName LIKE '%" + txtStudentId.Text + "%'"
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand("SELECT MSSV FROM student Where MSSV LIKE '%" + txtStudentId.Text + "%'", mydb.getConnection);
            mydb.openConnection();
            cmd.ExecuteNonQuery();

            dr = cmd.ExecuteReader();
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            while (dr.Read())
            {
                col.Add(dr.GetString(0));
            }
            txtStudentId.AutoCompleteCustomSource = col;
            dr.Close();
            mydb.closeConnection();





        }

        private void txtAvailableCourse_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Duyệt qua từng phần tử trong ListBox bên phải
            for (int i = listBoxSelectedCourse.Items.Count - 1; i >= 0; i--)
            {
                // Kiểm tra xem phần tử có được chọn hay không
                if (listBoxSelectedCourse.GetSelected(i))
                {
                    // Xóa phần tử khỏi ListBox bên phải
                    listBoxSelectedCourse.Items.RemoveAt(i);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string items;
            if (cboSelectedSemeter.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa Chọn sau lưu");

            }
            else
            {

                /*
                Artificial Intelligence
                Data Structure
                OOP                                                         
                Winforms
                Web Programming
                Mobile Programming */

                /*
                   HK1 2022-2023
                   HK2 2022-2023
                   HK1 2023-2024
                   HK2 2023-2024
                */

                

                if (cboSelectedSemeter.SelectedItem.ToString().Trim() == "HK1")
                {

                    try
                    {

                        // Lấy danh sách các phần tử trong Listbox và hợp nhất chúng thành một chuỗi string
                        string concatenatedString = string.Join(", ", listBoxSelectedCourse.Items.Cast<string>());
                        MessageBox.Show(concatenatedString);
                        if (student.updateStudentSelectedCourses(txtStudentId.Text, concatenatedString))
                        {

                            MessageBox.Show("Update thành công Course cho Student", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Lỗi", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }



                    }
                    catch (Exception er)
                    {
                        MessageBox.Show("Điền đầy đủ thông tin đi 2, Không là Luân đấm bạn đó2!",
                            "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }



                /*
                     else if (verif())
            {
                // chỉnh sửa thông tin sinh viên
                picStudent.Image.Save(pic, picStudent.Image.RawFormat);
                if (student.updateStudent(id, fName, lName, bdate, gender, phoneNumber, email, addrress, departMent, major, pic, ghome))
                {

                    MessageBox.Show("Chỉnh sửa thông tin sinh viên thành công", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lỗi", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


                     */



            }








        }

        private void listBoxAvailableCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void cboSelectedSemeter_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem lựa chọn mới có khác với lựa chọn trước đó hay không
            if (cboSelectedSemeter.SelectedIndex != lastSelectedIndex)
            {
                // Lưu lại lựa chọn mới
                lastSelectedIndex = cboSelectedSemeter.SelectedIndex;

                // Xóa các mục hiện tại trong ListBox
                listBoxAvailableCourse.Items.Clear();
            }
            // Thêm các mục mới vào ListBox dựa trên lựa chọn của người dùng
            else if (cboSelectedSemeter.SelectedIndex == 0)
            {
                SqlDataReader dr;
                
                SqlCommand cmd  = new SqlCommand("Select label from Course where semester='HK1'", mydb.getConnection);
                mydb.openConnection();
                cmd.ExecuteNonQuery();

                dr = cmd.ExecuteReader();
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                while (dr.Read())
                {
                    listBoxAvailableCourse.Items.Add(dr.GetString(0));
                }
                txtStudentId.AutoCompleteCustomSource = col;
                dr.Close();
                mydb.closeConnection();
                lastSelectedIndex = -1; // xóa khi người dùng cố chọn lại Semester


            }
            else if(cboSelectedSemeter.SelectedIndex == 1)
            {
                SqlDataReader dr;
                //listBoxAvailableCourse.Items.Add("Artificial Intelligence");
                //listBoxAvailableCourse.Items.Add("Data Structure");
                //listBoxAvailableCourse.Items.Add("OOP");
                //lastSelectedIndex = -1;     // xóa khi người dùng cố chọn lại Semester
                SqlCommand cmd = new SqlCommand("Select label from Course where semester='HK2'", mydb.getConnection);
                mydb.openConnection();
                cmd.ExecuteNonQuery();

                dr = cmd.ExecuteReader();
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                while (dr.Read())
                {
                    listBoxAvailableCourse.Items.Add(dr.GetString(0));
                }
                txtStudentId.AutoCompleteCustomSource = col;
                dr.Close();
                mydb.closeConnection();
                lastSelectedIndex = -1;
            } 
                
        }
    }
}
