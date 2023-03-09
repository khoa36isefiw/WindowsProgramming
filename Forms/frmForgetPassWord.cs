using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;

namespace _20110375_HuynhDangKhoa_LoginForm
{
    public partial class frmForgetPassWord : Form
    {
        MY_DB mydb = new MY_DB();
        STUDENT stu = new STUDENT();
        string usrMail = frmForgetPassWord.to;

        string randomCode;
        public static string to;
        public frmForgetPassWord()
        {
            InitializeComponent();
            btnVerifyCode.Enabled = false;  // khi load lên thì vô hiệu hóa luôn button Verify Code
         



        }

        // xíu fix check exception tiếp
        

        bool isVerifyCode = false;

        

        private void frmForgetPassWord_Load(object sender, EventArgs e)
        {

        }

        //This code is used to check email exists in database or not?
        /*
         
         SqlDataAdapter adapter = new SqlDataAdapter();

                SqlCommand command = new SqlCommand("SELECT * FROM user_login WHERE userName =@usrName OR userEmail=@usrEmail ");

                command.Parameters.Add("@usrName", SqlDbType.NChar).Value = userName;
                command.Parameters.Add("@usrEmail", SqlDbType.NChar).Value = email;
                DataTable table = stu.getStudents(command);

                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("UserName hoặc Gmail bị trùng!!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
         */


        // reset mat khau --> xét sự kiện nếu chưa nhậP verify code thì không được đổi mật khẩu

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (!isVerifyCode)
            {
                btnReset.Enabled = false;
            }
            else
            {
                if (txtResetPass.Text == txtResetPassVer.Text)
                {

                    SqlCommand cmd = new SqlCommand("UPDATE[dbo].[user_login] SET [userPassword] ='" + txtResetPass.Text + "'WHERE userEmail=@email", mydb.getConnection);
                    cmd.Parameters.AddWithValue("@email", SqlDbType.NChar).Value = txtInputGmail.Text;
                    mydb.openConnection();
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        mydb.closeConnection();
                    }
                    else
                        mydb.closeConnection();

                    MessageBox.Show("Congratulations!,You just have reset your password!",
                        "Reset Password",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);


                }
                else
                {
                    MessageBox.Show("Does not match!",
                        "Reset Password",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                }
            }
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnVerifyCode_Click(object sender, EventArgs e)
        {
            if (randomCode == (txtVerCode.Text).ToString())
            {
                to = txtInputGmail.Text;
                //frmResetPassword rp = new frmResetPassword();
                //this.Hide();
                //rp.Show();
                isVerifyCode = true;
                btnReset.Enabled = true;
                MessageBox.Show("Now you can change your password!!", "Reset Password",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            else
            {
                if (txtVerCode.Text == "")
                {
                    MessageBox.Show("Chú mài chưa điền mà đồi Verify rồi!", "Confirm",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Question);
                }
                else
                {
                    MessageBox.Show("Wrong code!", "Confirm",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Warning);
                }

            }
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT * FROM user_login WHERE userEmail=@usrEmail ");

            command.Parameters.Add("@usrEmail", SqlDbType.NChar).Value = txtInputGmail.Text;
            DataTable table = stu.getStudents(command);

            if (table.Rows.Count > 0)
            {

                string from, pass, messageBody;
                Random rand = new Random();
                randomCode = (rand.Next(999999)).ToString();
                MailMessage message = new MailMessage();


                try
                {
                    if (txtInputGmail.Text == "")
                    {
                        // đã fix được nếu không điền gmail mà click vào button send thì hiện ra
                        MessageBox.Show("Hãy điền gmail!",
                           "Reset Password",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                    }
                    else
                    {


                        // vẫn còn lỗi, nếu người dùng cố tình nhập sai gmail
                        // ==> Hệ thống vẫn gửi --> Giải pháp là: cần check lại gmail có tồn tại trong db không?
                        // nếu gmail có tồn tại trong gmail thì hệ thống sẽ gửi
                        // ngược lại thì hệ thống sẽ báo lỗi là gmail KHÔNG TỒN TẠI

                        to = (txtInputGmail.Text).ToString();
                        from = "20110380@student.hcmute.edu.vn";
                        pass = "Luan@141002";
                        messageBody = "Your resset code is: " + randomCode;
                        message.To.Add(to);
                        message.From = new MailAddress(from);
                        message.Body = messageBody;
                        message.Subject = "Password Reseting code";
                        SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                        smtp.EnableSsl = true;

                        smtp.Port = 587;
                        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                        smtp.Credentials = new NetworkCredential(from, pass);



                        smtp.Send(message);
                        DialogResult res = MessageBox.Show("Code Send Successfully!",
                            "Confirm",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        if (res == DialogResult.OK)
                        {
                            btnVerifyCode.Enabled = true;
                        }

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Something Wrong... or Your Email is Not Exist!!, Please Check Again");

            }
        }

    }
}
