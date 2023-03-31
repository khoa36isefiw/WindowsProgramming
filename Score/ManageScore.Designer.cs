namespace _20110375_HuynhDangKhoa_LoginForm.Score
{
    partial class ManageScore
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
            this.txtScore = new System.Windows.Forms.TextBox();
            this.cboChooseCourse = new System.Windows.Forms.ComboBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblSelectCourse = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.txtCourseDescription = new System.Windows.Forms.TextBox();
            this.dataGridViewManageResult = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAverageScore = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnShowStudents = new System.Windows.Forms.Button();
            this.btnShowScores = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageResult)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(171, 151);
            this.txtScore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(160, 22);
            this.txtScore.TabIndex = 65;
            // 
            // cboChooseCourse
            // 
            this.cboChooseCourse.FormattingEnabled = true;
            this.cboChooseCourse.Location = new System.Drawing.Point(171, 91);
            this.cboChooseCourse.Name = "cboChooseCourse";
            this.cboChooseCourse.Size = new System.Drawing.Size(160, 24);
            this.cboChooseCourse.TabIndex = 64;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(171, 34);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(160, 22);
            this.txtStudentID.TabIndex = 63;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(12, 212);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(127, 25);
            this.lblDescription.TabIndex = 62;
            this.lblDescription.Text = "Description:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(12, 151);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(76, 25);
            this.lblScore.TabIndex = 61;
            this.lblScore.Text = "Score:";
            // 
            // lblSelectCourse
            // 
            this.lblSelectCourse.AutoSize = true;
            this.lblSelectCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCourse.Location = new System.Drawing.Point(12, 91);
            this.lblSelectCourse.Name = "lblSelectCourse";
            this.lblSelectCourse.Size = new System.Drawing.Size(151, 25);
            this.lblSelectCourse.TabIndex = 60;
            this.lblSelectCourse.Text = "Course Name:";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.Location = new System.Drawing.Point(12, 30);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(121, 25);
            this.lblStudentID.TabIndex = 59;
            this.lblStudentID.Text = "Student ID:";
            // 
            // txtCourseDescription
            // 
            this.txtCourseDescription.Location = new System.Drawing.Point(171, 212);
            this.txtCourseDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCourseDescription.Multiline = true;
            this.txtCourseDescription.Name = "txtCourseDescription";
            this.txtCourseDescription.Size = new System.Drawing.Size(230, 87);
            this.txtCourseDescription.TabIndex = 58;
            // 
            // dataGridViewManageResult
            // 
            this.dataGridViewManageResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewManageResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManageResult.Location = new System.Drawing.Point(511, 114);
            this.dataGridViewManageResult.Name = "dataGridViewManageResult";
            this.dataGridViewManageResult.RowHeadersWidth = 51;
            this.dataGridViewManageResult.RowTemplate.Height = 24;
            this.dataGridViewManageResult.Size = new System.Drawing.Size(412, 344);
            this.dataGridViewManageResult.TabIndex = 66;
            this.dataGridViewManageResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewManageResult_CellClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(69, 374);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(123, 43);
            this.btnAdd.TabIndex = 67;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAverageScore
            // 
            this.btnAverageScore.Location = new System.Drawing.Point(150, 435);
            this.btnAverageScore.Name = "btnAverageScore";
            this.btnAverageScore.Size = new System.Drawing.Size(181, 56);
            this.btnAverageScore.TabIndex = 68;
            this.btnAverageScore.Text = "Average Score By Course";
            this.btnAverageScore.UseVisualStyleBackColor = true;
            this.btnAverageScore.Click += new System.EventHandler(this.btnAverageScore_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(280, 374);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(123, 43);
            this.btnRemove.TabIndex = 69;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnShowStudents
            // 
            this.btnShowStudents.Location = new System.Drawing.Point(511, 34);
            this.btnShowStudents.Name = "btnShowStudents";
            this.btnShowStudents.Size = new System.Drawing.Size(174, 39);
            this.btnShowStudents.TabIndex = 70;
            this.btnShowStudents.Text = "Show Students";
            this.btnShowStudents.UseVisualStyleBackColor = true;
            this.btnShowStudents.Click += new System.EventHandler(this.btnShowStudents_Click);
            // 
            // btnShowScores
            // 
            this.btnShowScores.Location = new System.Drawing.Point(749, 34);
            this.btnShowScores.Name = "btnShowScores";
            this.btnShowScores.Size = new System.Drawing.Size(174, 39);
            this.btnShowScores.TabIndex = 71;
            this.btnShowScores.Text = "Show Scores";
            this.btnShowScores.UseVisualStyleBackColor = true;
            this.btnShowScores.Click += new System.EventHandler(this.btnShowScores_Click);
            // 
            // ManageScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 529);
            this.Controls.Add(this.btnShowScores);
            this.Controls.Add(this.btnShowStudents);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAverageScore);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridViewManageResult);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.cboChooseCourse);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblSelectCourse);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.txtCourseDescription);
            this.Name = "ManageScore";
            this.Text = "ManageScore";
            this.Load += new System.EventHandler(this.ManageScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.ComboBox cboChooseCourse;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblSelectCourse;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.TextBox txtCourseDescription;
        private System.Windows.Forms.DataGridView dataGridViewManageResult;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAverageScore;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnShowStudents;
        private System.Windows.Forms.Button btnShowScores;
    }
}