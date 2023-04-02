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

namespace _20110375_HuynhDangKhoa_LoginForm
{
    public partial class frmManagementUser : Form
    {
        // get users
        STUDENT student = new STUDENT();
        USER user = new USER();

        public frmManagementUser()
        {
            InitializeComponent();
        }

        private void frmManagementUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userDataSet.user_login' table. You can move, or remove it, as needed.
            fillGrid(new SqlCommand("Select * from user_login"));

        }
        public void fillGrid(SqlCommand cmd)
        {

            // load dữ liệu của sinh viên từ database vào  datagridView - bằng bảng sinh viên
            dataGRV_User.ReadOnly = true;
            dataGRV_User.DataSource = student.getStudents(cmd);
            dataGRV_User.AllowUserToAddRows = false;
        }

 

                
        

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("Select * from user_login"));
        }

      

        private void dataGRV_User_Click(object sender, EventArgs e)
        {
            txtUName.Text = dataGRV_User.CurrentRow.Cells[0].Value.ToString();
            txtPass.Text = dataGRV_User.CurrentRow.Cells[1].Value.ToString();
            txtFName.Text = dataGRV_User.CurrentRow.Cells[2].Value.ToString();
            txtLName.Text = dataGRV_User.CurrentRow.Cells[3].Value.ToString();

            // xét cột giới tính
            if (dataGRV_User.CurrentRow.Cells[4].Value.ToString() == "Female")
            {
                txtGender.Text = "Female";
            }
            else
            {
                txtGender.Text = "Male";
            }

            txtPhone.Text = dataGRV_User.CurrentRow.Cells[5].Value.ToString();
            txtEmail.Text = dataGRV_User.CurrentRow.Cells[6].Value.ToString();
            //txtRoles.Text = dataGRV_User.CurrentRow.Cells[7].Value.ToString();
        }

        private void dataGRV_User_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
           
            try
            {
              
                
                    string id = (txtUName.Text);
                    // cho người dùng chọn: đồng ý xóa hoặc không
                    // nếu đồng ý - xóa đi một sinh viên đã chọn theo id
                    // nếu không thì quay trở lại form bình thường không xóa

                    DialogResult confirmDelete = MessageBox.Show("Bạn có thực sự muốn xóa đi User này không?",
                  "Delete User",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirmDelete == DialogResult.Yes)
                    {
                        // kiểm tra nếu người dùng có username = admin và first là Khoa thì không xáo
                        if(txtFName.Text == "Khoa" || txtUName.Text=="admin")
                        {
                                MessageBox.Show("Bạn Không Có Quyền Xóa Người Dùng Này!",
                             "Delete User",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Information);
                        }
                        else
                        {
                            user.deleteUser(id);
                            MessageBox.Show("User đã được xóa: " + id,
                                "Delete User",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            // clear data
                            txtUName.Text = "";
                            txtPass.Text = "";
                            txtGender.Text = "";
                            txtFName.Text = "";
                            txtLName.Text = "";
                            txtPhone.Text = "";
                            txtEmail.Text = "";
                        }
                       
                    }
                    else
                    {
                        MessageBox.Show("Bạn không xóa User!",
                           "Delete Student",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
                    }
                
            }
            catch (Exception err)
            {

                MessageBox.Show("Must Find User To Remove",
                   "Delete User",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
            }
        }
    }
}
