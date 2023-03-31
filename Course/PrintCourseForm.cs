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
using System.IO;
using System.Drawing.Printing;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Word = Microsoft.Office.Interop.Word;

namespace _20110375_HuynhDangKhoa_LoginForm.Course
{
    public partial class PrintCourseForm : Form
    {
        STUDENT student = new STUDENT();
        Course.COURSE course = new Course.COURSE(); 

        public PrintCourseForm()
        {
            InitializeComponent();
        }

        private void PrintCourseForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSVDataSetFull.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.qLSVDataSetFull.Course);
            dataGRV_Course.DataSource = course.getAllCourses();
            dataGRV_Course.RowTemplate.Height = 30;
            dataGRV_Course.AllowUserToAddRows = false;
            dataGRV_Course.ReadOnly = true;
        }

        // chỉ export sang Word Thôi
        private void btnToFile_Click(object sender, EventArgs e)
        {
            if (dataGRV_Course.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Word Documents (.docx)|.docx";
                sfd.FileName = "exportCourse.docx";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Export_Data_To_Word(dataGRV_Course, sfd.FileName);
                }
                //ExportToWord(DGV);
                //ExportToWord2(DGV);

            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            printDlg.Document = printDoc;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;

            if (printDlg.ShowDialog() == DialogResult.OK)
                printDoc.Print();

        }

        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            // export data in dataGridView to Word. Have the column Name

            if (DGV.Rows.Count != 0)
            {
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;
                Word.Document oDoc = new Word.Document();
                oDoc.Application.Visible = true;
                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;
                string oTemp = "";
                var table = oDoc.Tables.Add(oDoc.Range(), DGV.RowCount + 1, DGV.ColumnCount);
                Object oMissing = System.Reflection.Missing.Value;

                // Thêm tên cột cho bảng
                var headerRow = table.Rows[1];
                for (int i = 0; i < DGV.ColumnCount; i++)
                {
                    headerRow.Cells[i + 1].Range.Text = DGV.Columns[i].HeaderText;
                }

                // Thêm dữ liệu từ DataGridView vào bảng
                for (int r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c < ColumnCount; c++)
                    {

                        if (DGV.Rows[r].Cells[c].Value != null)
                        {                         
                                           
                                table.Cell(r + 2, c + 1).Range.Text = DGV.Rows[r].Cells[c].Value.ToString();
                        }
                        else
                        {
                            table.Cell(r + 2, c + 1).Range.Text = "";
                        }



                    }
                }

                // Lưu tài liệu Word
                oDoc.SaveAs2(filename);
            }
        }

    }
}
