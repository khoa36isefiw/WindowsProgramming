namespace _20110375_HuynhDangKhoa_LoginForm
{
    partial class frmStudentList
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
            this.dataGVStudentList = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnShowPicture = new System.Windows.Forms.Button();
            this.pictureBoxShow = new System.Windows.Forms.PictureBox();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVStudentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGVStudentList
            // 
            this.dataGVStudentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGVStudentList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.dataGVStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVStudentList.Location = new System.Drawing.Point(28, 12);
            this.dataGVStudentList.Name = "dataGVStudentList";
            this.dataGVStudentList.RowHeadersWidth = 51;
            this.dataGVStudentList.RowTemplate.Height = 24;
            this.dataGVStudentList.Size = new System.Drawing.Size(1029, 487);
            this.dataGVStudentList.TabIndex = 0;
            this.dataGVStudentList.DoubleClick += new System.EventHandler(this.dataGVStudentList_DoubleClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(614, 532);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(173, 48);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.Lime;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(292, 532);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(173, 48);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnShowPicture
            // 
            this.btnShowPicture.BackColor = System.Drawing.Color.DarkOrange;
            this.btnShowPicture.Location = new System.Drawing.Point(1240, 453);
            this.btnShowPicture.Name = "btnShowPicture";
            this.btnShowPicture.Size = new System.Drawing.Size(113, 46);
            this.btnShowPicture.TabIndex = 3;
            this.btnShowPicture.Text = "Show Picture";
            this.btnShowPicture.UseVisualStyleBackColor = false;
            this.btnShowPicture.Click += new System.EventHandler(this.btnShowPicture_Click);
            // 
            // pictureBoxShow
            // 
            this.pictureBoxShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.pictureBoxShow.Location = new System.Drawing.Point(1096, 88);
            this.pictureBoxShow.Name = "pictureBoxShow";
            this.pictureBoxShow.Size = new System.Drawing.Size(335, 304);
            this.pictureBoxShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxShow.TabIndex = 4;
            this.pictureBoxShow.TabStop = false;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.btnShowPicture);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(35)))), ((int)(((byte)(135)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(64)))), ((int)(((byte)(87)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(113)))), ((int)(((byte)(33)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(244)))), ((int)(((byte)(22)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1462, 620);
            this.guna2CustomGradientPanel1.TabIndex = 6;
            // 
            // frmStudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1462, 620);
            this.Controls.Add(this.pictureBoxShow);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataGVStudentList);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Name = "frmStudentList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStudentList";
            this.Load += new System.EventHandler(this.frmStudentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVStudentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRefresh;
        internal System.Windows.Forms.DataGridView dataGVStudentList;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnShowPicture;
        private System.Windows.Forms.PictureBox pictureBoxShow;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
    }
}