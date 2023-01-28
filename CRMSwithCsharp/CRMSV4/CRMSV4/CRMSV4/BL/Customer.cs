using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSV4.BL
{
    public class Customer
    {
        //   CONSTRUCTERS

        // DEFAULT CONSTRUCTER
        public Customer()
        {

        }


        // PARAMETRIZED CONSTRUCTER

        public Customer(string custID, string custName, string custPassword, int age)
        {
            this.CustID = custID;
            this.CustName = custName;
            this.CustPassword = custPassword;
            this.Age = age;
            RentedCarName = "0";
        }
        public Customer(string custID, string custPassword)
        {
            this.CustID = custID;
            this.custPassword = custPassword;
        }



        // MEMBERS OF CLASS

        private string custID;
        private string custName;
        private string custPassword;
        private int age;
        //private float rent_amount;
        private string rentedCarName;

        public string CustID { get => custID; set => custID = value; }
        public string CustName { get => custName; set => custName = value; }
        public string CustPassword { get => custPassword; set => custPassword = value; }
        public int Age { get => age; set => age = value; }
        public string RentedCarName { get => rentedCarName; set => rentedCarName = value; }





        public void returnCarBack(List<Car> cars)
        {
            foreach (var c in cars)
            {
                if (rentedCarName == c.CarName)
                {
                    c.IsAvailable = true;
                    rentedCarName = "0";
                }
            }
        }

    }
}
