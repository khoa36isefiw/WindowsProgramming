namespace _20110375_HuynhDangKhoa_LoginForm
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStudentAdded = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStudentList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStudentStatics = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStudentEditAndRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStudentManageStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStudentPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuStudentExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCourse = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuScore = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManageUser = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManageUser_Account = new System.Windows.Forms.ToolStripMenuItem();
            this.picBackGround = new System.Windows.Forms.PictureBox();
            this.btnlogOut = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackGround)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStudent,
            this.mnuCourse,
            this.mnuScore,
            this.mnuManageUser});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuStudent
            // 
            this.mnuStudent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStudentAdded,
            this.mnuStudentList,
            this.mnuStudentStatics,
            this.mnuStudentEditAndRemove,
            this.mnuStudentManageStudent,
            this.mnuStudentPrint,
            this.toolStripMenuItem1,
            this.mnuStudentExit});
            this.mnuStudent.Name = "mnuStudent";
            this.mnuStudent.Size = new System.Drawing.Size(87, 26);
            this.mnuStudent.Text = "STUDENT";
            // 
            // mnuStudentAdded
            // 
            this.mnuStudentAdded.Name = "mnuStudentAdded";
            this.mnuStudentAdded.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuStudentAdded.Size = new System.Drawing.Size(266, 26);
            this.mnuStudentAdded.Text = "Add New Student ";
            this.mnuStudentAdded.Click += new System.EventHandler(this.mnuStudentAdded_Click);
            // 
            // mnuStudentList
            // 
            this.mnuStudentList.Name = "mnuStudentList";
            this.mnuStudentList.Size = new System.Drawing.Size(266, 26);
            this.mnuStudentList.Text = "Students List";
            this.mnuStudentList.Click += new System.EventHandler(this.mnuStudentList_Click);
            // 
            // mnuStudentStatics
            // 
            this.mnuStudentStatics.Name = "mnuStudentStatics";
            this.mnuStudentStatics.Size = new System.Drawing.Size(266, 26);
            this.mnuStudentStatics.Text = "Statics";
            // 
            // mnuStudentEditAndRemove
            // 
            this.mnuStudentEditAndRemove.Name = "mnuStudentEditAndRemove";
            this.mnuStudentEditAndRemove.Size = new System.Drawing.Size(266, 26);
            this.mnuStudentEditAndRemove.Text = "Edit / Remove";
            this.mnuStudentEditAndRemove.Click += new System.EventHandler(this.mnuStudentEditAndRemove_Click);
            // 
            // mnuStudentManageStudent
            // 
            this.mnuStudentManageStudent.Name = "mnuStudentManageStudent";
            this.mnuStudentManageStudent.Size = new System.Drawing.Size(266, 26);
            this.mnuStudentManageStudent.Text = "Manage Student Form";
            // 
            // mnuStudentPrint
            // 
            this.mnuStudentPrint.Name = "mnuStudentPrint";
            this.mnuStudentPrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.mnuStudentPrint.Size = new System.Drawing.Size(266, 26);
            this.mnuStudentPrint.Text = "Print";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(263, 6);
            // 
            // mnuStudentExit
            // 
            this.mnuStudentExit.Name = "mnuStudentExit";
            this.mnuStudentExit.Size = new System.Drawing.Size(266, 26);
            this.mnuStudentExit.Text = "Exit";
            this.mnuStudentExit.Click += new System.EventHandler(this.mnuStudentExit_Click);
            // 
            // mnuCourse
            // 
            this.mnuCourse.Name = "mnuCourse";
            this.mnuCourse.Size = new System.Drawing.Size(78, 26);
            this.mnuCourse.Text = "COURSE";
            // 
            // mnuScore
            // 
            this.mnuScore.Name = "mnuScore";
            this.mnuScore.Size = new System.Drawing.Size(68, 26);
            this.mnuScore.Text = "SCORE";
            // 
            // mnuManageUser
            // 
            this.mnuManageUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuManageUser_Account});
            this.mnuManageUser.Name = "mnuManageUser";
            this.mnuManageUser.Size = new System.Drawing.Size(164, 26);
            this.mnuManageUser.Text = "MANAGEMENT USER";
            this.mnuManageUser.Click += new System.EventHandler(this.mnuManageUser_Click);
            // 
            // mnuManageUser_Account
            // 
            this.mnuManageUser_Account.Name = "mnuManageUser_Account";
            this.mnuManageUser_Account.Size = new System.Drawing.Size(146, 26);
            this.mnuManageUser_Account.Text = "Account";
            this.mnuManageUser_Account.Click += new System.EventHandler(this.mnuManageUser_Account_Click);
            // 
            // picBackGround
            // 
            this.picBackGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBackGround.Image = ((System.Drawing.Image)(resources.GetObject("picBackGround.Image")));
            this.picBackGround.Location = new System.Drawing.Point(0, 30);
            this.picBackGround.Name = "picBackGround";
            this.picBackGround.Size = new System.Drawing.Size(1008, 571);
            this.picBackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBackGround.TabIndex = 1;
            this.picBackGround.TabStop = false;
            // 
            // btnlogOut
            // 
            this.btnlogOut.Location = new System.Drawing.Point(681, 4);
            this.btnlogOut.Name = "btnlogOut";
            this.btnlogOut.Size = new System.Drawing.Size(75, 23);
            this.btnlogOut.TabIndex = 2;
            this.btnlogOut.Text = "LogOut";
            this.btnlogOut.UseVisualStyleBackColor = true;
            this.btnlogOut.Click += new System.EventHandler(this.btnlogOut_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 601);
            this.Controls.Add(this.btnlogOut);
            this.Controls.Add(this.picBackGround);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ Thống Quản Lý Sinh Viên";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackGround)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuStudent;
        private System.Windows.Forms.ToolStripMenuItem mnuCourse;
        private System.Windows.Forms.ToolStripMenuItem mnuScore;
        private System.Windows.Forms.ToolStripMenuItem mnuStudentAdded;
        private System.Windows.Forms.ToolStripMenuItem mnuStudentList;
        private System.Windows.Forms.ToolStripMenuItem mnuStudentStatics;
        private System.Windows.Forms.ToolStripMenuItem mnuStudentEditAndRemove;
        private System.Windows.Forms.ToolStripMenuItem mnuStudentManageStudent;
        private System.Windows.Forms.ToolStripMenuItem mnuStudentPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuStudentExit;
        private System.Windows.Forms.PictureBox picBackGround;
        private System.Windows.Forms.Button btnlogOut;
        private System.Windows.Forms.ToolStripMenuItem mnuManageUser_Account;
        internal System.Windows.Forms.ToolStripMenuItem mnuManageUser;
    }
}