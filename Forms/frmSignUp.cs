using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20110375_HuynhDangKhoa_LoginForm
{
    public partial class frmSignUp : Form
    {
        STUDENT stu = new STUDENT();
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void frmSignUp_Load(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            USER user = new USER();
            MY_DB db = new MY_DB();

            try
            {
                string userName = txtUserName.Text;
                string userPass = txtPass.Text;
                string userFName = txtFirstName.Text;
                string userLName = txtLastName.Text;
                string gender = "Male";
                int phoneNumber = Convert.ToInt32(txtPhone.Text);
                string email = txtEmail.Text;


                if (radbFemale.Checked)
                {
                    gender = "Female";
                }


                SqlDataAdapter adapter = new SqlDataAdapter();

                SqlCommand command = new SqlCommand("SELECT * FROM user_login WHERE userName =@usrName OR userEmail=@usrEmail ");

                command.Parameters.Add("@usrName", SqlDbType.NChar).Value = userName;
                command.Parameters.Add("@usrEmail", SqlDbType.NChar).Value = email;
                DataTable table = stu.getStudents(command);

                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("UserName hoặc Gmail bị trùng!!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (!checkEmail(txtEmail.Text))
                {
                    MessageBox.Show("Hãy điền đúng format của EMAIL!!", 
                        "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtFirstName.Text.Any(char.IsDigit) || txtLastName.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("FirstName và LastName của USER không chứa số!",
                        "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (!checkPhoneNumber())
                {
                    MessageBox.Show("Số điện thoại phải nhập đủ 10 số !!!!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                else
                {
                    if (verif())
                    {

                        if (txtPass.Text == txtReEnterPass.Text)
                        {
                            if (user.insertUser(userName, userPass, userFName, userLName, gender, phoneNumber, email))
                            {
                                // MessageBox.Show(department, "test");
                                MessageBox.Show("Đăng ký thành công", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Lỗi Đăng Ký", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mật Khẩu không khớp!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }
                }
                
            }
            catch (Exception error)
            {

                MessageBox.Show("Vui Nhập Đầy đủ thông tin mới Đăng Ký được tài khoản!!!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


            /*
             else
                {
                    MessageBox.Show("Login error", "Confirm",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
             
             
             */



        }

        // thiếu trường hợp 2 cái pasword trùng nhau moiws đc phép đăng ký

        #region Một số hàm dùng để check điều kiện
        bool verif()
        {
            if ( (txtUserName.Text.Trim() =="") || (txtPass.Text.Trim() == "") || (txtFirstName.Text.Trim() == "") || (txtLastName.Text.Trim() == "")
                || txtEmail.Text.Trim() == "" ||txtPhone.Text.Trim()==""  )
                
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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


        // khi nhập số điện thoại chỉ được NHẬP SỐ
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // hàm kiểm tra trong chuỗi có chứa số không?
            // Ví dự như là họ tên của người dùng
        bool IsDigitsOnly(string str)
        {
            if (str.Any(char.IsDigit))
            {
                return true;
            }
            return false;
        }


        // hàm kiểm tra độ dài của số điện thoại có nhập đủ 10 số không?
        public bool checkPhoneNumber()
        {
            Regex isValidInput = new Regex(@"^\d{10}$");
            string strPhone = txtPhone.Text;
            if (!isValidInput.IsMatch(strPhone))
                return false;
            return true;
        }
        #endregion

        // show password
        //  yes --> show >< no --> hide the password
        private void btnShowPass_Click(object sender, EventArgs e)
        {
           
            DialogResult result = MessageBox.Show("Bạn có muốn xem mật khẩu không?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                txtPass.PasswordChar = default(char);
                txtReEnterPass.PasswordChar = default(char);
            }
            else
            {
                txtPass.PasswordChar = '*';
                txtReEnterPass.PasswordChar = '*';
            }
        }
        

        // check khi người dùng nhập có ký tự đặc biệt, chỉ nhập tiếng anh thôi
        // Not Unicode 
        #region Not Unicode 
            private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (!char.IsLetter(e.KeyChar))
                {
                    MessageBox.Show("Luân Khùng");
                    txtFirstName.Text = "";
                    e.Handled = true;
                }
            }

            private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (!char.IsLetter(e.KeyChar))
                {
                    MessageBox.Show("Luân Khùng 2");
                    txtFirstName.Text = "";
                    e.Handled = true;
                }
            }
        #endregion

        //toggle use to showpassword
        private void toggleShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(toggleShowPassword.Checked)
            {
                txtPass.PasswordChar = default(char);
                txtReEnterPass.PasswordChar = default(char);
                
            }
            else {

                txtPass.PasswordChar = '*';
                txtReEnterPass.PasswordChar = '*';
            }
        }

        private void lblHaveAccount_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            
        }
    }
}
