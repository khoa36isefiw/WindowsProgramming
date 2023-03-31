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
using Excel = Microsoft.Office.Interop.Excel;
using Font = System.Drawing.Font;

namespace _20110375_HuynhDangKhoa_LoginForm
{
    public partial class frmPrint : Form
    {
     
        MY_DB db = new MY_DB();

        public frmPrint()
        {
            InitializeComponent();

        }


       
        private void frmPrint_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'userDataSet.user_login' table. You can move, or remove it, as needed.
            //this.user_loginTableAdapter.Fill(this.userDataSet.user_login);
            // TODO: This line of code loads data into the 'studentDataSet.student' table. You can move, or remove it, as needed.
            //this.studentTableAdapter1.Fill(this.studentDataSet.student);

            // TODO: This line of code loads data into the 'qLSVDataSet.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.qLSVDataSet.student);
            radioButton_All.Checked = true;
            radioButton_No.Checked = true;

            string strSQL = "select * from student";
            

            dataGVStudent_information.RowTemplate.Height = 20;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            try
            {
                db.openConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(strSQL, db.getConnection);

                DataSet ds = new DataSet("Student");
                adapter.Fill(ds, "Student");
                DataTable table = ds.Tables["Student"];
                dataGVStudent_information.DataSource = table;

                picCol = (DataGridViewImageColumn)dataGVStudent_information.Columns[11];
                picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                dataGVStudent_information.AllowUserToAddRows = false;
                db.closeConnection();


            }
            catch (Exception err)
            {
                MessageBox.Show("Error", err.Message);
                db.closeConnection();
            }
           

        }

        private void groupBoxChoose_Enter(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string strSQL = "SELECT * FROM student";
            if (radioButton_No.Checked == true)
            {
                if (radioButton_Male.Checked == true)
                {
                    strSQL += " WHERE Gender = 'Male'";
                }
                else strSQL += " WHERE Gender = 'Female'";
            }

            else
            {
                // yess
                if (radioButton_Yes.Checked == true)
                {
                    DateTime start = dateTimePicker_start.Value;
                    DateTime end = dateTimePicker_end.Value;
                    if (radioButton_All.Checked == true)
                    {
                        strSQL += " WHERE BirthDate BETWEEN '" + start.ToString() + "' AND '" + end.ToString() + "'";
                    }

                    if (radioButton_Male.Checked == true)
                    {
                        strSQL += " Where Gender ='Male' AND BirthDate between '" + start.ToString() + "' AND '" + end.ToString() + "'";
                    }

                    if (radioButton_Female.Checked == true)
                    {
                        strSQL += " Where Gender ='Female' AND BirthDate between '" + start.ToString() + "' AND '" + end.ToString() + "'";
                    }
                }




                dataGVStudent_information.RowTemplate.Height = 60;
                DataGridViewImageColumn picCol = new DataGridViewImageColumn();
                try
                {
                    db.openConnection();
                    SqlDataAdapter adapter = new SqlDataAdapter(strSQL, db.getConnection);
                    DataSet ds = new DataSet("Student");
                    adapter.Fill(ds, "Student");
                    DataTable table = ds.Tables["Student"];
                    dataGVStudent_information.DataSource = table;

                    picCol = (DataGridViewImageColumn)dataGVStudent_information.Columns[11];
                    picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    dataGVStudent_information.AllowUserToAddRows = false;
                    db.closeConnection();
                }
                catch (Exception err)
                {
                    MessageBox.Show("Error", err.Message);
                    db.closeConnection();
                }

            }
           

        }

        

        private void btnSaveText_Click(object sender, EventArgs e)
        {
            if (dataGVStudent_information.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Word Documents (.docx)|.docx";
                sfd.FileName = "export.docx";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Export_Data_To_Word(dataGVStudent_information, sfd.FileName);
                }
                //ExportToWord(dataGVStudent_information);
                //ExportToWord2(dataGVStudent_information);

            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }

        }

        private void btnPrinter_Click(object sender, EventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            printDlg.Document = printDoc;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;
            if (printDlg.ShowDialog() == DialogResult.OK)
            {
                printDoc.Print();
            }
        }

        private void btnSavePDF_Click(object sender, EventArgs e)
        {
            
                       

            if (dataGVStudent_information.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }

                    else if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dataGVStudent_information.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            foreach (DataGridViewColumn column in dataGVStudent_information.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dataGVStudent_information.Rows)
                            {


                                string sott = row.Cells[0].Value.ToString();
                                pdfTable.AddCell(sott);


                                string id = row.Cells[1].Value.ToString();
                                pdfTable.AddCell(id);

                                string Fname = row.Cells[2].Value.ToString();
                                pdfTable.AddCell(Fname.ToUpper());

                                string Lname = row.Cells[3].Value.ToString();
                                pdfTable.AddCell(Lname.ToUpper());

                                // chỉ in ra day-month-year; có time
                                string Bdate = ((DateTime)row.Cells[4].Value).ToString("dd/MM/yyyy");
                                pdfTable.AddCell(Bdate);

                                string gender = row.Cells[5].Value.ToString();
                                pdfTable.AddCell(gender.ToUpper());

                                string phone = row.Cells[6].Value.ToString();
                                pdfTable.AddCell(phone);

                                string email = row.Cells[7].Value.ToString();
                                pdfTable.AddCell(email);


                                string address = row.Cells[8].Value.ToString();
                                pdfTable.AddCell(address.ToUpper());

                                string depart = row.Cells[9].Value.ToString();
                                pdfTable.AddCell(depart.ToUpper());

                                string major = row.Cells[10].Value.ToString();
                                pdfTable.AddCell(major.ToUpper());

                                byte[] imageByte = (byte[])row.Cells[11].Value;
                                iTextSharp.text.Image Image = iTextSharp.text.Image.GetInstance(imageByte);
                                pdfTable.AddCell(Image);

                                string home = row.Cells[12].Value.ToString();
                                pdfTable.AddCell(home.ToUpper());


                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }
                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show("Error :" + err.Message);
                        }


                    }
               
                }


            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dataGVStudent_information.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Documents (*.xls)|*.xls";
                sfd.FileName = "Inventory_Adjustment_Export.xls";
                bool fileError = false;
                if (!fileError)
                {
                    try
                    {
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            // Copy DataGridView results to clipboard
                            copyAlltoClipboard();

                            object misValue = System.Reflection.Missing.Value;
                            Excel.Application xlexcel = new Excel.Application();

                            xlexcel.DisplayAlerts = false; // Without this you will get two confirm overwrite prompts
                            Excel.Workbook xlWorkBook = xlexcel.Workbooks.Add(misValue);
                            Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                            // Format column D as text before pasting results, this was required for my data
                            Excel.Range rng = xlWorkSheet.get_Range("D:D").Cells;
                            rng.NumberFormat = "@";

                            // Paste clipboard results to worksheet range
                            Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
                            CR.Select();
                            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

                            // For some reason column A is always blank in the worksheet. ¯\_(ツ)_/¯
                            // Delete blank column A and select cell A1
                            Excel.Range delRng = xlWorkSheet.get_Range("A:A").Cells;
                            delRng.Delete(Type.Missing);
                            xlWorkSheet.get_Range("A1").Select();

                            // Save the excel file under the captured location from the SaveFileDialog
                            xlWorkBook.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                            xlexcel.DisplayAlerts = true;
                            xlWorkBook.Close(true, misValue, misValue);
                            xlexcel.Quit();

                            releaseObject(xlWorkSheet);
                            releaseObject(xlWorkBook);
                            releaseObject(xlexcel);

                            // Clear Clipboard and DataGridView selection
                            Clipboard.Clear();
                            dataGVStudent_information.ClearSelection();

                            // Open the newly saved excel file
                            if (File.Exists(sfd.FileName))
                                System.Diagnostics.Process.Start(sfd.FileName);
                        }
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Error :" + err.Message);
                    }
                }
            }



            else
            {

                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }

        private void copyAlltoClipboard()
        {
            dataGVStudent_information.SelectAll();
            DataObject dataObj = dataGVStudent_information.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

    
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception err)
            {
                obj = null;
                MessageBox.Show("Exception Occurred while releasing object " + err.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void radioButton_Yes_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker_start.Enabled = true;
            dateTimePicker_end.Enabled = true;
        }

        private void radioButton_No_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker_start.Enabled = false;
            dateTimePicker_end.Enabled = false;
        }

        private void dataGVStudent_information_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            // export data in dataGridView to Word. Have the column Name

            if (dataGVStudent_information.Rows.Count != 0)
            {
                int RowCount = dataGVStudent_information.Rows.Count;
                int ColumnCount = dataGVStudent_information.Columns.Count;
                Word.Document oDoc = new Word.Document();
                oDoc.Application.Visible = true;
                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;
                string oTemp = "";
                var table = oDoc.Tables.Add(oDoc.Range(), dataGVStudent_information.RowCount + 1, dataGVStudent_information.ColumnCount);
                Object oMissing = System.Reflection.Missing.Value;

                // Thêm tên cột cho bảng
                var headerRow = table.Rows[1];
                for (int i = 0; i < dataGVStudent_information.ColumnCount; i++)
                {
                    headerRow.Cells[i + 1].Range.Text = dataGVStudent_information.Columns[i].HeaderText;
                }

                // Thêm dữ liệu từ DataGridView vào bảng
                for (int r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c < ColumnCount; c++)
                    {

                        if (dataGVStudent_information.Rows[r].Cells[c].Value != null)
                        {
                            // Check ở cột Có tên là Birth Date thì không in ra giờ 
                            if (dataGVStudent_information.Columns[c].HeaderText == "Birth Date")
                            {
                                table.Cell(r + 2, c + 1).Range.Text = Convert.ToDateTime(dataGVStudent_information.Rows[r].Cells[c].Value).ToString("dd/MM/yyyy");
                            }

                            // Nếu tên cột là "Picture", chèn hình ảnh vào ô tương ứng


                            /*Để chèn hình ảnh vào ô tương ứng nếu tên cột là "Picture", 
                                sử dụng câu lệnh kiểm tra if (dataGVStudent_information.Columns[c].HeaderText == "Picture"), 
                                    và chèn hình ảnh vào bằng cách sử dụng đoạn mã tương tự như trong đoạn mã ban đầu.*/

                            else if (dataGVStudent_information.Columns[c].HeaderText == "Picture")
                            {
                                byte[] imgbyte = (byte[])dataGVStudent_information.Rows[r].Cells[c].Value;
                                if (imgbyte != null)
                                {
                                    MemoryStream ms = new MemoryStream(imgbyte);
                                    System.Drawing.Image sparePicture = System.Drawing.Image.FromStream(ms);
                                    System.Drawing.Image finalPic = (System.Drawing.Image)(new Bitmap(sparePicture, new Size(90, 90)));
                                    Clipboard.SetDataObject(finalPic);
                                    table.Cell(r + 2, c + 1).Range.Paste();
                                }
                            }
                            else
                            {
                                table.Cell(r + 2, c + 1).Range.Text = dataGVStudent_information.Rows[r].Cells[c].Value.ToString();
                            }
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


        // Hàm xuất dữ liệu từ DataGridView sang Word
        private void ExportToWord(DataGridView dataGridView)
        {
            // Khởi tạo đối tượng Word
            Word.Document oDoc = new Word.Document();
            //var wordApp = new Word.Application();
            oDoc.Application.Visible = true;
            oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;

            // Tạo một tài liệu mới
            //var doc = wordApp.Documents.Add();

            // Tạo bảng trong tài liệu
            var table = oDoc.Tables.Add(oDoc.Range(), dataGridView.RowCount + 1, dataGridView.ColumnCount);

            // Đặt định dạng cho bảng
            table.Borders.Enable = 1;
            table.AllowAutoFit = true;
            table.AutoFitBehavior(Word.WdAutoFitBehavior.wdAutoFitWindow);
            Object oMissing = System.Reflection.Missing.Value;
            // Đặt tiêu đề cho các cột trong bảng
            for (int i = 0; i < dataGridView.ColumnCount; i++)
            {
                table.Cell(1, i + 1).Range.Text = dataGVStudent_information.Columns[i].HeaderText;
            }

            //Điền dữ liệu vào bảng
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                for (int j = 0; j < dataGridView.ColumnCount; j++)
                {
                    table.Cell(i + 2, j + 1).Range.Text = dataGVStudent_information.Rows[i].Cells[j].Value.ToString();

                }
                byte[] imgbyte = (byte[])dataGridView.Rows[i].Cells[11].Value;
                MemoryStream ms = new MemoryStream(imgbyte);
                System.Drawing.Image sparePicture = System.Drawing.Image.FromStream(ms);
                System.Drawing.Image finalPic = (System.Drawing.Image)(new Bitmap(sparePicture, new Size(90, 90)));
                Clipboard.SetDataObject(finalPic);
                var oPara2 = oDoc.Content.Paragraphs.Add(ref oMissing);
                oPara2.Range.Paste();
                oPara2.Range.InsertParagraphAfter();

            }

        }

        private void ExportToWord2(DataGridView dataGridView)
        {
            // Khởi tạo một đối tượng Word.Application mới
            Word.Application wordApp = new Word.Application();

            // Tạo một tài liệu Word mới
            Word.Document doc = wordApp.Documents.Add();

          

            // Tạo một đối tượng Shape trong tài liệu Word và dán nội dung từ Clipboard vào đối tượng đó
            Word.Shape shape = doc.Shapes.AddShape(1, 0, 0, 50, 50);
            shape.Select();
            wordApp.Selection.Paste();

            // Tạo bảng trong tài liệu
            var table = doc.Tables.Add(doc.Range(), dataGridView.RowCount + 1, dataGridView.ColumnCount);

            // Đặt định dạng cho bảng
            table.Borders.Enable = 1;
            table.AllowAutoFit = true;
            table.AutoFitBehavior(Word.WdAutoFitBehavior.wdAutoFitWindow);

            // Đặt tiêu đề cho các cột trong bảng
            for (int i = 0; i < dataGridView.ColumnCount; i++)
            {
                table.Cell(1, i + 1).Range.Text = dataGridView.Columns[i].HeaderText;
            }

            // Điền dữ liệu vào bảng
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                for (int j = 0; j < dataGridView.ColumnCount; j++)
                {
                    // Kiểm tra nếu cột đang xét chứa hình ảnh
                    if (dataGridView.Columns[j].CellType == typeof(DataGridViewImageCell))
                    {
                        // Sao chép dữ liệu và hình ảnh vào Clipboard
                        dataGVStudent_information.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
                        dataGVStudent_information.CurrentCell = dataGVStudent_information[j, i];
                        dataGVStudent_information[j, i].Selected = true;
                        Clipboard.SetDataObject(dataGVStudent_information.GetClipboardContent());

                        // Tạo một đối tượng Shape trong tài liệu và dán hình ảnh vào đó
                        Word.Shape imageShape = doc.Shapes.AddShape(1, 0, 0, 50, 50);
                        imageShape.Select();
                        wordApp.Selection.Paste();

                        // Điều chỉnh kích thước của đối tượng Shape để hiển thị hình ảnh đầy đủ
                        float width = imageShape.Width;
                        float height = imageShape.Height;
                        imageShape.Width = width * 2;
                        imageShape.Height = height * 2;

                        // Điền một dấu chấm vào ô tương ứng của bảng để tránh lỗi khi xuất file Word
                        table.Cell(i + 2, j + 1).Range.Text = ".";
                    }
                    else
                    {
                        table.Cell(i + 2, j + 1).Range.Text = dataGridView.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // Sao chép dữ liệu và hình ảnh từ DataGridView vào Clipboard
                dataGVStudent_information.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText;
                dataGVStudent_information.SelectAll();
                DataObject dataObj = dataGVStudent_information.GetClipboardContent();
                Clipboard.SetDataObject(dataObj, true);
            }

            // Lưu tài liệu Word và đóng ứng dụng Word
            wordApp.ActiveDocument.SaveAs2(@"C:\Users\Asus\OneDrive\Máy tính\Khoa\Đại Học\Junior\HK 2 2022-2023\Windows Programming\Git\StudentManagement\StudentManagement\PrintToWord.docx");
            wordApp.ActiveDocument.Close(false);
            wordApp.Quit();
        }


        private void ExportToPDF(DataGridView dataGridView, string filePath)
        {
            // Load font Unicode hỗ trợ tiếng Việt
            BaseFont unicodeFont = BaseFont.CreateFont(@"C:\Windows\Fonts\Arial.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);

            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
            document.Open();

            // Add column headers
            PdfPTable table = new PdfPTable(dataGridView.Columns.Count);
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                PdfPCell cell = new PdfPCell(new Phrase(Convert.ToInt32(dataGridView.Columns[i].HeaderText)));
                table.AddCell(cell);
            }

            // Add row data
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(Convert.ToInt32(dataGridView.Rows[i].Cells[j].Value.ToString())));
                    table.AddCell(cell);
                }
            }

            document.Add(table);
            document.Close();
        }
    }
}
