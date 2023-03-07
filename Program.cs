using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20110375_HuynhDangKhoa_LoginForm
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmLogin());
            
            frmLogin flogin = new frmLogin();
            if(flogin.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new frmMain());
                

            }
            else
            {
                Application.Exit();
            }
        }
    }
}
