namespace _20110375_HuynhDangKhoa_LoginForm.Course
{
    partial class frmEditCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditCourse));
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSelectCourse = new System.Windows.Forms.Label();
            this.txtCourseDescription = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.numericUpDownPeriod = new System.Windows.Forms.NumericUpDown();
            this.cboSelectCourse = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeriod)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(182)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(193, 338);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(230, 42);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(46, 217);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(120, 25);
            this.lblDescription.TabIndex = 16;
            this.lblDescription.Text = "Description";
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriod.Location = new System.Drawing.Point(92, 151);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(74, 25);
            this.lblPeriod.TabIndex = 15;
            this.lblPeriod.Text = "Period";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(31, 86);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(144, 25);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Course Name";
            // 
            // lblSelectCourse
            // 
            this.lblSelectCourse.AutoSize = true;
            this.lblSelectCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCourse.Location = new System.Drawing.Point(26, 35);
            this.lblSelectCourse.Name = "lblSelectCourse";
            this.lblSelectCourse.Size = new System.Drawing.Size(149, 25);
            this.lblSelectCourse.TabIndex = 13;
            this.lblSelectCourse.Text = "Select Course";
            // 
            // txtCourseDescription
            // 
            this.txtCourseDescription.Location = new System.Drawing.Point(193, 217);
            this.txtCourseDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCourseDescription.Multiline = true;
            this.txtCourseDescription.Name = "txtCourseDescription";
            this.txtCourseDescription.Size = new System.Drawing.Size(230, 87);
            this.txtCourseDescription.TabIndex = 12;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(193, 86);
            this.txtCourseName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(160, 22);
            this.txtCourseName.TabIndex = 10;
            // 
            // numericUpDownPeriod
            // 
            this.numericUpDownPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownPeriod.Location = new System.Drawing.Point(193, 148);
            this.numericUpDownPeriod.Name = "numericUpDownPeriod";
            this.numericUpDownPeriod.Size = new System.Drawing.Size(120, 28);
            this.numericUpDownPeriod.TabIndex = 18;
            this.numericUpDownPeriod.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // cboSelectCourse
            // 
            this.cboSelectCourse.FormattingEnabled = true;
            this.cboSelectCourse.Location = new System.Drawing.Point(193, 36);
            this.cboSelectCourse.Name = "cboSelectCourse";
            this.cboSelectCourse.Size = new System.Drawing.Size(160, 24);
            this.cboSelectCourse.TabIndex = 19;
            this.cboSelectCourse.SelectedIndexChanged += new System.EventHandler(this.cboSelectCourse_SelectedIndexChanged);
            // 
            // frmEditCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 457);
            this.Controls.Add(this.cboSelectCourse);
            this.Controls.Add(this.numericUpDownPeriod);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblPeriod);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblSelectCourse);
            this.Controls.Add(this.txtCourseDescription);
            this.Controls.Add(this.txtCourseName);
            this.Name = "frmEditCourse";
            this.Text = "EditCourse";
            this.Load += new System.EventHandler(this.frmEditCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeriod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSelectCourse;
        private System.Windows.Forms.TextBox txtCourseDescription;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.NumericUpDown numericUpDownPeriod;
        private System.Windows.Forms.ComboBox cboSelectCourse;
    }
}