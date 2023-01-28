using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRMSV4.GUI.Login;
using CRMSV4.GUI.LoginPortal;
using CRMSV4.GUI.Admin_sForm;
using CRMSV4.DL;

namespace CRMSV4
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CustomerDL.loadCustomerIntoList();
            CarDL.loadCarIntoList();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login_Portal());
        }
    }
}
