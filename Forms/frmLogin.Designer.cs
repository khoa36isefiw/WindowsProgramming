namespace _20110375_HuynhDangKhoa_LoginForm
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pictBoxShow = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pictBoxHide = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblIntro = new System.Windows.Forms.Label();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.toolTipPass = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipUserName = new System.Windows.Forms.ToolTip(this.components);
            this.chkBoxRemember = new System.Windows.Forms.CheckBox();
            this.radbHuman = new System.Windows.Forms.RadioButton();
            this.radbStudent = new System.Windows.Forms.RadioButton();
            this.txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.btnSignUp = new Guna.UI2.WinForms.Guna2Button();
            this.btnResetPass = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictBoxShow
            // 
            this.pictBoxShow.Image = ((System.Drawing.Image)(resources.GetObject("pictBoxShow.Image")));
            this.pictBoxShow.ImageRotate = 0F;
            this.pictBoxShow.Location = new System.Drawing.Point(332, 164);
            this.pictBoxShow.Name = "pictBoxShow";
            this.pictBoxShow.Size = new System.Drawing.Size(29, 32);
            this.pictBoxShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictBoxShow.TabIndex = 20;
            this.pictBoxShow.TabStop = false;
            this.pictBoxShow.Click += new System.EventHandler(this.pictBoxShow_Click);
            // 
            // pictBoxHide
            // 
            this.pictBoxHide.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.pictBoxHide.Image = ((System.Drawing.Image)(resources.GetObject("pictBoxHide.Image")));
            this.pictBoxHide.ImageRotate = 0F;
            this.pictBoxHide.Location = new System.Drawing.Point(332, 164);
            this.pictBoxHide.Name = "pictBoxHide";
            this.pictBoxHide.Size = new System.Drawing.Size(29, 32);
            this.pictBoxHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictBoxHide.TabIndex = 19;
            this.pictBoxHide.TabStop = false;
            this.pictBoxHide.Click += new System.EventHandler(this.pictBoxHide_Click);
            // 
            // lblIntro
            // 
            this.lblIntro.AutoSize = true;
            this.lblIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntro.Location = new System.Drawing.Point(113, 36);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(177, 29);
            this.lblIntro.TabIndex = 1;
            this.lblIntro.Text = "Account Login";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.txtPassword.BorderRadius = 10;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(79, 148);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(229, 48);
            this.txtPassword.TabIndex = 18;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(451, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(655, 614);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 16;
            this.guna2PictureBox1.TabStop = false;
            // 
            // toolTipPass
            // 
            this.toolTipPass.ToolTipTitle = "Nhắc Nhở";
            // 
            // toolTipUserName
            // 
            this.toolTipUserName.ToolTipTitle = "Nhắc Nhở";
            // 
            // chkBoxRemember
            // 
            this.chkBoxRemember.AutoSize = true;
            this.chkBoxRemember.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxRemember.Location = new System.Drawing.Point(138, 281);
            this.chkBoxRemember.Name = "chkBoxRemember";
            this.chkBoxRemember.Size = new System.Drawing.Size(137, 29);
            this.chkBoxRemember.TabIndex = 12;
            this.chkBoxRemember.Text = "Remember";
            this.chkBoxRemember.UseVisualStyleBackColor = true;
            // 
            // radbHuman
            // 
            this.radbHuman.AutoSize = true;
            this.radbHuman.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbHuman.Location = new System.Drawing.Point(235, 222);
            this.radbHuman.Name = "radbHuman";
            this.radbHuman.Size = new System.Drawing.Size(170, 26);
            this.radbHuman.TabIndex = 9;
            this.radbHuman.TabStop = true;
            this.radbHuman.Text = "Human Resource";
            this.radbHuman.UseVisualStyleBackColor = true;
            // 
            // radbStudent
            // 
            this.radbStudent.AutoSize = true;
            this.radbStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbStudent.Location = new System.Drawing.Point(59, 222);
            this.radbStudent.Name = "radbStudent";
            this.radbStudent.Size = new System.Drawing.Size(93, 26);
            this.radbStudent.TabIndex = 8;
            this.radbStudent.TabStop = true;
            this.radbStudent.Text = "Student";
            this.radbStudent.UseVisualStyleBackColor = true;
            // 
            // txtUserName
            // 
            this.txtUserName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.txtUserName.BorderRadius = 10;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.DefaultText = "";
            this.txtUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.txtUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.txtUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.Location = new System.Drawing.Point(79, 92);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.PlaceholderText = "User Name";
            this.txtUserName.SelectedText = "";
            this.txtUserName.Size = new System.Drawing.Size(229, 48);
            this.txtUserName.TabIndex = 17;
            // 
            // btnCancel
            // 
            this.btnCancel.BorderRadius = 15;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.White;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.btnCancel.Location = new System.Drawing.Point(37, 368);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(115, 46);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BorderRadius = 15;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(235, 368);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(115, 46);
            this.btnLogin.TabIndex = 22;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.BorderRadius = 15;
            this.btnSignUp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSignUp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSignUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSignUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSignUp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.btnSignUp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(37, 453);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(115, 46);
            this.btnSignUp.TabIndex = 23;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnResetPass
            // 
            this.btnResetPass.BorderRadius = 15;
            this.btnResetPass.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnResetPass.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnResetPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnResetPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnResetPass.FillColor = System.Drawing.Color.White;
            this.btnResetPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnResetPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(20)))), ((int)(((byte)(27)))));
            this.btnResetPass.Location = new System.Drawing.Point(235, 453);
            this.btnResetPass.Name = "btnResetPass";
            this.btnResetPass.Size = new System.Drawing.Size(115, 46);
            this.btnResetPass.TabIndex = 24;
            this.btnResetPass.Text = "Reset Password";
            this.btnResetPass.Click += new System.EventHandler(this.btnResetPass_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1105, 609);
            this.Controls.Add(this.btnResetPass);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.chkBoxRemember);
            this.Controls.Add(this.radbHuman);
            this.Controls.Add(this.radbStudent);
            this.Controls.Add(this.lblIntro);
            this.Controls.Add(this.pictBoxShow);
            this.Controls.Add(this.pictBoxHide);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form - Huynh Dang Khoa - 20110375";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pictBoxShow;
        private Guna.UI2.WinForms.Guna2PictureBox pictBoxHide;
        private System.Windows.Forms.Label lblIntro;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.ToolTip toolTipPass;
        private System.Windows.Forms.ToolTip toolTipUserName;
        private System.Windows.Forms.CheckBox chkBoxRemember;
        private System.Windows.Forms.RadioButton radbHuman;
        private System.Windows.Forms.RadioButton radbStudent;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2Button btnSignUp;
        private Guna.UI2.WinForms.Guna2Button btnResetPass;
        internal Guna.UI2.WinForms.Guna2TextBox txtUserName;
    }
}

