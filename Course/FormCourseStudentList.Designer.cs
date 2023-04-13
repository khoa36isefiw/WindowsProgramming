namespace _20110375_HuynhDangKhoa_LoginForm.Course
{
    partial class FormCourseStudentList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCourseStudentList));
            this.dataGridViewStudentList = new System.Windows.Forms.DataGridView();
            this.txtCourseName2 = new System.Windows.Forms.TextBox();
            this.lblShow = new System.Windows.Forms.Label();
            this.lblCourseLabel = new System.Windows.Forms.Label();
            this.lblSeme = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStudentList
            // 
            this.dataGridViewStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentList.Location = new System.Drawing.Point(59, 86);
            this.dataGridViewStudentList.Name = "dataGridViewStudentList";
            this.dataGridViewStudentList.RowHeadersWidth = 51;
            this.dataGridViewStudentList.RowTemplate.Height = 24;
            this.dataGridViewStudentList.Size = new System.Drawing.Size(684, 309);
            this.dataGridViewStudentList.TabIndex = 0;
            this.dataGridViewStudentList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudentList_CellContentClick);
            // 
            // txtCourseName2
            // 
            this.txtCourseName2.BackColor = System.Drawing.Color.White;
            this.txtCourseName2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCourseName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseName2.ForeColor = System.Drawing.Color.Black;
            this.txtCourseName2.Location = new System.Drawing.Point(221, 41);
            this.txtCourseName2.Multiline = true;
            this.txtCourseName2.Name = "txtCourseName2";
            this.txtCourseName2.Size = new System.Drawing.Size(203, 30);
            this.txtCourseName2.TabIndex = 1;
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.BackColor = System.Drawing.Color.Yellow;
            this.lblShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShow.Location = new System.Drawing.Point(630, 46);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(104, 25);
            this.lblShow.TabIndex = 2;
            this.lblShow.Text = "Semester";
            // 
            // lblCourseLabel
            // 
            this.lblCourseLabel.AutoSize = true;
            this.lblCourseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseLabel.Location = new System.Drawing.Point(54, 41);
            this.lblCourseLabel.Name = "lblCourseLabel";
            this.lblCourseLabel.Size = new System.Drawing.Size(144, 25);
            this.lblCourseLabel.TabIndex = 3;
            this.lblCourseLabel.Text = "Course Name";
            // 
            // lblSeme
            // 
            this.lblSeme.AutoSize = true;
            this.lblSeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeme.Location = new System.Drawing.Point(497, 46);
            this.lblSeme.Name = "lblSeme";
            this.lblSeme.Size = new System.Drawing.Size(111, 25);
            this.lblSeme.TabIndex = 4;
            this.lblSeme.Text = "Semester:";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(59, 442);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(170, 54);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Export to Word";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(573, 442);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(170, 54);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Exit";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormCourseStudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(767, 542);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblSeme);
            this.Controls.Add(this.lblCourseLabel);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.txtCourseName2);
            this.Controls.Add(this.dataGridViewStudentList);
            this.Name = "FormCourseStudentList";
            this.Text = "FormCourseStudentList";
            this.Load += new System.EventHandler(this.FormCourseStudentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStudentList;
        internal System.Windows.Forms.TextBox txtCourseName2;
        internal System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Label lblCourseLabel;
        private System.Windows.Forms.Label lblSeme;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnCancel;
    }
}