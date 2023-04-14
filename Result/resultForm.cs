using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Word = Microsoft.Office.Interop.Word;
using System.Windows.Forms;
using System.IO;
using Xceed.Words.NET;
using Aspose.Words;
using static iTextSharp.text.TabStop;
using System.Data.Linq;
using System.Web.UI.WebControls;
using Aspose.Words.Tables;
using WordsTable = Aspose.Words.Tables.Table;
using _20110375_HuynhDangKhoa_LoginForm.Classes;




namespace _20110375_HuynhDangKhoa_LoginForm.Result
{
    public partial class resultForm : Form
    {
        public resultForm()
        {
            InitializeComponent();
        }
        Course.COURSE course = new Course.COURSE();
        Score.SCORE score = new Score.SCORE();
        STUDENT student = new STUDENT();
        MY_DB mydb = new MY_DB();

      
        private void resultForm_Load(object sender, EventArgs e)
        {
            dataGridView_ResultStudent.DataSource = score.getAllCourseScoreAndResult();
            //dataGridView_ResultStudent.AutoSize = true;
            dataGridView_ResultStudent.Columns[0].HeaderText = "Student ID";
            dataGridView_ResultStudent.Columns[1].HeaderText = "First Name";
            dataGridView_ResultStudent.Columns[2].HeaderText = "Last Name";
        }

        private void dataGridView_ResultStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtStudentId.Text = dataGridView_ResultStudent.CurrentRow.Cells[0].Value.ToString();
            txtFName.Text = dataGridView_ResultStudent.CurrentRow.Cells[1].Value.ToString();
            txtLName.Text = dataGridView_ResultStudent.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT MSSV, FirstName, LastName FROM student WHERE CONCAT(FirstName, MSSV) LIKE '%" + txtFindStu.Text + "%' ", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            DataTable tableCourse = new DataTable();
            tableCourse = course.getAllCourses();

            //lấy khóa học theo chiều ngang
            for (int i = 0; i < tableCourse.Rows.Count; i++)
            {
                DataColumn CourseNamecolumn = new DataColumn();
                CourseNamecolumn.ColumnName = tableCourse.Rows[i]["label"].ToString();
                table.Columns.Add(CourseNamecolumn);
            }
            //lấy điểm của từng khóa học dựa theo id của học sinh
            DataTable tableScore = new DataTable();
            tableScore = score.getStudentScore();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                for (int c = 0; c < tableScore.Rows.Count; c++)
                {
                    if (table.Rows[i]["MSSV"].ToString().Trim() == tableScore.Rows[c]["StudentID"].ToString().Trim())
                    {
                        for (int k = 3; k < table.Columns.Count; k++)
                        {
                            if (table.Columns[k].ColumnName == tableScore.Rows[c]["Course Name"].ToString())
                            {
                                
                                table.Rows[i][k] = tableScore.Rows[c]["Score22"].ToString();
                                break;
                            }
                        }
                    }
                }
            }

            table.Columns.Add("AVG_Score", typeof(float));
            table.Columns.Add("Result", typeof(string));
            for (int i = 0; i < table.Rows.Count; i++)
            {
                int count = 0;
                float sum = 0;
                for (int j = 3; j < table.Columns.Count - 2; j++)
                {
                    float temp;
                    string coursename = table.Columns[j].ColumnName;
                    if (float.TryParse(table.Rows[i][coursename].ToString(), out temp))
                    {
                        sum += temp;
                        count++;
                    }
                }

                float avg = sum / count;
                Math.Round(avg, 2);
                table.Rows[i]["AVG_Score"] = Math.Round(avg, 2);

                if (avg < 5) table.Rows[i]["Result"] = "Fail";
                if (avg >= 5 && avg <= 6.5) table.Rows[i]["Result"] = "Average";
                if (avg > 6.5 && avg <= 7.9) table.Rows[i]["Result"] = "Goods";
                if (avg >= 8) table.Rows[i]["Result"] = "Excellent";
                if (count == 0) table.Rows[i]["Result"] = "Drop Out Of University!";
                if (avg.ToString() == "NaN") table.Rows[i]["AVG_Score"] = 0;
            }
            dataGridView_ResultStudent.DataSource = table;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }






        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dataGridView_ResultStudent.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Word Documents (.docx)|.docx";
                sfd.FileName = "export_StudentListRegister.docx";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Export_Data_To_Word(dataGridView_ResultStudent, sfd.FileName);
                }
                //ExportToWord(dataGVStudent_information);
                //ExportToWord2(dataGVStudent_information);

            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }

        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            // export data in dataGridView to Word. Have the column Name

            if (dataGridView_ResultStudent.Rows.Count != 0)
            {
                int RowCount = dataGridView_ResultStudent.Rows.Count;
                int ColumnCount = dataGridView_ResultStudent.Columns.Count;
                Word.Document oDoc = new Word.Document();
                oDoc.Application.Visible = true;
                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;
                string oTemp = "";
                var table = oDoc.Tables.Add(oDoc.Range(), dataGridView_ResultStudent.RowCount + 1, dataGridView_ResultStudent.ColumnCount);
                Object oMissing = System.Reflection.Missing.Value;

                Word.Section section = oDoc.Sections.Add();
                // Thêm tiêu đề khóa học vào tài liệu
                //Microsoft.Office.Interop.Word.Paragraph title = oDoc.Content.Paragraphs.Add();
                Word.HeaderFooter title = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary];

                string time = DateTime.Today.Day.ToString("00") + "/" + DateTime.Today.Month.ToString("00") + "/"
                + DateTime.Today.Year.ToString("0000");

                // định nghĩa cững luôn cho nhanh :)))
                title.Range.Text = "TRƯỜNG ĐẠI HỌC SPKT TP.HCM                                              CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM\n" +
                    "\nKHOA ĐÀO TẠO CHẤT LƯỢNG CAO\t\tĐộc Lập - Tự Do - Hạnh Phúc\n" +
                    "\nNGÀNH CÔNG NGHỆ THÔNG TIN\n" +
                    //"\nMÔN HỌC: " + txtCourseName2.Text + "\n" +
                    //"\nHỌC KỲ: " + lblShow.Text + " - NĂM HỌC 2022 - 2023" + "\n" +
                    "\n_____________________________________________________________________________________________________________________\n" +
                    "\nMôn học - Nhóm:              Windows Programming (2+1) - 04CLC" + "\tSố tín chỉ:" + "\t3" +
                    "\nLớp học phần:                    222WIPR230579E_04CLC" +
                    "\nGBGD:                               Lê Vĩnh Thịnh (0132)" +
                    "\nNgười thực hiện:                Huỳnh Đăng Khoa" +
                    "\nNgày:                                 " + time +
                    "\nMã số sinh viên:                20110375";

                title.Range.Font.Name = "Times New Roman";
                // Thêm Section Break và ngắt liên kết với Header của phần trước
                object breakType = Word.WdBreakType.wdSectionBreakContinuous;
                oDoc.ActiveWindow.Selection.InsertBreak(ref breakType);
                title.LinkToPrevious = false;
                title.Range.Text = "";



                title.Range.Font.Bold = 1;
                title.Range.Font.Size = 14;
                title.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                title.Range.InsertParagraphBefore();






                // Thêm tên cột cho bảng
                var headerRow = table.Rows[1];
                for (int i = 0; i < dataGridView_ResultStudent.ColumnCount; i++)
                {
                    headerRow.Cells[i + 1].Range.Text = dataGridView_ResultStudent.Columns[i].HeaderText;
                }

                // Thêm dữ liệu từ DataGridView vào bảng
                for (int r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c < ColumnCount; c++)
                    {

                        if (dataGridView_ResultStudent.Rows[r].Cells[c].Value != null)
                        {
                            // Check ở cột Có tên là Birth Date thì không in ra giờ 
                            if (dataGridView_ResultStudent.Columns[c].HeaderText == "BirthDate")
                            {
                                table.Cell(r + 2, c + 1).Range.Text = Convert.ToDateTime(dataGridView_ResultStudent.Rows[r].Cells[c].Value).ToString("dd/MM/yyyy");
                            }

                            // Nếu tên cột là "Picture", chèn hình ảnh vào ô tương ứng


                            /*Để chèn hình ảnh vào ô tương ứng nếu tên cột là "Picture", 
                                sử dụng câu lệnh kiểm tra if (dataGridViewStudentList.Columns[c].HeaderText == "Picture"), 
                                    và chèn hình ảnh vào bằng cách sử dụng đoạn mã tương tự như trong đoạn mã ban đầu.*/

                            else
                            {
                                table.Cell(r + 2, c + 1).Range.Text = dataGridView_ResultStudent.Rows[r].Cells[c].Value.ToString();
                            }
                        }
                        else
                        {
                            table.Cell(r + 2, c + 1).Range.Text = "";
                        }



                    }
                }


                // Lưu tài liệu Word
                oDoc.SaveAs2(@"C:\Users\Asus\OneDrive\Máy tính\Khoa\Đại Học\Junior\HK 2 2022-2023\Windows Programming\Git\StudentManagement\StudentManagement\Export");
            }
        }

    }
}
