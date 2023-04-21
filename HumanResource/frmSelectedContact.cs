using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _20110375_HuynhDangKhoa_LoginForm.HumanResource
{
    public partial class frmSelectedContact : Form
    {
        public int ContactID;
        public frmSelectedContact()
        {
            InitializeComponent();
        }
        Contact.Contact contact = new Contact.Contact();
        Group group = new Group();


        private void frmSelectedContact_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table = contact.GetContactByID(ContactID);
            txt_ID.Text = table.Rows[0]["id"].ToString();
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
    }
}
