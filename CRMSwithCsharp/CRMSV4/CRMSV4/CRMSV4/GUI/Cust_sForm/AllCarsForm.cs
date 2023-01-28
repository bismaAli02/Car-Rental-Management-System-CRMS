using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRMSV4.DL;
using CRMSV4.GUI.Login;
using CRMSV4.BL;

namespace CRMSV4.GUI.Cust_sForm
{
    public partial class AllCarsForm : Form
    {
        private Customer logInCust = null;
        public AllCarsForm(Customer logInCust)
        {
            InitializeComponent();
            this.logInCust = logInCust;
        }

        private void AllCarsForm_Load(object sender, EventArgs e)
        {
            DataBind();
        }
        public void DataBind()
        {
            CarShowGV.DataSource = null;
            CarShowGV.DataSource = CarDL.CarList;
            CarShowGV.Refresh();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login_Portal logout = new Login_Portal();
            this.Hide();
            logout.ShowDialog();
        }

        private void CarUnBudBtn_Click(object sender, EventArgs e)
        {
            CarsUnderBudgetForm carsUnderBudget = new CarsUnderBudgetForm(logInCust);
            this.Hide();
            carsUnderBudget.ShowDialog();
        }

        private void SortedBtn_Click(object sender, EventArgs e)
        {
            ViewSortedCarForm SortedCar = new ViewSortedCarForm(logInCust);
            this.Hide();
            SortedCar.ShowDialog();
        }

        private void InvoiceBtn_Click(object sender, EventArgs e)
        {
            InvoiceForm invoice = new InvoiceForm(logInCust);
            this.Hide();
            invoice.ShowDialog();
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            ReturnCarForm returnC = new ReturnCarForm(logInCust);
            this.Hide();
            returnC.ShowDialog();
        }

        private void MainBtn_Click(object sender, EventArgs e)
        {
            CustMainMenuForm mainPage = new CustMainMenuForm(logInCust);
            this.Hide();
            mainPage.ShowDialog();
        }

        private void AllCarsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void CarShowGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
