namespace _20110375_HuynhDangKhoa_LoginForm
{
    partial class frmAddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddStudent));
            this.lblStuID = new System.Windows.Forms.Label();
            this.lblStuFName = new System.Windows.Forms.Label();
            this.lblStuLName = new System.Windows.Forms.Label();
            this.lblStuBirthDate = new System.Windows.Forms.Label();
            this.lblStuGender = new System.Windows.Forms.Label();
            this.lblStuPhone = new System.Windows.Forms.Label();
            this.lblStuEmail = new System.Windows.Forms.Label();
            this.lblStuAddr = new System.Windows.Forms.Label();
            this.lblStuDepart = new System.Windows.Forms.Label();
            this.lblStuMajor = new System.Windows.Forms.Label();
            this.lblStuPic = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.grboGender = new System.Windows.Forms.GroupBox();
            this.radbFemale = new System.Windows.Forms.RadioButton();
            this.radbMale = new System.Windows.Forms.RadioButton();
            this.picStudent = new System.Windows.Forms.PictureBox();
            this.pictBackgroundAddStudent = new System.Windows.Forms.PictureBox();
            this.txtStudentID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddStudent = new Guna.UI2.WinForms.Guna2Button();
            this.txtLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMajor = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboDepartment = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnUpImage = new Guna.UI2.WinForms.Guna2Button();
            this.grboGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBackgroundAddStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStuID
            // 
            this.lblStuID.AutoSize = true;
            this.lblStuID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.lblStuID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStuID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(59)))));
            this.lblStuID.Location = new System.Drawing.Point(8, 25);
            this.lblStuID.Name = "lblStuID";
            this.lblStuID.Size = new System.Drawing.Size(88, 20);
            this.lblStuID.TabIndex = 0;
            this.lblStuID.Text = "Student ID";
            // 
            // lblStuFName
            // 
            this.lblStuFName.AutoSize = true;
            this.lblStuFName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.lblStuFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStuFName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(59)))));
            this.lblStuFName.Location = new System.Drawing.Point(8, 55);
            this.lblStuFName.Name = "lblStuFName";
            this.lblStuFName.Size = new System.Drawing.Size(92, 20);
            this.lblStuFName.TabIndex = 1;
            this.lblStuFName.Text = "First Name";
            // 
            // lblStuLName
            // 
            this.lblStuLName.AutoSize = true;
            this.lblStuLName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.lblStuLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStuLName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(59)))));
            this.lblStuLName.Location = new System.Drawing.Point(8, 93);
            this.lblStuLName.Name = "lblStuLName";
            this.lblStuLName.Size = new System.Drawing.Size(91, 20);
            this.lblStuLName.TabIndex = 2;
            this.lblStuLName.Text = "Last Name";
            // 
            // lblStuBirthDate
            // 
            this.lblStuBirthDate.AutoSize = true;
            this.lblStuBirthDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.lblStuBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStuBirthDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(59)))));
            this.lblStuBirthDate.Location = new System.Drawing.Point(8, 132);
            this.lblStuBirthDate.Name = "lblStuBirthDate";
            this.lblStuBirthDate.Size = new System.Drawing.Size(81, 20);
            this.lblStuBirthDate.TabIndex = 3;
            this.lblStuBirthDate.Text = "BirthDate";
            // 
            // lblStuGender
            // 
            this.lblStuGender.AutoSize = true;
            this.lblStuGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(55)))), ((int)(((byte)(85)))));
            this.lblStuGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStuGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(59)))));
            this.lblStuGender.Location = new System.Drawing.Point(8, 190);
            this.lblStuGender.Name = "lblStuGender";
            this.lblStuGender.Size = new System.Drawing.Size(64, 20);
            this.lblStuGender.TabIndex = 4;
            this.lblStuGender.Text = "Gender";
            // 
            // lblStuPhone
            // 
            this.lblStuPhone.AutoSize = true;
            this.lblStuPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(55)))), ((int)(((byte)(85)))));
            this.lblStuPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStuPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(59)))));
            this.lblStuPhone.Location = new System.Drawing.Point(8, 262);
            this.lblStuPhone.Name = "lblStuPhone";
            this.lblStuPhone.Size = new System.Drawing.Size(56, 20);
            this.lblStuPhone.TabIndex = 5;
            this.lblStuPhone.Text = "Phone";
            // 
            // lblStuEmail
            // 
            this.lblStuEmail.AutoSize = true;
            this.lblStuEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.lblStuEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStuEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(59)))));
            this.lblStuEmail.Location = new System.Drawing.Point(8, 320);
            this.lblStuEmail.Name = "lblStuEmail";
            this.lblStuEmail.Size = new System.Drawing.Size(51, 20);
            this.lblStuEmail.TabIndex = 6;
            this.lblStuEmail.Text = "Email";
            // 
            // lblStuAddr
            // 
            this.lblStuAddr.AutoSize = true;
            this.lblStuAddr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(46)))), ((int)(((byte)(61)))));
            this.lblStuAddr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStuAddr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(59)))));
            this.lblStuAddr.Location = new System.Drawing.Point(425, 22);
            this.lblStuAddr.Name = "lblStuAddr";
            this.lblStuAddr.Size = new System.Drawing.Size(71, 20);
            this.lblStuAddr.TabIndex = 7;
            this.lblStuAddr.Text = "Address";
            // 
            // lblStuDepart
            // 
            this.lblStuDepart.AutoSize = true;
            this.lblStuDepart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.lblStuDepart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStuDepart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(59)))));
            this.lblStuDepart.Location = new System.Drawing.Point(425, 64);
            this.lblStuDepart.Name = "lblStuDepart";
            this.lblStuDepart.Size = new System.Drawing.Size(97, 20);
            this.lblStuDepart.TabIndex = 8;
            this.lblStuDepart.Text = "Department";
            // 
            // lblStuMajor
            // 
            this.lblStuMajor.AutoSize = true;
            this.lblStuMajor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(73)))));
            this.lblStuMajor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStuMajor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(59)))));
            this.lblStuMajor.Location = new System.Drawing.Point(425, 127);
            this.lblStuMajor.Name = "lblStuMajor";
            this.lblStuMajor.Size = new System.Drawing.Size(51, 20);
            this.lblStuMajor.TabIndex = 9;
            this.lblStuMajor.Text = "Major";
            // 
            // lblStuPic
            // 
            this.lblStuPic.AutoSize = true;
            this.lblStuPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(53)))), ((int)(((byte)(82)))));
            this.lblStuPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStuPic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(59)))));
            this.lblStuPic.Location = new System.Drawing.Point(425, 200);
            this.lblStuPic.Name = "lblStuPic";
            this.lblStuPic.Size = new System.Drawing.Size(62, 20);
            this.lblStuPic.TabIndex = 10;
            this.lblStuPic.Text = "Picture";
            this.lblStuPic.Click += new System.EventHandler(this.label11_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd-MM-yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(107, 132);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(201, 22);
            this.dtpDate.TabIndex = 23;
            this.dtpDate.Value = new System.DateTime(2023, 2, 17, 0, 0, 0, 0);
            // 
            // grboGender
            // 
            this.grboGender.Controls.Add(this.radbFemale);
            this.grboGender.Controls.Add(this.radbMale);
            this.grboGender.Location = new System.Drawing.Point(107, 176);
            this.grboGender.Name = "grboGender";
            this.grboGender.Size = new System.Drawing.Size(201, 40);
            this.grboGender.TabIndex = 24;
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
            // picStudent
            // 
            this.picStudent.Location = new System.Drawing.Point(524, 165);
            this.picStudent.Name = "picStudent";
            this.picStudent.Size = new System.Drawing.Size(201, 128);
            this.picStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStudent.TabIndex = 25;
            this.picStudent.TabStop = false;
            // 
            // pictBackgroundAddStudent
            // 
            this.pictBackgroundAddStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictBackgroundAddStudent.Image = ((System.Drawing.Image)(resources.GetObject("pictBackgroundAddStudent.Image")));
            this.pictBackgroundAddStudent.Location = new System.Drawing.Point(0, 0);
            this.pictBackgroundAddStudent.Name = "pictBackgroundAddStudent";
            this.pictBackgroundAddStudent.Size = new System.Drawing.Size(775, 528);
            this.pictBackgroundAddStudent.TabIndex = 30;
            this.pictBackgroundAddStudent.TabStop = false;
            this.pictBackgroundAddStudent.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtStudentID
            // 
            this.txtStudentID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.txtStudentID.BorderColor = System.Drawing.Color.Transparent;
            this.txtStudentID.BorderRadius = 8;
            this.txtStudentID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStudentID.DefaultText = "";
            this.txtStudentID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStudentID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStudentID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStudentID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStudentID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStudentID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtStudentID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStudentID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStudentID.Location = new System.Drawing.Point(107, 11);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.PasswordChar = '\0';
            this.txtStudentID.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStudentID.PlaceholderText = "Text";
            this.txtStudentID.SelectedText = "";
            this.txtStudentID.Size = new System.Drawing.Size(201, 30);
            this.txtStudentID.TabIndex = 31;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.txtFirstName.BorderColor = System.Drawing.Color.Transparent;
            this.txtFirstName.BorderRadius = 8;
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName.DefaultText = "";
            this.txtFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstName.Location = new System.Drawing.Point(107, 50);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.PlaceholderText = "Text";
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.Size = new System.Drawing.Size(201, 30);
            this.txtFirstName.TabIndex = 32;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.BorderThickness = 2;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(213)))), ((int)(((byte)(41)))));
            this.btnCancel.Location = new System.Drawing.Point(132, 368);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 63);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(44)))), ((int)(((byte)(67)))));
            this.btnAddStudent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddStudent.BorderRadius = 10;
            this.btnAddStudent.BorderThickness = 2;
            this.btnAddStudent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddStudent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddStudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddStudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddStudent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.btnAddStudent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(213)))), ((int)(((byte)(41)))));
            this.btnAddStudent.Location = new System.Drawing.Point(559, 368);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(130, 63);
            this.btnAddStudent.TabIndex = 34;
            this.btnAddStudent.Text = "Add";
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.txtLastName.BorderColor = System.Drawing.Color.Transparent;
            this.txtLastName.BorderRadius = 8;
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastName.DefaultText = "";
            this.txtLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastName.Location = new System.Drawing.Point(107, 88);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.PlaceholderText = "Text";
            this.txtLastName.SelectedText = "";
            this.txtLastName.Size = new System.Drawing.Size(201, 30);
            this.txtLastName.TabIndex = 35;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(56)))), ((int)(((byte)(90)))));
            this.txtPhone.BorderColor = System.Drawing.Color.Transparent;
            this.txtPhone.BorderRadius = 8;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.DefaultText = "";
            this.txtPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.Location = new System.Drawing.Point(107, 248);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.PlaceholderText = "Text";
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(201, 30);
            this.txtPhone.TabIndex = 36;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(56)))), ((int)(((byte)(90)))));
            this.txtEmail.BorderColor = System.Drawing.Color.Transparent;
            this.txtEmail.BorderRadius = 8;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(107, 306);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.PlaceholderText = "Text";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(201, 30);
            this.txtEmail.TabIndex = 37;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.txtAddress.BorderColor = System.Drawing.Color.Transparent;
            this.txtAddress.BorderRadius = 8;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Location = new System.Drawing.Point(524, 11);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.PlaceholderText = "Text";
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(201, 30);
            this.txtAddress.TabIndex = 38;
            // 
            // txtMajor
            // 
            this.txtMajor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.txtMajor.BorderColor = System.Drawing.Color.Transparent;
            this.txtMajor.BorderRadius = 8;
            this.txtMajor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMajor.DefaultText = "";
            this.txtMajor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMajor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMajor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMajor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMajor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMajor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMajor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMajor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMajor.Location = new System.Drawing.Point(524, 113);
            this.txtMajor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMajor.Name = "txtMajor";
            this.txtMajor.PasswordChar = '\0';
            this.txtMajor.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMajor.PlaceholderText = "Text";
            this.txtMajor.SelectedText = "";
            this.txtMajor.Size = new System.Drawing.Size(201, 30);
            this.txtMajor.TabIndex = 39;
            // 
            // cboDepartment
            // 
            this.cboDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.cboDepartment.BorderRadius = 10;
            this.cboDepartment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboDepartment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboDepartment.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.ItemHeight = 30;
            this.cboDepartment.Items.AddRange(new object[] {
            "Khoa ĐT CLC",
            "Khoa CNTT",
            "Khoa Điện - Điện Điện Tử",
            "Khoa Du Lịch",
            "Khoa In và Truyền Thông",
            "Khoa Xây Dựng",
            "Khoa Ngoại Ngữ",
            "Khoa Kinh Tế"});
            this.cboDepartment.Location = new System.Drawing.Point(524, 57);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(201, 36);
            this.cboDepartment.TabIndex = 40;
            // 
            // btnUpImage
            // 
            this.btnUpImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.btnUpImage.BorderRadius = 8;
            this.btnUpImage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpImage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpImage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpImage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpImage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.btnUpImage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpImage.ForeColor = System.Drawing.Color.White;
            this.btnUpImage.Location = new System.Drawing.Point(534, 306);
            this.btnUpImage.Name = "btnUpImage";
            this.btnUpImage.Size = new System.Drawing.Size(180, 30);
            this.btnUpImage.TabIndex = 41;
            this.btnUpImage.Text = "Upload Image";
            this.btnUpImage.Click += new System.EventHandler(this.btnUpImage_Click);
            // 
            // frmAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 528);
            this.Controls.Add(this.btnUpImage);
            this.Controls.Add(this.cboDepartment);
            this.Controls.Add(this.txtMajor);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.picStudent);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblStuPic);
            this.Controls.Add(this.lblStuMajor);
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
            this.Controls.Add(this.pictBackgroundAddStudent);
            this.Name = "frmAddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Student";
            this.Load += new System.EventHandler(this.frmAddStudent_Load);
            this.grboGender.ResumeLayout(false);
            this.grboGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBackgroundAddStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStuID;
        private System.Windows.Forms.Label lblStuFName;
        private System.Windows.Forms.Label lblStuLName;
        private System.Windows.Forms.Label lblStuBirthDate;
        private System.Windows.Forms.Label lblStuGender;
        private System.Windows.Forms.Label lblStuPhone;
        private System.Windows.Forms.Label lblStuEmail;
        private System.Windows.Forms.Label lblStuAddr;
        private System.Windows.Forms.Label lblStuDepart;
        private System.Windows.Forms.Label lblStuMajor;
        private System.Windows.Forms.Label lblStuPic;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.GroupBox grboGender;
        private System.Windows.Forms.RadioButton radbFemale;
        private System.Windows.Forms.RadioButton radbMale;
        private System.Windows.Forms.PictureBox picStudent;
        private System.Windows.Forms.PictureBox pictBackgroundAddStudent;
        private Guna.UI2.WinForms.Guna2TextBox txtStudentID;
        private Guna.UI2.WinForms.Guna2TextBox txtFirstName;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnAddStudent;
        private Guna.UI2.WinForms.Guna2TextBox txtLastName;
        private Guna.UI2.WinForms.Guna2TextBox txtPhone;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtMajor;
        private Guna.UI2.WinForms.Guna2ComboBox cboDepartment;
        private Guna.UI2.WinForms.Guna2Button btnUpImage;
    }
}