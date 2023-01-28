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

namespace CRMSV4.GUI.Admin_sForm
{
    public partial class CrudCarForm : Form
    {
        public CrudCarForm()
        {
            InitializeComponent();
        }

        private void CrudCarForm_Load(object sender, EventArgs e)
        {
            DataBind();
        }
        public void DataBind()
        {
            CarShowGV.DataSource = null;
            CarShowGV.DataSource = CarDL.CarList;
            CarShowGV.Refresh();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            AddCarForm carAdd = new AddCarForm();
            this.Hide();
            carAdd.ShowDialog();
        }

        private void CarShowGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Car c = (Car)CarShowGV.CurrentRow.DataBoundItem;
            if (CarShowGV.Columns["Delete"].Index == e.ColumnIndex)
            {
                CarDL.DeleteCar(c);
                CarDL.addCarIntoFile();
                DataBind();
            }

            if (CarShowGV.Columns["Edit"].Index == e.ColumnIndex)
            {
                AddCarForm carAdd = new AddCarForm(c);
                this.Hide();
                carAdd.ShowDialog();
            }
        }


        private void logoutBtn_Click(object sender, EventArgs e)
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

        private void CrudCarForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
