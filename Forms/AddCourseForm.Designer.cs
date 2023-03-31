namespace _20110375_HuynhDangKhoa_LoginForm.Forms
{
    partial class AddCourseForm
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
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblAvailableCourse = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSeectedSemester = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.txtAvailableCourse = new System.Windows.Forms.TextBox();
            this.cboSelectedSemeter = new System.Windows.Forms.ComboBox();
            this.txtSelectedCourse = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(21, 41);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(71, 16);
            this.lblStudentID.TabIndex = 0;
            this.lblStudentID.Text = "Student ID:";
            // 
            // lblAvailableCourse
            // 
            this.lblAvailableCourse.AutoSize = true;
            this.lblAvailableCourse.Location = new System.Drawing.Point(85, 124);
            this.lblAvailableCourse.Name = "lblAvailableCourse";
            this.lblAvailableCourse.Size = new System.Drawing.Size(113, 16);
            this.lblAvailableCourse.TabIndex = 1;
            this.lblAvailableCourse.Text = "Available Course:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Selected Course:";
            // 
            // lblSeectedSemester
            // 
            this.lblSeectedSemester.AutoSize = true;
            this.lblSeectedSemester.Location = new System.Drawing.Point(282, 41);
            this.lblSeectedSemester.Name = "lblSeectedSemester";
            this.lblSeectedSemester.Size = new System.Drawing.Size(125, 16);
            this.lblSeectedSemester.TabIndex = 3;
            this.lblSeectedSemester.Text = "Selected Semester:";
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(117, 38);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(100, 22);
            this.txtStudentId.TabIndex = 4;
            // 
            // txtAvailableCourse
            // 
            this.txtAvailableCourse.Location = new System.Drawing.Point(50, 160);
            this.txtAvailableCourse.Multiline = true;
            this.txtAvailableCourse.Name = "txtAvailableCourse";
            this.txtAvailableCourse.Size = new System.Drawing.Size(180, 164);
            this.txtAvailableCourse.TabIndex = 5;
            // 
            // cboSelectedSemeter
            // 
            this.cboSelectedSemeter.FormattingEnabled = true;
            this.cboSelectedSemeter.Location = new System.Drawing.Point(427, 38);
            this.cboSelectedSemeter.Name = "cboSelectedSemeter";
            this.cboSelectedSemeter.Size = new System.Drawing.Size(121, 24);
            this.cboSelectedSemeter.TabIndex = 7;
            // 
            // txtSelectedCourse
            // 
            this.txtSelectedCourse.Location = new System.Drawing.Point(377, 160);
            this.txtSelectedCourse.Multiline = true;
            this.txtSelectedCourse.Name = "txtSelectedCourse";
            this.txtSelectedCourse.Size = new System.Drawing.Size(180, 164);
            this.txtSelectedCourse.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(265, 160);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 42);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(265, 267);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 42);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // AddCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 387);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSelectedCourse);
            this.Controls.Add(this.cboSelectedSemeter);
            this.Controls.Add(this.txtAvailableCourse);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.lblSeectedSemester);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAvailableCourse);
            this.Controls.Add(this.lblStudentID);
            this.Name = "AddCourseForm";
            this.Text = "AddFormCourse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblAvailableCourse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSeectedSemester;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.TextBox txtAvailableCourse;
        private System.Windows.Forms.ComboBox cboSelectedSemeter;
        private System.Windows.Forms.TextBox txtSelectedCourse;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
    }
}