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

namespace _20110375_HuynhDangKhoa_LoginForm.Forms
{
    public partial class frmMainHR : Form
    {
        USER HRuser = new USER();
        Contact.Contact contact = new Contact.Contact();
        Group group = new Group();
        MY_DB mydb = new MY_DB();
        public frmMainHR()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            HumanResource.frmAddContact addContact = new HumanResource.frmAddContact();
            addContact.ShowDialog();
        }

        private void btnEditContact_Click(object sender, EventArgs e)
        {
            HumanResource.frmEditContact editContact = new HumanResource.frmEditContact();
            editContact.ShowDialog();
        }

        private void frmMainHR_Load(object sender, EventArgs e)
        {



          
            /*
            
            
              byte[] pic;
            pic = (byte[])dataGVStudentList.CurrentRow.Cells[11].Value;
            MemoryStream picture = new MemoryStream(pic);
            updateRemoveStudent.picStudent.Image = Image.FromStream(picture);

             */




            #region Load Form Hình ảnh và các dòng chữ welcome

            SqlCommand command = new SqlCommand("SELECT* FROM [HumanResource] where id=@uid", mydb.getConnection);
            command.Parameters.Add("@uid", SqlDbType.Int).Value = Global.GlobalUserID1;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                table = HRuser.GetHR(Global.GlobalUserID1);
                byte[] pic = (byte[])table.Rows[0]["fig"];
                MemoryStream ms = new MemoryStream(pic);
                pictureBox_User.Image = Image.FromStream(ms);

                // welcome 'human resource has uname'
                lblWelcome.Text = ("Welcome: " + table.Rows[0]["uname"].ToString() + "");
                //lblUser.Text = (table.Rows[0]["f_name"].ToString() + " " + table.Rows[0]["l_name"].ToString());
                lblUser.Text = "";
            }
            //Image x = (Bitmap)((new ImageConverter()).ConvertFrom(pic));
            //pictureBox.Image = x;
            #endregion

            #region Load Lại Combobox cho Group
            cboEditSelectGroup.DataSource = group.GetUserGroups(Global.GlobalUserID1);
            cboEditSelectGroup.DisplayMember = "Name";
            cboEditSelectGroup.ValueMember = "id";
            
            cboRemoveGroup.DataSource = group.GetUserGroups(Global.GlobalUserID1);
            cboRemoveGroup.DisplayMember = "Name";
            cboRemoveGroup.ValueMember = "id";
            #endregion


            // chưa duoc--> tao ra details cho selected course, khi nguoi dung double click vao chu nay thi no hien ra listview hoac listbox
            STUDENT stu = new STUDENT();
            frmLogin login = new frmLogin();
            int isAdmin = 0;
            SqlCommand cmd = new SqlCommand("SELECT isAdmin FROM HumanResource WHERE uname=@userName");
            cmd.Parameters.Add("@userName", SqlDbType.NChar).Value = login.txtUserName.Text;
            DataTable table1 = stu.getStudents(cmd);


            if (table1.Rows.Count > 0)
            {
                isAdmin = Convert.ToInt32(table1.Rows[0][0]);

                if (isAdmin == 1)
                {
                    lblManageAccount.Enabled = true;
                }
                else
                {
                    lblManageAccount.Enabled = false;
                }

            }


        }

        private void lblEditMyInfor_Click(object sender, EventArgs e)
        {
            EditHRForm EHRF = new EditHRForm();
            EHRF.Show(this);
         //   frmMainHR(null, null);
        }

       
        private void lbl_Logout_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }


        private void btn_ContactID_Select_Click(object sender, EventArgs e)
        {
            Contact.frmContactGroups contactGS = new Contact.frmContactGroups();
            contactGS.Show(this);
        }

        private void btn_ContactID_Remove_Click(object sender, EventArgs e)
        {
            int num = -1; // checking input is interger or not
            if (txt_ContactID.Text.Trim() == "")
            {
                MessageBox.Show("Please Add An ID", "Select Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!Int32.TryParse(txt_ContactID.Text, out num))
            {
                MessageBox.Show("Please Add An InterGer", "Select Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int ContactID = Convert.ToInt32(txt_ContactID.Text);
                if (!contact.CheckContactID(ContactID, Global.GlobalUserID1))
                {
                    if ((MessageBox.Show("Are you sure want to delete this Contact?", "Delete Contact", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        if (contact.deleteContact(ContactID))
                        {
                            MessageBox.Show("Contact Deleted", "Delete Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt_ContactID.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Can Not Delete Contact", "Delete Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("ID Can Not Be Found!", "Delete Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_ContactID.Text = "";
                }
            }
        }

        private void btnShowFullList_Click(object sender, EventArgs e)
        {
            HumanResource.frmListFullContact listFullContact = new HumanResource.frmListFullContact();
            listFullContact.ShowDialog();
        }

        private void btnAddGroupName_Click(object sender, EventArgs e)
        {
            if (verif())
            {
                int num = -1;
                if (txt_Enter_GroupID.Text.Trim() == "")
                {
                    MessageBox.Show("Please Add An ID", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!Int32.TryParse(txt_Enter_GroupID.Text, out num))
                {
                    MessageBox.Show("Please Add An InterGer For Group's ID", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int GroupID = Convert.ToInt32(txt_Enter_GroupID.Text);
                    string GroupName = txtGroupName.Text;
                    if (group.CheckGroupID(GroupID))
                    {
                        if (group.CheckGroupName(GroupName))
                        {
                            if (group.insertGroup(GroupID, GroupName, Global.GlobalUserID1))
                            {
                                MessageBox.Show("Group Added!", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txt_Enter_GroupID.Text = "";
                                txtGroupName.Text = "";
                                //frmMainHR(null, null);
                            }
                            else
                            {
                                MessageBox.Show("Can Not Add Group!", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Group's Name Existed!", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtGroupName.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Group's ID Existed!", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_Enter_GroupID.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEditGroup_Click(object sender, EventArgs e)
        {
            if (txtNewGroupName.Text.Trim() != "")
            {
                string GroupName = txtNewGroupName.Text;
                int GroupID = (int)cboEditSelectGroup.SelectedValue;
                if (group.CheckGroupName(GroupName))
                {
                    if (group.updateGroupName(GroupID, GroupName))
                    {
                        MessageBox.Show("Group's Name Edited", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNewGroupName.Text = "";
                        //MainFormHR_Load(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Can Not Update Group's Name", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Group's Name Existed!", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNewGroupName.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnRemoveGroup_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are you sure want to delete this Group?", "Delete Group", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                int GroupID = (int)cboRemoveGroup.SelectedValue;
                //int GroupID = (int)cbb_EditGroup.SelectedIndex;
                if (group.deleteGroup(GroupID))
                {
                    MessageBox.Show("Group Deleted", "Delete Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //MainFormHR_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Can Not Delete Group!", "Delete Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        bool verif()
        {
            if (txt_Enter_GroupID.Text.Trim() == "" || txtGroupName.Text.Trim() == "")
                return false;
            else
                return true;

        }

        private void lblManageAccount_Click(object sender, EventArgs e)
        {
            HumanResource.frmManageAccountHR manageAccountHR = new HumanResource.frmManageAccountHR();
            manageAccountHR.ShowDialog();
        }
    }
}
