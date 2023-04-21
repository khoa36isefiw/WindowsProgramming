namespace _20110375_HuynhDangKhoa_LoginForm
{
    partial class ClassStudentListForm
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
            this.dataGridView_ClassStudentLForm = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ClassStudentLForm)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_ClassStudentLForm
            // 
            this.dataGridView_ClassStudentLForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ClassStudentLForm.Location = new System.Drawing.Point(44, 35);
            this.dataGridView_ClassStudentLForm.Name = "dataGridView_ClassStudentLForm";
            this.dataGridView_ClassStudentLForm.RowHeadersWidth = 51;
            this.dataGridView_ClassStudentLForm.RowTemplate.Height = 24;
            this.dataGridView_ClassStudentLForm.Size = new System.Drawing.Size(698, 361);
            this.dataGridView_ClassStudentLForm.TabIndex = 0;
            // 
            // ClassStudentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_ClassStudentLForm);
            this.Name = "ClassStudentListForm";
            this.Text = "ClassStudentListForm";
            this.Load += new System.EventHandler(this.ClassStudentListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ClassStudentLForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_ClassStudentLForm;
    }
}