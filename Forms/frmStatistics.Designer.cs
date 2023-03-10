namespace _20110375_HuynhDangKhoa_LoginForm
{
    partial class frmStatistics
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
            this.panelTotalStudent = new System.Windows.Forms.Panel();
            this.lblTotalStudent = new System.Windows.Forms.Label();
            this.panelFemaleStudent = new System.Windows.Forms.Panel();
            this.lblTotalFemaleStudent = new System.Windows.Forms.Label();
            this.panelMaleStudent = new System.Windows.Forms.Panel();
            this.lblTotalMaleStudent = new System.Windows.Forms.Label();
            this.panelTotalStudent.SuspendLayout();
            this.panelFemaleStudent.SuspendLayout();
            this.panelMaleStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTotalStudent
            // 
            this.panelTotalStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelTotalStudent.Controls.Add(this.lblTotalStudent);
            this.panelTotalStudent.Location = new System.Drawing.Point(0, 1);
            this.panelTotalStudent.Name = "panelTotalStudent";
            this.panelTotalStudent.Size = new System.Drawing.Size(794, 223);
            this.panelTotalStudent.TabIndex = 0;
            // 
            // lblTotalStudent
            // 
            this.lblTotalStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalStudent.Location = new System.Drawing.Point(0, 0);
            this.lblTotalStudent.Name = "lblTotalStudent";
            this.lblTotalStudent.Size = new System.Drawing.Size(790, 223);
            this.lblTotalStudent.TabIndex = 0;
            this.lblTotalStudent.Text = "Total Student: 100%";
            this.lblTotalStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelFemaleStudent
            // 
            this.panelFemaleStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelFemaleStudent.Controls.Add(this.lblTotalFemaleStudent);
            this.panelFemaleStudent.Location = new System.Drawing.Point(0, 224);
            this.panelFemaleStudent.Name = "panelFemaleStudent";
            this.panelFemaleStudent.Size = new System.Drawing.Size(381, 210);
            this.panelFemaleStudent.TabIndex = 1;
            // 
            // lblTotalFemaleStudent
            // 
            this.lblTotalFemaleStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFemaleStudent.Location = new System.Drawing.Point(0, 3);
            this.lblTotalFemaleStudent.Name = "lblTotalFemaleStudent";
            this.lblTotalFemaleStudent.Size = new System.Drawing.Size(378, 206);
            this.lblTotalFemaleStudent.TabIndex = 0;
            this.lblTotalFemaleStudent.Text = "Total Female: 50%";
            this.lblTotalFemaleStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMaleStudent
            // 
            this.panelMaleStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelMaleStudent.Controls.Add(this.lblTotalMaleStudent);
            this.panelMaleStudent.Location = new System.Drawing.Point(376, 224);
            this.panelMaleStudent.Name = "panelMaleStudent";
            this.panelMaleStudent.Size = new System.Drawing.Size(417, 209);
            this.panelMaleStudent.TabIndex = 2;
            // 
            // lblTotalMaleStudent
            // 
            this.lblTotalMaleStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMaleStudent.Location = new System.Drawing.Point(0, 0);
            this.lblTotalMaleStudent.Name = "lblTotalMaleStudent";
            this.lblTotalMaleStudent.Size = new System.Drawing.Size(418, 210);
            this.lblTotalMaleStudent.TabIndex = 0;
            this.lblTotalMaleStudent.Text = "Total Male: 50%";
            this.lblTotalMaleStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(791, 433);
            this.Controls.Add(this.panelMaleStudent);
            this.Controls.Add(this.panelFemaleStudent);
            this.Controls.Add(this.panelTotalStudent);
            this.Name = "frmStatistics";
            this.Text = "frmStatistics";
            this.Load += new System.EventHandler(this.frmStatistics_Load);
            this.panelTotalStudent.ResumeLayout(false);
            this.panelFemaleStudent.ResumeLayout(false);
            this.panelMaleStudent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTotalStudent;
        private System.Windows.Forms.Panel panelFemaleStudent;
        private System.Windows.Forms.Panel panelMaleStudent;
        private System.Windows.Forms.Label lblTotalStudent;
        private System.Windows.Forms.Label lblTotalFemaleStudent;
        private System.Windows.Forms.Label lblTotalMaleStudent;
    }
}