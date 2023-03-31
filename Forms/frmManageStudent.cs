using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.IO;
using System.Text.RegularExpressions;

namespace _20110375_HuynhDangKhoa_LoginForm
{
    public partial class frmManageStudent : Form
    {
        STUDENT student = new STUDENT();
        public frmManageStudent()
        {
            InitializeComponent();
        }

        private void frmManageStudent_Load(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("Select * from student"));
        }


        // create a function to populate the datagridView
        public void fillGrid(SqlCommand cmd) 
        {

            // load dữ liệu của sinh viên từ database vào  datagridView - bằng bảng sinh viên
            dataGVManageStudent.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGVManageStudent.RowTemplate.Height = 20;
            dataGVManageStudent.DataSource = student.getStudents(cmd);

            // columns[10] là tương ứng cột picture trong database
            picCol = (DataGridViewImageColumn)dataGVManageStudent.Columns[11];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGVManageStudent.AllowUserToAddRows = false;

            // count student in dataGridView
            lblTotalStudent.Text = "Total Student: " + dataGVManageStudent.Rows.Count;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM student Where CONCAT(ID,FirstName,LastName,Address) LIKE '%" + txtSearch.Text + "%'");
            fillGrid(cmd);
        }

        // save Picture with File
        private void btnDownload_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.FileName = "student_" + txtStudentID.Text;
            if(picStudent.Image == null)
            {
                MessageBox.Show("No Image In the PictureBox");
            }
            else if(svf.ShowDialog() == DialogResult.OK)
            {
                picStudent.Image.Save((svf.FileName + "." + ImageFormat.Jpeg.ToString()));
            }
        }

    

        // Hiển thị thông tin sinh viên lên các textbox khi Click vào 1 row trong data GridView
        private void dataGVManageStudent_Click(object sender, EventArgs e)
        {
            //txtStudentID.ReadOnly = true;
            txtStudentID.Text = dataGVManageStudent.CurrentRow.Cells[1].Value.ToString();
            txtFirstName.Text = dataGVManageStudent.CurrentRow.Cells[2].Value.ToString();
            txtLastName.Text = dataGVManageStudent.CurrentRow.Cells[3].Value.ToString();
            dtpDate.Value = (DateTime)dataGVManageStudent.CurrentRow.Cells[4].Value;

            // xét cột giới tính
            if (dataGVManageStudent.CurrentRow.Cells[5].Value.ToString() == "Female")
            {
                radbFemale.Checked = true;


            }

            txtPhone.Text = dataGVManageStudent.CurrentRow.Cells[6].Value.ToString();
            txtEmail.Text = dataGVManageStudent.CurrentRow.Cells[7].Value.ToString();
            txtAddress.Text = dataGVManageStudent.CurrentRow.Cells[8].Value.ToString();
            cboDepartment.SelectedItem = dataGVManageStudent.CurrentRow.Cells[9].Value.ToString();
            txtMajor.Text = dataGVManageStudent.CurrentRow.Cells[10].Value.ToString();


            // up image lên
            byte[] pic;
            pic = (byte[])dataGVManageStudent.CurrentRow.Cells[11].Value;
            MemoryStream picture = new MemoryStream(pic);
            picStudent.Image = Image.FromStream(picture);
            txtHomeTown.Text = dataGVManageStudent.CurrentRow.Cells[12].Value.ToString();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            STUDENT student = new STUDENT();
            #region Vùng check 
            try
            {
                string id = (txtStudentID.Text);
                string fName = txtFirstName.Text;
                string lName = txtLastName.Text;
                DateTime bdate = dtpDate.Value;
                string gender = "Male";
                int phoneNumber = Convert.ToInt32(txtPhone.Text);
                string email = txtEmail.Text;
                string addrress = txtAddress.Text;
                string departMent = cboDepartment.SelectedItem.ToString();
                string major = txtMajor.Text;
                string homeT = txtHomeTown.Text;
                MemoryStream pic = new MemoryStream();

                int born_year = dtpDate.Value.Year;
                int this_year = DateTime.Now.Year;

                if (radbFemale.Checked)
                {
                    gender = "Female";
                }


                if ((this_year - born_year) < 17 || ((this_year - born_year) > 100))
                {
                    MessageBox.Show("Sinh viên phải từ 18 tuổi trở lên", "Ngày sinh không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (verif())
                {
                    picStudent.Image.Save(pic, picStudent.Image.RawFormat);

                    // kiểm tra student id có tồn tại hay không
                    SqlCommand command = new SqlCommand("SELECT * FROM student WHERE MSSV =@id ");
                    command.Parameters.Add("@id",SqlDbType.NChar).Value= id;
                    
                    DataTable table = student.getStudents(command);

                    if (table.Rows.Count > 0)   // sinh viên tồn tại
                    {
                        MessageBox.Show("MSSV đã tồn tại!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                    else if (!checkPhoneNumber() && txtPhone.Text.Length > 10)
                    {
                        MessageBox.Show("Số điện thoại phải nhập đủ 10 số !!!!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }



                    // xử lý nếu tên của sinh viên có chứa số (0 --> 9)
                    else if (txtFirstName.Text.Any(char.IsDigit) || txtLastName.Text.Any(char.IsDigit))
                    {
                        MessageBox.Show("FirstName và LastName của sinh viên không chứa số!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }

                    else if (!checkEmail(txtEmail.Text))    // kiểm tra người dùng có nhập đúng cú pháp gmail hay không?
                    {
                        MessageBox.Show("Luân đấm mày đó nha - Hãy điền đúng format của GMAIL!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // student id chưa tồn tại 
                    else
                    {
                        if (student.insertStudent(id, fName, lName, bdate, gender, phoneNumber, email, addrress, departMent, major, pic, homeT))
                        {
                            MessageBox.Show("Thêm sinh viên thành công", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else // khoong hien thong bao?
                        {
                            MessageBox.Show("Lỗi", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        } 


                    }

                }

                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ các thông tin của sinh viên1", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }




            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các thông tin của sinh viên2", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            #endregion
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string id   = (dataGVManageStudent.CurrentRow.Cells[0].Value.ToString());

            try
            {

                SqlCommand command = new SqlCommand("SELECT ID, MSSV, FirstName, LastName, BirthDate, Gender" +
                       ", PhoneNumber, Email, Address, Department, Major, Picture, HomeTown FROM student WHERE ID = @id");

                command.Parameters.Add("@id", SqlDbType.NChar).Value = id;

                DataTable table = student.getStudents(command);

                if (table.Rows.Count > 0)
                {
                    string stuID = txtStudentID.Text;
                    string fName = txtFirstName.Text;
                    string lName = txtLastName.Text;
                    DateTime bdate = dtpDate.Value;
                    string gender = "Male";
                    int phoneNumber = Convert.ToInt32(txtPhone.Text);
                    string email = txtEmail.Text;
                    string addrress = txtAddress.Text;
                    string departMent = cboDepartment.SelectedItem.ToString();
                    string major = txtMajor.Text;
                    MemoryStream pic = new MemoryStream();
                    if (radbFemale.Checked)
                    {
                        gender = "Female";
                    }

                    string home = txtHomeTown.Text;
                    int born_year = dtpDate.Value.Year;
                    int this_year = DateTime.Now.Year;



                    if ((this_year - born_year) < 17 || ((this_year - born_year) > 100))
                    {

                        MessageBox.Show("Tuổi của sinh viên phải từ 18 đến 100 tuổi", "Ngày sinh không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (verif())
                    {
                        // chỉnh sửa thông tin sinh viên
                        picStudent.Image.Save(pic, picStudent.Image.RawFormat);
                        if (student.updateStudent(id, fName, lName, bdate, gender, phoneNumber, email, addrress, departMent, major, pic, home))
                        {

                            MessageBox.Show("Chỉnh sửa thông tin sinh viên thành công", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            fillGrid(new SqlCommand("Select * from student"));
                        }
                        else
                        {
                            MessageBox.Show("Lỗi", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    else
                    {
                        MessageBox.Show("Điền đầy đủ thông tin đi, Không là Luân đấm bạn đó!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
            catch (Exception er)
            {
                MessageBox.Show("Điền đầy đủ thông tin đi 2, Không là Luân đấm bạn đó2!",
                    "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                string id = Convert.ToString(txtStudentID.Text);
                // cho người dùng chọn: đồng ý xóa hoặc không
                // nếu đồng ý - xóa đi một sinh viên đã chọn theo id
                // nếu không thì quay trở lại form bình thường không xóa
                DialogResult confirmDelete = MessageBox.Show("Bạn có thực sự muốn xóa đi sinh viên này không?",
                    "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmDelete == DialogResult.Yes)
                {
                    student.deleteStudent(id);
                    MessageBox.Show("Sinh viên đã được xóa: " + id,
                        "Confirm - Delete Student",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // clear data
                    txtStudentID.Text = "";
                    txtFirstName.Text = "";
                    txtLastName.Text = "";
                    dtpDate.Value = DateTime.Now;
                    txtStudentID.Text = "";
                    txtPhone.Text = "";
                    txtEmail.Text = "";
                    txtAddress.Text = "";
                    cboDepartment.SelectedItem = null;
                    cboDepartment.SelectedText = "--select--";
                    txtMajor.Text = "";
                    picStudent.Image = null;
                    txtHomeTown.Text = "";

                }
                else
                {
                    MessageBox.Show("Bạn không xóa sinh viên!",
                       "Confirm - Delete Student",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                }
            }
            catch (Exception err)
            {

                MessageBox.Show("Bạn tìm kiếm được sinh viên muốn xóa",
                   "Confirm - Delete Student",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtStudentID.ReadOnly = false;
            txtStudentID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            dtpDate.Value = DateTime.Now;
            txtStudentID.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";

            cboDepartment.SelectedItem = null;
            txtMajor.Text = "";
            picStudent.Image = null;
            txtHomeTown.Text = "";
        }





        bool verif()
        {
            if ((txtFirstName.Text.Trim() == "") || (txtLastName.Text.Trim() == "")

                || txtPhone.Text.Trim() == ""
                || txtEmail.Text.Trim() == ""
                || txtAddress.Text.Trim() == ""
                || txtMajor.Text.Trim() == ""
                || picStudent.Image == null)
            {
                MessageBox.Show("Nhập cho nhập đủ thông tin mới được add");
                return false;
            }
            else
            {
                return true;
            }

        }


        // hàm kiểm tra độ dài của số điện thoại có nhập đủ 10 số không?
        public bool checkPhoneNumber()
        {
            // return Regex.Match(number, @"^(\+[0-9]{9})$").Success;
            Regex isValidInput = new Regex(@"^\d{10}$");
            string strPhone = txtPhone.Text;
            if (!isValidInput.IsMatch(strPhone))
                return false;
            return true;
        }


        // hàm kiểm tra trong chuỗi có chứa số không? - Ví dự như là họ tên của người dùng
        bool IsDigitsOnly(string str)
        {
            if (str.Any(char.IsDigit))
            {
                return true;
            }
            return false;
        }


        // hàm kiểm tra nhập gmail
        bool checkEmail(string email)
        {

            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
                if (!reg.IsMatch(txtEmail.Text))
                {
                    return false;
                }
            }
            return true;
        }



        // người dùng không thể rewrite something in combobox
        private void cboDepartment_KeyDown_1(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;

        }

        private void btnUpImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image (*.jpg; *.png; *.gif) | *.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                picStudent.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
