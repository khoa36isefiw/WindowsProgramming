namespace _20110375_HuynhDangKhoa_LoginForm.Score
{
    partial class AverageScore
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
            this.dataGridView_AverageStudentScore = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AverageStudentScore)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_AverageStudentScore
            // 
            this.dataGridView_AverageStudentScore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_AverageStudentScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AverageStudentScore.Location = new System.Drawing.Point(33, 49);
            this.dataGridView_AverageStudentScore.Name = "dataGridView_AverageStudentScore";
            this.dataGridView_AverageStudentScore.RowHeadersWidth = 51;
            this.dataGridView_AverageStudentScore.RowTemplate.Height = 24;
            this.dataGridView_AverageStudentScore.Size = new System.Drawing.Size(709, 273);
            this.dataGridView_AverageStudentScore.TabIndex = 0;
            // 
            // AverageScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_AverageStudentScore);
            this.Name = "AverageScore";
            this.Text = "AverageScore";
            this.Load += new System.EventHandler(this.AverageScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AverageStudentScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_AverageStudentScore;
    }
}