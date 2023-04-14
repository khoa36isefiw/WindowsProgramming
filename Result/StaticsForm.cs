using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20110375_HuynhDangKhoa_LoginForm.Result
{
    public partial class StaticsForm : Form
    {
        public StaticsForm()
        {
            InitializeComponent();
        }
        Course.COURSE course = new Course.COURSE();
        Score.SCORE score = new Score.SCORE();
        STUDENT student = new STUDENT();
        private void StaticsForm_Load(object sender, EventArgs e)
        {
            StaticByCourse_Load();
            StaticByResult_Load();
            BarChart_Load();
        }

        void StaticByCourse_Load()
        {
            DataTable table = new DataTable();
            table = score.getAverageCourse();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (lblWeb.Text == table.Rows[i]["label"].ToString()) lblWeb.Text = table.Rows[i]["Average Grade"].ToString();
                if (lblSP.Text == table.Rows[i]["label"].ToString()) lblSP.Text = table.Rows[i]["Average Grade"].ToString();
                if (lblWF.Text == table.Rows[i]["label"].ToString()) lblWF.Text = table.Rows[i]["Average Grade"].ToString();
                if (lblMP.Text == table.Rows[i]["label"].ToString()) lblMP.Text = table.Rows[i]["Average Grade"].ToString();
                if (lblCNPM.Text == table.Rows[i]["label"].ToString()) lblCNPM.Text = table.Rows[i]["Average Grade"].ToString();
                if (lblOOP.Text == table.Rows[i]["label"].ToString()) lblOOP.Text = table.Rows[i]["Average Grade"].ToString();
                if (lblNabati.Text == table.Rows[i]["label"].ToString()) lblNabati.Text = table.Rows[i]["Average Grade"].ToString();
                if (lblOOSE.Text == table.Rows[i]["label"].ToString()) lblOOSE.Text = table.Rows[i]["Average Grade"].ToString();
                if (lblDesign.Text == table.Rows[i]["label"].ToString()) lblDesign.Text = table.Rows[i]["Average Grade"].ToString();
                if (lblIT.Text == table.Rows[i]["label"].ToString()) lblIT.Text = table.Rows[i]["Average Grade"].ToString();
                if (lblJAVA.Text == table.Rows[i]["label"].ToString()) lblJAVA.Text = table.Rows[i]["Average Grade"].ToString();

            }
        }
        void StaticByResult_Load()
        {
            DataTable table = new DataTable();
            table = score.getAllCourseScoreAndResult();
            double totalStudent = Convert.ToDouble(student.totalStudent());
            double ExcellentStudent = 0;
            double GoodStudent = 0;
            double AverageStudent = 0;
            double FailStudent = 0;
            double OutStudent = 0;

            //trích xuất bảng để lấy dữ liệu result cho từng loại học sinh
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (table.Rows[i]["Result"].ToString() == "Excellent: ") ExcellentStudent++;
                if (table.Rows[i]["Result"].ToString() == "Good: ") GoodStudent++;
                if (table.Rows[i]["Result"].ToString() == "Average") AverageStudent++;
                if (table.Rows[i]["Result"].ToString() == "Fail:") FailStudent++;
                if (table.Rows[i]["Result"].ToString() == "Drop Out Of University!:") OutStudent++;
            }

            //Tính %
            double PExcellentStudent = Math.Round((ExcellentStudent / totalStudent) * 100, 2);
            double PGoodStudent = Math.Round((GoodStudent / totalStudent) * 100, 2);
            double PAverageStudent = Math.Round((AverageStudent / totalStudent) * 100, 2);
            double PFailStudent = Math.Round((FailStudent / totalStudent) * 100, 2);
            double POutStudent = Math.Round((OutStudent / totalStudent) * 100, 2);

          

            lblExcellent.Text += (ExcellentStudent.ToString() + " (Students)");
            lblGood.Text += GoodStudent.ToString() + " (Students)";
            lblAverage.Text = AverageStudent.ToString() + " (Students)";
            lblFail.Text += FailStudent.ToString() + " (Students)";
            lblDrop.Text += OutStudent.ToString() + " (Students)";
            lblTotal.Text += totalStudent.ToString() + " (Students)";

            ////Pie Chart
            //PieChart.Series["Result"].Points.AddXY("Excellent", PExcellentStudent);
            //PieChart.Series["Result"].Points[0].AxisLabel = (PExcellentStudent.ToString("0.00") + "%");
            //PieChart.Series["Result"].Points[0].LegendText = "Excellent";

            //PieChart.Series["Result"].Points.AddXY("Good", PGoodStudent);
            //PieChart.Series["Result"].Points[1].AxisLabel = (PGoodStudent.ToString("0.00") + "%");
            //PieChart.Series["Result"].Points[1].LegendText = "Good";

            //PieChart.Series["Result"].Points.AddXY("Average", PAverageStudent);
            //PieChart.Series["Result"].Points[2].AxisLabel = (PAverageStudent.ToString("0.00") + "%");
            //PieChart.Series["Result"].Points[2].LegendText = "Average";

            //PieChart.Series["Result"].Points.AddXY("Fail", PFailStudent);
            //PieChart.Series["Result"].Points[3].AxisLabel = (PFailStudent.ToString("0.00") + "%");
            //PieChart.Series["Result"].Points[3].LegendText = "Fail";

            //PieChart.Series["Result"].Points.AddXY("Drop Out", POutStudent);
            //PieChart.Series["Result"].Points[4].AxisLabel = (POutStudent.ToString("0.00") + "%");
            //PieChart.Series["Result"].Points[4].LegendText = "Drop Out";
        }
        void BarChart_Load()
        {
            //DataTable table = new DataTable();
            //table = course.getCoursesAndStudentAttend();
            //for (int i = 0; i < table.Rows.Count; i++)
            //{
            //    BarChart.Series["Student"].Points.AddXY(table.Rows[i]["label"].ToString(), table.Rows[i]["total"].ToString());
            //}
        }

    }
}
