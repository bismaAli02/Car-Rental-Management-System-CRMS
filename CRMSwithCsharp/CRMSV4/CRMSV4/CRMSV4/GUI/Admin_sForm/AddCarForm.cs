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

namespace CRMSV4.GUI.Admin_sForm
{
    public partial class AddCarForm : Form
    {
        private Car c = null;
        public AddCarForm(Car c)
        {
            InitializeComponent();
            this.c = c;
            CreatButton.Visible = false;
            EditButton.Visible = true;
            Availabletxt.Visible = true;
            checkBox1.Visible = true;
            checkBox2.Visible = true;
            SetTextBoxes();
        }
        public AddCarForm()
        {
            InitializeComponent();
            CreatButton.Visible = true;
            EditButton.Visible = false;
            Availabletxt.Visible = false;
            checkBox1.Visible = false;
            checkBox2.Visible = false;
        }
        public void SetTextBoxes()
        {
            NameTxt.Text = c.CarName;
            RentTxt.Value = c.Rent;
            if (c.IsAvailable)
            {
                checkBox1.Checked = true;
                checkBox2.Checked = false;
            }
            else
            {
                checkBox1.Checked = false;
                checkBox2.Checked = true;
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (NameTxt.Text == "")
            {
                MessageBox.Show("Invalid Name");
            }
            else
            {
                string CarName = NameTxt.Text;
                int Rent = int.Parse(RentTxt.Value.ToString());
                bool IsAvailable;
                if (checkBox1.Checked)
                {
                    IsAvailable = true;
                }
                else
                {
                    IsAvailable = false;
                }
                Car car = new Car(CarName, Rent, IsAvailable);
                CarDL.EditCar(c, car);
                CarDL.addCarIntoFile();
                CrudCarForm carView = new CrudCarForm();
                this.Hide();
                carView.ShowDialog();
            }
        }

        private void CreatButton_Click(object sender, EventArgs e)
        {
            if (NameTxt.Text == "")
            {
                MessageBox.Show("Invalid Name");
            }
            else
            {
                string CarName = NameTxt.Text;
                int Rent = int.Parse(RentTxt.Value.ToString());
                Car car = new Car(CarName, Rent);
                CarDL.AddCarInList(car);
                CarDL.addCarIntoFile();
                CrudCarForm carView = new CrudCarForm();
                this.Hide();
                carView.ShowDialog();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
            }
            else
            {
                checkBox2.Checked = true;
            }
        }


        private void BackButton_Click(object sender, EventArgs e)
        {
            CrudCarForm carView = new CrudCarForm();
            this.Hide();
            carView.ShowDialog();
        }

        private void AddCarForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
            }
        }

        private void AddCarForm_Load(object sender, EventArgs e)
        {

        }
    }
}
