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
using CRMSV4.GUI.Admin_sForm;
using CRMSV4.GUI.Login;

namespace CRMSV4.GUI.Admin_sForm
{
    public partial class crudForm : Form
    {
        public crudForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomer = new AddCustomerForm();
            this.Hide();
            addCustomer.ShowDialog();
        }

        private void crudForm_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        private void CustomerShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void DataBind()
        {
            CustomerShowGV.DataSource = null;
            CustomerShowGV.DataSource = CustomerDL.CustRecord;
            //  CustomerShowGV.Columns["custPassword"].Visible = false;
            CustomerShowGV.Refresh();
        }

        private void CustomerShowGV_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CustomerShowGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Customer cust = (Customer)CustomerShowGV.CurrentRow.DataBoundItem;
            if (CustomerShowGV.Columns["Delete"].Index == e.ColumnIndex)
            {
                CustomerDL.DeleteCustomer(cust);
                CustomerDL.AddCustInFile();
                DataBind();
            }

            if (CustomerShowGV.Columns["Edit"].Index == e.ColumnIndex)
            {
                AddCustomerForm addCust = new AddCustomerForm(cust);
                this.Hide();
                addCust.ShowDialog();
            }
        }

        private void logoutBtn_Click_1(object sender, EventArgs e)
        {
            Login_Portal logout = new Login_Portal();
            this.Hide();
            logout.ShowDialog();
        }

        private void CarBtn_Click(object sender, EventArgs e)
        {
            CrudCarForm carView = new CrudCarForm();
            this.Hide();
            carView.ShowDialog();
        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            AdminMainMenuForm mainMenu = new AdminMainMenuForm();
            this.Hide();
            mainMenu.ShowDialog();
        }

        private void crudForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
