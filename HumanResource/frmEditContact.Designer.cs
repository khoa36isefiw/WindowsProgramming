namespace _20110375_HuynhDangKhoa_LoginForm.HumanResource
{
    partial class frmEditContact
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
            this.components = new System.ComponentModel.Container();
            this.btn_EditContact = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Upload = new System.Windows.Forms.Button();
            this.cbo_Group = new System.Windows.Forms.ComboBox();
            this.pictureBox_Image = new System.Windows.Forms.PictureBox();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.txt_LName = new System.Windows.Forms.TextBox();
            this.txt_FName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_SelectContact = new System.Windows.Forms.Button();
            this.errorProviderContact = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderContact)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_EditContact
            // 
            this.btn_EditContact.Location = new System.Drawing.Point(190, 456);
            this.btn_EditContact.Name = "btn_EditContact";
            this.btn_EditContact.Size = new System.Drawing.Size(154, 47);
            this.btn_EditContact.TabIndex = 37;
            this.btn_EditContact.Text = "Edit Contact";
            this.btn_EditContact.UseVisualStyleBackColor = true;
            this.btn_EditContact.Click += new System.EventHandler(this.btn_EditContact_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(466, 456);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(195, 47);
            this.btn_Cancel.TabIndex = 36;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Upload
            // 
            this.btn_Upload.Location = new System.Drawing.Point(466, 384);
            this.btn_Upload.Name = "btn_Upload";
            this.btn_Upload.Size = new System.Drawing.Size(195, 37);
            this.btn_Upload.TabIndex = 35;
            this.btn_Upload.Text = "Upload";
            this.btn_Upload.UseVisualStyleBackColor = true;
            this.btn_Upload.Click += new System.EventHandler(this.btn_Upload_Click);
            // 
            // cbo_Group
            // 
            this.cbo_Group.FormattingEnabled = true;
            this.cbo_Group.Items.AddRange(new object[] {
            "MATH",
            "IT",
            "MOBILE"});
            this.cbo_Group.Location = new System.Drawing.Point(190, 187);
            this.cbo_Group.Name = "cbo_Group";
            this.cbo_Group.Size = new System.Drawing.Size(133, 24);
            this.cbo_Group.TabIndex = 34;
            // 
            // pictureBox_Image
            // 
            this.pictureBox_Image.Location = new System.Drawing.Point(466, 249);
            this.pictureBox_Image.Name = "pictureBox_Image";
            this.pictureBox_Image.Size = new System.Drawing.Size(195, 105);
            this.pictureBox_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Image.TabIndex = 33;
            this.pictureBox_Image.TabStop = false;
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(466, 92);
            this.txt_Address.Multiline = true;
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(195, 96);
            this.txt_Address.TabIndex = 31;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(190, 312);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(133, 22);
            this.txt_Email.TabIndex = 30;
            this.txt_Email.TextChanged += new System.EventHandler(this.txt_Email_TextChanged);
            this.txt_Email.Leave += new System.EventHandler(this.txt_Email_Leave);
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(190, 251);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(133, 22);
            this.txt_Phone.TabIndex = 29;
            // 
            // txt_LName
            // 
            this.txt_LName.Location = new System.Drawing.Point(190, 133);
            this.txt_LName.Name = "txt_LName";
            this.txt_LName.Size = new System.Drawing.Size(133, 22);
            this.txt_LName.TabIndex = 28;
            // 
            // txt_FName
            // 
            this.txt_FName.Location = new System.Drawing.Point(190, 91);
            this.txt_FName.Name = "txt_FName";
            this.txt_FName.Size = new System.Drawing.Size(133, 22);
            this.txt_FName.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(378, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Picture:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(378, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Group";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "LastName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "FirstName";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(190, 41);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(133, 22);
            this.txt_ID.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(85, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 16);
            this.label8.TabIndex = 38;
            this.label8.Text = "ID:";
            // 
            // btn_SelectContact
            // 
            this.btn_SelectContact.Location = new System.Drawing.Point(357, 34);
            this.btn_SelectContact.Name = "btn_SelectContact";
            this.btn_SelectContact.Size = new System.Drawing.Size(140, 37);
            this.btn_SelectContact.TabIndex = 40;
            this.btn_SelectContact.Text = "Select Contact";
            this.btn_SelectContact.UseVisualStyleBackColor = true;
            this.btn_SelectContact.Click += new System.EventHandler(this.btn_SelectContact_Click);
            // 
            // errorProviderContact
            // 
            this.errorProviderContact.ContainerControl = this;
            // 
            // frmEditContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 548);
            this.Controls.Add(this.btn_SelectContact);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_EditContact);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Upload);
            this.Controls.Add(this.cbo_Group);
            this.Controls.Add(this.pictureBox_Image);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_Phone);
            this.Controls.Add(this.txt_LName);
            this.Controls.Add(this.txt_FName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmEditContact";
            this.Text = "frmEditContact";
            this.Load += new System.EventHandler(this.frmEditContact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderContact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_EditContact;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Upload;
        private System.Windows.Forms.ComboBox cbo_Group;
        private System.Windows.Forms.PictureBox pictureBox_Image;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.TextBox txt_LName;
        private System.Windows.Forms.TextBox txt_FName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_SelectContact;
        private System.Windows.Forms.ErrorProvider errorProviderContact;
    }
}