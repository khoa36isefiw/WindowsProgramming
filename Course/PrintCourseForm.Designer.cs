namespace _20110375_HuynhDangKhoa_LoginForm.Course
{
    partial class PrintCourseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGRV_Course = new System.Windows.Forms.DataGridView();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSVDataSetFull = new _20110375_HuynhDangKhoa_LoginForm.QLSVDataSetFull();
            this.btnToFile = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.courseTableAdapter = new _20110375_HuynhDangKhoa_LoginForm.QLSVDataSetFullTableAdapters.CourseTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGRV_Course)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSetFull)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGRV_Course
            // 
            this.dataGRV_Course.AutoGenerateColumns = false;
            this.dataGRV_Course.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGRV_Course.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGRV_Course.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.labelDataGridViewTextBoxColumn,
            this.periodDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGRV_Course.DataSource = this.courseBindingSource;
            this.dataGRV_Course.Location = new System.Drawing.Point(74, 12);
            this.dataGRV_Course.Name = "dataGRV_Course";
            this.dataGRV_Course.RowHeadersWidth = 51;
            this.dataGRV_Course.RowTemplate.Height = 24;
            this.dataGRV_Course.Size = new System.Drawing.Size(652, 314);
            this.dataGRV_Course.TabIndex = 0;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.qLSVDataSetFull;
            // 
            // qLSVDataSetFull
            // 
            this.qLSVDataSetFull.DataSetName = "QLSVDataSetFull";
            this.qLSVDataSetFull.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnToFile
            // 
            this.btnToFile.Location = new System.Drawing.Point(12, 381);
            this.btnToFile.Name = "btnToFile";
            this.btnToFile.Size = new System.Drawing.Size(121, 44);
            this.btnToFile.TabIndex = 1;
            this.btnToFile.Text = "To File";
            this.btnToFile.UseVisualStyleBackColor = true;
            this.btnToFile.Click += new System.EventHandler(this.btnToFile_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(203, 381);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(121, 44);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "STT";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // labelDataGridViewTextBoxColumn
            // 
            this.labelDataGridViewTextBoxColumn.DataPropertyName = "label";
            this.labelDataGridViewTextBoxColumn.HeaderText = "Course Name";
            this.labelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.labelDataGridViewTextBoxColumn.Name = "labelDataGridViewTextBoxColumn";
            // 
            // periodDataGridViewTextBoxColumn
            // 
            this.periodDataGridViewTextBoxColumn.DataPropertyName = "period";
            this.periodDataGridViewTextBoxColumn.HeaderText = "Duration";
            this.periodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.periodDataGridViewTextBoxColumn.Name = "periodDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Mo Ta";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // PrintCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnToFile);
            this.Controls.Add(this.dataGRV_Course);
            this.Name = "PrintCourseForm";
            this.Text = "PrintCourseForm";
            this.Load += new System.EventHandler(this.PrintCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGRV_Course)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSetFull)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGRV_Course;
        private System.Windows.Forms.Button btnToFile;
        private System.Windows.Forms.Button btnPrint;
        private QLSVDataSetFull qLSVDataSetFull;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private QLSVDataSetFullTableAdapters.CourseTableAdapter courseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn labelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}