namespace _20110375_HuynhDangKhoa_LoginForm
{
    partial class frmImageShow
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
            this.pictShowed = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictShowed)).BeginInit();
            this.SuspendLayout();
            // 
            // pictShowed
            // 
            this.pictShowed.Location = new System.Drawing.Point(104, 62);
            this.pictShowed.Name = "pictShowed";
            this.pictShowed.Size = new System.Drawing.Size(335, 253);
            this.pictShowed.TabIndex = 0;
            this.pictShowed.TabStop = false;
            // 
            // frmImageShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictShowed);
            this.Name = "frmImageShow";
            this.Text = "frmImageShow";
            this.Load += new System.EventHandler(this.frmImageShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictShowed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictShowed;
    }
}