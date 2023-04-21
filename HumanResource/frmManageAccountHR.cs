using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20110375_HuynhDangKhoa_LoginForm.HumanResource
{
    public partial class frmManageAccountHR : Form
    {
        USER user = new USER();
        STUDENT std = new STUDENT();
        public frmManageAccountHR()
        {
            InitializeComponent();
        }

        private void txtLName_TextChanged(object sender, EventArgs e)
        {

        }

        private void datagridView_HRAccount_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmManageAccountHR_Load(object sender, EventArgs e)
        {

            // load dữ liệu của sinh viên từ database vào  datagridView - bằng bảng sinh viên
            //SqlCommand command = new SqlCommand("SELECT * FROM student");
            SqlCommand command = new SqlCommand("Select id as N'HR ID', f_name as N'First Name'," +
                    " l_name as N'Last Name', uname as N'HR Login Name'," +
                        "pwd as Password, fig as 'Image', gmail as N'HR Email' from HumanResource");
            datagridView_HRAccount.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            datagridView_HRAccount.RowTemplate.Height = 20;
            datagridView_HRAccount.DataSource = std.getStudents(command);

            // columns[10] là tương ứng cột picture trong database
            picCol = (DataGridViewImageColumn)datagridView_HRAccount.Columns[5];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            datagridView_HRAccount.AllowUserToAddRows = false;
        }

        private void datagridView_HRAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUName.Text = datagridView_HRAccount.CurrentRow.Cells[0].Value.ToString();
            txtPass.Text = datagridView_HRAccount.CurrentRow.Cells[1].Value.ToString();
            txtFName.Text = datagridView_HRAccount.CurrentRow.Cells[2].Value.ToString();
            txtLName.Text = datagridView_HRAccount.CurrentRow.Cells[3].Value.ToString();



            txt_HRID.Text = datagridView_HRAccount.CurrentRow.Cells[4].Value.ToString();
            txtEmail.Text = datagridView_HRAccount.CurrentRow.Cells[6].Value.ToString();


            // up image lên
            byte[] pic;
            pic = (byte[])datagridView_HRAccount.CurrentRow.Cells[5].Value;
            MemoryStream picture = new MemoryStream(pic);
            pictureBox_Img.Image = Image.FromStream(picture);



        }
    }
}
