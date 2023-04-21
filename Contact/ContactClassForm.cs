using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20110375_HuynhDangKhoa_LoginForm.Contact
{
    public partial class ContactClassForm : Form
    {
        public ContactClassForm()
        {
            InitializeComponent();
        }

        public ContactClassForm(int contactID)
        {
            this.ContactID = contactID;
        }


        public int ContactID;
        MY_DB mydb = new MY_DB();
        
        private void ContactClassForm_Load(object sender, EventArgs e)
        {
            dataGridView_ContactClassForm.ReadOnly = true;
            /*
         SqlCommand command = new SqlCommand("select contact.fname as FirstName, 
        contact.lname as LastName, Course.id as CourseID, Course.label as CourseName " +
            "from contact inner join Course on contact.id = course.contactID WHERE contact.id = @cid", mydb.getConnection);

         */

            SqlCommand command = new SqlCommand("select contact.fname as FirstName, contact.lname as LastName, " +
                "Course.id as CourseID, Course.label as CourseName from contact " +
                "inner join Course on contact.id = Course.contactID  WHERE contact.id = @cid", mydb.getConnection);
            command.Parameters.Add("@cid", SqlDbType.Int).Value = ContactID;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_ContactClassForm.DataSource = table;
        }

    

        private void dataGridView_ContactClassForm_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ClassStudentListForm CSLF = new ClassStudentListForm();
            CSLF.ContactID = ContactID;
            CSLF.ClassName = dataGridView_ContactClassForm.CurrentRow.Cells["CourseName"].Value.ToString();
            CSLF.Show(this);
        }
    }
}
