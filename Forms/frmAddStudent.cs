using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20110375_HuynhDangKhoa_LoginForm
{
    public partial class frmAddStudent : Form
    {
        public frmAddStudent()
        {
            InitializeComponent();
        }

        private void frmAddStudent_Load(object sender, EventArgs e)
        {
            
        }

      

       

        //   string.IsNullOrEmpty(txtLastName.Text) || txtLastName.Text.Any(char.IsDigit))
        bool verif()
        {
            if (string.IsNullOrEmpty(txtStudentID.Text)|| txtFirstName.Text.Trim() == "" 
                ||txtLastName.Text.Trim() == "" 
                || cboDepartment.SelectedItem== null
                || cboHomeTown.SelectedItem == null
                || txtPhone.Text.Trim() ==""
                || txtEmail.Text.Trim() == ""
                || txtAddress.Text.Trim() == ""
                || txtMajor.Text.Trim() == ""
                || picStudent.Image == null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        



     


        // chinh sua loi khi nguoi dung nhap ID Student khong phai la so
        private void txtStudentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }
        
        // khi nhập số điện thoại chỉ được NHẬP SỐ
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Mahiru");
            }
        }





        /*
        txtphonenumber
       - phải đủ 10 số
       - không có chữ cái

        */
        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
        }


        // hàm kiểm tra độ dài của số điện thoại có nhập đủ 10 số không?
        public bool checkPhoneNumber()
        {
            // return Regex.Match(number, @"^(\+[0-9]{9})$").Success;
            Regex isValidInput = new Regex(@"^\d{10}$");
            string strPhone = txtPhone.Text;
            if (!isValidInput.IsMatch(strPhone) )
                return false;
            return true;
        }


        // hàm kiểm tra trong chuỗi có chứa số không? - Ví dự như là họ tên của người dùng
        bool IsDigitsOnly(string str)
        {
            if(str.Any(char.IsDigit))
            {
                return true;
            }
            return false;
        }


        // hàm kiểm tra nhập gmail
        bool checkEmail(string email)
        {

            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
                if (!reg.IsMatch(txtEmail.Text)) 
                {
                    return false;
                }
            }
            return true;
        }



        // người dùng không thể rewrite something in combobox
        private void cboDepartment_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn sẽ thoát khỏi Ứng dụng thêm sinh viên",
                   "Confirm",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Mời bạn tiêp tục sử dụng Ứng Dụng!");
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            STUDENT student = new STUDENT();
            #region Vùng check 
            try
            {
                string id = (txtStudentID.Text);
                string fName = txtFirstName.Text;
                string lName = txtLastName.Text;
                DateTime bdate = dtpDate.Value;
                string gender = "Male";
                int phoneNumber = Convert.ToInt32(txtPhone.Text);
                string email = txtEmail.Text;
                string addrress = txtAddress.Text;
                string departMent = cboDepartment.SelectedItem.ToString();
                string home = cboHomeTown.SelectedItem.ToString();
                string major = txtMajor.Text;
                MemoryStream pic = new MemoryStream();
                int born_year = dtpDate.Value.Year;
                int this_year = DateTime.Now.Year;

                if (radbFemale.Checked)
                {
                    gender = "Female";
                }


                if ((this_year - born_year) < 17 || ((this_year - born_year) > 100))
                {
                    MessageBox.Show("Sinh viên phải từ 18 tuổi trở lên", "Ngày sinh không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (verif())
                {
                    picStudent.Image.Save(pic, picStudent.Image.RawFormat);

                    // kiểm tra student id có tồn tại hay không
                    SqlCommand command = new SqlCommand("SELECT * FROM student WHERE MSSV = @id");
                    
                    //
                    command.Parameters.Add("@id", SqlDbType.NChar).Value = id;

                    DataTable table = student.getStudents(command);

                    if (table.Rows.Count > 0)   // sinh viên tồn tại
                    {
                        MessageBox.Show("MSSV đã tồn tại!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                    else if (txtPhone.Text.Length > 0 && txtPhone.Text.Length < 4)
                    {
                        MessageBox.Show("Số điện thoại phải nhập đủ 4 số !!!!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }



                    // xử lý nếu tên của sinh viên có chứa số (0 --> 9)
                    else if (txtFirstName.Text.Any(char.IsDigit) || txtLastName.Text.Any(char.IsDigit))
                    {
                        MessageBox.Show("FirstName và LastName của sinh viên không chứa số!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }

                    else if (!checkEmail(txtEmail.Text))    // kiểm tra người dùng có nhập đúng cú pháp gmail hay không?
                    {
                        MessageBox.Show("Luân đấm mày đó nha - Hãy điền đúng format của GMAIL!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



                    // student id chưa tồn tại 
                    else
                    {
                        if (student.insertStudent(id, fName, lName, bdate, gender, phoneNumber, email, addrress, departMent, major, pic, home))
                        {
                            MessageBox.Show("Thêm sinh viên thành công", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else // khoong hien thong bao?
                        {
                            MessageBox.Show("Lỗi", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                    }

                }

                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ các thông tin của sinh viên1", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }




            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các thông tin của sinh viên", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            #endregion
        }

        private void btnUpImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image (*.jpg; *.png; *.gif) | *.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                picStudent.Image = Image.FromFile(opf.FileName);
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            // Define regular expression pattern
            string pattern = @"^[a-zA-Z\s\u0080-\uFFFF]*$";


            // Check if input matches pattern
            if (!Regex.IsMatch(txtFirstName.Text, pattern))
            {
                // Display error message
                MessageBox.Show("Input can only contain letters and spaces.", "" +
                    "Add Student",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtFirstName.Text = ""; // Clear the textbox
            }
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            // Define regular expression pattern
            string pattern = @"^[a-zA-Z\s\u0080-\uFFFF]*$";


            // Check if input matches pattern
            if (!Regex.IsMatch(txtLastName.Text, pattern))
            {
                // Display error message
                MessageBox.Show("Input can only contain letters and spaces.", "" +
                    "Add Student",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtLastName.Text = ""; // Clear the textbox
            }
        }

        private static bool errorShown = false; // Biến flag
        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

            // Biểu thức chính quy
            // Define regular expression pattern
            string pattern = @"^[0-9]+$"; // Chỉ chấp nhận các ký tự số

            // Kiểm tra chuỗi nhập vào bằng biểu thức chính quy
            if (!Regex.IsMatch(txtPhone.Text, pattern))
            {
                if(!errorShown)
                {
                    txtPhone.Text = ""; // Clear the textbox
                    MessageBox.Show("Số điện thoại chỉ được chứa các ký tự số.",
                       "Add Student",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning);
                    errorShown = true;
                }
                else
                {
                    errorShown = false; // Nếu chuỗi hợp lệ, đặt biến flag thành false
                }

            }
            

        }

        private void cboHomeTown_SelectedIndexChanged(object sender, EventArgs e)
        {
            //// Kiểm tra xem có phần tử nào được chọn hay không
            if (cboHomeTown.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn phần tử nào trong ComboBox!");
            }
            else
            {
                // Phần tử được chọn
                string selectedValue = cboHomeTown.SelectedItem.ToString();
                MessageBox.Show("Bạn đã chọn phần tử: " + selectedValue);
            }


        }

        private void cboHomeTown_TextChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem chuỗi văn bản trong ComboBox có chứa số hay không
            if (cboHomeTown.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Không được nhập số trong ComboBox!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboHomeTown.SelectedItem = null;
            }

        }

    
    }


}
