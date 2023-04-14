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
            this.mnuStudentStatistics = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStudent_Statistics_Chart = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStatistics_PieChart = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStudentEditAndRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManageStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStudentPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuStudentExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStudent_Find = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCourse = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCourse_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCOURSE_List = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCourse_Remove = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCourse_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCourse_Manage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCourse_Print = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuScore = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSCORE_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSCORE_Remove = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSCORE_Manage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSCORE_AverageScore = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSCORE_Print = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSCORE_Result = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManageUser = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManageUser_Account = new System.Windows.Forms.ToolStripMenuItem();
            this.rESULTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuResult_AVGResult = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuResult_StaticsResult = new System.Windows.Forms.ToolStripMenuItem();
            this.picBackGround = new System.Windows.Forms.PictureBox();
            this.btnlogOut = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackGround)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStudent,
            this.mnuCourse,
            this.mnuScore,
            this.mnuManageUser,
            this.rESULTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 54);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuStudent
            // 
            this.mnuStudent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStudentAdded,
            this.mnuStudentList,
            this.mnuStudentStatistics,
            this.mnuStudentEditAndRemove,
            this.mnuManageStudent,
            this.mnuStudentPrint,
            this.toolStripMenuItem1,
            this.mnuStudentExit,
            this.mnuStudent_Find});
            this.mnuStudent.Name = "mnuStudent";
            this.mnuStudent.Size = new System.Drawing.Size(87, 50);
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
            // mnuStudentStatistics
            // 
            this.mnuStudentStatistics.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStudent_Statistics_Chart,
            this.mnuStatistics_PieChart});
            this.mnuStudentStatistics.Name = "mnuStudentStatistics";
            this.mnuStudentStatistics.Size = new System.Drawing.Size(266, 26);
            this.mnuStudentStatistics.Text = "Statistics";
            this.mnuStudentStatistics.Click += new System.EventHandler(this.mnuStudentStatistics_Click);
            // 
            // mnuStudent_Statistics_Chart
            // 
            this.mnuStudent_Statistics_Chart.Name = "mnuStudent_Statistics_Chart";
            this.mnuStudent_Statistics_Chart.Size = new System.Drawing.Size(151, 26);
            this.mnuStudent_Statistics_Chart.Text = "Chart";
            this.mnuStudent_Statistics_Chart.Click += new System.EventHandler(this.mnuStudent_Statistics_Chart_Click);
            // 
            // mnuStatistics_PieChart
            // 
            this.mnuStatistics_PieChart.Name = "mnuStatistics_PieChart";
            this.mnuStatistics_PieChart.Size = new System.Drawing.Size(151, 26);
            this.mnuStatistics_PieChart.Text = "Pie Chart";
            this.mnuStatistics_PieChart.Click += new System.EventHandler(this.mnuStatistics_PieChart_Click);
            // 
            // mnuStudentEditAndRemove
            // 
            this.mnuStudentEditAndRemove.Name = "mnuStudentEditAndRemove";
            this.mnuStudentEditAndRemove.Size = new System.Drawing.Size(266, 26);
            this.mnuStudentEditAndRemove.Text = "Edit / Remove";
            this.mnuStudentEditAndRemove.Click += new System.EventHandler(this.mnuStudentEditAndRemove_Click);
            // 
            // mnuManageStudent
            // 
            this.mnuManageStudent.Name = "mnuManageStudent";
            this.mnuManageStudent.Size = new System.Drawing.Size(266, 26);
            this.mnuManageStudent.Text = "Manage Student Form";
            this.mnuManageStudent.Click += new System.EventHandler(this.mnuManageStudent_Click);
            // 
            // mnuStudentPrint
            // 
            this.mnuStudentPrint.Name = "mnuStudentPrint";
            this.mnuStudentPrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.mnuStudentPrint.Size = new System.Drawing.Size(266, 26);
            this.mnuStudentPrint.Text = "Print";
            this.mnuStudentPrint.Click += new System.EventHandler(this.mnuStudentPrint_Click);
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
            // mnuStudent_Find
            // 
            this.mnuStudent_Find.Name = "mnuStudent_Find";
            this.mnuStudent_Find.Size = new System.Drawing.Size(266, 26);
            this.mnuStudent_Find.Text = "Find";
            this.mnuStudent_Find.Click += new System.EventHandler(this.mnuStudent_Find_Click);
            // 
            // mnuCourse
            // 
            this.mnuCourse.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCourse_Add,
            this.mnuCOURSE_List,
            this.mnuCourse_Remove,
            this.mnuCourse_Edit,
            this.mnuCourse_Manage,
            this.toolStripMenuItem3,
            this.mnuCourse_Print});
            this.mnuCourse.Name = "mnuCourse";
            this.mnuCourse.Size = new System.Drawing.Size(78, 50);
            this.mnuCourse.Text = "COURSE";
            // 
            // mnuCourse_Add
            // 
            this.mnuCourse_Add.Name = "mnuCourse_Add";
            this.mnuCourse_Add.Size = new System.Drawing.Size(201, 26);
            this.mnuCourse_Add.Text = "Add Course";
            this.mnuCourse_Add.Click += new System.EventHandler(this.mnuCourse_Add_Click);
            // 
            // mnuCOURSE_List
            // 
            this.mnuCOURSE_List.Name = "mnuCOURSE_List";
            this.mnuCOURSE_List.Size = new System.Drawing.Size(201, 26);
            this.mnuCOURSE_List.Text = "List Course";
            this.mnuCOURSE_List.Click += new System.EventHandler(this.mnuCOURSE_List_Click);
            // 
            // mnuCourse_Remove
            // 
            this.mnuCourse_Remove.Name = "mnuCourse_Remove";
            this.mnuCourse_Remove.Size = new System.Drawing.Size(201, 26);
            this.mnuCourse_Remove.Text = "Remove Course";
            this.mnuCourse_Remove.Click += new System.EventHandler(this.mnuCourse_Remove_Click);
            // 
            // mnuCourse_Edit
            // 
            this.mnuCourse_Edit.Name = "mnuCourse_Edit";
            this.mnuCourse_Edit.Size = new System.Drawing.Size(201, 26);
            this.mnuCourse_Edit.Text = "Edit Course";
            this.mnuCourse_Edit.Click += new System.EventHandler(this.mnuCourse_Edit_Click);
            // 
            // mnuCourse_Manage
            // 
            this.mnuCourse_Manage.Name = "mnuCourse_Manage";
            this.mnuCourse_Manage.Size = new System.Drawing.Size(201, 26);
            this.mnuCourse_Manage.Text = "Manage Courses";
            this.mnuCourse_Manage.Click += new System.EventHandler(this.mnuCourse_Manage_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(198, 6);
            // 
            // mnuCourse_Print
            // 
            this.mnuCourse_Print.Name = "mnuCourse_Print";
            this.mnuCourse_Print.Size = new System.Drawing.Size(201, 26);
            this.mnuCourse_Print.Text = "Print";
            this.mnuCourse_Print.Click += new System.EventHandler(this.mnuCourse_Print_Click);
            // 
            // mnuScore
            // 
            this.mnuScore.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSCORE_Add,
            this.mnuSCORE_Remove,
            this.mnuSCORE_Manage,
            this.mnuSCORE_AverageScore,
            this.toolStripMenuItem2,
            this.mnuSCORE_Print,
            this.mnuSCORE_Result});
            this.mnuScore.Name = "mnuScore";
            this.mnuScore.Size = new System.Drawing.Size(68, 50);
            this.mnuScore.Text = "SCORE";
            // 
            // mnuSCORE_Add
            // 
            this.mnuSCORE_Add.Name = "mnuSCORE_Add";
            this.mnuSCORE_Add.Size = new System.Drawing.Size(257, 26);
            this.mnuSCORE_Add.Text = "Add Score";
            this.mnuSCORE_Add.Click += new System.EventHandler(this.mnuSCORE_Add_Click);
            // 
            // mnuSCORE_Remove
            // 
            this.mnuSCORE_Remove.Name = "mnuSCORE_Remove";
            this.mnuSCORE_Remove.Size = new System.Drawing.Size(257, 26);
            this.mnuSCORE_Remove.Text = "Remove Score";
            this.mnuSCORE_Remove.Click += new System.EventHandler(this.mnuSCORE_Remove_Click);
            // 
            // mnuSCORE_Manage
            // 
            this.mnuSCORE_Manage.Name = "mnuSCORE_Manage";
            this.mnuSCORE_Manage.Size = new System.Drawing.Size(257, 26);
            this.mnuSCORE_Manage.Text = "Manage Score";
            this.mnuSCORE_Manage.Click += new System.EventHandler(this.mnuSCORE_Manage_Click);
            // 
            // mnuSCORE_AverageScore
            // 
            this.mnuSCORE_AverageScore.Name = "mnuSCORE_AverageScore";
            this.mnuSCORE_AverageScore.Size = new System.Drawing.Size(257, 26);
            this.mnuSCORE_AverageScore.Text = "Average Score By Course";
            this.mnuSCORE_AverageScore.Click += new System.EventHandler(this.mnuSCORE_AverageScore_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(254, 6);
            // 
            // mnuSCORE_Print
            // 
            this.mnuSCORE_Print.Name = "mnuSCORE_Print";
            this.mnuSCORE_Print.Size = new System.Drawing.Size(257, 26);
            this.mnuSCORE_Print.Text = "Print";
            this.mnuSCORE_Print.Click += new System.EventHandler(this.mnuSCORE_Print_Click);
            // 
            // mnuSCORE_Result
            // 
            this.mnuSCORE_Result.Name = "mnuSCORE_Result";
            this.mnuSCORE_Result.Size = new System.Drawing.Size(257, 26);
            this.mnuSCORE_Result.Text = "Result";
            this.mnuSCORE_Result.Click += new System.EventHandler(this.mnuSCORE_Result_Click);
            // 
            // mnuManageUser
            // 
            this.mnuManageUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuManageUser_Account});
            this.mnuManageUser.Name = "mnuManageUser";
            this.mnuManageUser.Size = new System.Drawing.Size(164, 50);
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
            // rESULTToolStripMenuItem
            // 
            this.rESULTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuResult_AVGResult,
            this.mnuResult_StaticsResult});
            this.rESULTToolStripMenuItem.Name = "rESULTToolStripMenuItem";
            this.rESULTToolStripMenuItem.Size = new System.Drawing.Size(72, 50);
            this.rESULTToolStripMenuItem.Text = "RESULT";
            // 
            // mnuResult_AVGResult
            // 
            this.mnuResult_AVGResult.Name = "mnuResult_AVGResult";
            this.mnuResult_AVGResult.Size = new System.Drawing.Size(229, 26);
            this.mnuResult_AVGResult.Text = " AVG Result By Score";
            this.mnuResult_AVGResult.Click += new System.EventHandler(this.mnuResult_AVGResult_Click);
            // 
            // mnuResult_StaticsResult
            // 
            this.mnuResult_StaticsResult.Name = "mnuResult_StaticsResult";
            this.mnuResult_StaticsResult.Size = new System.Drawing.Size(229, 26);
            this.mnuResult_StaticsResult.Text = "Statics Result";
            this.mnuResult_StaticsResult.Click += new System.EventHandler(this.mnuResult_StaticsResult_Click);
            // 
            // picBackGround
            // 
            this.picBackGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBackGround.Image = ((System.Drawing.Image)(resources.GetObject("picBackGround.Image")));
            this.picBackGround.Location = new System.Drawing.Point(0, 54);
            this.picBackGround.Name = "picBackGround";
            this.picBackGround.Size = new System.Drawing.Size(1008, 547);
            this.picBackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBackGround.TabIndex = 1;
            this.picBackGround.TabStop = false;
            // 
            // btnlogOut
            // 
            this.btnlogOut.Location = new System.Drawing.Point(760, 12);
            this.btnlogOut.Name = "btnlogOut";
            this.btnlogOut.Size = new System.Drawing.Size(75, 36);
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

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuStudent;
        private System.Windows.Forms.ToolStripMenuItem mnuCourse;
        private System.Windows.Forms.ToolStripMenuItem mnuScore;
        private System.Windows.Forms.ToolStripMenuItem mnuStudentAdded;
        private System.Windows.Forms.ToolStripMenuItem mnuStudentList;
        private System.Windows.Forms.ToolStripMenuItem mnuStudentStatistics;
        private System.Windows.Forms.ToolStripMenuItem mnuStudentEditAndRemove;
        private System.Windows.Forms.ToolStripMenuItem mnuManageStudent;
        private System.Windows.Forms.ToolStripMenuItem mnuStudentPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuStudentExit;
        private System.Windows.Forms.PictureBox picBackGround;
        private System.Windows.Forms.Button btnlogOut;
        private System.Windows.Forms.ToolStripMenuItem mnuManageUser_Account;
        internal System.Windows.Forms.ToolStripMenuItem mnuManageUser;
        private System.Windows.Forms.ToolStripMenuItem mnuStudent_Find;
        private System.Windows.Forms.ToolStripMenuItem mnuStudent_Statistics_Chart;
        private System.Windows.Forms.ToolStripMenuItem mnuStatistics_PieChart;
        private System.Windows.Forms.ToolStripMenuItem mnuCourse_Add;
        private System.Windows.Forms.ToolStripMenuItem mnuCourse_Remove;
        private System.Windows.Forms.ToolStripMenuItem mnuCourse_Edit;
        private System.Windows.Forms.ToolStripMenuItem mnuCourse_Manage;
        private System.Windows.Forms.ToolStripMenuItem mnuCourse_Print;
        private System.Windows.Forms.ToolStripMenuItem mnuCOURSE_List;
        private System.Windows.Forms.ToolStripMenuItem mnuSCORE_Add;
        private System.Windows.Forms.ToolStripMenuItem mnuSCORE_Remove;
        private System.Windows.Forms.ToolStripMenuItem mnuSCORE_Manage;
        private System.Windows.Forms.ToolStripMenuItem mnuSCORE_AverageScore;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuSCORE_Print;
        private System.Windows.Forms.ToolStripMenuItem mnuSCORE_Result;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem rESULTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuResult_AVGResult;
        private System.Windows.Forms.ToolStripMenuItem mnuResult_StaticsResult;
    }
}