using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20110375_HuynhDangKhoa_LoginForm
{
    public partial class frmStatisticsByChart : Form
    {
        public frmStatisticsByChart()
        {
            InitializeComponent();
        }

        private void frmStatisticsByChart_Load(object sender, EventArgs e)
        {
            using (QLSVEntities db = new QLSVEntities())
            {
                var data = db.totalBirthYearStudent();
                ColumnSeries col = new ColumnSeries()
                {
                    DataLabels = true,
                    Values = new ChartValues<int>(),
                    LabelPoint = point => point.Y.ToString()
                };

                Axis ax = new Axis()
                {
                    Separator = new Separator()
                    {
                        Step = 1,
                        IsEnabled = false
                    }
                };

                ax.Labels = new List<string>();
                foreach (var x in data)
                {
                    col.Values.Add(x.Total.Value);
                    ax.Labels.Add(x.Year.ToString());
                }
                cartesianChart2.Series.Add(col);
                cartesianChart2.AxisX.Add(ax);
                cartesianChart2.AxisY.Add(new Axis
                {
                    LabelFormatter = value => value.ToString(),
                    Separator = new Separator()
                });


            }
        }
    }
}
