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
using CRMSV4.BL;

namespace CRMSV4.GUI.Cust_sForm
{
    public partial class InvoiceForm : Form
    {
        private Customer logInCust = null;
        public InvoiceForm(Customer logInCust)
        {
            InitializeComponent();
            this.logInCust = logInCust;
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            CarNameCombo.DataSource = CarDL.CarList;
            CarNameCombo.DisplayMember = "CarName";
        }

        private void InvoiceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            CustMainMenuForm mainPage = new CustMainMenuForm(logInCust);
            this.Hide();
            mainPage.ShowDialog();
        }

        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            int days = int.Parse(InvoiceDays.Value.ToString());
            if (days > 0)
            {
                if (logInCust.RentedCarName == "0")
                {
                    string CarName = CarNameCombo.Text;
                    Car c = CarDL.FindCar(CarName);
                    if (c.IsAvailable)
                    {
                        c.IsAvailable = false;
                        logInCust.RentedCarName = CarName;
                        CarDL.addCarIntoFile();
                        CustomerDL.AddCustInFile();
                        CustMainMenuForm mainPage = new CustMainMenuForm(logInCust);
                        this.Hide();
                        mainPage.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Car Not Available");
                    }
                }
                else
                {
                    MessageBox.Show("You already have a Car on Rent");
                }
                CarDL.addCarIntoFile();
                CustomerDL.AddCustInFile();
            }
        }

        private void InvoiceDays_ValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }
        public void Calculate()
        {
            string CarName = CarNameCombo.Text;
            Car c = CarDL.FindCar(CarName);
            int days = int.Parse(InvoiceDays.Value.ToString());
            if (days != 0)
            {
                PayAbleLabel.Text = c.RentCalculate(days).ToString();
            }
            else
            {
                PayAbleLabel.Text = "0";
            }
            if (days >= 5)
            {
                MessageBox.Show("Days more than 5 or 5 will give you a discount of 5%");
            }
        }
        private void CarNameCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}
