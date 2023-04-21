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
    public partial class EditHRForm : Form
    {
        public EditHRForm()
        {
            InitializeComponent();
        }

        USER HRuser = new USER();
        MY_DB mydb = new MY_DB();
        private void EditHRForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM [HumanResource] where id=@uid", mydb.getConnection);
            command.Parameters.Add("@uid", SqlDbType.Int).Value =Global.GlobalUserID1;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {

                //table = HRuser.GetHR(Global.GlobalUserID1);
                txt_UserID.Text = table.Rows[0]["id"].ToString();
                txt_Fname.Text = table.Rows[0]["f_name"].ToString();
                txt_Lname.Text = table.Rows[0]["l_name"].ToString();
                txt_UserName.Text = table.Rows[0]["uname"].ToString();
                txt_PassWord.Text = table.Rows[0]["pwd"].ToString();
                txt_ConfirmPassword.Text = table.Rows[0]["pwd"].ToString();

                byte[] pic = (byte[])table.Rows[0]["fig"];
                MemoryStream ms = new MemoryStream(pic);
                pictureBoxHRImage.Image = Image.FromStream(ms);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (verif())
            {
                int userID = Convert.ToInt32(txt_UserID.Text);
                string firstname = txt_Fname.Text;
                string lastname = txt_Lname.Text;
                string username = txt_UserName.Text;
                string password = txt_PassWord.Text;
                string ConfirmPass = txt_ConfirmPassword.Text;
                MemoryStream pic = new MemoryStream();
                if (HRuser.CheckHRUserNameForEdit(username))
                {
                    int id = Int32.Parse(txt_UserID.Text);
                    if (String.Compare(password, ConfirmPass) != 0)
                    {
                        MessageBox.Show("Password Not Match!", "Invalid Password Confirm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        pictureBoxHRImage.Image.Save(pic, pictureBoxHRImage.Image.RawFormat);
                        if (HRuser.updateHumanResource(id, firstname, lastname, username, password, pic))
                        {
                            MessageBox.Show("Human Resource User Edited!", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Error", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("UserName Existed!", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_UploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*gif)|*.jpg;*.pngl*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBoxHRImage.Image = Image.FromFile(opf.FileName);
            }
        }

        bool verif()
        {
            if ((txt_Fname.Text.Trim() == "")
                || (txt_Lname.Text.Trim() == "")
                || (txt_UserID.Text.Trim() == "")
                || (txt_UserName.Text.Trim() == "")
                || (txt_PassWord.Text.Trim() == "")
                || (txt_ConfirmPassword.Text.Trim() == "")
                || (pictureBoxHRImage.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        #region Kiểm tra khi người dùng cố tình chỉnh sửa lại FName, LName có chứa số

        private void txt_Fname_TextChanged(object sender, EventArgs e)
        {
            bool containsDigit = false;
            foreach (char c in txt_Fname.Text)
            {
                if (char.IsDigit(c))
                {
                    containsDigit = true;
                    break;
                }
            }

            if (containsDigit)
            {
                MessageBox.Show("Input cannot contain a number.");
                txt_Fname.Clear();
            }
        }

        private void txt_Lname_TextChanged(object sender, EventArgs e)
        {
            bool containsDigit = false;
            foreach (char c in txt_Lname.Text)
            {
                if (char.IsDigit(c))
                {
                    containsDigit = true;
                    break;
                }
            }

            if (containsDigit)
            {
                MessageBox.Show("Input cannot contain a number.");
                txt_Lname.Clear();
            }
        }

        #endregion
    }
}
