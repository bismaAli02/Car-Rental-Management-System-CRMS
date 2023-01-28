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
using CRMSV4.GUI.Admin_sForm;
using CRMSV4.GUI.Cust_sForm;
using CRMSV4.GUI.Login;

namespace CRMSV4.GUI.LoginPortal
{
    public partial class LoginPortal1 : Form
    {
        private string role;
        public LoginPortal1(string role)
        {
            InitializeComponent();
            this.role = role;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ID = textBox1.Text;
            string pass = textBox2.Text;
            if (ID == "")
            {
                MessageBox.Show("Invalid ID");
            }
            else if (pass == "")
            {
                MessageBox.Show("Invalid Password");
            }
            else
            {
                if (role == "Admin")
                {
                    if (ID == "123" && pass == "abc@")
                    {
                        AdminMainMenuForm mainMenu = new AdminMainMenuForm();
                        this.Hide();
                        mainMenu.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Invalid ID or Password");
                    }
                }
                else if (role == "Customer")
                {
                    Customer cust = new Customer(ID, pass);
                    Customer logInCust = CustomerDL.FindCustomer(cust);
                    if (logInCust != null)
                    {
                        MessageBox.Show("Welcome");
                        CustMainMenuForm mainPage = new CustMainMenuForm(logInCust);
                        this.Hide();
                        mainPage.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Customer");
                    }
                }
            }
        }

        private void LoginPortal1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Login_Portal status = new Login_Portal();
            this.Hide();
            status.ShowDialog();
        }
    }
}
