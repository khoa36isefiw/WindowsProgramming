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
    public partial class frmEditContact : Form
    {

        int FirstContactID;
        Contact.Contact contact = new Contact.Contact();
        Group group = new Group();

        public frmEditContact()
        {
            InitializeComponent();
        }

        private void frmEditContact_Load(object sender, EventArgs e)
        {
            //cbo_Group.DataSource = contact.GetContactByID(Global.GlobalUserID1);
            //cbo_Group.DisplayMember = "Name";
            //cbo_Group.ValueMember = "id";
        }

        private void btn_SelectContact_Click(object sender, EventArgs e)
        {
            int num = -1; // checking input is interger or not
            if (txt_ID.Text.Trim() == "")
            {
                MessageBox.Show("Please Add An ID", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!Int32.TryParse(txt_ID.Text, out num))
            {
                MessageBox.Show("Please Add An InterGer", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int ContactID = Convert.ToInt32(txt_ID.Text);
                FirstContactID = Convert.ToInt32(txt_ID.Text);
                if (!contact.CheckContactID(ContactID, Global.GlobalUserID1))
                {
                    DataTable table = new DataTable();
                    table = contact.GetContactByID(ContactID);
                    txt_FName.Text = table.Rows[0]["fname"].ToString();
                    txt_LName.Text = table.Rows[0]["lname"].ToString();
                    //cbb_Group.SelectedValue = dataGridView1.CurrentRow.Cells[3].Value;
                    cbo_Group.DataSource = group.GetUserGroups(Global.GlobalUserID1);
                    cbo_Group.DisplayMember = "name";
                    cbo_Group.ValueMember = "id";
                    cbo_Group.SelectedValue = table.Rows[0]["group_id"];

                    txt_Phone.Text = table.Rows[0]["phone"].ToString();
                    txt_Email.Text = table.Rows[0]["email"].ToString();
                    txt_Address.Text = table.Rows[0]["address"].ToString();

                    byte[] pic = (byte[])table.Rows[0]["pic"];
                    MemoryStream ms = new MemoryStream(pic);
                    pictureBox_Image.Image = Image.FromStream(ms);

                }
                else
                {
                    MessageBox.Show("Contact's ID Of This User Can Not Be Found!", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_ID.Text = "";
                    txt_FName.Text = "";
                    txt_LName.Text = "";
                    txt_Address.Text = "";
                    txt_Phone.Text = "";
                    txt_Email.Text = "";
                    cbo_Group.SelectedItem = null;      // clear combobox
                    pictureBox_Image.Image = null;
                }
            }
        }

      

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

        private void btn_EditContact_Click(object sender, EventArgs e)
        {
            try
            {
                if (verif())
                {
                    int ContactID = Convert.ToInt32(txt_ID.Text);
                    string fname = txt_FName.Text;
                    string lname = txt_LName.Text;
                    string phone = txt_Phone.Text;
                    string email = txt_Email.Text;
                    string address = txt_Address.Text;
                    int GroupID = (int)cbo_Group.SelectedValue;
                    MemoryStream pic = new MemoryStream();
                    pictureBox_Image.Image.Save(pic, pictureBox_Image.Image.RawFormat);
                    //giữ nguyên ID
                    if (FirstContactID == ContactID)
                    {
                        if (contact.updateContact(ContactID, fname, lname, phone, address, email, GroupID, pic, FirstContactID))
                        {
                            MessageBox.Show("Contact Edited", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clearField();
                        }
                        else
                        {
                            MessageBox.Show("Can not Update Contact ", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    //Thay đổi ID => kiểm tra xem có trùng ID đối với các user khác không
                    else
                    {
                        if (contact.CheckContactIDForAllUser(ContactID))
                        {
                            if (contact.updateContact(ContactID, fname, lname, phone, address, email, GroupID, pic, FirstContactID))
                            {
                                MessageBox.Show("Contact Edited", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clearField();
                            }
                            else
                            {
                                MessageBox.Show("Can not Update Contact!", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        else
                        {
                            MessageBox.Show("ID Already Existed!", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Empty Fields", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("Error: " + er);
            }
        }

        #region Vùng chek Data Input
        public bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            return regex.IsMatch(email);
        }

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
                errorProviderContact.SetError(txt_Email, "Địa chỉ email không đúng định dạng.");
            }
            else
            {
                errorProviderContact.SetError(txt_Email, "");
            }
        }


        bool verif()
        {
            if ((txt_FName.Text.Trim() == "")
                || (txt_LName.Text.Trim() == "")
                || (txt_Address.Text.Trim() == "")
                || (txt_Phone.Text.Trim() == "")
                || (txt_Email.Text.Trim() == "")
                || (txt_ID.Text.Trim() == "")
                || (pictureBox_Image.Image == null)
                || (cbo_Group.DataSource == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        void clearField()
        {
            txt_ID.Text = "";
            txt_FName.Text = "";
            txt_LName.Text = "";
            txt_Address.Text = "";
            txt_Phone.Text = "";
            txt_Email.Text = "";
            cbo_Group.SelectedItem = null;      // clear combobox
            pictureBox_Image.Image = null;
        }



        #endregion

    }
}
