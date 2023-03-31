namespace _20110375_HuynhDangKhoa_LoginForm
{
    partial class frmStatisticsPieChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Piechart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblAge = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Piechart)).BeginInit();
            this.SuspendLayout();
            // 
            // Piechart
            // 
            chartArea1.Name = "ChartArea1";
            this.Piechart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Piechart.Legends.Add(legend1);
            this.Piechart.Location = new System.Drawing.Point(115, 61);
            this.Piechart.Name = "Piechart";
            this.Piechart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Quantitys";
            this.Piechart.Series.Add(series1);
            this.Piechart.Size = new System.Drawing.Size(473, 356);
            this.Piechart.TabIndex = 0;
            this.Piechart.Text = "Age Chart";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(618, 364);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(104, 53);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(207, 24);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(257, 25);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Statistics Student By Age";
            // 
            // frmStatisticsPieChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 448);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.Piechart);
            this.Name = "frmStatisticsPieChart";
            this.Text = "frmStatisticsPieChart";
            this.Load += new System.EventHandler(this.frmStatisticsPieChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Piechart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Piechart;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblAge;
    }
}