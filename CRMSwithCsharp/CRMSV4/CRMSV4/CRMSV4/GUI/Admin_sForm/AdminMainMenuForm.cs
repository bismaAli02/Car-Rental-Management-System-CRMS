using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRMSV4.GUI.Login;

namespace CRMSV4.GUI.Admin_sForm
{
    public partial class AdminMainMenuForm : Form
    {
        public AdminMainMenuForm()
        {
            InitializeComponent();
        }

        private void AdminMainMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login_Portal logout = new Login_Portal();
            this.Hide();
            logout.ShowDialog();
        }

        private void CustomerBtn_Click(object sender, EventArgs e)
        {
            crudForm custView = new crudForm();
            this.Hide();
            custView.ShowDialog();
        }

        private void CarBtn_Click(object sender, EventArgs e)
        {
            CrudCarForm carView = new CrudCarForm();
            this.Hide();
            carView.ShowDialog();
        }

        private void AdminMainMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
