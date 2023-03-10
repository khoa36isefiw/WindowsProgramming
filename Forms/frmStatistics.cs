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
    public partial class frmStatistics : Form
    {

        STUDENT stu = new STUDENT();

        public frmStatistics()
        {
            InitializeComponent();
        }
      
        private void frmStatistics_Load(object sender, EventArgs e)
        {
          
            // display the valeus
            double total = Convert.ToDouble(stu.totalStudent());
            double totalMale = Convert.ToDouble(stu.totalMaleStudent());
            double totalFemale = Convert.ToDouble(stu.totalFemaleStudent());

            // tinh ty le phan %
            // (tong student x 100) / totalStudents
            double maleStudentPercent = (totalMale * (100 / total));
            double femaleStudentPercent = (totalFemale * (100 / total));
            lblTotalStudent.Text = ("Total Students: " + total.ToString());
            lblTotalMaleStudent.Text = ("Male: " + (maleStudentPercent.ToString("0.00") + "%"));
            lblTotalFemaleStudent.Text = ("Female: " + (femaleStudentPercent.ToString("0.00") + "%"));
        }

        // change color cua panel

        //private void lblTotalStudent_MouseEnter(object sender, EventArgs e)
        //{
        //    lblTotalStudent.ForeColor = panTotalColor; 
        //    panelTotalStudent.BackColor = Color.White;
        //}

        //private void lblTotalStudent_MouseLeave(object sender, EventArgs e)
        //{
        //    lblTotalStudent.ForeColor = Color.White;
        //    panelTotalStudent.BackColor = panTotalColor;
        //}

        //private void lblTotalFemaleStudent_MouseEnter(object sender, EventArgs e)
        //{
        //    lblTotalFemaleStudent.ForeColor = panTotalColor;
        //    panelFemaleStudent.BackColor = Color.White;
        //}

        //private void lblTotalFemaleStudent_MouseLeave(object sender, EventArgs e)
        //{
        //    lblTotalFemaleStudent.ForeColor = Color.White;
        //    panelFemaleStudent.BackColor = panTotalColor;
        //}

        //private void lblTotalMaleStudent_MouseEnter(object sender, EventArgs e)
        //{
        //    lblTotalMaleStudent.ForeColor = panTotalColor;
        //    panelMaleStudent.BackColor = Color.White;
        //}

        //private void lblTotalMaleStudent_MouseLeave(object sender, EventArgs e)
        //{
        //    lblTotalMaleStudent.ForeColor = Color.White;
        //    panelMaleStudent.BackColor = panTotalColor;
        //}
    }
}
