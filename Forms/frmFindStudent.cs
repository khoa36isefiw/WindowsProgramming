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

namespace _20110375_HuynhDangKhoa_LoginForm
{
    public partial class frmFindStudent : Form
    {
        STUDENT student = new STUDENT();

        public frmFindStudent()
        {
            InitializeComponent();
            
        }

       

        private void frmFindStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDataSet.student' table. You can move, or remove it, as needed.
            //this.studentTableAdapter1.Fill(this.studentDataSet.student);
            // TODO: This line of code loads data into the 'qLSVDataSet.student' table. You can move, or remove it, as needed.
            //this.studentTableAdapter.Fill(this.qLSVDataSet.student);
        }

        private void btnFind2_Click(object sender, EventArgs e)
        {
            if(cboFind.SelectedIndex > -1 && txtFind.Text != "")
            {
                if (cboFind.SelectedIndex == 0)
                {
                    #region Bỏ Comment vẫn chạy được, Nhưng chỉ có mỗi ID
                    //load dữ liệu của sinh viên từ database vào datagridView -bằng bảng sinh viên

                    SqlCommand command = new SqlCommand("SELECT * FROM student WHERE MSSV LIKE '%" + txtFind.Text + "%'");
                    DataTable table = student.getStudents(command);
                    //SqlCommand cmd = new SqlCommand("SELECT * FROM student Where CONCAT(ID,FirstName,LastName,Address) LIKE '%" + txtSearch.Text + "%'");
                    try
                    {
                        // find by MSSV


                        if (table.Rows.Count > 0)
                        {
                            dataGRV_StudentFound.ReadOnly = true;

                            dataGRV_StudentFound.RowTemplate.Height = 20;
                            dataGRV_StudentFound.DataSource = student.getStudents(command);
                            DataGridViewImageColumn picCol = new DataGridViewImageColumn();

                            // columns[10] là tương ứng cột picture trong database
                            picCol = (DataGridViewImageColumn)dataGRV_StudentFound.Columns[11];
                            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                            dataGRV_StudentFound.AllowUserToAddRows = false;
                        }
                        else
                        {
                            dataGRV_StudentFound.ReadOnly = true;

                            dataGRV_StudentFound.RowTemplate.Height = 20;
                            dataGRV_StudentFound.DataSource = student.getStudents(command);
                            DataGridViewImageColumn picCol = new DataGridViewImageColumn();

                            // columns[10] là tương ứng cột picture trong database
                            picCol = (DataGridViewImageColumn)dataGRV_StudentFound.Columns[11];
                            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                            dataGRV_StudentFound.AllowUserToAddRows = false;
                            MessageBox.Show("Không tìm thấy sinh viên này!", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Bạn chưa điền MSSV nên không tìm được sinh viên", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    #endregion



                }
                else if (cboFind.SelectedIndex == 1)        // lấy ra những sinh viên có first Name tương tự nhau
                {
                    #region Nào cùng được - C1
                    //SqlCommand command = new SqlCommand("SELECT * FROM student WHERE (FirstName) LIKE '%" + txtFind.Text + "%'");
                    //DataTable table = student.getStudents(command);
                    ////SqlCommand cmd = new SqlCommand("SELECT * FROM student Where CONCAT(ID,FirstName,LastName,Address) LIKE '%" + txtSearch.Text + "%'");
                    //try
                    //{
                    //    // find by ID


                    //    if (table.Rows.Count > 0)
                    //    {
                    //        dataGRV_StudentFound.ReadOnly = true;

                    //        dataGRV_StudentFound.RowTemplate.Height = 40;
                    //        dataGRV_StudentFound.DataSource = student.getStudents(command);
                    //        DataGridViewImageColumn picCol = new DataGridViewImageColumn();

                    //        // columns[10] là tương ứng cột picture trong database
                    //        picCol = (DataGridViewImageColumn)dataGRV_StudentFound.Columns[10];
                    //        picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    //        dataGRV_StudentFound.AllowUserToAddRows = false;
                    //    }
                    //    else
                    //    {
                    //        dataGRV_StudentFound.ReadOnly = true;

                    //        dataGRV_StudentFound.RowTemplate.Height = 40;
                    //        dataGRV_StudentFound.DataSource = student.getStudents(command);
                    //        DataGridViewImageColumn picCol = new DataGridViewImageColumn();

                    //        // columns[10] là tương ứng cột picture trong database
                    //        picCol = (DataGridViewImageColumn)dataGRV_StudentFound.Columns[10];
                    //        picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    //        dataGRV_StudentFound.AllowUserToAddRows = false;
                    //        MessageBox.Show("Không tìm thấy sinh viên này!", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //    }
                    //}
                    //catch (Exception err)
                    //{
                    //    MessageBox.Show("Bạn chưa điền First name nên không tìm được sinh viên", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //}
                    #endregion

                    string findFirstName = txtFind.Text;
                    #region Cách 2
                    SqlCommand cmd = new SqlCommand("SELECT * FROM student Where FirstName LIKE '%" + findFirstName + "%'");
                    fillGrid(cmd);
                    #endregion

                }

                else if (cboFind.SelectedIndex == 2) // get by lastName
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM student Where LastName LIKE '%" + txtFind.Text + "%'");
                    fillGrid(cmd);
                }
                else if (cboFind.SelectedIndex == 3) // get by address
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM student Where Address LIKE '%" + txtFind.Text + "%'");
                    fillGrid(cmd);
                }
                else if (cboFind.SelectedIndex == 4) // get by MSSV
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM student Where MSSV LIKE '%" + txtFind.Text + "%'");
                    fillGrid(cmd);
                }
                else  // get by Major
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM student Where Major LIKE '%" + txtFind.Text + "%'");
                    fillGrid(cmd);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn giá trị tìm kiếm!", "Find",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            


            // cần thêm tính năng xem ảnh cảu thành viên trong danh sách. Button để hiển thị ảnh của thành viên đó



        }


        #region Load data to datagridView
        // create a function to populate the datagridView
        public void fillGrid(SqlCommand cmd)
        {

            // load dữ liệu của sinh viên từ database vào  datagridView - bằng bảng sinh viên
            dataGRV_StudentFound.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGRV_StudentFound.RowTemplate.Height = 20;
            dataGRV_StudentFound.DataSource = student.getStudents(cmd);

            // columns[11] là tương ứng cột picture trong database
            picCol = (DataGridViewImageColumn)dataGRV_StudentFound.Columns[11];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGRV_StudentFound.AllowUserToAddRows = false;

            
        }
        #endregion

        
        //set default text for combobox
        private void cboFind_TextChanged(object sender, EventArgs e)
        {
            if (cboFind.SelectedIndex < 0)
            {
                cboFind.Text = "Please, Select any value...";
            }
            else
            {
                cboFind.Text = cboFind.SelectedText;
            }
        }


        // Click on the cell containing the image and
            // then click the Show Image button to display the image
        private void btnShowImage_Click(object sender, EventArgs e)
        {
            int outNek;
            try  
            {
                //foreach (DataGridViewRow rw in this.dataGRV_StudentFound.Rows)
                //{
                //    for (int i = 0; i < rw.Cells.Count; i++)
                //    {
                //        //if (rw.Cells[i].Value == null || rw.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(rw.Cells[i].Value.ToString()))
                //        //{
                //        //    MessageBox.Show("Luân bảo là Empty! Sao mà click được!");
                //        //    outNek = rw.Cells.Count;
                //        //    break;
                //        //}
                //        //else
                //        {

                //        }
                //    }
                //}
                byte[] pic;
                pic = (byte[])dataGRV_StudentFound.CurrentRow.Cells[11].Value;
                MemoryStream picture = new MemoryStream(pic);
                pictureBox1.Image = Image.FromStream(picture);

            }
            catch(Exception err)
            {
                MessageBox.Show("Luân bảo là Empty!");

            }

        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
