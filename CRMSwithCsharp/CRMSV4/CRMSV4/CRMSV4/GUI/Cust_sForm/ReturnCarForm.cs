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
    public partial class ReturnCarForm : Form
    {
        private Customer logInCust = null;
        public ReturnCarForm(Customer logInCust)
        {
            InitializeComponent();
            this.logInCust = logInCust;
        }

        private void ReturnCarForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MainBtn_Click(object sender, EventArgs e)
        {
            CustMainMenuForm mainPage = new CustMainMenuForm(logInCust);
            this.Hide();
            mainPage.ShowDialog();
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

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login_Portal logout = new Login_Portal();
            this.Hide();
            logout.ShowDialog();
        }

        private void ReturnCarForm_Load(object sender, EventArgs e)
        {
            if (logInCust.RentedCarName != "0")
            {
                button1.Visible = true;
                label2.Text = "You have Taken " + logInCust.RentedCarName + " On rent do you want to return it";

            }
            else
            {
                button1.Visible = false;
                label2.Text = "No car have been taken by You";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Car c = CarDL.FindCar(logInCust.RentedCarName);
            c.IsAvailable = true;
            logInCust.RentedCarName = "0";
            CarDL.addCarIntoFile();
            CustomerDL.AddCustInFile();
            MessageBox.Show("Car Returned");
            ReturnCarForm returnC = new ReturnCarForm(logInCust);
            this.Hide();
            returnC.ShowDialog();
        }
    }
}
