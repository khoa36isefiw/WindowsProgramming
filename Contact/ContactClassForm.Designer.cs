namespace _20110375_HuynhDangKhoa_LoginForm.Contact
{
    partial class ContactClassForm
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
            this.dataGridView_ContactClassForm = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ContactClassForm)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_ContactClassForm
            // 
            this.dataGridView_ContactClassForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ContactClassForm.Location = new System.Drawing.Point(74, 92);
            this.dataGridView_ContactClassForm.Name = "dataGridView_ContactClassForm";
            this.dataGridView_ContactClassForm.RowHeadersWidth = 51;
            this.dataGridView_ContactClassForm.RowTemplate.Height = 24;
            this.dataGridView_ContactClassForm.Size = new System.Drawing.Size(671, 295);
            this.dataGridView_ContactClassForm.TabIndex = 0;
            this.dataGridView_ContactClassForm.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ContactClassForm_CellDoubleClick);
            // 
            // ContactClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_ContactClassForm);
            this.Name = "ContactClassForm";
            this.Text = "ContactClassForm";
            this.Load += new System.EventHandler(this.ContactClassForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ContactClassForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_ContactClassForm;
    }
}