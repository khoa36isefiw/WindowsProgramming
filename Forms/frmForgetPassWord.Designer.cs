namespace _20110375_HuynhDangKhoa_LoginForm
{
    partial class frmForgetPassWord
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtInputGmail = new System.Windows.Forms.TextBox();
            this.lblVerify = new System.Windows.Forms.Label();
            this.txtVerCode = new System.Windows.Forms.TextBox();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.btnVerifyCode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(67, 73);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 16);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Gmail";
            // 
            // txtInputGmail
            // 
            this.txtInputGmail.Location = new System.Drawing.Point(174, 73);
            this.txtInputGmail.Name = "txtInputGmail";
            this.txtInputGmail.Size = new System.Drawing.Size(183, 22);
            this.txtInputGmail.TabIndex = 1;
            // 
            // lblVerify
            // 
            this.lblVerify.AutoSize = true;
            this.lblVerify.Location = new System.Drawing.Point(70, 140);
            this.lblVerify.Name = "lblVerify";
            this.lblVerify.Size = new System.Drawing.Size(78, 16);
            this.lblVerify.TabIndex = 2;
            this.lblVerify.Text = "Verify-Code";
            // 
            // txtVerCode
            // 
            this.txtVerCode.Location = new System.Drawing.Point(174, 133);
            this.txtVerCode.Name = "txtVerCode";
            this.txtVerCode.Size = new System.Drawing.Size(183, 22);
            this.txtVerCode.TabIndex = 3;
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Location = new System.Drawing.Point(409, 71);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(87, 24);
            this.btnSendEmail.TabIndex = 4;
            this.btnSendEmail.Text = "Send";
            this.btnSendEmail.UseVisualStyleBackColor = true;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // btnVerifyCode
            // 
            this.btnVerifyCode.Location = new System.Drawing.Point(409, 140);
            this.btnVerifyCode.Name = "btnVerifyCode";
            this.btnVerifyCode.Size = new System.Drawing.Size(87, 30);
            this.btnVerifyCode.TabIndex = 4;
            this.btnVerifyCode.Text = "Verify-Code";
            this.btnVerifyCode.UseVisualStyleBackColor = true;
            this.btnVerifyCode.Click += new System.EventHandler(this.btnVerifyCode_Click);
            // 
            // frmForgetPassWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 560);
            this.Controls.Add(this.btnVerifyCode);
            this.Controls.Add(this.btnSendEmail);
            this.Controls.Add(this.txtVerCode);
            this.Controls.Add(this.lblVerify);
            this.Controls.Add(this.txtInputGmail);
            this.Controls.Add(this.lblEmail);
            this.Name = "frmForgetPassWord";
            this.Text = "frmForgetPassWord";
            this.Load += new System.EventHandler(this.frmForgetPassWord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblVerify;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.Button btnVerifyCode;
        internal System.Windows.Forms.TextBox txtInputGmail;
        internal System.Windows.Forms.TextBox txtVerCode;
    }
}