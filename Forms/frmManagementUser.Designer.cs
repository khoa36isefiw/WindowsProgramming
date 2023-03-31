namespace _20110375_HuynhDangKhoa_LoginForm
{
    partial class frmManagementUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManagementUser));
            this.dataGRV_User = new System.Windows.Forms.DataGridView();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userFNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userLNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userGenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userloginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userDataSet = new _20110375_HuynhDangKhoa_LoginForm.UserDataSet();
            this.user_loginTableAdapter = new _20110375_HuynhDangKhoa_LoginForm.UserDataSetTableAdapters.user_loginTableAdapter();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtUName = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUserPass = new System.Windows.Forms.Label();
            this.lblUserFName = new System.Windows.Forms.Label();
            this.lblUserLName = new System.Windows.Forms.Label();
            this.lblUserPhone = new System.Windows.Forms.Label();
            this.lblUserGmail = new System.Windows.Forms.Label();
            this.lblUserEmail = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGRV_User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userloginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGRV_User
            // 
            this.dataGRV_User.AutoGenerateColumns = false;
            this.dataGRV_User.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGRV_User.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGRV_User.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userNameDataGridViewTextBoxColumn,
            this.userPasswordDataGridViewTextBoxColumn,
            this.userFNameDataGridViewTextBoxColumn,
            this.userLNameDataGridViewTextBoxColumn,
            this.userGenderDataGridViewTextBoxColumn,
            this.userPhoneDataGridViewTextBoxColumn,
            this.userEmailDataGridViewTextBoxColumn,
            this.rolesDataGridViewTextBoxColumn});
            this.dataGRV_User.DataSource = this.userloginBindingSource;
            this.dataGRV_User.Location = new System.Drawing.Point(367, 89);
            this.dataGRV_User.Name = "dataGRV_User";
            this.dataGRV_User.RowHeadersWidth = 51;
            this.dataGRV_User.RowTemplate.Height = 24;
            this.dataGRV_User.Size = new System.Drawing.Size(863, 500);
            this.dataGRV_User.TabIndex = 0;

            this.dataGRV_User.Click += new System.EventHandler(this.dataGRV_User_Click);
            
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "userName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "USER NAME";
            this.userNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            // 
            // userPasswordDataGridViewTextBoxColumn
            // 
            this.userPasswordDataGridViewTextBoxColumn.DataPropertyName = "userPassword";
            this.userPasswordDataGridViewTextBoxColumn.HeaderText = "PASSWORD";
            this.userPasswordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userPasswordDataGridViewTextBoxColumn.Name = "userPasswordDataGridViewTextBoxColumn";
            // 
            // userFNameDataGridViewTextBoxColumn
            // 
            this.userFNameDataGridViewTextBoxColumn.DataPropertyName = "userFName";
            this.userFNameDataGridViewTextBoxColumn.HeaderText = "FIRST NAME";
            this.userFNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userFNameDataGridViewTextBoxColumn.Name = "userFNameDataGridViewTextBoxColumn";
            // 
            // userLNameDataGridViewTextBoxColumn
            // 
            this.userLNameDataGridViewTextBoxColumn.DataPropertyName = "userLName";
            this.userLNameDataGridViewTextBoxColumn.HeaderText = "LAST NAME";
            this.userLNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userLNameDataGridViewTextBoxColumn.Name = "userLNameDataGridViewTextBoxColumn";
            // 
            // userGenderDataGridViewTextBoxColumn
            // 
            this.userGenderDataGridViewTextBoxColumn.DataPropertyName = "userGender";
            this.userGenderDataGridViewTextBoxColumn.HeaderText = "GENDER";
            this.userGenderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userGenderDataGridViewTextBoxColumn.Name = "userGenderDataGridViewTextBoxColumn";
            // 
            // userPhoneDataGridViewTextBoxColumn
            // 
            this.userPhoneDataGridViewTextBoxColumn.DataPropertyName = "userPhone";
            this.userPhoneDataGridViewTextBoxColumn.HeaderText = "PHONE NUMBER";
            this.userPhoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userPhoneDataGridViewTextBoxColumn.Name = "userPhoneDataGridViewTextBoxColumn";
            // 
            // userEmailDataGridViewTextBoxColumn
            // 
            this.userEmailDataGridViewTextBoxColumn.DataPropertyName = "userEmail";
            this.userEmailDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.userEmailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userEmailDataGridViewTextBoxColumn.Name = "userEmailDataGridViewTextBoxColumn";
            // 
            // rolesDataGridViewTextBoxColumn
            // 
            this.rolesDataGridViewTextBoxColumn.DataPropertyName = "Roles";
            this.rolesDataGridViewTextBoxColumn.HeaderText = "ROLES";
            this.rolesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rolesDataGridViewTextBoxColumn.Name = "rolesDataGridViewTextBoxColumn";
            // 
            // userloginBindingSource
            // 
            this.userloginBindingSource.DataMember = "user_login";
            this.userloginBindingSource.DataSource = this.userDataSet;
            // 
            // userDataSet
            // 
            this.userDataSet.DataSetName = "UserDataSet";
            this.userDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // user_loginTableAdapter
            // 
            this.user_loginTableAdapter.ClearBeforeFill = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(604, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(257, 29);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "List of Users Account";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(79, 474);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(151, 55);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtUName
            // 
            this.txtUName.Location = new System.Drawing.Point(122, 136);
            this.txtUName.Name = "txtUName";
            this.txtUName.Size = new System.Drawing.Size(151, 22);
            this.txtUName.TabIndex = 3;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(122, 178);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(151, 22);
            this.txtPass.TabIndex = 4;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(122, 299);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(151, 22);
            this.txtGender.TabIndex = 5;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(122, 222);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(151, 22);
            this.txtFName.TabIndex = 6;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(122, 261);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(151, 22);
            this.txtLName.TabIndex = 7;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(122, 339);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(151, 22);
            this.txtPhone.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(122, 384);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(151, 22);
            this.txtEmail.TabIndex = 8;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(30, 139);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(76, 16);
            this.lblUserName.TabIndex = 11;
            this.lblUserName.Text = "User Name";
            // 
            // lblUserPass
            // 
            this.lblUserPass.AutoSize = true;
            this.lblUserPass.Location = new System.Drawing.Point(30, 181);
            this.lblUserPass.Name = "lblUserPass";
            this.lblUserPass.Size = new System.Drawing.Size(67, 16);
            this.lblUserPass.TabIndex = 12;
            this.lblUserPass.Text = "Password";
            // 
            // lblUserFName
            // 
            this.lblUserFName.AutoSize = true;
            this.lblUserFName.Location = new System.Drawing.Point(30, 222);
            this.lblUserFName.Name = "lblUserFName";
            this.lblUserFName.Size = new System.Drawing.Size(72, 16);
            this.lblUserFName.TabIndex = 13;
            this.lblUserFName.Text = "First Name";
            // 
            // lblUserLName
            // 
            this.lblUserLName.AutoSize = true;
            this.lblUserLName.Location = new System.Drawing.Point(30, 267);
            this.lblUserLName.Name = "lblUserLName";
            this.lblUserLName.Size = new System.Drawing.Size(72, 16);
            this.lblUserLName.TabIndex = 14;
            this.lblUserLName.Text = "Last Name";
            // 
            // lblUserPhone
            // 
            this.lblUserPhone.AutoSize = true;
            this.lblUserPhone.Location = new System.Drawing.Point(30, 305);
            this.lblUserPhone.Name = "lblUserPhone";
            this.lblUserPhone.Size = new System.Drawing.Size(52, 16);
            this.lblUserPhone.TabIndex = 15;
            this.lblUserPhone.Text = "Gender";
            // 
            // lblUserGmail
            // 
            this.lblUserGmail.AutoSize = true;
            this.lblUserGmail.Location = new System.Drawing.Point(30, 345);
            this.lblUserGmail.Name = "lblUserGmail";
            this.lblUserGmail.Size = new System.Drawing.Size(46, 16);
            this.lblUserGmail.TabIndex = 16;
            this.lblUserGmail.Text = "Phone";
            // 
            // lblUserEmail
            // 
            this.lblUserEmail.AutoSize = true;
            this.lblUserEmail.Location = new System.Drawing.Point(30, 390);
            this.lblUserEmail.Name = "lblUserEmail";
            this.lblUserEmail.Size = new System.Drawing.Size(41, 16);
            this.lblUserEmail.TabIndex = 18;
            this.lblUserEmail.Text = "Email";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(715, 595);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(146, 58);
            this.btnRefresh.TabIndex = 20;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1242, 665);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // frmManagementUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1242, 665);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblUserEmail);
            this.Controls.Add(this.lblUserGmail);
            this.Controls.Add(this.lblUserPhone);
            this.Controls.Add(this.lblUserLName);
            this.Controls.Add(this.lblUserFName);
            this.Controls.Add(this.lblUserPass);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUName);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dataGRV_User);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "frmManagementUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManagementUser";
            this.Load += new System.EventHandler(this.frmManagementUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGRV_User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userloginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGRV_User;
        private UserDataSet userDataSet;
        private System.Windows.Forms.BindingSource userloginBindingSource;
        private UserDataSetTableAdapters.user_loginTableAdapter user_loginTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userFNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userLNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userGenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolesDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtUName;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserPass;
        private System.Windows.Forms.Label lblUserFName;
        private System.Windows.Forms.Label lblUserLName;
        private System.Windows.Forms.Label lblUserPhone;
        private System.Windows.Forms.Label lblUserGmail;
        private System.Windows.Forms.Label lblUserEmail;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}