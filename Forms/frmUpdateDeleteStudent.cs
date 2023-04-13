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
    
    public partial class frmUpdateDeleteStudent : Form
    {

        STUDENT student = new STUDENT();
        MY_DB mydb = new MY_DB();

        public frmUpdateDeleteStudent()
        {
            InitializeComponent();
        }

        private void frmUpdateDeleteStudent_Load(object sender, EventArgs e)
        {

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

        // find id - fname, phonenumber, major
        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                 string id = (txtStudentID.Text);  // find by MSSV
                
                SqlCommand command = new SqlCommand("SELECT MSSV, FirstName, LastName, BirthDate, Gender" +
                    ", PhoneNumber, Email, Address, Department, Major, Picture, HomeTown FROM student WHERE MSSV =@id ");

                command.Parameters.Add("@id", SqlDbType.NChar).Value = id;


                DataTable table = student.getStudents(command);

                if (table.Rows.Count > 0)
                {
                    txtFirstName.Text = table.Rows[0]["FirstName"].ToString();
                    txtLastName.Text = table.Rows[0]["LastName"].ToString();
                    
                    dtpDate.Value = (DateTime)table.Rows[0]["BirthDate"];

                    //dtpDate.Text = table.Rows[0]["BirthDate"].ToString();

                    //gender
                    if (table.Rows[0]["Gender"].ToString() == "Female")
                    {
                        radbFemale.Checked = true;
                    }
                    else
                    {
                        radbMale.Checked = true;
                    }
                    txtPhone.Text = table.Rows[0]["PhoneNumber"].ToString();
                    txtEmail.Text = table.Rows[0]["Email"].ToString();
                    txtAddress.Text = table.Rows[0]["Address"].ToString();
                    txtMajor.Text = table.Rows[0]["Major"].ToString();
                    cboDepartment.Text = table.Rows[0]["Department"].ToString();
                    
                    // picture
                    byte[] pic = (byte[])table.Rows[0]["Picture"];
                    MemoryStream picture = new MemoryStream(pic);
                    picStudent.Image = Image.FromStream(picture);
                    cboHomeTown.Text = table.Rows[0]["HomeTown"].ToString();
//                    txtHome.Text = table.Rows[0]["HomeTown"].ToString();

                }
                else
                {
                    MessageBox.Show("Not Found", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Bạn chưa điền ID nên không tìm được sinh viên", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
          
        }



        bool verif()
        {
            if ( (txtFirstName.Text.Trim() == "") || (txtLastName.Text.Trim() == "")
             
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


        private void btnEdit_Click(object sender, EventArgs e)
        {
            string id = (txtStudentID.Text);

            try
            {

                SqlCommand command = new SqlCommand("SELECT MSSV, FirstName, LastName, BirthDate, Gender" +
                       ", PhoneNumber, Email, Address, Department, Major, Picture FROM student WHERE MSSV =@id " );
                command.Parameters.Add("@id", SqlDbType.NChar).Value = id;
                DataTable table = student.getStudents(command);

                if (table.Rows.Count > 0)
                {
                    
                    string fName = txtFirstName.Text;
                    string lName = txtLastName.Text;
                    DateTime bdate = dtpDate.Value;
                    string gender = "Male";
                    int phoneNumber = Convert.ToInt32(txtPhone.Text);
                    string email = txtEmail.Text;
                    string addrress = txtAddress.Text;
                    string departMent = cboDepartment.SelectedItem.ToString();
                    string major = txtMajor.Text;

                    string ghome = cboHomeTown.SelectedItem.ToString();
                    
                    MemoryStream pic = new MemoryStream();
                    if (radbFemale.Checked)
                    {
                        gender = "Female";
                    }

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
                        if (student.updateStudent(id, fName, lName, bdate, gender, phoneNumber, email, addrress, departMent, major, pic, ghome))
                        {

                            MessageBox.Show("Chỉnh sửa thông tin sinh viên thành công", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        // xóa đi một sinh viên - xóa theo ID của sinh viên
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                string id = (txtStudentID.Text);
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
                    
                    cboHomeTown.SelectedItem = null;
                    cboHomeTown.SelectedText = "--select--";

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

        private void cboDepartment_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboHomeTown_TextChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem chuỗi văn bản trong ComboBox có chứa số hay không
            if (cboHomeTown.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Không được nhập số trong ComboBox!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboHomeTown.SelectedItem = null;
            }
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            Forms.AddCourseForm addCF = new Forms.AddCourseForm();
            addCF.Show();
        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {
            //// gợi ý MSSV của student cho người dùng khi nhập vào text box này 
            //SqlDataReader dr;
            //SqlCommand cmd = new SqlCommand("SELECT MSSV FROM student Where MSSV LIKE '%" + txtStudentID.Text + "%'", mydb.getConnection);
            //mydb.openConnection();
            //cmd.ExecuteNonQuery();


            //dr = cmd.ExecuteReader();
            //AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            //while (dr.Read())
            //{
            //    col.Add(dr.GetString(0));
            //}
            //txtStudentID.AutoCompleteCustomSource = col;
            //dr.Close();
            //mydb.closeConnection();



        }
    }
}
