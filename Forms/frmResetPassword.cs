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
    public partial class frmResetPassword : Form
    {

        string usrMail = frmForgetPassWord.to;
        
        MY_DB mydb = new MY_DB();
        public frmResetPassword()
        {
            InitializeComponent();
        }

        private void frmResetPassword_Load(object sender, EventArgs e)
        {

           
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            if (txtResetPass.Text == txtResetPassVer.Text)
            {

                SqlCommand cmd = new SqlCommand("UPDATE[dbo].[user_login] SET [userPassword] ='" + txtResetPass.Text + "'WHERE userEmail=@email", mydb.getConnection);
                cmd.Parameters.AddWithValue("@email", SqlDbType.NChar).Value = usrMail;
                mydb.openConnection();
                if(cmd.ExecuteNonQuery() == 1)
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
}
