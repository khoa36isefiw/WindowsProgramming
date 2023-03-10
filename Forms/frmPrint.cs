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

namespace _20110375_HuynhDangKhoa_LoginForm
{
    public partial class frmPrint : Form
    {
        public frmPrint()
        {
            InitializeComponent();
        }
        MY_DB db = new MY_DB();


       
        private void frmPrint_Load(object sender, EventArgs e)
        {



            // TODO: This line of code loads data into the 'qLSVDataSet.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.qLSVDataSet.student);
            radioButton_All.Checked = true;
            radioButton_No.Checked = false;

            string strSQL = "select * from student";
            

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

                picCol = (DataGridViewImageColumn)dataGVStudent_information.Columns[10];
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
                    strSQL += " WHERE gender = 'male'";
                }
                else strSQL += " WHERE gender = 'female'";
            }

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
                    strSQL += "Where Gender ='Male' AND BirthDate between'" + start.ToString() + "'AND'" + end.ToString() + "";
                }

                if (radioButton_Female.Checked == true)
                {
                    strSQL += "Where Gender ='Female' AND BirthDate between'" + start.ToString() + "'AND'" + end.ToString() + "";
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

                    picCol = (DataGridViewImageColumn)dataGVStudent_information.Columns[10];
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

        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            if (dataGVStudent_information.Rows.Count != 0)
            {
                int RowCount = dataGVStudent_information.Rows.Count;
                int ColumnCount = dataGVStudent_information.Columns.Count;
                Word.Document oDoc = new Word.Document();
                oDoc.Application.Visible = true;
                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;
                //dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                Object oMissing = System.Reflection.Missing.Value;
                for (int r = 0; r <= RowCount - 1; r++)
                {
                    oTemp = "";
                    for (int c = 0; c < ColumnCount - 1; c++)
                    {
                        oTemp = oTemp + dataGVStudent_information.Rows[r].Cells[c].Value + "\t";
                    }
                    var oPara1 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara1.Range.Text = oTemp;
                    oPara1.Range.InsertParagraphAfter();
                    byte[] imgbyte = (byte[])dataGVStudent_information.Rows[r].Cells[10].Value;
                    MemoryStream ms = new MemoryStream(imgbyte);
                    System.Drawing.Image sparePicture = System.Drawing.Image.FromStream(ms);
                    System.Drawing.Image finalPic = (System.Drawing.Image)(new Bitmap(sparePicture, new
                    Size(90, 90)));
                    Clipboard.SetDataObject(finalPic);
                    var oPara2 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara2.Range.Paste();
                    oPara2.Range.InsertParagraphAfter();
                    //oTemp += "\n";
                }
                //save the file
                oDoc.SaveAs2(filename);
            }
        }

        private void btnSaveText_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Word Documents (.docx)|.docx";
            sfd.FileName = "export.docx";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Export_Data_To_Word(dataGVStudent_information, sfd.FileName);
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
                }
                if (!fileError)
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
                            string id = row.Cells[0].Value.ToString();
                            pdfTable.AddCell(id);

                            string Fname = row.Cells[1].Value.ToString();
                            pdfTable.AddCell(Fname);
                            
                            string Lname = row.Cells[2].Value.ToString();
                            pdfTable.AddCell(Lname);
                            
                            string Bdate = row.Cells[3].Value.ToString();
                            pdfTable.AddCell(Bdate);
                            
                            string gender = row.Cells[4].Value.ToString();
                            pdfTable.AddCell(gender);

                            string phone = row.Cells[5].Value.ToString();
                            pdfTable.AddCell(phone);

                            string email = row.Cells[6].Value.ToString();
                            pdfTable.AddCell(email);


                            string address = row.Cells[7].Value.ToString();
                            pdfTable.AddCell(address);

                            string depart = row.Cells[8].Value.ToString();
                            pdfTable.AddCell(depart);

                            string major= row.Cells[9].Value.ToString();
                            pdfTable.AddCell(major);


                            byte[] imageByte = (byte[])row.Cells[10].Value;
                            iTextSharp.text.Image Image = iTextSharp.text.Image.GetInstance(imageByte);
                            pdfTable.AddCell(Image);
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
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error :" + ex.Message);
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

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "Inventory_Adjustment_Export.xls";
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
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occurred while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
