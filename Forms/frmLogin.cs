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

namespace _20110375_HuynhDangKhoa_LoginForm
{
    public partial class frmLogin : Form
    {
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        public frmLogin()
        {
            InitializeComponent();
           
            if (Properties.Settings.Default.taiKhoan != String.Empty)
            {
                 txtUserName.Text = Properties.Settings.Default.taiKhoan;
                txtPassword.Text = Properties.Settings.Default.matKhau;
            }
        }
   

        private void btnCancel_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Cảm ơn bạn đã ghé vào hệ thống của chúng tôi!");
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (chkBoxRemember.Checked)
            {
                Properties.Settings.Default.taiKhoan = txtUserName.Text;
                Properties.Settings.Default.matKhau = txtPassword.Text;
                Properties.Settings.Default.Save();
            }


            // Connect to the Database
            MY_DB db = new MY_DB();
            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("SELECT * FROM user_login WHERE userName = @User AND userPassword =@Pass", db.getConnection);


            //Difine User and Pass
            command.Parameters.Add("@User", SqlDbType.VarChar).Value = txtUserName.Text;
            command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = txtPassword.Text;

            adapter.SelectCommand = command;

            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Login error", "Confirm",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {

            frmSignUp fSignUp = new frmSignUp();
            fSignUp.ShowDialog();
        }

        private void btnResetPass_Click(object sender, EventArgs e)
        {
            frmForgetPassWord ressetPass = new frmForgetPassWord();
            ressetPass.ShowDialog();
        }


        private void pictBoxShow_Click(object sender, EventArgs e)
        {
            if (pictBoxShow.Visible)
            {
                txtPassword.PasswordChar = '*';
                //txtPassword.PasswordChar = '\0';
                pictBoxHide.Visible = true;
                pictBoxShow.Visible = false;
            }
        }

        private void pictBoxHide_Click(object sender, EventArgs e)
        {
            if (pictBoxHide.Visible)
            {
                txtPassword.PasswordChar = default(char);

                pictBoxShow.Visible = true;
                pictBoxHide.Visible = false;
            }
        }





    }
}
