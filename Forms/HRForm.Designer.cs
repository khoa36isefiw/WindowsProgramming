namespace _20110375_HuynhDangKhoa_LoginForm.Forms
{
    partial class frmMainHR
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
            this.lblContact = new System.Windows.Forms.Label();
            this.lblContactID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddContact = new System.Windows.Forms.Button();
            this.btnEditContact = new System.Windows.Forms.Button();
            this.btn_ContactID_Remove = new System.Windows.Forms.Button();
            this.btn_ContactID_Select = new System.Windows.Forms.Button();
            this.btnShowFullList = new System.Windows.Forms.Button();
            this.btnAddGroupName = new System.Windows.Forms.Button();
            this.btnEditGroup = new System.Windows.Forms.Button();
            this.btnRemoveGroup = new System.Windows.Forms.Button();
            this.txtNewGroupName = new System.Windows.Forms.TextBox();
            this.txt_ContactID = new System.Windows.Forms.TextBox();
            this.cboRemoveGroup = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.cboEditSelectGroup = new System.Windows.Forms.ComboBox();
            this.lblGroup = new System.Windows.Forms.Label();
            this.groupBox_EnterContactID = new System.Windows.Forms.GroupBox();
            this.groupBoxAdd_EnterGroupName = new System.Windows.Forms.GroupBox();
            this.txt_Enter_GroupID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxEdit_SelectGroup_EnterNewName = new System.Windows.Forms.GroupBox();
            this.groupBoxRemove_SelectGroup = new System.Windows.Forms.GroupBox();
            this.panel_Infor = new System.Windows.Forms.Panel();
            this.pictureBox_User = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Logout = new System.Windows.Forms.Label();
            this.lblManageAccount = new System.Windows.Forms.Label();
            this.lblSeperate = new System.Windows.Forms.Label();
            this.lblEditMyInfor = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBoxAdd_EnterGroupName.SuspendLayout();
            this.panel_Infor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_User)).BeginInit();
            this.SuspendLayout();
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(117, 154);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(52, 16);
            this.lblContact.TabIndex = 0;
            this.lblContact.Text = "Contact";
            // 
            // lblContactID
            // 
            this.lblContactID.AutoSize = true;
            this.lblContactID.Location = new System.Drawing.Point(32, 346);
            this.lblContactID.Name = "lblContactID";
            this.lblContactID.Size = new System.Drawing.Size(102, 16);
            this.lblContactID.TabIndex = 2;
            this.lblContactID.Text = "Enter Contact ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(579, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter New Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(581, 559);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Select Group:";
            // 
            // btnAddContact
            // 
            this.btnAddContact.BackColor = System.Drawing.Color.Lime;
            this.btnAddContact.Location = new System.Drawing.Point(67, 182);
            this.btnAddContact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(157, 48);
            this.btnAddContact.TabIndex = 7;
            this.btnAddContact.Text = "Add";
            this.btnAddContact.UseVisualStyleBackColor = false;
            this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Click);
            // 
            // btnEditContact
            // 
            this.btnEditContact.BackColor = System.Drawing.Color.Lime;
            this.btnEditContact.Location = new System.Drawing.Point(67, 245);
            this.btnEditContact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditContact.Name = "btnEditContact";
            this.btnEditContact.Size = new System.Drawing.Size(157, 48);
            this.btnEditContact.TabIndex = 8;
            this.btnEditContact.Text = "Edit";
            this.btnEditContact.UseVisualStyleBackColor = false;
            this.btnEditContact.Click += new System.EventHandler(this.btnEditContact_Click);
            // 
            // btn_ContactID_Remove
            // 
            this.btn_ContactID_Remove.BackColor = System.Drawing.Color.Lime;
            this.btn_ContactID_Remove.Location = new System.Drawing.Point(41, 393);
            this.btn_ContactID_Remove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ContactID_Remove.Name = "btn_ContactID_Remove";
            this.btn_ContactID_Remove.Size = new System.Drawing.Size(359, 34);
            this.btn_ContactID_Remove.TabIndex = 9;
            this.btn_ContactID_Remove.Text = "Remove";
            this.btn_ContactID_Remove.UseVisualStyleBackColor = false;
            this.btn_ContactID_Remove.Click += new System.EventHandler(this.btn_ContactID_Remove_Click);
            // 
            // btn_ContactID_Select
            // 
            this.btn_ContactID_Select.BackColor = System.Drawing.Color.Lime;
            this.btn_ContactID_Select.Location = new System.Drawing.Point(299, 338);
            this.btn_ContactID_Select.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ContactID_Select.Name = "btn_ContactID_Select";
            this.btn_ContactID_Select.Size = new System.Drawing.Size(101, 34);
            this.btn_ContactID_Select.TabIndex = 10;
            this.btn_ContactID_Select.Text = "Select Contact";
            this.btn_ContactID_Select.UseVisualStyleBackColor = false;
            this.btn_ContactID_Select.Click += new System.EventHandler(this.btn_ContactID_Select_Click);
            // 
            // btnShowFullList
            // 
            this.btnShowFullList.BackColor = System.Drawing.Color.Lime;
            this.btnShowFullList.Location = new System.Drawing.Point(41, 500);
            this.btnShowFullList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowFullList.Name = "btnShowFullList";
            this.btnShowFullList.Size = new System.Drawing.Size(359, 34);
            this.btnShowFullList.TabIndex = 11;
            this.btnShowFullList.Text = "Show Ful List";
            this.btnShowFullList.UseVisualStyleBackColor = false;
            this.btnShowFullList.Click += new System.EventHandler(this.btnShowFullList_Click);
            // 
            // btnAddGroupName
            // 
            this.btnAddGroupName.BackColor = System.Drawing.Color.Lime;
            this.btnAddGroupName.Location = new System.Drawing.Point(195, 117);
            this.btnAddGroupName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddGroupName.Name = "btnAddGroupName";
            this.btnAddGroupName.Size = new System.Drawing.Size(123, 34);
            this.btnAddGroupName.TabIndex = 12;
            this.btnAddGroupName.Text = "Add";
            this.btnAddGroupName.UseVisualStyleBackColor = false;
            this.btnAddGroupName.Click += new System.EventHandler(this.btnAddGroupName_Click);
            // 
            // btnEditGroup
            // 
            this.btnEditGroup.BackColor = System.Drawing.Color.Lime;
            this.btnEditGroup.Location = new System.Drawing.Point(709, 446);
            this.btnEditGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditGroup.Name = "btnEditGroup";
            this.btnEditGroup.Size = new System.Drawing.Size(100, 44);
            this.btnEditGroup.TabIndex = 13;
            this.btnEditGroup.Text = "Edit";
            this.btnEditGroup.UseVisualStyleBackColor = false;
            this.btnEditGroup.Click += new System.EventHandler(this.btnEditGroup_Click);
            // 
            // btnRemoveGroup
            // 
            this.btnRemoveGroup.BackColor = System.Drawing.Color.Lime;
            this.btnRemoveGroup.Location = new System.Drawing.Point(703, 596);
            this.btnRemoveGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveGroup.Name = "btnRemoveGroup";
            this.btnRemoveGroup.Size = new System.Drawing.Size(107, 41);
            this.btnRemoveGroup.TabIndex = 14;
            this.btnRemoveGroup.Text = "Remove";
            this.btnRemoveGroup.UseVisualStyleBackColor = false;
            this.btnRemoveGroup.Click += new System.EventHandler(this.btnRemoveGroup_Click);
            // 
            // txtNewGroupName
            // 
            this.txtNewGroupName.Location = new System.Drawing.Point(709, 400);
            this.txtNewGroupName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNewGroupName.Name = "txtNewGroupName";
            this.txtNewGroupName.Size = new System.Drawing.Size(100, 22);
            this.txtNewGroupName.TabIndex = 15;
            // 
            // txt_ContactID
            // 
            this.txt_ContactID.Location = new System.Drawing.Point(171, 343);
            this.txt_ContactID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ContactID.Name = "txt_ContactID";
            this.txt_ContactID.Size = new System.Drawing.Size(100, 22);
            this.txt_ContactID.TabIndex = 17;
            // 
            // cboRemoveGroup
            // 
            this.cboRemoveGroup.FormattingEnabled = true;
            this.cboRemoveGroup.Location = new System.Drawing.Point(689, 556);
            this.cboRemoveGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboRemoveGroup.Name = "cboRemoveGroup";
            this.cboRemoveGroup.Size = new System.Drawing.Size(121, 24);
            this.cboRemoveGroup.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(579, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Group:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(573, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Enter Group Name:";
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(184, 30);
            this.txtGroupName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(127, 22);
            this.txtGroupName.TabIndex = 16;
            // 
            // cboEditSelectGroup
            // 
            this.cboEditSelectGroup.FormattingEnabled = true;
            this.cboEditSelectGroup.Location = new System.Drawing.Point(696, 354);
            this.cboEditSelectGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboEditSelectGroup.Name = "cboEditSelectGroup";
            this.cboEditSelectGroup.Size = new System.Drawing.Size(121, 24);
            this.cboEditSelectGroup.TabIndex = 18;
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(573, 165);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(44, 16);
            this.lblGroup.TabIndex = 20;
            this.lblGroup.Text = "Group";
            // 
            // groupBox_EnterContactID
            // 
            this.groupBox_EnterContactID.Location = new System.Drawing.Point(23, 313);
            this.groupBox_EnterContactID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_EnterContactID.Name = "groupBox_EnterContactID";
            this.groupBox_EnterContactID.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_EnterContactID.Size = new System.Drawing.Size(391, 123);
            this.groupBox_EnterContactID.TabIndex = 21;
            this.groupBox_EnterContactID.TabStop = false;
            // 
            // groupBoxAdd_EnterGroupName
            // 
            this.groupBoxAdd_EnterGroupName.Controls.Add(this.txt_Enter_GroupID);
            this.groupBoxAdd_EnterGroupName.Controls.Add(this.label1);
            this.groupBoxAdd_EnterGroupName.Controls.Add(this.txtGroupName);
            this.groupBoxAdd_EnterGroupName.Controls.Add(this.btnAddGroupName);
            this.groupBoxAdd_EnterGroupName.Location = new System.Drawing.Point(545, 193);
            this.groupBoxAdd_EnterGroupName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxAdd_EnterGroupName.Name = "groupBoxAdd_EnterGroupName";
            this.groupBoxAdd_EnterGroupName.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxAdd_EnterGroupName.Size = new System.Drawing.Size(317, 156);
            this.groupBoxAdd_EnterGroupName.TabIndex = 22;
            this.groupBoxAdd_EnterGroupName.TabStop = false;
            // 
            // txt_Enter_GroupID
            // 
            this.txt_Enter_GroupID.Location = new System.Drawing.Point(184, 80);
            this.txt_Enter_GroupID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Enter_GroupID.Name = "txt_Enter_GroupID";
            this.txt_Enter_GroupID.Size = new System.Drawing.Size(127, 22);
            this.txt_Enter_GroupID.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Enter Group ID:";
            // 
            // groupBoxEdit_SelectGroup_EnterNewName
            // 
            this.groupBoxEdit_SelectGroup_EnterNewName.Location = new System.Drawing.Point(547, 331);
            this.groupBoxEdit_SelectGroup_EnterNewName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxEdit_SelectGroup_EnterNewName.Name = "groupBoxEdit_SelectGroup_EnterNewName";
            this.groupBoxEdit_SelectGroup_EnterNewName.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxEdit_SelectGroup_EnterNewName.Size = new System.Drawing.Size(316, 166);
            this.groupBoxEdit_SelectGroup_EnterNewName.TabIndex = 23;
            this.groupBoxEdit_SelectGroup_EnterNewName.TabStop = false;
            // 
            // groupBoxRemove_SelectGroup
            // 
            this.groupBoxRemove_SelectGroup.Location = new System.Drawing.Point(547, 537);
            this.groupBoxRemove_SelectGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxRemove_SelectGroup.Name = "groupBoxRemove_SelectGroup";
            this.groupBoxRemove_SelectGroup.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxRemove_SelectGroup.Size = new System.Drawing.Size(316, 116);
            this.groupBoxRemove_SelectGroup.TabIndex = 24;
            this.groupBoxRemove_SelectGroup.TabStop = false;
            // 
            // panel_Infor
            // 
            this.panel_Infor.BackColor = System.Drawing.Color.YellowGreen;
            this.panel_Infor.Controls.Add(this.pictureBox_User);
            this.panel_Infor.Controls.Add(this.label3);
            this.panel_Infor.Controls.Add(this.lbl_Logout);
            this.panel_Infor.Controls.Add(this.lblManageAccount);
            this.panel_Infor.Controls.Add(this.lblSeperate);
            this.panel_Infor.Controls.Add(this.lblEditMyInfor);
            this.panel_Infor.Controls.Add(this.lblUser);
            this.panel_Infor.Controls.Add(this.lblWelcome);
            this.panel_Infor.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Infor.Location = new System.Drawing.Point(0, 0);
            this.panel_Infor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Infor.Name = "panel_Infor";
            this.panel_Infor.Size = new System.Drawing.Size(907, 121);
            this.panel_Infor.TabIndex = 25;
            this.panel_Infor.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox_User
            // 
            this.pictureBox_User.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_User.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_User.Name = "pictureBox_User";
            this.pictureBox_User.Size = new System.Drawing.Size(123, 96);
            this.pictureBox_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_User.TabIndex = 0;
            this.pictureBox_User.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(436, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "|";
            // 
            // lbl_Logout
            // 
            this.lbl_Logout.AutoSize = true;
            this.lbl_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Logout.ForeColor = System.Drawing.Color.White;
            this.lbl_Logout.Location = new System.Drawing.Point(346, 76);
            this.lbl_Logout.Name = "lbl_Logout";
            this.lbl_Logout.Size = new System.Drawing.Size(81, 22);
            this.lbl_Logout.TabIndex = 6;
            this.lbl_Logout.Text = "Log Out";
            this.lbl_Logout.Click += new System.EventHandler(this.lbl_Logout_Click);
            // 
            // lblManageAccount
            // 
            this.lblManageAccount.AutoSize = true;
            this.lblManageAccount.BackColor = System.Drawing.Color.Red;
            this.lblManageAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageAccount.ForeColor = System.Drawing.Color.White;
            this.lblManageAccount.Location = new System.Drawing.Point(470, 76);
            this.lblManageAccount.Name = "lblManageAccount";
            this.lblManageAccount.Size = new System.Drawing.Size(164, 22);
            this.lblManageAccount.TabIndex = 5;
            this.lblManageAccount.Text = "Manage Account ";
            this.lblManageAccount.Click += new System.EventHandler(this.lblManageAccount_Click);
            // 
            // lblSeperate
            // 
            this.lblSeperate.AutoSize = true;
            this.lblSeperate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeperate.ForeColor = System.Drawing.Color.White;
            this.lblSeperate.Location = new System.Drawing.Point(311, 76);
            this.lblSeperate.Name = "lblSeperate";
            this.lblSeperate.Size = new System.Drawing.Size(16, 22);
            this.lblSeperate.TabIndex = 4;
            this.lblSeperate.Text = "|";
            // 
            // lblEditMyInfor
            // 
            this.lblEditMyInfor.AutoSize = true;
            this.lblEditMyInfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditMyInfor.ForeColor = System.Drawing.Color.White;
            this.lblEditMyInfor.Location = new System.Drawing.Point(171, 76);
            this.lblEditMyInfor.Name = "lblEditMyInfor";
            this.lblEditMyInfor.Size = new System.Drawing.Size(122, 22);
            this.lblEditMyInfor.TabIndex = 3;
            this.lblEditMyInfor.Text = "Edit My Infor";
            this.lblEditMyInfor.Click += new System.EventHandler(this.lblEditMyInfor_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(403, 23);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(49, 22);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "user";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(171, 23);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(97, 22);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome:";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Lime;
            this.btnExit.Location = new System.Drawing.Point(41, 559);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(359, 38);
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Location = new System.Drawing.Point(451, 158);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(13, 495);
            this.panel2.TabIndex = 27;
            // 
            // frmMainHR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(907, 686);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel_Infor);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.cboRemoveGroup);
            this.Controls.Add(this.cboEditSelectGroup);
            this.Controls.Add(this.txt_ContactID);
            this.Controls.Add(this.txtNewGroupName);
            this.Controls.Add(this.btnRemoveGroup);
            this.Controls.Add(this.btnEditGroup);
            this.Controls.Add(this.btnShowFullList);
            this.Controls.Add(this.btn_ContactID_Select);
            this.Controls.Add(this.btn_ContactID_Remove);
            this.Controls.Add(this.btnEditContact);
            this.Controls.Add(this.btnAddContact);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblContactID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.groupBox_EnterContactID);
            this.Controls.Add(this.groupBoxAdd_EnterGroupName);
            this.Controls.Add(this.groupBoxEdit_SelectGroup_EnterNewName);
            this.Controls.Add(this.groupBoxRemove_SelectGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMainHR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HR Main Form";
            this.Load += new System.EventHandler(this.frmMainHR_Load);
            this.groupBoxAdd_EnterGroupName.ResumeLayout(false);
            this.groupBoxAdd_EnterGroupName.PerformLayout();
            this.panel_Infor.ResumeLayout(false);
            this.panel_Infor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_User)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblContactID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.Button btnEditContact;
        private System.Windows.Forms.Button btn_ContactID_Remove;
        private System.Windows.Forms.Button btn_ContactID_Select;
        private System.Windows.Forms.Button btnShowFullList;
        private System.Windows.Forms.Button btnAddGroupName;
        private System.Windows.Forms.Button btnEditGroup;
        private System.Windows.Forms.Button btnRemoveGroup;
        private System.Windows.Forms.TextBox txtNewGroupName;
        private System.Windows.Forms.TextBox txt_ContactID;
        private System.Windows.Forms.ComboBox cboRemoveGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.ComboBox cboEditSelectGroup;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.GroupBox groupBox_EnterContactID;
        private System.Windows.Forms.GroupBox groupBoxAdd_EnterGroupName;
        private System.Windows.Forms.GroupBox groupBoxEdit_SelectGroup_EnterNewName;
        private System.Windows.Forms.GroupBox groupBoxRemove_SelectGroup;
        private System.Windows.Forms.Panel panel_Infor;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblManageAccount;
        private System.Windows.Forms.Label lblSeperate;
        private System.Windows.Forms.Label lblEditMyInfor;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox pictureBox_User;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Logout;
        private System.Windows.Forms.TextBox txt_Enter_GroupID;
        private System.Windows.Forms.Label label1;
    }
}