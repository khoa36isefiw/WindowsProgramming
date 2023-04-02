using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;



namespace _20110375_HuynhDangKhoa_LoginForm
{
    public partial class frmStudentList : Form
    {
        public frmStudentList()
        {
            InitializeComponent();
        }

        STUDENT student = new STUDENT();
        //frmUpdateDeleteStudent updateRemoveStudent = new frmUpdateDeleteStudent();   
        
        private void frmStudentList_Load(object sender, EventArgs e)
        {
            // load dữ liệu của sinh viên từ database vào  datagridView - bằng bảng sinh viên
            SqlCommand command = new SqlCommand("SELECT * FROM student");
            dataGVStudentList.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGVStudentList.RowTemplate.Height = 20;
            dataGVStudentList.DataSource = student.getStudents(command);

            // columns[10] là tương ứng cột picture trong database
            picCol = (DataGridViewImageColumn)dataGVStudentList.Columns[11];    
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGVStudentList.AllowUserToAddRows = false;
        }


        private void dataGVStudentList_DoubleClick(object sender, EventArgs e)
        {
            
            // hiển thị thông tin của sinh viên trong 1 form mơi ta double click vào
            // tại form này ta có thể chỉnh sửa hoặc xóa đi sinh viên

            frmUpdateDeleteStudent updateRemoveStudent = new frmUpdateDeleteStudent();
            updateRemoveStudent.txtStudentID.Enabled = false;   // can't modify the student id when we click in datagridview
            
            updateRemoveStudent.txtStudentID.Text = dataGVStudentList.CurrentRow.Cells[1].Value.ToString();
            updateRemoveStudent.txtFirstName.Text = dataGVStudentList.CurrentRow.Cells[2].Value.ToString();
            updateRemoveStudent.txtLastName.Text = dataGVStudentList.CurrentRow.Cells[3].Value.ToString();
            updateRemoveStudent.dtpDate.Value = (DateTime)dataGVStudentList.CurrentRow.Cells[4].Value;

            // xét cột giới tính
            if (dataGVStudentList.CurrentRow.Cells[5].Value.ToString() == "Female")
            {
                updateRemoveStudent.radbFemale.Checked = true;
            }
            else
            {
                updateRemoveStudent.radbMale.Checked = true;
            }

            updateRemoveStudent.txtPhone.Text = dataGVStudentList.CurrentRow.Cells[6].Value.ToString();
            updateRemoveStudent.txtEmail.Text = dataGVStudentList.CurrentRow.Cells[7].Value.ToString();
            updateRemoveStudent.txtAddress.Text = dataGVStudentList.CurrentRow.Cells[8].Value.ToString();
            updateRemoveStudent.cboDepartment.SelectedItem = dataGVStudentList.CurrentRow.Cells[9].Value.ToString();
            updateRemoveStudent.txtMajor.Text = dataGVStudentList.CurrentRow.Cells[10].Value.ToString();


            // up image lên
            byte[] pic;
            pic = (byte[])dataGVStudentList.CurrentRow.Cells[11].Value;
            MemoryStream picture = new MemoryStream(pic);
            updateRemoveStudent.picStudent.Image = Image.FromStream(picture);
            updateRemoveStudent.cboHomeTown.SelectedItem = dataGVStudentList.CurrentRow.Cells[12].Value.ToString();
            
            updateRemoveStudent.Show();
            


        }



        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Lọc lại dữ liệu trong database
            SqlCommand command = new SqlCommand("SELECT * FROM student");
            dataGVStudentList.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGVStudentList.RowTemplate.Height = 20;
            dataGVStudentList.DataSource = student.getStudents(command);

            // columns[10] là tương ứng cột picture trong database
            picCol = (DataGridViewImageColumn)dataGVStudentList.Columns[11];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGVStudentList.AllowUserToAddRows = false;


            // tự động sắp xếp tăng dần/ giảm dần 
            dataGVStudentList.Sort(dataGVStudentList.Columns[1], ListSortDirection.Ascending);


        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            frmFindStudent findStu = new frmFindStudent();
            findStu.Show();
        }

        // show ảnh
        private void btnShowPicture_Click(object sender, EventArgs e)
        {
            try
            {
              
                byte[] pic;
                pic = (byte[])dataGVStudentList.CurrentRow.Cells[11].Value;
                MemoryStream picture = new MemoryStream(pic);
                pictureBoxShow.Image = Image.FromStream(picture);

            }
            catch (Exception err)
            {
                MessageBox.Show("Luân bảo là Empty!");

            }

        }
    }
}
