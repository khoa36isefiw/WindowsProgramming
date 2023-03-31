namespace _20110375_HuynhDangKhoa_LoginForm
{
    partial class frmPrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrint));
            this.groupBoxChoose = new System.Windows.Forms.GroupBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.groupBoxDate = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_end = new System.Windows.Forms.DateTimePicker();
            this.radioButton_No = new System.Windows.Forms.RadioButton();
            this.dateTimePicker_start = new System.Windows.Forms.DateTimePicker();
            this.radioButton_Yes = new System.Windows.Forms.RadioButton();
            this.lblAnd = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblChooseRange = new System.Windows.Forms.Label();
            this.radioButton_Male = new System.Windows.Forms.RadioButton();
            this.radioButton_Female = new System.Windows.Forms.RadioButton();
            this.radioButton_All = new System.Windows.Forms.RadioButton();
            this.studentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataSet = new _20110375_HuynhDangKhoa_LoginForm.StudentDataSet();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSVDataSet = new _20110375_HuynhDangKhoa_LoginForm.QLSVDataSet();
            this.btnSaveText = new System.Windows.Forms.Button();
            this.btnPrinter = new System.Windows.Forms.Button();
            this.btnSavePDF = new System.Windows.Forms.Button();
            this.studentTableAdapter = new _20110375_HuynhDangKhoa_LoginForm.QLSVDataSetTableAdapters.studentTableAdapter();
            this.btnExcel = new System.Windows.Forms.Button();
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter1 = new _20110375_HuynhDangKhoa_LoginForm.StudentDataSetTableAdapters.studentTableAdapter();
            this.userDataSet = new _20110375_HuynhDangKhoa_LoginForm.UserDataSet();
            this.userDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSVDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userloginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_loginTableAdapter = new _20110375_HuynhDangKhoa_LoginForm.UserDataSetTableAdapters.user_loginTableAdapter();
            this.dataGVStudent_information = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mSSVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.majorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.homeTownDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.qLSVDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxChoose.SuspendLayout();
            this.groupBoxDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userloginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVStudent_information)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxChoose
            // 
            this.groupBoxChoose.Controls.Add(this.btnCheck);
            this.groupBoxChoose.Controls.Add(this.groupBoxDate);
            this.groupBoxChoose.Controls.Add(this.radioButton_Male);
            this.groupBoxChoose.Controls.Add(this.radioButton_Female);
            this.groupBoxChoose.Controls.Add(this.radioButton_All);
            this.groupBoxChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxChoose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxChoose.Location = new System.Drawing.Point(23, 12);
            this.groupBoxChoose.Name = "groupBoxChoose";
            this.groupBoxChoose.Size = new System.Drawing.Size(1510, 139);
            this.groupBoxChoose.TabIndex = 0;
            this.groupBoxChoose.TabStop = false;
            this.groupBoxChoose.Enter += new System.EventHandler(this.groupBoxChoose_Enter);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.Red;
            this.btnCheck.Location = new System.Drawing.Point(1187, 45);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(144, 64);
            this.btnCheck.TabIndex = 5;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // groupBoxDate
            // 
            this.groupBoxDate.Controls.Add(this.dateTimePicker_end);
            this.groupBoxDate.Controls.Add(this.radioButton_No);
            this.groupBoxDate.Controls.Add(this.dateTimePicker_start);
            this.groupBoxDate.Controls.Add(this.radioButton_Yes);
            this.groupBoxDate.Controls.Add(this.lblAnd);
            this.groupBoxDate.Controls.Add(this.lblBirthDate);
            this.groupBoxDate.Controls.Add(this.lblChooseRange);
            this.groupBoxDate.Location = new System.Drawing.Point(417, 20);
            this.groupBoxDate.Name = "groupBoxDate";
            this.groupBoxDate.Size = new System.Drawing.Size(621, 113);
            this.groupBoxDate.TabIndex = 3;
            this.groupBoxDate.TabStop = false;
            // 
            // dateTimePicker_end
            // 
            this.dateTimePicker_end.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker_end.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_end.Location = new System.Drawing.Point(472, 75);
            this.dateTimePicker_end.Name = "dateTimePicker_end";
            this.dateTimePicker_end.Size = new System.Drawing.Size(143, 30);
            this.dateTimePicker_end.TabIndex = 2;
            // 
            // radioButton_No
            // 
            this.radioButton_No.AutoSize = true;
            this.radioButton_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_No.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton_No.Location = new System.Drawing.Point(339, 30);
            this.radioButton_No.Name = "radioButton_No";
            this.radioButton_No.Size = new System.Drawing.Size(60, 29);
            this.radioButton_No.TabIndex = 5;
            this.radioButton_No.Text = "No";
            this.radioButton_No.UseVisualStyleBackColor = true;
            this.radioButton_No.CheckedChanged += new System.EventHandler(this.radioButton_No_CheckedChanged);
            // 
            // dateTimePicker_start
            // 
            this.dateTimePicker_start.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_start.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker_start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_start.Location = new System.Drawing.Point(244, 77);
            this.dateTimePicker_start.Name = "dateTimePicker_start";
            this.dateTimePicker_start.Size = new System.Drawing.Size(146, 30);
            this.dateTimePicker_start.TabIndex = 1;
            // 
            // radioButton_Yes
            // 
            this.radioButton_Yes.AutoSize = true;
            this.radioButton_Yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Yes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton_Yes.Location = new System.Drawing.Point(244, 28);
            this.radioButton_Yes.Name = "radioButton_Yes";
            this.radioButton_Yes.Size = new System.Drawing.Size(70, 29);
            this.radioButton_Yes.TabIndex = 4;
            this.radioButton_Yes.Text = "Yes";
            this.radioButton_Yes.UseVisualStyleBackColor = true;
            this.radioButton_Yes.CheckedChanged += new System.EventHandler(this.radioButton_Yes_CheckedChanged);
            // 
            // lblAnd
            // 
            this.lblAnd.AutoSize = true;
            this.lblAnd.Location = new System.Drawing.Point(396, 82);
            this.lblAnd.Name = "lblAnd";
            this.lblAnd.Size = new System.Drawing.Size(51, 25);
            this.lblAnd.TabIndex = 1;
            this.lblAnd.Text = "And";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(21, 80);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(197, 25);
            this.lblBirthDate.TabIndex = 1;
            this.lblBirthDate.Text = "BirthDate Between:";
            // 
            // lblChooseRange
            // 
            this.lblChooseRange.AutoSize = true;
            this.lblChooseRange.Location = new System.Drawing.Point(21, 30);
            this.lblChooseRange.Name = "lblChooseRange";
            this.lblChooseRange.Size = new System.Drawing.Size(176, 25);
            this.lblChooseRange.TabIndex = 0;
            this.lblChooseRange.Text = "Use Date Range:";
            // 
            // radioButton_Male
            // 
            this.radioButton_Male.AutoSize = true;
            this.radioButton_Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Male.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton_Male.Location = new System.Drawing.Point(139, 63);
            this.radioButton_Male.Name = "radioButton_Male";
            this.radioButton_Male.Size = new System.Drawing.Size(80, 29);
            this.radioButton_Male.TabIndex = 2;
            this.radioButton_Male.Text = "Male";
            this.radioButton_Male.UseVisualStyleBackColor = true;
            // 
            // radioButton_Female
            // 
            this.radioButton_Female.AutoSize = true;
            this.radioButton_Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Female.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton_Female.Location = new System.Drawing.Point(263, 63);
            this.radioButton_Female.Name = "radioButton_Female";
            this.radioButton_Female.Size = new System.Drawing.Size(104, 29);
            this.radioButton_Female.TabIndex = 1;
            this.radioButton_Female.Text = "Female";
            this.radioButton_Female.UseVisualStyleBackColor = true;
            // 
            // radioButton_All
            // 
            this.radioButton_All.AutoSize = true;
            this.radioButton_All.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_All.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton_All.Location = new System.Drawing.Point(37, 63);
            this.radioButton_All.Name = "radioButton_All";
            this.radioButton_All.Size = new System.Drawing.Size(58, 29);
            this.radioButton_All.TabIndex = 0;
            this.radioButton_All.Text = "All";
            this.radioButton_All.UseVisualStyleBackColor = true;
            // 
            // studentBindingSource2
            // 
            this.studentBindingSource2.DataMember = "student";
            this.studentBindingSource2.DataSource = this.studentDataSet;
            // 
            // studentDataSet
            // 
            this.studentDataSet.DataSetName = "StudentDataSet";
            this.studentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "student";
            this.studentBindingSource.DataSource = this.qLSVDataSet;
            // 
            // qLSVDataSet
            // 
            this.qLSVDataSet.DataSetName = "QLSVDataSet";
            this.qLSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSaveText
            // 
            this.btnSaveText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveText.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveText.Image")));
            this.btnSaveText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveText.Location = new System.Drawing.Point(440, 712);
            this.btnSaveText.Name = "btnSaveText";
            this.btnSaveText.Size = new System.Drawing.Size(241, 56);
            this.btnSaveText.TabIndex = 2;
            this.btnSaveText.Text = "Save To Word";
            this.btnSaveText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveText.UseVisualStyleBackColor = true;
            this.btnSaveText.Click += new System.EventHandler(this.btnSaveText_Click);
            // 
            // btnPrinter
            // 
            this.btnPrinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrinter.Image = ((System.Drawing.Image)(resources.GetObject("btnPrinter.Image")));
            this.btnPrinter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrinter.Location = new System.Drawing.Point(1078, 712);
            this.btnPrinter.Name = "btnPrinter";
            this.btnPrinter.Size = new System.Drawing.Size(238, 56);
            this.btnPrinter.TabIndex = 2;
            this.btnPrinter.Text = "To Printer";
            this.btnPrinter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrinter.UseVisualStyleBackColor = true;
            this.btnPrinter.Click += new System.EventHandler(this.btnPrinter_Click);
            // 
            // btnSavePDF
            // 
            this.btnSavePDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePDF.Image = ((System.Drawing.Image)(resources.GetObject("btnSavePDF.Image")));
            this.btnSavePDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSavePDF.Location = new System.Drawing.Point(133, 712);
            this.btnSavePDF.Name = "btnSavePDF";
            this.btnSavePDF.Size = new System.Drawing.Size(226, 56);
            this.btnSavePDF.TabIndex = 3;
            this.btnSavePDF.Text = "Save To PDF";
            this.btnSavePDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSavePDF.UseVisualStyleBackColor = true;
            this.btnSavePDF.Click += new System.EventHandler(this.btnSavePDF_Click);
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // btnExcel
            // 
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.Location = new System.Drawing.Point(755, 712);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(252, 56);
            this.btnExcel.TabIndex = 4;
            this.btnExcel.Text = "Save To Excel";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // studentBindingSource1
            // 
            this.studentBindingSource1.DataMember = "student";
            this.studentBindingSource1.DataSource = this.qLSVDataSet;
            // 
            // studentTableAdapter1
            // 
            this.studentTableAdapter1.ClearBeforeFill = true;
            // 
            // userDataSet
            // 
            this.userDataSet.DataSetName = "UserDataSet";
            this.userDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userDataSetBindingSource
            // 
            this.userDataSetBindingSource.DataSource = this.userDataSet;
            this.userDataSetBindingSource.Position = 0;
            // 
            // qLSVDataSetBindingSource
            // 
            this.qLSVDataSetBindingSource.DataSource = this.qLSVDataSet;
            this.qLSVDataSetBindingSource.Position = 0;
            // 
            // userloginBindingSource
            // 
            this.userloginBindingSource.DataMember = "user_login";
            this.userloginBindingSource.DataSource = this.userDataSetBindingSource;
            // 
            // user_loginTableAdapter
            // 
            this.user_loginTableAdapter.ClearBeforeFill = true;
            // 
            // dataGVStudent_information
            // 
            this.dataGVStudent_information.AutoGenerateColumns = false;
            this.dataGVStudent_information.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGVStudent_information.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVStudent_information.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.mSSVDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.birthDateDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.majorDataGridViewTextBoxColumn,
            this.pictureDataGridViewImageColumn,
            this.homeTownDataGridViewTextBoxColumn});
            this.dataGVStudent_information.DataSource = this.studentBindingSource2;
            this.dataGVStudent_information.Location = new System.Drawing.Point(12, 177);
            this.dataGVStudent_information.Name = "dataGVStudent_information";
            this.dataGVStudent_information.RowHeadersWidth = 51;
            this.dataGVStudent_information.RowTemplate.Height = 24;
            this.dataGVStudent_information.Size = new System.Drawing.Size(1497, 441);
            this.dataGVStudent_information.TabIndex = 5;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "STT";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mSSVDataGridViewTextBoxColumn
            // 
            this.mSSVDataGridViewTextBoxColumn.DataPropertyName = "MSSV";
            this.mSSVDataGridViewTextBoxColumn.HeaderText = "MSSV";
            this.mSSVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mSSVDataGridViewTextBoxColumn.Name = "mSSVDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            this.birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.HeaderText = "Birth Date";
            this.birthDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone Number";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            // 
            // majorDataGridViewTextBoxColumn
            // 
            this.majorDataGridViewTextBoxColumn.DataPropertyName = "Major";
            this.majorDataGridViewTextBoxColumn.HeaderText = "Major";
            this.majorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.majorDataGridViewTextBoxColumn.Name = "majorDataGridViewTextBoxColumn";
            // 
            // pictureDataGridViewImageColumn
            // 
            this.pictureDataGridViewImageColumn.DataPropertyName = "Picture";
            this.pictureDataGridViewImageColumn.HeaderText = "Picture";
            this.pictureDataGridViewImageColumn.MinimumWidth = 6;
            this.pictureDataGridViewImageColumn.Name = "pictureDataGridViewImageColumn";
            // 
            // homeTownDataGridViewTextBoxColumn
            // 
            this.homeTownDataGridViewTextBoxColumn.DataPropertyName = "HomeTown";
            this.homeTownDataGridViewTextBoxColumn.HeaderText = "Home Town";
            this.homeTownDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.homeTownDataGridViewTextBoxColumn.Name = "homeTownDataGridViewTextBoxColumn";
            // 
            // studentBindingSource3
            // 
            this.studentBindingSource3.DataMember = "student";
            this.studentBindingSource3.DataSource = this.qLSVDataSetBindingSource;
            // 
            // studentBindingSource4
            // 
            this.studentBindingSource4.DataMember = "student";
            this.studentBindingSource4.DataSource = this.qLSVDataSetBindingSource;
            // 
            // studentBindingSource5
            // 
            this.studentBindingSource5.DataMember = "student";
            this.studentBindingSource5.DataSource = this.qLSVDataSetBindingSource;
            // 
            // qLSVDataSetBindingSource1
            // 
            this.qLSVDataSetBindingSource1.DataSource = this.qLSVDataSet;
            this.qLSVDataSetBindingSource1.Position = 0;
            // 
            // studentDataSetBindingSource
            // 
            this.studentDataSetBindingSource.DataSource = this.studentDataSet;
            this.studentDataSetBindingSource.Position = 0;
            // 
            // frmPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(78)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(1561, 810);
            this.Controls.Add(this.dataGVStudent_information);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnSavePDF);
            this.Controls.Add(this.btnPrinter);
            this.Controls.Add(this.btnSaveText);
            this.Controls.Add(this.groupBoxChoose);
            this.Name = "frmPrint";
            this.Text = " Print";
            this.Load += new System.EventHandler(this.frmPrint_Load);
            this.groupBoxChoose.ResumeLayout(false);
            this.groupBoxChoose.PerformLayout();
            this.groupBoxDate.ResumeLayout(false);
            this.groupBoxDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userloginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVStudent_information)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxChoose;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.GroupBox groupBoxDate;
        private System.Windows.Forms.RadioButton radioButton_No;
        private System.Windows.Forms.RadioButton radioButton_Yes;
        private System.Windows.Forms.Label lblAnd;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblChooseRange;
        private System.Windows.Forms.RadioButton radioButton_Male;
        private System.Windows.Forms.RadioButton radioButton_Female;
        private System.Windows.Forms.RadioButton radioButton_All;
        private System.Windows.Forms.DateTimePicker dateTimePicker_start;
        private System.Windows.Forms.DateTimePicker dateTimePicker_end;
        private System.Windows.Forms.Button btnSaveText;
        private System.Windows.Forms.Button btnPrinter;
        private QLSVDataSet qLSVDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private QLSVDataSetTableAdapters.studentTableAdapter studentTableAdapter;
        private System.Windows.Forms.Button btnSavePDF;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.BindingSource studentBindingSource1;
        private StudentDataSet studentDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource2;
        private StudentDataSetTableAdapters.studentTableAdapter studentTableAdapter1;
        private System.Windows.Forms.BindingSource qLSVDataSetBindingSource;
        private UserDataSet userDataSet;
        private System.Windows.Forms.BindingSource userDataSetBindingSource;
        private System.Windows.Forms.BindingSource userloginBindingSource;
        private UserDataSetTableAdapters.user_loginTableAdapter user_loginTableAdapter;
        private System.Windows.Forms.DataGridView dataGVStudent_information;
        private System.Windows.Forms.BindingSource studentDataSetBindingSource;
        private System.Windows.Forms.BindingSource studentBindingSource3;
        private System.Windows.Forms.BindingSource studentBindingSource4;
        private System.Windows.Forms.BindingSource studentBindingSource5;
        private System.Windows.Forms.BindingSource qLSVDataSetBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mSSVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn majorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn pictureDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeTownDataGridViewTextBoxColumn;
    }
}