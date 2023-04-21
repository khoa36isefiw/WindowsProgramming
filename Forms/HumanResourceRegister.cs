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
using System.IO;

namespace _20110375_HuynhDangKhoa_LoginForm.Forms
{
    public partial class HumanResourceRegister : Form
    {
        public HumanResourceRegister()
        {
            InitializeComponent();
        }
        USER user = new USER();
        MY_DB mydb = new MY_DB();



        string randomCode;
        public static string to;
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {

            if (verif())
            {

                int userID = Convert.ToInt32(txt_UserID.Text);
                string firstname = txt_Fname.Text;
                string lastname = txt_Lname.Text;
                string username = txt_UserName.Text;
                string password = txt_PassWord.Text;
                string ConfirmPass = txt_ConfirmPassword.Text;
                string Gmail = txt_gmail.Text;
                string ConfirmMail = txt_ConfirmCode.Text;
                MemoryStream pic = new MemoryStream();

                if (user.CheckHRUserName(username))
                {
                    if (user.CheckHRID(userID))
                    {
                        int id = Int32.Parse(txt_UserID.Text);
                        if (String.Compare(password, ConfirmPass) != 0)
                        {
                            MessageBox.Show("Password Not Match!", "Invalid Password Confirm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (randomCode == (txt_ConfirmCode.Text).ToString())
                            {
                                PicBox_HRImage.Image.Save(pic, PicBox_HRImage.Image.RawFormat);
                                //PicBox_HRImage.Image.Save(pic, System.Drawing.Imaging.ImageFormat.Png);
                                if (user.insertHumanResource(id, firstname, lastname, username, password, pic, Gmail))
                                {
                                    MessageBox.Show("New Human Resource User Added!", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Close();
                                }
                                else
                                {
                                    MessageBox.Show("Error", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid Code!", "Confirmation Code", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("ID Existed!", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("UserName Existed!", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_UploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*gif)|*.jpg;*.pngl*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                PicBox_HRImage.Image = Image.FromFile(opf.FileName);
            }
        }

        bool verif()
        {
            if((txt_Fname.Text.Trim() == "")
                || (txt_Lname.Text.Trim() == "")
                || (txt_UserID.Text.Trim() == "")
                || (txt_UserName.Text.Trim() == "")
                || (txt_PassWord.Text.Trim() == "")
                || (txt_ConfirmPassword.Text.Trim() == "")
                || (txt_ConfirmCode.Text.Trim() == "")
                || (txt_gmail.Text.Trim() == "")
                || (PicBox_HRImage.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btn_SendConfirm_Click(object sender, EventArgs e)
        {
            if (txt_gmail.Text.Trim() != "")
            {
                Random rand = new Random();
                randomCode = (rand.Next(999999)).ToString();

                string from, pass, messageBody;
                MailMessage message = new MailMessage();
                to = (txt_gmail.Text).ToString();
                from = "20110380@student.hcmute.edu.vn";
                pass = "Luan@141002";
                messageBody = "Your confirmation code is " + randomCode;
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = messageBody;
                message.Subject = "Password Reseting code";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);
                try
                {
                    smtp.Send(message);
                    MessageBox.Show("Code Send Successfully!", "Confirmation Code", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Invalid Gmail!", "Confirmation Code", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ConfirmCode_Click(object sender, EventArgs e)
        {
            if (randomCode == (txt_ConfirmCode.Text).ToString())
            {
                MessageBox.Show("Congratulation! Email has been confirmed!", "Confirmation Code", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid Code!", "Confirmation Code", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_UserID_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("SELECT * FROM HumanResource WHERE id = @uid ", mydb.getConnection);

            command.Parameters.Add("@uid", SqlDbType.VarChar).Value = txt_UserID.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0 || txt_UserID.Text.Trim() == "")
            {
                lb_UserID.ForeColor = Color.Red;
                lb_UserID.Text = "ID Existed!";

            }
            else
            {
                lb_UserID.ForeColor = Color.Green;
                lb_UserID.Text = "Valid UserID";
            }
        }

        private void txt_UserName_Leave(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("SELECT * FROM HumanResource WHERE uname = @un ", mydb.getConnection);

            command.Parameters.Add("@un", SqlDbType.VarChar).Value = txt_UserName.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0 || txt_UserName.Text.Trim() == "")
            {
                lb_UserName.ForeColor = Color.Red;
                lb_UserName.Text = "Username Existed!";

            }
            else
            {
                lb_UserName.ForeColor = Color.Green;
                lb_UserName.Text = "Valid Username";
            }
        }
    }
}
