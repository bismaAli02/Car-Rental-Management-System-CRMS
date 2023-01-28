using CRMSV4.BL;
using CRMSV4.DL;
using System;
using System.Windows.Forms;

namespace CRMSV4.GUI.Admin_sForm
{

    public partial class AddCustomerForm : Form
    {
        private Customer cust = null;
        public AddCustomerForm()
        {
            InitializeComponent();
            EditButton.Visible = false;
            CreatButton.Visible = true;
        }

        public AddCustomerForm(Customer cust)
        {
            InitializeComponent();
            this.cust = cust;
            setTextBoxes();
            EditButton.Visible = true;
            CreatButton.Visible = false;
        }

        public void setTextBoxes()
        {
            NameTxt.Text = cust.CustName;
            IDTxt.Text = cust.CustID;
            AgeTxt.Value = cust.Age;
            PasswordTxt.Text = cust.CustPassword;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CreatButton_Click(object sender, EventArgs e)
        {
            if (NameTxt.Text == "")
            {
                MessageBox.Show("Invalid Name");
            }
            else if (IDTxt.Text == "")
            {
                MessageBox.Show("Invalid ID");
            }
            else if (PasswordTxt.Text == "")
            {
                MessageBox.Show("Invalid Password");
            }
            else
            {
                string custName = NameTxt.Text;
                string custID = IDTxt.Text;
                int age = int.Parse(AgeTxt.Value.ToString());
                if (CustomerDL.validationOfId(custID))
                {
                    string custPassword = PasswordTxt.Text;
                    if (CustomerDL.validationOfPassword(custPassword))
                    {
                        Customer cust = new Customer(custID, custName, custPassword, age);
                        CustomerDL.AddCustInList(cust);
                        CustomerDL.AddCustInFile();
                        BackButton_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Password must have a special Character");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid ID");
                }
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            crudForm view = new crudForm();
            this.Hide();
            view.ShowDialog();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (NameTxt.Text == "")
            {
                MessageBox.Show("Invalid Name");
            }
            else if (IDTxt.Text == "")
            {
                MessageBox.Show("Invalid ID");
            }
            else if (PasswordTxt.Text == "")
            {
                MessageBox.Show("Invalid Password");
            }
            else
            {
                string custName = NameTxt.Text;
                string custID = IDTxt.Text;
                int age = int.Parse(AgeTxt.Value.ToString());
                if (CustomerDL.validationOfId(custID))
                {
                    string custPassword = PasswordTxt.Text;
                    if (CustomerDL.validationOfPassword(custPassword))
                    {
                        Customer c = new Customer(custID, custName, custPassword, age);
                        CustomerDL.EditCustomer(cust, c);
                        CustomerDL.AddCustInFile();
                        BackButton_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Password must have a special Character");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid ID");
                }
            }

        }

        private void AddCustomerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
