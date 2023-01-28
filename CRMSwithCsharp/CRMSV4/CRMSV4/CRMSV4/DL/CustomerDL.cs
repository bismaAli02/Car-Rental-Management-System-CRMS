using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRMSV4.BL;
using System.IO;

namespace CRMSV4.DL
{
    public class CustomerDL
    {
        private static List<Customer> custRecord = new List<Customer>();
        private static string path = "Customer.txt";
        public static List<Customer> CustRecord { get => custRecord; set => custRecord = value; }

        public static void EditCustomer(Customer c1, Customer c2)
        {
            foreach (Customer c in CustRecord)
            {
                if (c.CustID == c1.CustID)
                {
                    c.CustName = c2.CustName;
                    c.Age = c2.Age;
                    c.CustID = c2.CustID;
                    c.CustPassword = c2.CustPassword;
                }
            }
        }
        public static void AddCustInList(Customer c)
        {
            CustRecord.Add(c);
        }
        public static bool DeleteCustomer(Customer c)
        {
            int idx = -1;
            for (int i = 0; i < custRecord.Count; i++)
            {
                if (custRecord[i].CustID == c.CustID)
                {
                    idx = i;
                }
            }
            if (idx != -1)
            {
                custRecord.RemoveAt(idx);
                return true;
            }
            return false;
        }
        public static Customer FindCustomerByName(string custName)
        {
            foreach (Customer cust in CustRecord)
            {
                if (custName == cust.CustName)
                {
                    return cust;
                }
            }

            return null;
        }
        public static Customer FindCustomer(Customer c)
        {
            foreach (Customer cust in CustRecord)
            {
                if (c.CustID == cust.CustID && c.CustPassword == cust.CustPassword)
                {
                    return cust;
                }
            }

            return null;
        }
        public static bool checkUser(string id, string password, ref int idx)
        {
            for (int i = 0; i < custRecord.Count; i++)
            {
                if (id == custRecord[i].CustID && password == custRecord[i].CustPassword)
                {
                    idx = i;
                    return true;
                }
            }
            idx = -1;
            return false;
        }
        public static void AddCustInFile()
        {
            StreamWriter cust = new StreamWriter(path, false);
            for (int i = 0; i < custRecord.Count; i++)
            {
                cust.WriteLine(custRecord[i].CustID + "," + custRecord[i].CustName + "," + custRecord[i].CustPassword + "," + CustRecord[i].Age + "," + custRecord[i].RentedCarName);

            }
            cust.Flush();
            cust.Close();
        }

        public static void loadCustomerIntoList()
        {
            string word;
            if (File.Exists(path))
            {
                StreamReader cust = new StreamReader(path);
                while ((word = cust.ReadLine()) != null)
                {
                    Customer c = new Customer();
                    string[] SplittedRecord = word.Split(',');
                    c.CustID = (SplittedRecord[0]);
                    c.CustName = SplittedRecord[1];
                    c.CustPassword = SplittedRecord[2];
                    c.Age = int.Parse(SplittedRecord[3]);
                    c.RentedCarName = SplittedRecord[4];
                    AddCustInList(c);
                }
                cust.Close();
            }
        }

        public static bool validationOfId(string id)
        {
            foreach (Customer cust in custRecord)
            {
                if (id == cust.CustID)
                {
                    return false;
                }
            }
            for (int i = 0; i < id.Length; i++)
            {
                if ((id[i] >= 33 && id[i] <= 47) || (id[i] >= 58 && id[i] < 127))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool validationOfPassword(string pass)
        {
            for (int x = 0; x < pass.Length; x++)
            {
                if (pass[x] == '@' || pass[x] == '!' || pass[x] == '#' || pass[x] == '%' || pass[x] == '^' || pass[x] == '&' || pass[x] == '*' || pass[x] == '$')
                    return true;
            }
            return false;
        }


    }
}
