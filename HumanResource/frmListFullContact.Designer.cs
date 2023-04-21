namespace _20110375_HuynhDangKhoa_LoginForm.HumanResource
{
    partial class frmListFullContact
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
            this.listBox_Contact = new System.Windows.Forms.ListBox();
            this.lblGroup = new System.Windows.Forms.Label();
            this.lblShowAll = new System.Windows.Forms.Label();
            this.dataGridView_Contact = new System.Windows.Forms.DataGridView();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Contact)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_Contact
            // 
            this.listBox_Contact.FormattingEnabled = true;
            this.listBox_Contact.ItemHeight = 16;
            this.listBox_Contact.Location = new System.Drawing.Point(22, 106);
            this.listBox_Contact.Name = "listBox_Contact";
            this.listBox_Contact.Size = new System.Drawing.Size(236, 324);
            this.listBox_Contact.TabIndex = 0;
            this.listBox_Contact.Click += new System.EventHandler(this.listBox_Contact_Click);
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(19, 40);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(44, 16);
            this.lblGroup.TabIndex = 1;
            this.lblGroup.Text = "Group";
            // 
            // lblShowAll
            // 
            this.lblShowAll.AutoSize = true;
            this.lblShowAll.Location = new System.Drawing.Point(309, 40);
            this.lblShowAll.Name = "lblShowAll";
            this.lblShowAll.Size = new System.Drawing.Size(70, 16);
            this.lblShowAll.TabIndex = 2;
            this.lblShowAll.Text = "All Contact";
            // 
            // dataGridView_Contact
            // 
            this.dataGridView_Contact.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Contact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Contact.Location = new System.Drawing.Point(312, 106);
            this.dataGridView_Contact.Name = "dataGridView_Contact";
            this.dataGridView_Contact.RowHeadersWidth = 51;
            this.dataGridView_Contact.RowTemplate.Height = 24;
            this.dataGridView_Contact.Size = new System.Drawing.Size(774, 335);
            this.dataGridView_Contact.TabIndex = 3;
            this.dataGridView_Contact.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Contact_CellDoubleClick);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(423, 30);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(144, 33);
            this.btnShowAll.TabIndex = 4;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(312, 474);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(144, 33);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmListFullContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 575);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.dataGridView_Contact);
            this.Controls.Add(this.lblShowAll);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.listBox_Contact);
            this.Name = "frmListFullContact";
            this.Text = "frmListFullContact";
            this.Load += new System.EventHandler(this.frmListFullContact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Contact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Contact;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Label lblShowAll;
        private System.Windows.Forms.DataGridView dataGridView_Contact;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnExit;
    }
}