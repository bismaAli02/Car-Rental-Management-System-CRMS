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
using CRMSV4.DL;
using CRMSV4.GUI.Login;


namespace CRMSV4.GUI.Cust_sForm
{
    public partial class CarsUnderBudgetForm : Form
    {
        private Customer logInCust = null;
        public CarsUnderBudgetForm(Customer logInCust)
        {
            InitializeComponent();
            CarShowGV.Visible = false;
            this.logInCust = logInCust;
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            CarShowGV.Visible = true;
            DataBind();
        }
        public void DataBind()
        {
            CarShowGV.DataSource = null;
            CarShowGV.DataSource = CarDL.GetListOfCarUnderBudget(int.Parse(RentBnum.Value.ToString()));
            CarShowGV.Refresh();
        }

        private void AllCarBtn_Click(object sender, EventArgs e)
        {
            AllCarsForm allCars = new AllCarsForm(logInCust);
            this.Hide();
            allCars.ShowDialog();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login_Portal logout = new Login_Portal();
            this.Hide();
            logout.ShowDialog();
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

        private void CarsUnderBudgetForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
