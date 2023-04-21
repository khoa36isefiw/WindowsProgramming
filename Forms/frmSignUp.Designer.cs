namespace _20110375_HuynhDangKhoa_LoginForm
{
    partial class frmSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSignUp));
            this.btnSignUp = new System.Windows.Forms.Button();
            this.radbFemale = new System.Windows.Forms.RadioButton();
            this.radbMale = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.grboGender = new System.Windows.Forms.GroupBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtReEnterPass = new System.Windows.Forms.TextBox();
            this.lblRePass = new System.Windows.Forms.Label();
            this.picBackgroundSignUpForm = new System.Windows.Forms.PictureBox();
            this.toggleShowPassword = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.lblShowPass = new System.Windows.Forms.Label();
            this.pictProfile = new System.Windows.Forms.PictureBox();
            this.lblPicture = new System.Windows.Forms.Label();
            this.lblHaveAccount = new System.Windows.Forms.Label();
            this.s = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnUploadImg = new System.Windows.Forms.Button();
            this.grboGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackgroundSignUpForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(404, 576);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(122, 56);
            this.btnSignUp.TabIndex = 54;
            this.btnSignUp.Text = "SignUp";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // radbFemale
            // 
            this.radbFemale.AutoSize = true;
            this.radbFemale.Location = new System.Drawing.Point(127, 14);
            this.radbFemale.Name = "radbFemale";
            this.radbFemale.Size = new System.Drawing.Size(74, 20);
            this.radbFemale.TabIndex = 1;
            this.radbFemale.TabStop = true;
            this.radbFemale.Text = "Female";
            this.radbFemale.UseVisualStyleBackColor = true;
            // 
            // radbMale
            // 
            this.radbMale.AutoSize = true;
            this.radbMale.Location = new System.Drawing.Point(7, 14);
            this.radbMale.Name = "radbMale";
            this.radbMale.Size = new System.Drawing.Size(58, 20);
            this.radbMale.TabIndex = 0;
            this.radbMale.TabStop = true;
            this.radbMale.Text = "Male";
            this.radbMale.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(179, 576);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 56);
            this.btnCancel.TabIndex = 53;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(266, 343);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(201, 22);
            this.txtEmail.TabIndex = 45;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(266, 302);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(201, 22);
            this.txtPhone.TabIndex = 44;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(266, 204);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(201, 22);
            this.txtLastName.TabIndex = 43;
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(266, 166);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(201, 22);
            this.txtFirstName.TabIndex = 42;
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(266, 46);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(201, 22);
            this.txtUserName.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(76)))), ((int)(((byte)(138)))));
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.lblEmail.Location = new System.Drawing.Point(81, 347);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(50, 18);
            this.lblEmail.TabIndex = 36;
            this.lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.lblPhone.Location = new System.Drawing.Point(81, 302);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(56, 18);
            this.lblPhone.TabIndex = 35;
            this.lblPhone.Text = "Phone";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(241)))), ((int)(((byte)(239)))));
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.lblGender.Location = new System.Drawing.Point(81, 264);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(63, 18);
            this.lblGender.TabIndex = 34;
            this.lblGender.Text = "Gender";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.lblLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.lblLName.Location = new System.Drawing.Point(81, 208);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(89, 18);
            this.lblLName.TabIndex = 32;
            this.lblLName.Text = "Last Name";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.lblFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.lblFName.Location = new System.Drawing.Point(81, 170);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(91, 18);
            this.lblFName.TabIndex = 31;
            this.lblFName.Text = "First Name";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.lblUserName.Location = new System.Drawing.Point(81, 50);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(93, 18);
            this.lblUserName.TabIndex = 30;
            this.lblUserName.Text = "User Name";
            // 
            // grboGender
            // 
            this.grboGender.Controls.Add(this.radbFemale);
            this.grboGender.Controls.Add(this.radbMale);
            this.grboGender.Location = new System.Drawing.Point(266, 246);
            this.grboGender.Name = "grboGender";
            this.grboGender.Size = new System.Drawing.Size(201, 40);
            this.grboGender.TabIndex = 49;
            this.grboGender.TabStop = false;
            this.grboGender.Text = "GroupGender";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(266, 84);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(201, 22);
            this.txtPass.TabIndex = 2;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.lblPass.Location = new System.Drawing.Point(81, 88);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(83, 18);
            this.lblPass.TabIndex = 55;
            this.lblPass.Text = "Password";
            // 
            // txtReEnterPass
            // 
            this.txtReEnterPass.Location = new System.Drawing.Point(266, 121);
            this.txtReEnterPass.Name = "txtReEnterPass";
            this.txtReEnterPass.PasswordChar = '*';
            this.txtReEnterPass.Size = new System.Drawing.Size(201, 22);
            this.txtReEnterPass.TabIndex = 3;
            // 
            // lblRePass
            // 
            this.lblRePass.AutoSize = true;
            this.lblRePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.lblRePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRePass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.lblRePass.Location = new System.Drawing.Point(81, 125);
            this.lblRePass.Name = "lblRePass";
            this.lblRePass.Size = new System.Drawing.Size(153, 18);
            this.lblRePass.TabIndex = 57;
            this.lblRePass.Text = "Re-enter Password";
            // 
            // picBackgroundSignUpForm
            // 
            this.picBackgroundSignUpForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.picBackgroundSignUpForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBackgroundSignUpForm.Image = ((System.Drawing.Image)(resources.GetObject("picBackgroundSignUpForm.Image")));
            this.picBackgroundSignUpForm.Location = new System.Drawing.Point(0, 0);
            this.picBackgroundSignUpForm.Name = "picBackgroundSignUpForm";
            this.picBackgroundSignUpForm.Size = new System.Drawing.Size(784, 690);
            this.picBackgroundSignUpForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBackgroundSignUpForm.TabIndex = 58;
            this.picBackgroundSignUpForm.TabStop = false;
            // 
            // toggleShowPassword
            // 
            this.toggleShowPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.toggleShowPassword.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toggleShowPassword.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toggleShowPassword.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleShowPassword.CheckedState.InnerColor = System.Drawing.Color.White;
            this.toggleShowPassword.Location = new System.Drawing.Point(530, 88);
            this.toggleShowPassword.Name = "toggleShowPassword";
            this.toggleShowPassword.Size = new System.Drawing.Size(52, 27);
            this.toggleShowPassword.TabIndex = 60;
            this.toggleShowPassword.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.toggleShowPassword.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.toggleShowPassword.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleShowPassword.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.toggleShowPassword.CheckedChanged += new System.EventHandler(this.toggleShowPassword_CheckedChanged);
            // 
            // lblShowPass
            // 
            this.lblShowPass.AutoSize = true;
            this.lblShowPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.lblShowPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.lblShowPass.Location = new System.Drawing.Point(507, 127);
            this.lblShowPass.Name = "lblShowPass";
            this.lblShowPass.Size = new System.Drawing.Size(130, 18);
            this.lblShowPass.TabIndex = 61;
            this.lblShowPass.Text = "Show Password";
            // 
            // pictProfile
            // 
            this.pictProfile.Location = new System.Drawing.Point(266, 384);
            this.pictProfile.Name = "pictProfile";
            this.pictProfile.Size = new System.Drawing.Size(201, 141);
            this.pictProfile.TabIndex = 62;
            this.pictProfile.TabStop = false;
            // 
            // lblPicture
            // 
            this.lblPicture.AutoSize = true;
            this.lblPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(76)))), ((int)(((byte)(138)))));
            this.lblPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPicture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.lblPicture.Location = new System.Drawing.Point(81, 396);
            this.lblPicture.Name = "lblPicture";
            this.lblPicture.Size = new System.Drawing.Size(66, 18);
            this.lblPicture.TabIndex = 63;
            this.lblPicture.Text = "Picture:";
            // 
            // lblHaveAccount
            // 
            this.lblHaveAccount.AutoSize = true;
            this.lblHaveAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHaveAccount.Location = new System.Drawing.Point(227, 659);
            this.lblHaveAccount.Name = "lblHaveAccount";
            this.lblHaveAccount.Size = new System.Drawing.Size(278, 25);
            this.lblHaveAccount.TabIndex = 64;
            this.lblHaveAccount.Text = "<<Have An Account? LogIn";
            this.lblHaveAccount.UseMnemonic = false;
            this.lblHaveAccount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblHaveAccount_MouseClick);
            // 
            // s
            // 
            this.s.Location = new System.Drawing.Point(266, 12);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(201, 22);
            this.s.TabIndex = 65;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.lblID.Location = new System.Drawing.Point(81, 16);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(24, 18);
            this.lblID.TabIndex = 66;
            this.lblID.Text = "ID";
            // 
            // btnUploadImg
            // 
            this.btnUploadImg.Location = new System.Drawing.Point(266, 532);
            this.btnUploadImg.Name = "btnUploadImg";
            this.btnUploadImg.Size = new System.Drawing.Size(201, 30);
            this.btnUploadImg.TabIndex = 67;
            this.btnUploadImg.Text = "Up Load Image";
            this.btnUploadImg.UseVisualStyleBackColor = true;
            // 
            // frmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 690);
            this.Controls.Add(this.btnUploadImg);
            this.Controls.Add(this.s);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblHaveAccount);
            this.Controls.Add(this.lblPicture);
            this.Controls.Add(this.pictProfile);
            this.Controls.Add(this.lblShowPass);
            this.Controls.Add(this.toggleShowPassword);
            this.Controls.Add(this.txtReEnterPass);
            this.Controls.Add(this.lblRePass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.lblFName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.grboGender);
            this.Controls.Add(this.picBackgroundSignUpForm);
            this.Name = "frmSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSignUp";
            this.Load += new System.EventHandler(this.frmSignUp_Load);
            this.grboGender.ResumeLayout(false);
            this.grboGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackgroundSignUpForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.RadioButton radbFemale;
        private System.Windows.Forms.RadioButton radbMale;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.GroupBox grboGender;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtReEnterPass;
        private System.Windows.Forms.Label lblRePass;
        private System.Windows.Forms.PictureBox picBackgroundSignUpForm;
        private Guna.UI2.WinForms.Guna2ToggleSwitch toggleShowPassword;
        private System.Windows.Forms.Label lblShowPass;
        private System.Windows.Forms.PictureBox pictProfile;
        private System.Windows.Forms.Label lblPicture;
        private System.Windows.Forms.Label lblHaveAccount;
        private System.Windows.Forms.TextBox s;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnUploadImg;
    }
}