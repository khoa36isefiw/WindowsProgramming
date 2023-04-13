namespace _20110375_HuynhDangKhoa_LoginForm.Score
{
    partial class AddScore
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddScore = new System.Windows.Forms.Button();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblSelectCourse = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.txtCourseDescription = new System.Windows.Forms.TextBox();
            this.cboChooseCourse = new System.Windows.Forms.ComboBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.dataGridView_Score = new System.Windows.Forms.DataGridView();
            this.lblStudentList = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Score)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(698, 370);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(124, 46);
            this.btnRefresh.TabIndex = 55;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnAddScore
            // 
            this.btnAddScore.Location = new System.Drawing.Point(190, 370);
            this.btnAddScore.Name = "btnAddScore";
            this.btnAddScore.Size = new System.Drawing.Size(124, 46);
            this.btnAddScore.TabIndex = 51;
            this.btnAddScore.Text = "Add Score";
            this.btnAddScore.UseVisualStyleBackColor = true;
            this.btnAddScore.Click += new System.EventHandler(this.btnAddScore_Click);
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(190, 29);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(160, 22);
            this.txtStudentID.TabIndex = 46;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(45, 207);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(127, 25);
            this.lblDescription.TabIndex = 43;
            this.lblDescription.Text = "Description:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(96, 142);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(76, 25);
            this.lblScore.TabIndex = 42;
            this.lblScore.Text = "Score:";
            // 
            // lblSelectCourse
            // 
            this.lblSelectCourse.AutoSize = true;
            this.lblSelectCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCourse.Location = new System.Drawing.Point(21, 86);
            this.lblSelectCourse.Name = "lblSelectCourse";
            this.lblSelectCourse.Size = new System.Drawing.Size(151, 25);
            this.lblSelectCourse.TabIndex = 41;
            this.lblSelectCourse.Text = "Course Name:";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.Location = new System.Drawing.Point(51, 26);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(121, 25);
            this.lblStudentID.TabIndex = 40;
            this.lblStudentID.Text = "Student ID:";
            // 
            // txtCourseDescription
            // 
            this.txtCourseDescription.Location = new System.Drawing.Point(190, 207);
            this.txtCourseDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCourseDescription.Multiline = true;
            this.txtCourseDescription.Name = "txtCourseDescription";
            this.txtCourseDescription.Size = new System.Drawing.Size(230, 87);
            this.txtCourseDescription.TabIndex = 39;
            // 
            // cboChooseCourse
            // 
            this.cboChooseCourse.FormattingEnabled = true;
            this.cboChooseCourse.Location = new System.Drawing.Point(190, 86);
            this.cboChooseCourse.Name = "cboChooseCourse";
            this.cboChooseCourse.Size = new System.Drawing.Size(160, 24);
            this.cboChooseCourse.TabIndex = 56;
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(190, 146);
            this.txtScore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(160, 22);
            this.txtScore.TabIndex = 57;
            // 
            // dataGridView_Score
            // 
            this.dataGridView_Score.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Score.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Score.Location = new System.Drawing.Point(502, 47);
            this.dataGridView_Score.Name = "dataGridView_Score";
            this.dataGridView_Score.RowHeadersWidth = 51;
            this.dataGridView_Score.RowTemplate.Height = 24;
            this.dataGridView_Score.Size = new System.Drawing.Size(485, 304);
            this.dataGridView_Score.TabIndex = 58;
            this.dataGridView_Score.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Score_CellContentClick);
            this.dataGridView_Score.Click += new System.EventHandler(this.dataGridView_Score_Click);
            // 
            // lblStudentList
            // 
            this.lblStudentList.AutoSize = true;
            this.lblStudentList.Location = new System.Drawing.Point(708, 9);
            this.lblStudentList.Name = "lblStudentList";
            this.lblStudentList.Size = new System.Drawing.Size(75, 16);
            this.lblStudentList.TabIndex = 59;
            this.lblStudentList.Text = "Student List";
            // 
            // AddScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 480);
            this.Controls.Add(this.lblStudentList);
            this.Controls.Add(this.dataGridView_Score);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.cboChooseCourse);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAddScore);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblSelectCourse);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.txtCourseDescription);
            this.Name = "AddScore";
            this.Text = "AddScore";
            this.Load += new System.EventHandler(this.AddScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Score)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAddScore;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblSelectCourse;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.TextBox txtCourseDescription;
        private System.Windows.Forms.ComboBox cboChooseCourse;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.DataGridView dataGridView_Score;
        private System.Windows.Forms.Label lblStudentList;
    }
}