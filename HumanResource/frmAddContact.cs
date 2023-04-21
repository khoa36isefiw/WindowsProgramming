using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20110375_HuynhDangKhoa_LoginForm.HumanResource
{
    public partial class frmAddContact : Form
    {
        public frmAddContact()
        {
            InitializeComponent();
        }

        private void frmAddContact_Load(object sender, EventArgs e)
        {
            cbo_Group.DataSource = group.GetUserGroups(Global.GlobalUserID1);
            cbo_Group.DisplayMember = "Name";
            cbo_Group.ValueMember = "id";
        }


        Contact.Contact contact = new Contact.Contact();
        Group group = new Group();
        bool verif()
        {

            if ((txt_FName.Text.Trim() == "")
                || (txt_LName.Text.Trim() == "")
                || (txt_Address.Text.Trim() == "")
                || (txt_Phone.Text.Trim() == "")
                || (txt_Email.Text.Trim() == "")
                
                || (txt_ID.Text.Trim() == "")
                || (pictureBox_Image.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btn_AddContact_Click(object sender, EventArgs e)
        {
            if (verif())
            {
                //biến này dùng để kiểm tra ID nhập vào là Interger
                int num = -1;
                if (txt_ID.Text.Trim() == "")
                {
                    MessageBox.Show("Please Add An ID", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!Int32.TryParse(txt_ID.Text, out num))
                {
                    MessageBox.Show("Please Add An Interger For ID", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int ContactID = Convert.ToInt32(txt_ID.Text);
                    string fname = txt_FName.Text;
                    string lname = txt_LName.Text;
                    string phone = txt_Phone.Text;
                    string email = txt_Email.Text;
                    string address = txt_Address.Text;
                    int GroupID = (int)cbo_Group.SelectedValue;
                    MemoryStream pic = new MemoryStream();
                    int userid = Global.GlobalUserID1;
                    pictureBox_Image.Image.Save(pic, pictureBox_Image.Image.RawFormat);

                    //Kiểm Tra ID của User Này
                    if (contact.CheckContactID(ContactID, Global.GlobalUserID1))
                    {
                        //Nếu User Này ko trùng ID => Kiểm sang các user khác
                        if (contact.CheckContactIDForAllUser(ContactID))
                        {
                            if (contact.insertContact(ContactID, fname, lname, phone, address, email, GroupID, pic))
                            {
                                MessageBox.Show("New Contact Added", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                //Sau khi Add Contact vào thì làm sạch form
                                //CleanForm();

                                txt_ID.Text = "";
                                txt_FName.Text = "";
                                txt_LName.Text = "";
                                txt_Address.Text = "";
                                txt_Phone.Text = "";
                                txt_Email.Text = "";
                                cbo_Group.SelectedItem = null;      // clear combobox
                                pictureBox_Image.Image = null;
                            }
                            else
                            {
                                MessageBox.Show("Error", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("ID Already Existed!", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Contact's Of This User Already Existed!", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                MessageBox.Show("Empty Fields", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        // upload anh len
        private void btn_Upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*gif)|*.jpg;*.pngl*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBox_Image.Image = Image.FromFile(opf.FileName);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region bắt lỗi nhập vào fName, lName nếu có chứa số (0 --> 9)
        private void txt_FName_TextChanged(object sender, EventArgs e)
        {
            bool containsDigit = false;
            foreach (char c in txt_FName.Text)
            {
                if (char.IsDigit(c))
                {
                    containsDigit = true;
                    break;
                }
            }

            if (containsDigit)
            {
                MessageBox.Show("Tên không thể chứa số!", "Add Contact",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_FName.Clear();
            }
        }

        private void txt_LName_TextChanged(object sender, EventArgs e)
        {
            bool containsDigit = false;
            foreach (char c in txt_LName.Text)
            {
                if (char.IsDigit(c))
                {
                    containsDigit = true;
                    break;
                }
            }

            if (containsDigit)
            {
                MessageBox.Show("Tên không thể chứa số!", "Add Contact",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_LName.Clear();
            }
        }
        #endregion

        #region Bắt lỗi khi nhập vào chứ chữ cái 'a' --> 'z'

        private void txt_Phone_TextChanged(object sender, EventArgs e)
        {
            foreach (char c in txt_Phone.Text)
            {
                if (char.IsLetter(c) && (c < 'a' || c > 'z'))
                {
                    MessageBox.Show("Input cannot contain letters.","Add Contact",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_Phone.Clear();
                    break;
                }
            }
        }

        private void txt_ID_TextChanged(object sender, EventArgs e)
        {
            foreach (char c in txt_Phone.Text)
            {
                if (char.IsLetter(c) && (c < 'a' || c > 'z'))
                {
                    MessageBox.Show("Input cannot contain letters. Only Digits", "Add Contact",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_Phone.Clear();
                    break;
                }
            }
        }



        #region Check Email Input
        // check định dạng của email
        public bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            return regex.IsMatch(email);
        }


        /*
         sự kiện được kích hoạt khi người dùng rời khỏi TextBox email sau khi nhập xong
        */

        private void txt_Email_Leave(object sender, EventArgs e)
        {

            string userEmail = txt_Email.Text;
            if (!IsValidEmail(userEmail))
            {
                MessageBox.Show("Địa chỉ email không đúng định dạng, vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Email.Focus();
            }
        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {
            string userEmail = txt_Email.Text;
            if (!IsValidEmail(userEmail))
            {
                errorProvider.SetError(txt_Email, "Địa chỉ email không đúng định dạng.");
            }
            else
            {
                errorProvider.SetError(txt_Email, "");
            }
        }

        #endregion


        #endregion


    }
}
