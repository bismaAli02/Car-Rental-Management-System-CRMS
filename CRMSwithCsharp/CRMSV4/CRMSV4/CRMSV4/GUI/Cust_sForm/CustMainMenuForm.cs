using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRMSV4.BL;
using CRMSV4.GUI.Login;

namespace CRMSV4.GUI.Cust_sForm
{
    public partial class CustMainMenuForm : Form
    {
        private Customer logInCust = null;
        public CustMainMenuForm(Customer logInCust)
        {
            InitializeComponent();
            this.logInCust = logInCust;
        }

        private void CarUnBudBtn_Click(object sender, EventArgs e)
        {
            CarsUnderBudgetForm carsUnderBudget = new CarsUnderBudgetForm(logInCust);
            this.Hide();
            carsUnderBudget.ShowDialog();
        }

        private void AllCarBtn_Click(object sender, EventArgs e)
        {
            AllCarsForm allCars = new AllCarsForm(logInCust);
            this.Hide();
            allCars.ShowDialog();
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

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login_Portal logout = new Login_Portal();
            this.Hide();
            logout.ShowDialog();
        }

        private void CustMainMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void CustMainMenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
