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

namespace _20110375_HuynhDangKhoa_LoginForm
{
    public partial class frmForgetPassWord : Form
    {
        string randomCode;
        public static string to;
        public frmForgetPassWord()
        {
            InitializeComponent();
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            string from, pass, messageBody;
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
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

            try
            {
                smtp.Send(message);
                MessageBox.Show("Code Send Successfully!",
                    "Confirm",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void btnVerifyCode_Click(object sender, EventArgs e)
        {
            if (randomCode == (txtVerCode.Text).ToString())
            {
                to = txtInputGmail.Text;
                frmResetPassword rp = new frmResetPassword();
                this.Hide();
                rp.Show();

            }
            else
            {
                MessageBox.Show("Wrong code!", "Confirm",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }



        }

        private void frmForgetPassWord_Load(object sender, EventArgs e)
        {

        }
    }
}
