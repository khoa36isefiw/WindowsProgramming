using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20110375_HuynhDangKhoa_LoginForm
{
    public partial class frmMain : Form
    {


        public frmMain()
        {
            InitializeComponent();
        }

        void loadData()
        {
            for (int i = 0; i < 900; i++)
            {
                   Thread.Sleep(10);
            }
        }


        private void mnuStudentAdded_Click(object sender, EventArgs e)
        {
            frmAddStudent fAddStudent = new frmAddStudent();
            fAddStudent.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            STUDENT stu = new STUDENT();
            frmLogin login = new frmLogin();
            string roles;
            SqlCommand cmd = new SqlCommand("SELECT Roles FROM user_login WHERE userName=@user");
            cmd.Parameters.Add("@user", SqlDbType.NChar).Value = login.txtUserName.Text;
            DataTable table = stu.getStudents(cmd);


            if (table.Rows.Count > 0)
            {
                roles = table.Rows[0][0].ToString().Trim();
                if (roles == "admin")
                {
                    mnuManageUser.Enabled = true;
                }
                else
                {
                    mnuManageUser.Enabled = false;
                }


            }


        }

        private void mnuStudentList_Click(object sender, EventArgs e)
        {
            using (frmLoading frmLoad = new frmLoading(loadData))
            {
                frmLoad.ShowDialog();
               

            }
            frmStudentList frmStu = new frmStudentList();
            frmStu.Show();
        }

        private void mnuStudentEditAndRemove_Click(object sender, EventArgs e)
        {
            frmUpdateDeleteStudent updateDeleteStu = new frmUpdateDeleteStudent();
            updateDeleteStu.Show();
            
        }

        private void mnuStudentExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if(DialogResult.Yes == result)
            {
                this.Close();
                frmLogin lo = new frmLogin();
                lo.Show();
            }
            else
            {
                MessageBox.Show("Mời bạn tiếp tục dùng chương trình!",
               "Confirm",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);
            }

        }

        
        
        // Restart lại ứng dụng
        private void btnlogOut_Click(object sender, EventArgs e)
        {
            Application.Restart();

        }

        private void mnuManageUser_Click(object sender, EventArgs e)
        {
           
        }

        private void mnuManageUser_Account_Click(object sender, EventArgs e)
        {
            frmManagementUser manageUser = new frmManagementUser();
            manageUser.ShowDialog();
        }
    }
}
