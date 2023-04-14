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

using static iTextSharp.text.TabStop;

namespace _20110375_HuynhDangKhoa_LoginForm.Course
{
    public partial class FormCourseStudentList : Form
    {
        public FormCourseStudentList()
        {
            InitializeComponent();
        }
        STUDENT stu = new STUDENT();
        Course.COURSE course = new Course.COURSE();
        

        private void FormCourseStudentList_Load(object sender, EventArgs e)
        {
            string course = txtCourseName2.Text;
            SqlCommand cmd = new SqlCommand("Select MSSV, FirstName, LastName, BirthDate from student where [selectedCourse] LIKE N'%" + txtCourseName2.Text + "%'");

            
            dataGridViewStudentList.DataSource = stu.getStudents(cmd);
            
        }

        private void dataGridViewStudentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // print to word
        private void btnPrint_Click(object sender, EventArgs e)
        {

            if (dataGridViewStudentList.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Word Documents (.docx)|.docx";
                sfd.FileName = "export_StudentListRegister.docx";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Export_Data_To_Word(dataGridViewStudentList, sfd.FileName);
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

            if (dataGridViewStudentList.Rows.Count != 0)
            {
                int RowCount = dataGridViewStudentList.Rows.Count;
                int ColumnCount = dataGridViewStudentList.Columns.Count;
                Word.Document oDoc = new Word.Document();
                oDoc.Application.Visible = true;
                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;
                string oTemp = "";
                var table = oDoc.Tables.Add(oDoc.Range(), dataGridViewStudentList.RowCount + 1, dataGridViewStudentList.ColumnCount);
                Object oMissing = System.Reflection.Missing.Value;

                Word.Section section = oDoc.Sections.Add();
                // Thêm tiêu đề khóa học vào tài liệu
                //Microsoft.Office.Interop.Word.Paragraph title = oDoc.Content.Paragraphs.Add();
                Word.HeaderFooter title = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary];

                string time = DateTime.Today.Day.ToString("00") + "/" + DateTime.Today.Month.ToString("00") + "/"
                + DateTime.Today.Year.ToString("0000");

                // định nghĩa cững luôn cho nhanh :)))
                title.Range.Text = "TRƯỜNG ĐẠI HỌC SPKT TP.HCM\n"  +
                    "\nKHOA ĐÀO TẠO CHẤT LƯỢNG CAO\n" + 
                    "\nNGÀNH CÔNG NGHỆ THÔNG TIN\n" +
                    "\nMÔN HỌC: " + txtCourseName2.Text + "\n"+
                    "\nHỌC KỲ: " + lblShow.Text + " - NĂM HỌC 2022 - 2023"  + "\n"+
                    "\n_____________________________________________________________________________________________________________________\n" +
                    "\nMôn học - Nhóm:              Windows Programming (2+1) - 04CLC"+ "\tSố tín chỉ:"+"\t3" +
                    "\nLớp học phần:                    222WIPR230579E_04CLC" +
                    "\nGBGD:                               Lê Vĩnh Thịnh (0132)" + 
                    "\nNgười thực hiện:                Huỳnh Đăng Khoa"+
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
                for (int i = 0; i < dataGridViewStudentList.ColumnCount; i++)
                {
                    headerRow.Cells[i + 1].Range.Text = dataGridViewStudentList.Columns[i].HeaderText;
                }

                // Thêm dữ liệu từ DataGridView vào bảng
                for (int r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c < ColumnCount; c++)
                    {

                        if (dataGridViewStudentList.Rows[r].Cells[c].Value != null)
                        {
                            // Check ở cột Có tên là Birth Date thì không in ra giờ 
                            if (dataGridViewStudentList.Columns[c].HeaderText == "BirthDate")
                            {
                                table.Cell(r + 2, c + 1).Range.Text = Convert.ToDateTime(dataGridViewStudentList.Rows[r].Cells[c].Value).ToString("dd/MM/yyyy");
                            }

                            // Nếu tên cột là "Picture", chèn hình ảnh vào ô tương ứng


                            /*Để chèn hình ảnh vào ô tương ứng nếu tên cột là "Picture", 
                                sử dụng câu lệnh kiểm tra if (dataGridViewStudentList.Columns[c].HeaderText == "Picture"), 
                                    và chèn hình ảnh vào bằng cách sử dụng đoạn mã tương tự như trong đoạn mã ban đầu.*/

                            else
                            {
                                table.Cell(r + 2, c + 1).Range.Text = dataGridViewStudentList.Rows[r].Cells[c].Value.ToString();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }




       
    }
}
