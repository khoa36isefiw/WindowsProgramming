namespace _20110375_HuynhDangKhoa_LoginForm.Contact
{
    partial class frmContactGroups
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
            this.dataGridView_ContactGroups = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ContactGroups)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_ContactGroups
            // 
            this.dataGridView_ContactGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ContactGroups.Location = new System.Drawing.Point(60, 42);
            this.dataGridView_ContactGroups.Name = "dataGridView_ContactGroups";
            this.dataGridView_ContactGroups.Size = new System.Drawing.Size(682, 378);
            this.dataGridView_ContactGroups.TabIndex = 0;
            this.dataGridView_ContactGroups.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ContactGroups_CellDoubleClick);
            // 
            // frmContactGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_ContactGroups);
            this.Name = "frmContactGroups";
            this.Text = "Contact Groups";
            this.Load += new System.EventHandler(this.frmContactGroups_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ContactGroups)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_ContactGroups;
    }
}