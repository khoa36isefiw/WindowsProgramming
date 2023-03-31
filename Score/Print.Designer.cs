namespace _20110375_HuynhDangKhoa_LoginForm.Score
{
    partial class Print
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
            this.dataGridView_PrintScore = new System.Windows.Forms.DataGridView();
            this.btnPrintScore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PrintScore)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_PrintScore
            // 
            this.dataGridView_PrintScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_PrintScore.Location = new System.Drawing.Point(33, 40);
            this.dataGridView_PrintScore.Name = "dataGridView_PrintScore";
            this.dataGridView_PrintScore.RowHeadersWidth = 51;
            this.dataGridView_PrintScore.RowTemplate.Height = 24;
            this.dataGridView_PrintScore.Size = new System.Drawing.Size(719, 323);
            this.dataGridView_PrintScore.TabIndex = 0;
            // 
            // btnPrintScore
            // 
            this.btnPrintScore.Location = new System.Drawing.Point(33, 397);
            this.btnPrintScore.Name = "btnPrintScore";
            this.btnPrintScore.Size = new System.Drawing.Size(173, 41);
            this.btnPrintScore.TabIndex = 1;
            this.btnPrintScore.Text = "Print Score";
            this.btnPrintScore.UseVisualStyleBackColor = true;
            this.btnPrintScore.Click += new System.EventHandler(this.btnPrintScore_Click);
            // 
            // Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrintScore);
            this.Controls.Add(this.dataGridView_PrintScore);
            this.Name = "Print";
            this.Text = "Print";
            this.Load += new System.EventHandler(this.Print_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PrintScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_PrintScore;
        private System.Windows.Forms.Button btnPrintScore;
    }
}