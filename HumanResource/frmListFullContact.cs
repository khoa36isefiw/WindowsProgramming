using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20110375_HuynhDangKhoa_LoginForm.HumanResource
{
    public partial class frmListFullContact : Form
    {
        public frmListFullContact()
        {
            InitializeComponent();
        }

        Contact.Contact contact = new Contact.Contact();
        Group group = new Group();
        private void frmListFullContact_Load(object sender, EventArgs e)
        {
            dataGridView_Contact.ReadOnly = true;

            listBox_Contact.DataSource = group.GetUserGroups(Global.GlobalUserID1);
            listBox_Contact.ValueMember = "Id";
            listBox_Contact.DisplayMember = "name";
            listBox_Contact.SelectedItem = null;

            //DataGridView
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView_Contact.RowTemplate.Height = 20;
            dataGridView_Contact.DataSource = contact.ContactListByUserID(Global.GlobalUserID1);
            picCol = (DataGridViewImageColumn)dataGridView_Contact.Columns[6];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridView_Contact.AllowUserToAddRows = false;

            dataGridView_Contact.ClearSelection();

            for (int i = 0; i < dataGridView_Contact.Rows.Count; i++)
            {
                if (i % 2 != 0)
                {
                    dataGridView_Contact.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            frmListFullContact_Load(null, null);
        }

        private void listBox_Contact_Click(object sender, EventArgs e)
        {
            int GroupID = (Int32)listBox_Contact.SelectedValue;
            dataGridView_Contact.DataSource = contact.ContactListByUserIDandGroupID(Global.GlobalUserID1, GroupID);
            //dataGridView1.DataSource = contact
        }

        private void dataGridView_Contact_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Contact.ContactClassForm CCF = new Contact.ContactClassForm(); // forms này chỉ chứa datagridview để hiển thị
            CCF.ContactID = (int)(dataGridView_Contact.CurrentRow.Cells[0].Value);
            CCF.ShowDialog();
        }
    }
}
