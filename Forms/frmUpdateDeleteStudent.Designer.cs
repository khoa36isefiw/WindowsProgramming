namespace _20110375_HuynhDangKhoa_LoginForm
{
    partial class frmUpdateDeleteStudent
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
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpImage = new System.Windows.Forms.Button();
            this.picStudent = new System.Windows.Forms.PictureBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtMajor = new System.Windows.Forms.TextBox();
            this.lblStuPic = new System.Windows.Forms.Label();
            this.lblStuMajor = new System.Windows.Forms.Label();
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
            this.radbFemale = new System.Windows.Forms.RadioButton();
            this.radbMale = new System.Windows.Forms.RadioButton();
            this.btnFind = new System.Windows.Forms.Button();
            this.lblHome = new System.Windows.Forms.Label();
            this.cboHomeTown = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).BeginInit();
            this.grboGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(541, 400);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(163, 56);
            this.btnRemove.TabIndex = 54;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpImage
            // 
            this.btnUpImage.Location = new System.Drawing.Point(541, 314);
            this.btnUpImage.Name = "btnUpImage";
            this.btnUpImage.Size = new System.Drawing.Size(201, 24);
            this.btnUpImage.TabIndex = 52;
            this.btnUpImage.Text = "Upload Image";
            this.btnUpImage.UseVisualStyleBackColor = true;
            this.btnUpImage.Click += new System.EventHandler(this.btnUpImage_Click);
            // 
            // picStudent
            // 
            this.picStudent.Location = new System.Drawing.Point(541, 170);
            this.picStudent.Name = "picStudent";
            this.picStudent.Size = new System.Drawing.Size(201, 128);
            this.picStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStudent.TabIndex = 50;
            this.picStudent.TabStop = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.btnEdit.Location = new System.Drawing.Point(281, 400);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(163, 56);
            this.btnEdit.TabIndex = 53;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtMajor
            // 
            this.txtMajor.Location = new System.Drawing.Point(541, 128);
            this.txtMajor.Name = "txtMajor";
            this.txtMajor.Size = new System.Drawing.Size(201, 22);
            this.txtMajor.TabIndex = 47;
            // 
            // lblStuPic
            // 
            this.lblStuPic.AutoSize = true;
            this.lblStuPic.Location = new System.Drawing.Point(442, 170);
            this.lblStuPic.Name = "lblStuPic";
            this.lblStuPic.Size = new System.Drawing.Size(48, 16);
            this.lblStuPic.TabIndex = 40;
            this.lblStuPic.Text = "Picture";
            // 
            // lblStuMajor
            // 
            this.lblStuMajor.AutoSize = true;
            this.lblStuMajor.Location = new System.Drawing.Point(442, 131);
            this.lblStuMajor.Name = "lblStuMajor";
            this.lblStuMajor.Size = new System.Drawing.Size(41, 16);
            this.lblStuMajor.TabIndex = 39;
            this.lblStuMajor.Text = "Major";
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
            this.cboDepartment.Location = new System.Drawing.Point(541, 74);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(201, 24);
            this.cboDepartment.TabIndex = 72;
            this.cboDepartment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboDepartment_KeyDown);
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd-MM-yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(155, 151);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(201, 22);
            this.dtpDate.TabIndex = 70;
            this.dtpDate.Value = new System.DateTime(2011, 11, 11, 0, 0, 0, 0);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(541, 36);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(201, 22);
            this.txtAddress.TabIndex = 69;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(154, 298);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(201, 22);
            this.txtEmail.TabIndex = 68;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(154, 251);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(201, 22);
            this.txtPhone.TabIndex = 67;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(154, 112);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(201, 22);
            this.txtLastName.TabIndex = 66;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(154, 74);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(201, 22);
            this.txtFirstName.TabIndex = 65;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(154, 35);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(201, 22);
            this.txtStudentID.TabIndex = 64;
            // 
            // lblStuDepart
            // 
            this.lblStuDepart.AutoSize = true;
            this.lblStuDepart.Location = new System.Drawing.Point(442, 82);
            this.lblStuDepart.Name = "lblStuDepart";
            this.lblStuDepart.Size = new System.Drawing.Size(77, 16);
            this.lblStuDepart.TabIndex = 63;
            this.lblStuDepart.Text = "Department";
            // 
            // lblStuAddr
            // 
            this.lblStuAddr.AutoSize = true;
            this.lblStuAddr.Location = new System.Drawing.Point(442, 35);
            this.lblStuAddr.Name = "lblStuAddr";
            this.lblStuAddr.Size = new System.Drawing.Size(58, 16);
            this.lblStuAddr.TabIndex = 62;
            this.lblStuAddr.Text = "Address";
            // 
            // lblStuEmail
            // 
            this.lblStuEmail.AutoSize = true;
            this.lblStuEmail.Location = new System.Drawing.Point(55, 298);
            this.lblStuEmail.Name = "lblStuEmail";
            this.lblStuEmail.Size = new System.Drawing.Size(41, 16);
            this.lblStuEmail.TabIndex = 61;
            this.lblStuEmail.Text = "Email";
            // 
            // lblStuPhone
            // 
            this.lblStuPhone.AutoSize = true;
            this.lblStuPhone.Location = new System.Drawing.Point(55, 251);
            this.lblStuPhone.Name = "lblStuPhone";
            this.lblStuPhone.Size = new System.Drawing.Size(46, 16);
            this.lblStuPhone.TabIndex = 60;
            this.lblStuPhone.Text = "Phone";
            // 
            // lblStuGender
            // 
            this.lblStuGender.AutoSize = true;
            this.lblStuGender.Location = new System.Drawing.Point(55, 195);
            this.lblStuGender.Name = "lblStuGender";
            this.lblStuGender.Size = new System.Drawing.Size(52, 16);
            this.lblStuGender.TabIndex = 59;
            this.lblStuGender.Text = "Gender";
            // 
            // lblStuBirthDate
            // 
            this.lblStuBirthDate.AutoSize = true;
            this.lblStuBirthDate.Location = new System.Drawing.Point(55, 151);
            this.lblStuBirthDate.Name = "lblStuBirthDate";
            this.lblStuBirthDate.Size = new System.Drawing.Size(62, 16);
            this.lblStuBirthDate.TabIndex = 58;
            this.lblStuBirthDate.Text = "BirthDate";
            // 
            // lblStuLName
            // 
            this.lblStuLName.AutoSize = true;
            this.lblStuLName.Location = new System.Drawing.Point(55, 112);
            this.lblStuLName.Name = "lblStuLName";
            this.lblStuLName.Size = new System.Drawing.Size(72, 16);
            this.lblStuLName.TabIndex = 57;
            this.lblStuLName.Text = "Last Name";
            // 
            // lblStuFName
            // 
            this.lblStuFName.AutoSize = true;
            this.lblStuFName.Location = new System.Drawing.Point(55, 74);
            this.lblStuFName.Name = "lblStuFName";
            this.lblStuFName.Size = new System.Drawing.Size(72, 16);
            this.lblStuFName.TabIndex = 56;
            this.lblStuFName.Text = "First Name";
            // 
            // lblStuID
            // 
            this.lblStuID.AutoSize = true;
            this.lblStuID.Location = new System.Drawing.Point(55, 35);
            this.lblStuID.Name = "lblStuID";
            this.lblStuID.Size = new System.Drawing.Size(68, 16);
            this.lblStuID.TabIndex = 55;
            this.lblStuID.Text = "Student ID";
            // 
            // grboGender
            // 
            this.grboGender.Controls.Add(this.radbFemale);
            this.grboGender.Controls.Add(this.radbMale);
            this.grboGender.Location = new System.Drawing.Point(154, 195);
            this.grboGender.Name = "grboGender";
            this.grboGender.Size = new System.Drawing.Size(201, 40);
            this.grboGender.TabIndex = 71;
            this.grboGender.TabStop = false;
            this.grboGender.Text = "GroupGender";
            // 
            // radbFemale
            // 
            this.radbFemale.AutoSize = true;
            this.radbFemale.Location = new System.Drawing.Point(127, 14);
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
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.btnFind.Location = new System.Drawing.Point(21, 400);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(149, 56);
            this.btnFind.TabIndex = 73;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Location = new System.Drawing.Point(56, 348);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(44, 16);
            this.lblHome.TabIndex = 74;
            this.lblHome.Text = "Home";
            // 
            // cboHomeTown
            // 
            this.cboHomeTown.FormattingEnabled = true;
            this.cboHomeTown.Items.AddRange(new object[] {
            "An Giang",
            "Bà Rịa - Vũng Tàu",
            "Bắc Giang",
            "Bắc Kạn",
            "Bạc Liêu",
            "Bắc Ninh",
            "Bến Tre",
            "Bình Định",
            "Bình Dương",
            "Bình Phước",
            "Bình Thuận",
            "Cà Mau",
            "Cần Thơ ",
            "Cao Bằng",
            "Đà Nẵng",
            "Đắk Lắk",
            "Đắk Nông",
            "Điện Biên",
            "Đồng Nai",
            "Đồng Tháp",
            "Gia Lai",
            "Hà Giang",
            "Hải Dương",
            "Hải Phòng",
            "Hậu Giang",
            "Hà Nam",
            "Hà Nội ",
            "Hà Tĩnh",
            "Hòa Bình",
            "Hồ Chí Minh",
            "Hưng Yên",
            "Khánh Hòa",
            "Kiên Giang",
            "Kon Tum",
            "Lai Châu",
            "Lâm Đồng",
            "Lạng Sơn",
            "Lào Cai",
            "Long An",
            "Nam Định",
            "Nghệ An",
            "Ninh Bình",
            "Ninh Thuận",
            "Phú Thọ",
            "Phú Yên",
            "Quảng Bình",
            "Quảng Nam",
            "Quảng Ngãi",
            "Quảng Ninh",
            "Quảng Trị",
            "Sóc Trăng",
            "Sơn La",
            "Tây Ninh",
            "Thái Bình",
            "Thái Nguyên",
            "Thanh Hóa",
            "Thừa Thiên Huế",
            "Tiền Giang",
            "Trà Vinh",
            "Tuyên Quang",
            "Vĩnh Long",
            "Vĩnh Phúc",
            "Yên Bái"});
            this.cboHomeTown.Location = new System.Drawing.Point(155, 348);
            this.cboHomeTown.Name = "cboHomeTown";
            this.cboHomeTown.Size = new System.Drawing.Size(201, 24);
            this.cboHomeTown.TabIndex = 76;
            this.cboHomeTown.TextChanged += new System.EventHandler(this.cboHomeTown_TextChanged);
            // 
            // frmUpdateDeleteStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 552);
            this.Controls.Add(this.cboHomeTown);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(this.btnFind);
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
            this.Name = "frmUpdateDeleteStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUpdateDeleteStudent";
            this.Load += new System.EventHandler(this.frmUpdateDeleteStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).EndInit();
            this.grboGender.ResumeLayout(false);
            this.grboGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnUpImage;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblStuPic;
        private System.Windows.Forms.Label lblStuMajor;
        private System.Windows.Forms.Label lblStuDepart;
        private System.Windows.Forms.Label lblStuAddr;
        private System.Windows.Forms.Label lblStuEmail;
        private System.Windows.Forms.Label lblStuPhone;
        private System.Windows.Forms.Label lblStuGender;
        private System.Windows.Forms.Label lblStuBirthDate;
        private System.Windows.Forms.Label lblStuLName;
        private System.Windows.Forms.Label lblStuFName;
        private System.Windows.Forms.Label lblStuID;
        private System.Windows.Forms.Button btnFind;
        internal System.Windows.Forms.TextBox txtLastName;
        internal System.Windows.Forms.TextBox txtFirstName;
        internal System.Windows.Forms.PictureBox picStudent;
        internal System.Windows.Forms.TextBox txtMajor;
        internal System.Windows.Forms.ComboBox cboDepartment;
        internal System.Windows.Forms.DateTimePicker dtpDate;
        internal System.Windows.Forms.TextBox txtAddress;
        internal System.Windows.Forms.TextBox txtEmail;
        internal System.Windows.Forms.TextBox txtPhone;
        internal System.Windows.Forms.GroupBox grboGender;
        internal System.Windows.Forms.RadioButton radbFemale;
        internal System.Windows.Forms.RadioButton radbMale;
        public System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label lblHome;
        internal System.Windows.Forms.ComboBox cboHomeTown;
    }
}