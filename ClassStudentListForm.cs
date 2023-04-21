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

namespace _20110375_HuynhDangKhoa_LoginForm
{
    public partial class ClassStudentListForm : Form
    {
        public int ContactID;
        public string ClassName;
        MY_DB mydb = new MY_DB();

        public ClassStudentListForm()
        {
            InitializeComponent();
        }

        private void ClassStudentListForm_Load(object sender, EventArgs e)

        {
            /*
             SqlCommand command = new SqlCommand("select std.id as StudentID, std.fname as FirstName, 
            std.lname as LastName, course.label as CourseName, contact.fname as ContactName 
            from score inner join classes on score.course_id = classes.courseid inner join std on 
            score.student_id = std.id inner join course on course.id = classes.courseid 
            inner join Contact on contact.id = classes.contactid where contact.id = @cid
            and course.label = @cname order by courseName", mydb.getConnection);
             
             
             */
            dataGridView_ClassStudentLForm.ReadOnly = true;

            SqlCommand command = new SqlCommand("select student.MSSV as StudentID, student.FirstName as 'First Name'," +
                " student.LastName as 'Last Name', Course.label as CourseName," +
                " contact.fname as 'Contact Name' from SCORE2 inner join Course on" +
                " SCORE2.course_id = Course.id inner join student on SCORE2.student_id = student.MSSV " +
                "inner join contact on contact.id" +
                " = Course.contactID where contact.id = @cid and Course.label = @cname order by courseName", mydb.getConnection);

            command.Parameters.Add("@cid", SqlDbType.Int).Value = ContactID;
            command.Parameters.Add("@cname", SqlDbType.NVarChar).Value = ClassName;
            mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_ClassStudentLForm.DataSource = table;
            mydb.closeConnection();

        }
    }
}
