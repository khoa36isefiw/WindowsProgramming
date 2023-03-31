namespace _20110375_HuynhDangKhoa_LoginForm
{
    partial class frmManageStudent
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.radbFemale = new System.Windows.Forms.RadioButton();
            this.radbMale = new System.Windows.Forms.RadioButton();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lblStuDepart = new System.Windows.Forms.Label();
            this.lblStuAddr = new System.Windows.Forms.Label();
            this.lblStuEmail = new System.Windows.Forms.Label();
            this.lblStuPhone = new System.Windows.Forms.Label();
            this.lblStuGender = new System.Windows.Forms.Label();
            this.lblStuBirthDate = new System.Windows.Forms.Label();
            this.lblStuLName = new System.Windows.Forms.Label();
            this.lblStuFName = new System.Windows.Forms.Label();
            this.lblStuID = new System.Windows.Forms.Label();
            this.grboGender = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpImage = new System.Windows.Forms.Button();
            this.picStudent = new System.Windows.Forms.PictureBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtMajor = new System.Windows.Forms.TextBox();
            this.lblStuPic = new System.Windows.Forms.Label();
            this.lblStuMajor = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.dataGVManageStudent = new System.Windows.Forms.DataGridView();
            this.lblTotalStudent = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.txtHomeTown = new System.Windows.Forms.TextBox();
            this.lblHomeTown = new System.Windows.Forms.Label();
            this.grboGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVManageStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.btnAdd.Location = new System.Drawing.Point(28, 650);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(77, 43);
            this.btnAdd.TabIndex = 99;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // radbFemale
            // 
            this.radbFemale.AutoSize = true;
            this.radbFemale.Location = new System.Drawing.Point(117, 14);
            this.radbFemale.Name = "radbFemale";
            this.radbFemale.Size = new System.Drawing.Size(74, 20);
            this.radbFemale.TabIndex = 1;
            this.radbFemale.TabStop = true;
            this.radbFemale.Text = "Female";
            this.radbFemale.UseVisualStyleBackColor = true;
            // 
            // radbMale
            // 
            this.radbMale.AutoSize = true;
            this.radbMale.Location = new System.Drawing.Point(7, 14);
            this.radbMale.Name = "radbMale";
            this.radbMale.Size = new System.Drawing.Size(58, 20);
            this.radbMale.TabIndex = 0;
            this.radbMale.TabStop = true;
            this.radbMale.Text = "Male";
            this.radbMale.UseVisualStyleBackColor = true;
            // 
            // cboDepartment
            // 
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Items.AddRange(new object[] {
            "Khoa ĐT CLC",
            "Khoa CNTT",
            "Khoa Điện - Điện Điện Tử",
            "Khoa Du Lịch",
            "Khoa In và Truyền Thông",
            "Khoa Xây Dựng",
            "Khoa Ngoại Ngữ",
            "Khoa Kinh Tế"});
            this.cboDepartment.Location = new System.Drawing.Point(108, 349);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(192, 24);
            this.cboDepartment.TabIndex = 98;
            this.cboDepartment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboDepartment_KeyDown_1);
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd-MM-yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(109, 127);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(191, 22);
            this.dtpDate.TabIndex = 96;
            this.dtpDate.Value = new System.DateTime(2011, 11, 11, 0, 0, 0, 0);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(108, 311);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(192, 22);
            this.txtAddress.TabIndex = 95;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(108, 274);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(192, 22);
            this.txtEmail.TabIndex = 94;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(108, 227);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(192, 22);
            this.txtPhone.TabIndex = 93;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(108, 88);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(192, 22);
            this.txtLastName.TabIndex = 92;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(108, 50);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(192, 22);
            this.txtFirstName.TabIndex = 91;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(108, 11);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(192, 22);
            this.txtStudentID.TabIndex = 90;
            // 
            // lblStuDepart
            // 
            this.lblStuDepart.AutoSize = true;
            this.lblStuDepart.Location = new System.Drawing.Point(9, 352);
            this.lblStuDepart.Name = "lblStuDepart";
            this.lblStuDepart.Size = new System.Drawing.Size(77, 16);
            this.lblStuDepart.TabIndex = 89;
            this.lblStuDepart.Text = "Department";
            // 
            // lblStuAddr
            // 
            this.lblStuAddr.AutoSize = true;
            this.lblStuAddr.Location = new System.Drawing.Point(9, 310);
            this.lblStuAddr.Name = "lblStuAddr";
            this.lblStuAddr.Size = new System.Drawing.Size(58, 16);
            this.lblStuAddr.TabIndex = 88;
            this.lblStuAddr.Text = "Address";
            // 
            // lblStuEmail
            // 
            this.lblStuEmail.AutoSize = true;
            this.lblStuEmail.Location = new System.Drawing.Point(9, 274);
            this.lblStuEmail.Name = "lblStuEmail";
            this.lblStuEmail.Size = new System.Drawing.Size(41, 16);
            this.lblStuEmail.TabIndex = 87;
            this.lblStuEmail.Text = "Email";
            // 
            // lblStuPhone
            // 
            this.lblStuPhone.AutoSize = true;
            this.lblStuPhone.Location = new System.Drawing.Point(9, 227);
            this.lblStuPhone.Name = "lblStuPhone";
            this.lblStuPhone.Size = new System.Drawing.Size(46, 16);
            this.lblStuPhone.TabIndex = 86;
            this.lblStuPhone.Text = "Phone";
            // 
            // lblStuGender
            // 
            this.lblStuGender.AutoSize = true;
            this.lblStuGender.Location = new System.Drawing.Point(9, 171);
            this.lblStuGender.Name = "lblStuGender";
            this.lblStuGender.Size = new System.Drawing.Size(52, 16);
            this.lblStuGender.TabIndex = 85;
            this.lblStuGender.Text = "Gender";
            // 
            // lblStuBirthDate
            // 
            this.lblStuBirthDate.AutoSize = true;
            this.lblStuBirthDate.Location = new System.Drawing.Point(9, 127);
            this.lblStuBirthDate.Name = "lblStuBirthDate";
            this.lblStuBirthDate.Size = new System.Drawing.Size(62, 16);
            this.lblStuBirthDate.TabIndex = 84;
            this.lblStuBirthDate.Text = "BirthDate";
            // 
            // lblStuLName
            // 
            this.lblStuLName.AutoSize = true;
            this.lblStuLName.Location = new System.Drawing.Point(9, 88);
            this.lblStuLName.Name = "lblStuLName";
            this.lblStuLName.Size = new System.Drawing.Size(72, 16);
            this.lblStuLName.TabIndex = 83;
            this.lblStuLName.Text = "Last Name";
            // 
            // lblStuFName
            // 
            this.lblStuFName.AutoSize = true;
            this.lblStuFName.Location = new System.Drawing.Point(9, 50);
            this.lblStuFName.Name = "lblStuFName";
            this.lblStuFName.Size = new System.Drawing.Size(72, 16);
            this.lblStuFName.TabIndex = 82;
            this.lblStuFName.Text = "First Name";
            // 
            // lblStuID
            // 
            this.lblStuID.AutoSize = true;
            this.lblStuID.Location = new System.Drawing.Point(9, 11);
            this.lblStuID.Name = "lblStuID";
            this.lblStuID.Size = new System.Drawing.Size(68, 16);
            this.lblStuID.TabIndex = 81;
            this.lblStuID.Text = "Student ID";
            // 
            // grboGender
            // 
            this.grboGender.Controls.Add(this.radbFemale);
            this.grboGender.Controls.Add(this.radbMale);
            this.grboGender.Location = new System.Drawing.Point(109, 171);
            this.grboGender.Name = "grboGender";
            this.grboGender.Size = new System.Drawing.Size(191, 40);
            this.grboGender.TabIndex = 97;
            this.grboGender.TabStop = false;
            this.grboGender.Text = "GroupGender";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(28, 716);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(91, 43);
            this.btnRemove.TabIndex = 80;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpImage
            // 
            this.btnUpImage.Location = new System.Drawing.Point(108, 569);
            this.btnUpImage.Name = "btnUpImage";
            this.btnUpImage.Size = new System.Drawing.Size(94, 24);
            this.btnUpImage.TabIndex = 78;
            this.btnUpImage.Text = "Upload";
            this.btnUpImage.UseVisualStyleBackColor = true;
            this.btnUpImage.Click += new System.EventHandler(this.btnUpImage_Click);
            // 
            // picStudent
            // 
            this.picStudent.Location = new System.Drawing.Point(108, 427);
            this.picStudent.Name = "picStudent";
            this.picStudent.Size = new System.Drawing.Size(192, 128);
            this.picStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStudent.TabIndex = 77;
            this.picStudent.TabStop = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.btnEdit.Location = new System.Drawing.Point(178, 650);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(91, 43);
            this.btnEdit.TabIndex = 79;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtMajor
            // 
            this.txtMajor.Location = new System.Drawing.Point(108, 391);
            this.txtMajor.Name = "txtMajor";
            this.txtMajor.Size = new System.Drawing.Size(192, 22);
            this.txtMajor.TabIndex = 76;
            // 
            // lblStuPic
            // 
            this.lblStuPic.AutoSize = true;
            this.lblStuPic.Location = new System.Drawing.Point(9, 427);
            this.lblStuPic.Name = "lblStuPic";
            this.lblStuPic.Size = new System.Drawing.Size(48, 16);
            this.lblStuPic.TabIndex = 75;
            this.lblStuPic.Text = "Picture";
            // 
            // lblStuMajor
            // 
            this.lblStuMajor.AutoSize = true;
            this.lblStuMajor.Location = new System.Drawing.Point(9, 391);
            this.lblStuMajor.Name = "lblStuMajor";
            this.lblStuMajor.Size = new System.Drawing.Size(41, 16);
            this.lblStuMajor.TabIndex = 74;
            this.lblStuMajor.Text = "Major";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(178, 716);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(91, 43);
            this.btnReset.TabIndex = 100;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dataGVManageStudent
            // 
            this.dataGVManageStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGVManageStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVManageStudent.Location = new System.Drawing.Point(328, 53);
            this.dataGVManageStudent.Name = "dataGVManageStudent";
            this.dataGVManageStudent.RowHeadersWidth = 51;
            this.dataGVManageStudent.RowTemplate.Height = 24;
            this.dataGVManageStudent.Size = new System.Drawing.Size(1216, 640);
            this.dataGVManageStudent.TabIndex = 101;
            this.dataGVManageStudent.Click += new System.EventHandler(this.dataGVManageStudent_Click);
            // 
            // lblTotalStudent
            // 
            this.lblTotalStudent.BackColor = System.Drawing.Color.Aqua;
            this.lblTotalStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalStudent.Location = new System.Drawing.Point(867, 721);
            this.lblTotalStudent.Name = "lblTotalStudent";
            this.lblTotalStudent.Size = new System.Drawing.Size(313, 40);
            this.lblTotalStudent.TabIndex = 102;
            this.lblTotalStudent.Text = "Total Student: 10";
            this.lblTotalStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(596, 22);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(154, 16);
            this.lblSearch.TabIndex = 103;
            this.lblSearch.Text = "Enter A Value To Search";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1074, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(106, 42);
            this.btnSearch.TabIndex = 104;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(848, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(195, 22);
            this.txtSearch.TabIndex = 105;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(208, 568);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(92, 25);
            this.btnDownload.TabIndex = 106;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // txtHomeTown
            // 
            this.txtHomeTown.Location = new System.Drawing.Point(108, 613);
            this.txtHomeTown.Name = "txtHomeTown";
            this.txtHomeTown.Size = new System.Drawing.Size(191, 22);
            this.txtHomeTown.TabIndex = 107;
            // 
            // lblHomeTown
            // 
            this.lblHomeTown.AutoSize = true;
            this.lblHomeTown.Location = new System.Drawing.Point(9, 613);
            this.lblHomeTown.Name = "lblHomeTown";
            this.lblHomeTown.Size = new System.Drawing.Size(44, 16);
            this.lblHomeTown.TabIndex = 108;
            this.lblHomeTown.Text = "Home";
            // 
            // frmManageStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1559, 768);
            this.Controls.Add(this.lblHomeTown);
            this.Controls.Add(this.txtHomeTown);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblTotalStudent);
            this.Controls.Add(this.dataGVManageStudent);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cboDepartment);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.lblStuDepart);
            this.Controls.Add(this.lblStuAddr);
            this.Controls.Add(this.lblStuEmail);
            this.Controls.Add(this.lblStuPhone);
            this.Controls.Add(this.lblStuGender);
            this.Controls.Add(this.lblStuBirthDate);
            this.Controls.Add(this.lblStuLName);
            this.Controls.Add(this.lblStuFName);
            this.Controls.Add(this.lblStuID);
            this.Controls.Add(this.grboGender);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnUpImage);
            this.Controls.Add(this.picStudent);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtMajor);
            this.Controls.Add(this.lblStuPic);
            this.Controls.Add(this.lblStuMajor);
            this.Name = "frmManageStudent";
            this.Text = "frmManageStudent";
            this.Load += new System.EventHandler(this.frmManageStudent_Load);
            this.grboGender.ResumeLayout(false);
            this.grboGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVManageStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        internal System.Windows.Forms.RadioButton radbFemale;
        internal System.Windows.Forms.RadioButton radbMale;
        internal System.Windows.Forms.ComboBox cboDepartment;
        internal System.Windows.Forms.DateTimePicker dtpDate;
        internal System.Windows.Forms.TextBox txtAddress;
        internal System.Windows.Forms.TextBox txtEmail;
        internal System.Windows.Forms.TextBox txtPhone;
        internal System.Windows.Forms.TextBox txtLastName;
        internal System.Windows.Forms.TextBox txtFirstName;
        public System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label lblStuDepart;
        private System.Windows.Forms.Label lblStuAddr;
        private System.Windows.Forms.Label lblStuEmail;
        private System.Windows.Forms.Label lblStuPhone;
        private System.Windows.Forms.Label lblStuGender;
        private System.Windows.Forms.Label lblStuBirthDate;
        private System.Windows.Forms.Label lblStuLName;
        private System.Windows.Forms.Label lblStuFName;
        private System.Windows.Forms.Label lblStuID;
        internal System.Windows.Forms.GroupBox grboGender;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnUpImage;
        internal System.Windows.Forms.PictureBox picStudent;
        private System.Windows.Forms.Button btnEdit;
        internal System.Windows.Forms.TextBox txtMajor;
        private System.Windows.Forms.Label lblStuPic;
        private System.Windows.Forms.Label lblStuMajor;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dataGVManageStudent;
        private System.Windows.Forms.Label lblTotalStudent;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Label lblHomeTown;
        internal System.Windows.Forms.TextBox txtHomeTown;
    }
}