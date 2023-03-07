namespace _20110375_HuynhDangKhoa_LoginForm
{
    partial class frmFindStudent
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
            this.lbl_StudentID = new System.Windows.Forms.Label();
            this.btn_Find = new System.Windows.Forms.Button();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.dataGRV_StudentFound = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGRV_StudentFound)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_StudentID
            // 
            this.lbl_StudentID.AutoSize = true;
            this.lbl_StudentID.Location = new System.Drawing.Point(5, 15);
            this.lbl_StudentID.Name = "lbl_StudentID";
            this.lbl_StudentID.Size = new System.Drawing.Size(68, 16);
            this.lbl_StudentID.TabIndex = 0;
            this.lbl_StudentID.Text = "Student ID";
            // 
            // btn_Find
            // 
            this.btn_Find.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(194)))), ((int)(((byte)(233)))));
            this.btn_Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Find.Location = new System.Drawing.Point(23, 212);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(117, 57);
            this.btn_Find.TabIndex = 1;
            this.btn_Find.Text = "Find";
            this.btn_Find.UseVisualStyleBackColor = false;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(91, 12);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(82, 22);
            this.txtStudentID.TabIndex = 2;
            // 
            // dataGRV_StudentFound
            // 
            this.dataGRV_StudentFound.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGRV_StudentFound.Location = new System.Drawing.Point(189, 12);
            this.dataGRV_StudentFound.Name = "dataGRV_StudentFound";
            this.dataGRV_StudentFound.RowHeadersWidth = 51;
            this.dataGRV_StudentFound.RowTemplate.Height = 24;
            this.dataGRV_StudentFound.Size = new System.Drawing.Size(1193, 593);
            this.dataGRV_StudentFound.TabIndex = 3;
            // 
            // frmFindStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 617);
            this.Controls.Add(this.dataGRV_StudentFound);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.btn_Find);
            this.Controls.Add(this.lbl_StudentID);
            this.Name = "frmFindStudent";
            this.Text = "frmFindStudent";
            ((System.ComponentModel.ISupportInitialize)(this.dataGRV_StudentFound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_StudentID;
        private System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.DataGridView dataGRV_StudentFound;
    }
}