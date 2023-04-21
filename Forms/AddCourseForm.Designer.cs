namespace _20110375_HuynhDangKhoa_LoginForm.Forms
{
    partial class SelectedCourse
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
            this.lblSelectedCourse = new System.Windows.Forms.Label();
            this.lblSeectedSemester = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.cboSelectedSemeter = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.listBoxAvailableCourse = new System.Windows.Forms.ListBox();
            this.listBoxSelectedCourse = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
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
            // lblSelectedCourse
            // 
            this.lblSelectedCourse.AutoSize = true;
            this.lblSelectedCourse.Location = new System.Drawing.Point(424, 124);
            this.lblSelectedCourse.Name = "lblSelectedCourse";
            this.lblSelectedCourse.Size = new System.Drawing.Size(110, 16);
            this.lblSelectedCourse.TabIndex = 2;
            this.lblSelectedCourse.Text = "Selected Course:";
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
            this.txtStudentId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtStudentId.Location = new System.Drawing.Point(117, 38);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(100, 22);
            this.txtStudentId.TabIndex = 4;
            this.txtStudentId.TextChanged += new System.EventHandler(this.txtStudentId_TextChanged);
            // 
            // cboSelectedSemeter
            // 
            this.cboSelectedSemeter.FormattingEnabled = true;
            this.cboSelectedSemeter.Items.AddRange(new object[] {
            "HK1",
            "HK2"});
            this.cboSelectedSemeter.Location = new System.Drawing.Point(427, 38);
            this.cboSelectedSemeter.Name = "cboSelectedSemeter";
            this.cboSelectedSemeter.Size = new System.Drawing.Size(121, 24);
            this.cboSelectedSemeter.TabIndex = 7;
            this.cboSelectedSemeter.SelectedIndexChanged += new System.EventHandler(this.cboSelectedSemeter_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(269, 160);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 42);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(269, 293);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 42);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // listBoxAvailableCourse
            // 
            this.listBoxAvailableCourse.FormattingEnabled = true;
            this.listBoxAvailableCourse.ItemHeight = 16;
            this.listBoxAvailableCourse.Items.AddRange(new object[] {
            "Artificial Intelligence",
            "Data Structure",
            "OOP",
            "Winforms",
            "Web Programming",
            "Mobile Programming"});
            this.listBoxAvailableCourse.Location = new System.Drawing.Point(24, 160);
            this.listBoxAvailableCourse.Name = "listBoxAvailableCourse";
            this.listBoxAvailableCourse.Size = new System.Drawing.Size(206, 180);
            this.listBoxAvailableCourse.TabIndex = 11;
            this.listBoxAvailableCourse.SelectedIndexChanged += new System.EventHandler(this.listBoxAvailableCourse_SelectedIndexChanged);
            // 
            // listBoxSelectedCourse
            // 
            this.listBoxSelectedCourse.FormattingEnabled = true;
            this.listBoxSelectedCourse.ItemHeight = 16;
            this.listBoxSelectedCourse.Location = new System.Drawing.Point(395, 160);
            this.listBoxSelectedCourse.Name = "listBoxSelectedCourse";
            this.listBoxSelectedCourse.Size = new System.Drawing.Size(193, 180);
            this.listBoxSelectedCourse.TabIndex = 12;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(269, 225);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(83, 42);
            this.btnRemove.TabIndex = 13;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // SelectedCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 387);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.listBoxSelectedCourse);
            this.Controls.Add(this.listBoxAvailableCourse);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cboSelectedSemeter);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.lblSeectedSemester);
            this.Controls.Add(this.lblSelectedCourse);
            this.Controls.Add(this.lblAvailableCourse);
            this.Controls.Add(this.lblStudentID);
            this.Name = "SelectedCourse";
            this.Text = "AddFormCourse";
            this.Load += new System.EventHandler(this.AddCourseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblAvailableCourse;
        private System.Windows.Forms.Label lblSelectedCourse;
        private System.Windows.Forms.Label lblSeectedSemester;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.ComboBox cboSelectedSemeter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox listBoxAvailableCourse;
        private System.Windows.Forms.ListBox listBoxSelectedCourse;
        private System.Windows.Forms.Button btnRemove;
    }
}