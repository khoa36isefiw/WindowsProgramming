namespace _20110375_HuynhDangKhoa_LoginForm.Score
{
    partial class RemoveScore
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
            this.dataGridView_ScoreStudent = new System.Windows.Forms.DataGridView();
            this.btnRemoveScore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ScoreStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_ScoreStudent
            // 
            this.dataGridView_ScoreStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ScoreStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ScoreStudent.Location = new System.Drawing.Point(79, 34);
            this.dataGridView_ScoreStudent.Name = "dataGridView_ScoreStudent";
            this.dataGridView_ScoreStudent.RowHeadersWidth = 51;
            this.dataGridView_ScoreStudent.RowTemplate.Height = 24;
            this.dataGridView_ScoreStudent.Size = new System.Drawing.Size(633, 299);
            this.dataGridView_ScoreStudent.TabIndex = 0;
            // 
            // btnRemoveScore
            // 
            this.btnRemoveScore.Location = new System.Drawing.Point(79, 373);
            this.btnRemoveScore.Name = "btnRemoveScore";
            this.btnRemoveScore.Size = new System.Drawing.Size(126, 49);
            this.btnRemoveScore.TabIndex = 1;
            this.btnRemoveScore.Text = "Remove Score";
            this.btnRemoveScore.UseVisualStyleBackColor = true;
            this.btnRemoveScore.Click += new System.EventHandler(this.btnRemoveScore_Click);
            // 
            // RemoveScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemoveScore);
            this.Controls.Add(this.dataGridView_ScoreStudent);
            this.Name = "RemoveScore";
            this.Text = "RemoveScore";
            this.Load += new System.EventHandler(this.RemoveScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ScoreStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_ScoreStudent;
        private System.Windows.Forms.Button btnRemoveScore;
    }
}