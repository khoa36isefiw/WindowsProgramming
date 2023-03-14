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
    public partial class frmImageShow : Form
    {
        private string imagePath;
        public frmImageShow(string image)
        {
            InitializeComponent();
            this.imagePath = image;

        }

        private void frmImageShow_Load(object sender, EventArgs e)
        {
            pictShowed.Image = Image.FromFile(imagePath);
        }
    }
}
