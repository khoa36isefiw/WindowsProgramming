using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _20110375_HuynhDangKhoa_LoginForm
{
    public partial class frmStatisticsPieChart : Form
    {
        public frmStatisticsPieChart()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            DBPieChartDataContext db = new DBPieChartDataContext();
            Piechart.DataSource = db.totalAgeByViews.ToList();
            Piechart.Series["Quantitys"].XValueMember = "Age";
            Piechart.Series["Quantitys"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;

            Piechart.Series["Quantitys"].YValueMembers= "Quantitys";
            Piechart.Series["Quantitys"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;



        }

        private void frmStatisticsPieChart_Load(object sender, EventArgs e)
        {

        }
    }
}
