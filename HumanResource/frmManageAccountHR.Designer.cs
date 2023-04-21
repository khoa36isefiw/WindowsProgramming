namespace _20110375_HuynhDangKhoa_LoginForm.HumanResource
{
    partial class frmManageAccountHR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageAccountHR));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblUserEmail = new System.Windows.Forms.Label();
            this.lbl_HRID = new System.Windows.Forms.Label();
            this.lblUserLName = new System.Windows.Forms.Label();
            this.lblUserFName = new System.Windows.Forms.Label();
            this.lblUserPass = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txt_HRID = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUName = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.user_loginTableAdapter = new _20110375_HuynhDangKhoa_LoginForm.UserDataSetTableAdapters.user_loginTableAdapter();
            this.userDataSet = new _20110375_HuynhDangKhoa_LoginForm.UserDataSet();
            this.userloginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.datagridView_HRAccount = new System.Windows.Forms.DataGridView();
            this.lblPicture = new System.Windows.Forms.Label();
            this.pictureBox_Img = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.userDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userloginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridView_HRAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Img)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(629, 486);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(146, 58);
            this.btnRefresh.TabIndex = 39;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // lblUserEmail
            // 
            this.lblUserEmail.AutoSize = true;
            this.lblUserEmail.Location = new System.Drawing.Point(25, 284);
            this.lblUserEmail.Name = "lblUserEmail";
            this.lblUserEmail.Size = new System.Drawing.Size(41, 16);
            this.lblUserEmail.TabIndex = 38;
            this.lblUserEmail.Text = "Email";
            // 
            // lbl_HRID
            // 
            this.lbl_HRID.AutoSize = true;
            this.lbl_HRID.Location = new System.Drawing.Point(25, 227);
            this.lbl_HRID.Name = "lbl_HRID";
            this.lbl_HRID.Size = new System.Drawing.Size(43, 16);
            this.lbl_HRID.TabIndex = 36;
            this.lbl_HRID.Text = "HR ID";
            // 
            // lblUserLName
            // 
            this.lblUserLName.AutoSize = true;
            this.lblUserLName.Location = new System.Drawing.Point(25, 189);
            this.lblUserLName.Name = "lblUserLName";
            this.lblUserLName.Size = new System.Drawing.Size(72, 16);
            this.lblUserLName.TabIndex = 35;
            this.lblUserLName.Text = "Last Name";
            // 
            // lblUserFName
            // 
            this.lblUserFName.AutoSize = true;
            this.lblUserFName.Location = new System.Drawing.Point(25, 144);
            this.lblUserFName.Name = "lblUserFName";
            this.lblUserFName.Size = new System.Drawing.Size(72, 16);
            this.lblUserFName.TabIndex = 34;
            this.lblUserFName.Text = "First Name";
            // 
            // lblUserPass
            // 
            this.lblUserPass.AutoSize = true;
            this.lblUserPass.Location = new System.Drawing.Point(25, 103);
            this.lblUserPass.Name = "lblUserPass";
            this.lblUserPass.Size = new System.Drawing.Size(67, 16);
            this.lblUserPass.TabIndex = 33;
            this.lblUserPass.Text = "Password";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(25, 61);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(76, 16);
            this.lblUserName.TabIndex = 32;
            this.lblUserName.Text = "User Name";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(117, 278);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(151, 22);
            this.txtEmail.TabIndex = 30;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(117, 183);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(151, 22);
            this.txtLName.TabIndex = 29;
            this.txtLName.TextChanged += new System.EventHandler(this.txtLName_TextChanged);
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(117, 144);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(151, 22);
            this.txtFName.TabIndex = 28;
            // 
            // txt_HRID
            // 
            this.txt_HRID.Location = new System.Drawing.Point(117, 221);
            this.txt_HRID.Name = "txt_HRID";
            this.txt_HRID.Size = new System.Drawing.Size(151, 22);
            this.txt_HRID.TabIndex = 27;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(117, 100);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(151, 22);
            this.txtPass.TabIndex = 26;
            // 
            // txtUName
            // 
            this.txtUName.Location = new System.Drawing.Point(117, 58);
            this.txtUName.Name = "txtUName";
            this.txtUName.Size = new System.Drawing.Size(151, 22);
            this.txtUName.TabIndex = 25;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(117, 458);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(151, 55);
            this.btnRemove.TabIndex = 24;
            this.btnRemove.Text = "Remove";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // user_loginTableAdapter
            // 
            this.user_loginTableAdapter.ClearBeforeFill = true;
            // 
            // userDataSet
            // 
            this.userDataSet.DataSetName = "UserDataSet";
            this.userDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userloginBindingSource
            // 
            this.userloginBindingSource.DataMember = "user_login";
            this.userloginBindingSource.DataSource = this.userDataSet;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(550, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(225, 29);
            this.lblTitle.TabIndex = 23;
            this.lblTitle.Text = "List of HR Account";
            // 
            // datagridView_HRAccount
            // 
            this.datagridView_HRAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridView_HRAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridView_HRAccount.Location = new System.Drawing.Point(338, 71);
            this.datagridView_HRAccount.Name = "datagridView_HRAccount";
            this.datagridView_HRAccount.RowHeadersWidth = 51;
            this.datagridView_HRAccount.RowTemplate.Height = 24;
            this.datagridView_HRAccount.Size = new System.Drawing.Size(746, 388);
            this.datagridView_HRAccount.TabIndex = 41;
            this.datagridView_HRAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridView_HRAccount_CellClick);
            this.datagridView_HRAccount.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridView_HRAccount_CellDoubleClick);
            // 
            // lblPicture
            // 
            this.lblPicture.AutoSize = true;
            this.lblPicture.Location = new System.Drawing.Point(25, 333);
            this.lblPicture.Name = "lblPicture";
            this.lblPicture.Size = new System.Drawing.Size(48, 16);
            this.lblPicture.TabIndex = 42;
            this.lblPicture.Text = "Picture";
            // 
            // pictureBox_Img
            // 
            this.pictureBox_Img.Location = new System.Drawing.Point(117, 333);
            this.pictureBox_Img.Name = "pictureBox_Img";
            this.pictureBox_Img.Size = new System.Drawing.Size(151, 99);
            this.pictureBox_Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Img.TabIndex = 43;
            this.pictureBox_Img.TabStop = false;
            // 
            // frmManageAccountHR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 647);
            this.Controls.Add(this.pictureBox_Img);
            this.Controls.Add(this.lblPicture);
            this.Controls.Add(this.datagridView_HRAccount);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblUserEmail);
            this.Controls.Add(this.lbl_HRID);
            this.Controls.Add(this.lblUserLName);
            this.Controls.Add(this.lblUserFName);
            this.Controls.Add(this.lblUserPass);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.txt_HRID);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUName);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmManageAccountHR";
            this.Text = "frmManageAccountHR";
            this.Load += new System.EventHandler(this.frmManageAccountHR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userloginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridView_HRAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblUserEmail;
        private System.Windows.Forms.Label lbl_HRID;
        private System.Windows.Forms.Label lblUserLName;
        private System.Windows.Forms.Label lblUserFName;
        private System.Windows.Forms.Label lblUserPass;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txt_HRID;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUName;
        private System.Windows.Forms.Button btnRemove;
        private UserDataSetTableAdapters.user_loginTableAdapter user_loginTableAdapter;
        private UserDataSet userDataSet;
        private System.Windows.Forms.BindingSource userloginBindingSource;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView datagridView_HRAccount;
        private System.Windows.Forms.Label lblPicture;
        private System.Windows.Forms.PictureBox pictureBox_Img;
    }
}