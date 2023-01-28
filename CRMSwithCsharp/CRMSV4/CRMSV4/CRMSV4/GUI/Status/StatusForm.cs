using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRMSV4.GUI.LoginPortal;
using CRMSV4.GUI.Login;

namespace CRMSV4.GUI.Login
{
    public partial class Login_Portal : Form
    {
        public Login_Portal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginPortal1 login = new LoginPortal1("Admin");
            this.Hide();
            login.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginPortal1 loginC = new LoginPortal1("Customer");
            this.Hide();
            loginC.ShowDialog();
        }

        private void Login_Portal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using our Application");
            Application.Exit();
        }
    }
}
