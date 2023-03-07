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
    public partial class frmFindStudent : Form
    {
        STUDENT student = new STUDENT();
        public frmFindStudent()
        {
            InitializeComponent();
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {

            // load dữ liệu của sinh viên từ database vào  datagridView - bằng bảng sinh viên
             SqlCommand command = new SqlCommand("SELECT * FROM student WHERE ID = " + txtStudentID.Text);
             DataTable table = student.getStudents(command);
            try
            {
                // find by ID


                if (table.Rows.Count > 0)
                {
                    dataGRV_StudentFound.ReadOnly = true;

                    dataGRV_StudentFound.RowTemplate.Height = 40;
                    dataGRV_StudentFound.DataSource = student.getStudents(command);
                    DataGridViewImageColumn picCol = new DataGridViewImageColumn();

                    // columns[10] là tương ứng cột picture trong database
                    picCol = (DataGridViewImageColumn)dataGRV_StudentFound.Columns[10];
                    picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    dataGRV_StudentFound.AllowUserToAddRows = false;
                }
                else
                {
                    dataGRV_StudentFound.ReadOnly = true;

                    dataGRV_StudentFound.RowTemplate.Height = 40;
                    dataGRV_StudentFound.DataSource = student.getStudents(command);
                    DataGridViewImageColumn picCol = new DataGridViewImageColumn();

                    // columns[10] là tương ứng cột picture trong database
                    picCol = (DataGridViewImageColumn)dataGRV_StudentFound.Columns[10];
                    picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    dataGRV_StudentFound.AllowUserToAddRows = false;
                    MessageBox.Show("Không tìm thấy sinh viên này!", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Bạn chưa điền ID nên không tìm được sinh viên", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
    
}
