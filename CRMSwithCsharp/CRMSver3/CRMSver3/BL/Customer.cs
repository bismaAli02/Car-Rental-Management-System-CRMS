using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSver3.BL
{
    class Customer
    {
        //   CONSTRUCTERS
       
        // DEFAULT CONSTRUCTER
        public Customer()
        {

        }

       
        // PARAMETRIZED CONSTRUCTER
        
        public Customer(string c_id, string cust_name, string cust_p, int age)
        {
            this.c_id = c_id;
            this.cust_name = cust_name;
            this.cust_p = cust_p;
            this.age = age;
            rentedCarName = "0";
        }



        // MEMBERS OF CLASS

        public string c_id;
        public string cust_name;
        public string cust_p;
        public int age;
        //public float rent_amount;
        public string rentedCarName;

        // fUnctions


        
        public void cust_display(List<Customer> cust_record)
        {
            if (cust_record.Count > 0)
            {
                Console.WriteLine("All customer's record:");
                foreach (Customer c in cust_record)
                {
                    Console.WriteLine("Customer_ID: " + c.c_id);
                    Console.WriteLine("Customer_name: " + c.cust_name);
                    Console.WriteLine("Password: " + c.cust_p);
                    Console.WriteLine("Customer's age: " + c.age);
                    Console.WriteLine("                     ");
                }
            }
            else
                Console.WriteLine("No Customer record Available! ");
        }
        // This function will display all records of customer

      public bool validationOfPassword(string pass)
        {
            for (int x = 0; x < pass.Length; x++)
            {
                if (pass[x] == '@' || pass[x] == '!' || pass[x] == '#' || pass[x] == '%' || pass[x] == '^' || pass[x] == '&' || pass[x] == '*' || pass[x] == '$')
                    return true;
            }
            return false;
        }

        // Validation for password so that password must have a special character


       public bool validationOfId(string id)
        {

            for (int i = 0; i < id.Length; i++)
            {
                if ((id[i] >= 33 && id[i] <= 47) || (id[i] >= 58 && id[i] < 127))
                {
                    return false;
                }
            }

            return true;
        }

        // validation for id so that id must be in between 0 to 9 and don't have any alphabet or special characters


        
        //   function for adding in list

       
        // this function is used for remove customer from list

        public bool checkUser(string id, string password, List<Customer> cust_record, List<Car> car_detail,ref int idx)
        {
            for (int i = 0; i < cust_record.Count; i++)
            {
                if (id == cust_record[i].c_id && password == cust_record[i].cust_p)
                {
                    idx = i;
                    return true;
                }
            }
            idx = -1;
            return false;
        }
        // function for check user wether they are valid or not
        public void returnCarBack(List<Car> cars)
        {
            foreach (var c in cars)
            {
                if(rentedCarName==c.car)
                {
                    c.isAvailable = true;
                    rentedCarName = "0";
                }
            }
        }

    }
}