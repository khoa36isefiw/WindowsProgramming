using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Util.Store;
using System.Windows.Forms;
using Google.Apis.Util;
using System.Threading;

namespace _20110375_HuynhDangKhoa_LoginForm
{
    public partial class frmLogin : Form
    {

        private static string[] Scopes = { "email", "profile" };
        private static string ApplicationName = "StudentManagementApplication";
        UserCredential credential;
        private void frmLogin_Load(object sender, EventArgs e)
        {
            CreateHelpProvider();
            toolTipUserName.SetToolTip(txtUserName, "Nhập tên đăng nhập");
            toolTipPass.SetToolTip(txtPassword, "Nhập mật khẩu");
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
            if (radbStudent.Checked == true)
            {
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
                    frmMain mainF = new frmMain();
                    mainF.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Login error", "Confirm",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else if (radbHuman.Checked == true)
            {
                //table username and password of Human Resource
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand("SELECT * FROM HumanResource WHERE uname =" +
                        " @username And pwd = @password", db.getConnection);

                command.Parameters.Add("@username", SqlDbType.VarChar).Value = txtUserName.Text;
                command.Parameters.Add("@password", SqlDbType.VarChar).Value = txtPassword.Text;

                adapter.SelectCommand = command;
                adapter.Fill(table);
                
                if (table.Rows.Count > 0)
                {
                    int HRID = Convert.ToInt16(table.Rows[0][0].ToString());
                    Global.SetGlobalUserId(HRID);

                    //Hide();

                    Forms.frmMainHR fHR = new Forms.frmMainHR();
                    fHR.Show(this);

                    //Gán biến form cho fromHR để gọi ngược lại loginform khi sign out

                    
                }
                else
                {
                    MessageBox.Show("Login error", "Confirm",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else if(rad_btn_Admin.Checked == true)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand("SELECT * FROM HumanResource WHERE uname = 'admin' And pwd = '1'", db.getConnection);
                

                adapter.SelectCommand = command;

                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    Forms.frmMainHR fHR = new Forms.frmMainHR();
                    fHR.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Login error", "Confirm",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Chose User Type", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }




            #region cmt

            //SqlDataAdapter adapter = new SqlDataAdapter();

            //DataTable table = new DataTable();

            //SqlCommand command = new SqlCommand("SELECT * FROM user_login WHERE userName = @User AND userPassword =@Pass", db.getConnection);


            ////Difine User and Pass
            //command.Parameters.Add("@User", SqlDbType.VarChar).Value = txtUserName.Text;
            //command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = txtPassword.Text;

            //adapter.SelectCommand = command;

            //adapter.Fill(table);
            //if (table.Rows.Count > 0)
            //{
            //    this.DialogResult = DialogResult.OK;
            //}
            //else
            //{
            //    MessageBox.Show("Login error", "Confirm",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Error);
            //}
            #endregion
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if(radbStudent.Checked == true)
            {
                frmSignUp fSignUpForStudent = new frmSignUp();
                fSignUpForStudent.ShowDialog();
            }
            else if (radbHuman.Checked == true)
            {
                Forms.HumanResourceRegister fSignUpForHR = new Forms.HumanResourceRegister();
                fSignUpForHR.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Chose User Type", "Registor Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
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

        private void chkBoxRemember_CheckedChanged(object sender, EventArgs e)
        {

        }


        // login by google
        private void btnGG_Click(object sender, EventArgs e)
        {

            credential =  GoogleWebAuthorizationBroker.AuthorizeAsync(
                new ClientSecrets
                {
                    //ClientId = "636865955755-8crf1u7s24931uan92rd535k4a0m4p17.apps.googleusercontent.com",
                    //ClientSecret = "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"
                    ClientId = "636865955755-mpt5hpmas6fqqeboc4k2da1n2hn2mgus.apps.googleusercontent.com",
                    ClientSecret = "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"
                },
                Scopes,
                "user",
                System.Threading.CancellationToken.None,
                new FileDataStore("Drive.Auth.Store")).Result;

            if (credential != null )
            {
                MessageBox.Show("Nó chạy vào đây nè!");
                // If authentication succeeds, open the main form
                var mainForm = new frmMain();
                
                mainForm.Show();
            }
            else
            {
                //// If authentication fails, show an error message
                //MessageBox.Show("Login failed. Please try again.");
                // If authentication fails or token is expired, request new authorization
                
                {
                    // If reauthorization fails, show an error message
                    MessageBox.Show("Login failed. Please try again.");
                }

            }

        }









        private HelpProvider hlpProvider;

        private void CreateHelpProvider()

        {

            hlpProvider = new System.Windows.Forms.HelpProvider();

            hlpProvider.SetShowHelp(txtUserName, true);

            hlpProvider.SetHelpString(txtUserName, "Enter a valid text here.");



            hlpProvider.SetShowHelp(btnLogin, true);

            hlpProvider.SetHelpString(btnLogin, "Click this button to Login Systems.");



            // Help file

            hlpProvider.HelpNamespace = "helpFile.chm";



            hlpProvider.SetHelpNavigator(txtUserName, HelpNavigator.TableOfContents);



        }

        
    }
}
