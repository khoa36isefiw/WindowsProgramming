using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20110375_HuynhDangKhoa_LoginForm.Contact
{
    public partial class frmContactGroups : Form
    {
        public frmContactGroups()
        {
            InitializeComponent();
        }
        Contact contact = new Contact();
        private void dataGridView_ContactGroups_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            HumanResource.frmSelectedContact SCF = new HumanResource.frmSelectedContact();
            SCF.ContactID = Convert.ToInt32(dataGridView_ContactGroups.CurrentRow.Cells[0].Value);
            SCF.Show(this);
        }

        private void frmContactGroups_Load(object sender, EventArgs e)
        {
            dataGridView_ContactGroups.ReadOnly = true;
            dataGridView_ContactGroups.DataSource = contact.GetContactAndGroup(Global.GlobalUserID1);
            dataGridView_ContactGroups.RowTemplate.Height = 20;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dataGridView_ContactGroups.Columns[6];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }
    }
}
