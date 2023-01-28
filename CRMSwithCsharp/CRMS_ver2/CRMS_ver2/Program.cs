using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CRMSver2.BL;

namespace CRMSver2
{
    class Program
    {


        static void header()
        {
            Console.WriteLine("***********************************************************");
            Console.WriteLine("*                   Welcome to our company                *");
            Console.WriteLine("***********************************************************");
        }
        // end of header function

        static void header1()
        {
            Console.WriteLine("////////////////////////////////////////////////////////////");
            Console.WriteLine("--          Car Rental Management System (CRMS)           --");
            Console.WriteLine("////////////////////////////////////////////////////////////");
        }
        // end of 2nd header function

        static void system_cls()
        {
            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
            Console.Clear();
        }
        // end of system_cls function
        static char status_menu(ref char status)
        {
            header();
            Console.WriteLine("Select your Status:  >");
            Console.WriteLine("a.... Admin");
            Console.WriteLine("b.... Customer");
            Console.WriteLine("c.... Exit");
            Console.Write("Choose your option: ");
            status = char.Parse(Console.ReadLine());
            system_cls();
            return status;
        }
        // end of status_menu

        static char login_portal(ref char status, ref string id, ref string password)
        {
            if (status == 'a' || status == 'b')
            {
                header1();
                Console.WriteLine("               Login Portal                ");
                Console.Write("Enter User ID--------");
                id = Console.ReadLine();
                Console.Write("Enter Password--------");
                password = Console.ReadLine();
            }
            system_cls();
            return status;
        }
        // end of login portal function

        static char admin_menu(char option)
        {
            header();
            Console.WriteLine("Main Menu   ");
            Console.WriteLine("Select one of the following options number . . .");
            Console.WriteLine("1.  Display Car's model");
            Console.WriteLine("2.  Add new customers");
            Console.WriteLine("3.  Remove customer");
            Console.WriteLine("4.  Change rent of cars");
            Console.WriteLine("5.  View all customers record");
            Console.WriteLine("6.  Add new car");
            Console.WriteLine("7.  Remove car: ");
            Console.WriteLine("8.  logout");
            Console.Write("Choose your option: ");
            option = char.Parse(Console.ReadLine());
            system_cls();
            return option;
        }
        // end of admin's menu

        static char cust_menu(char option)
        {
            header();
            Console.WriteLine("Main Menu   ");
            Console.WriteLine("Select one of the following options number . . .");
            Console.WriteLine("1.  Display Car under budget");
            Console.WriteLine("2.  Display rent for all cars");
            Console.WriteLine("3.  Display cars from lower to higher rent");
            Console.WriteLine("4.  Invoice");
            Console.WriteLine("5.  Logout");
            Console.Write("Choose your option: ");
            option = char.Parse(Console.ReadLine());
            system_cls();
            return option;
        }

        static void cust_display(List<Customer> cust_record)
        {
            if (cust_record.Count > 0)
            {
                Console.WriteLine("All customer's record:");
                for (int i = 0; i < cust_record.Count; i++)
                {
                    Console.WriteLine("Customer_ID: " + cust_record[i].c_id);
                    Console.WriteLine("Customer_name: " + cust_record[i].cust_name);
                    Console.WriteLine("Password: " + cust_record[i].cust_p);
                    Console.WriteLine("Customer's age: " + cust_record[i].age);
                    Console.WriteLine("                     ");
                }
            }
            else
                Console.WriteLine("No Customer record Available! ");
        }
        // end of display customers function

        static void models(List<Car> car_detail)
        {
            header1();
            if (car_detail.Count == 0)
            {
                Console.WriteLine("Sorry no car available!!!!!!");
            }
            else
            {
                Console.WriteLine("All car's model  >");

                for (int i = 0; i < car_detail.Count; i++)
                {
                    Console.WriteLine("car id " + (i + 1) + " :  " + car_detail[i].car + "\t\t Rent :  " + car_detail[i].rent);
                }
            }
            system_cls();
        }


        // end of customer display function
        static void edit_rent(List<Car> car_detail)
        {
            string _id;
            int rent;
            if (car_detail.Count == 0)
            {
                Console.WriteLine("Sorry no car available!!!!!!");
            }
            else
            {
                Console.WriteLine("Enter the Car Id: ");
                _id = (Console.ReadLine());
                int id = int.Parse(_id);

                if (id > 0 && id <= car_detail.Count)
                {
                    Console.WriteLine("Enter new Rent: ");
                    rent = int.Parse(Console.ReadLine());
                    car_detail[id - 1].rent = rent;
                    Console.WriteLine("Rent Update Successfully!");
                }
                else
                    Console.WriteLine("Invalid Care Id!");
            }
        }
        // end of change rent function

        static void invoice(string car_name, int day, int rental_amount, List<Car> car_detail)
        {
            header1();
            Console.WriteLine("Invoice of a customer: ");
            Console.WriteLine("                                 ");
            Console.Write("Enter Car model: ");
            car_name = Console.ReadLine();
            for (int i = 0; i < car_detail.Count; i++)
            {
                if (car_detail[i].car == car_name)
                {
                    Console.WriteLine("If you avail this car more than 4 days you will get 5% discount");
                    Console.Write("Enter number of days: ");
                    day = int.Parse(Console.ReadLine());
                    rental_amount = day * car_detail[i].rent;
                    if (day >= 5)
                    {
                        rental_amount = rental_amount - (rental_amount * 5 / 100);
                    }
                    Console.WriteLine("YOUR TOTAL AMOUNT: " + rental_amount);
                }
            }
            if (rental_amount == 0)
            {
                Console.WriteLine("Car not found!!!!");
            }
        }
        // end of invoice function

        static void Budget(int budget, List<Car> car_detail)
        {
            int c = 0;
            header1();
            Console.Write("Enter your budget: ");
            budget = int.Parse(Console.ReadLine());
            for (int i = 0; i < car_detail.Count; i++)
            {
                if (car_detail[i].rent <= budget)
                {
                    Console.WriteLine(car_detail[i].car + " Car with rent " + car_detail[i].rent);
                    c++;
                }
            }
            if (c == 0)
            {
                Console.WriteLine("Sorry no car available under your budget......");
            }
        }
        // end of function that recommend cars under customer's budget
        static bool validationOfPassword(string pass)
        {
            for (int x = 0; x < pass.Length; x++)
            {
                if (pass[x] == '@' || pass[x] == '!' || pass[x] == '#' || pass[x] == '%' || pass[x] == '^' || pass[x] == '&' || pass[x] == '*' || pass[x] == '$')
                    return true;
            }
            return false;
        }

        static bool validationOfId(string id)
        {

            for (int i = 0; i<id.Length; i++)
            {
                if ((id[i] >= 33 && id[i] <= 47) || (id[i] >= 58 && id[i] < 127))
                {
                    return false;
                }
            }

            return true;
        }
        static void add_C(List<Customer> cust_record)
        {
            Customer cust = new Customer();
            int n = 0;

            Console.Write("Enter customer  ID:  ");
            cust.c_id = (Console.ReadLine());

            for (int i = 0; i < cust_record.Count; i++)
            {
                if (cust_record[i].c_id == cust.c_id)
                {
                    Console.WriteLine("You already assign this id to another customer Use another id");
                    n = 1;
                    break;
                }
            }

            if (validationOfId(cust.c_id) == true)
            {
                if (n == 0)
                {
                    Console.Write("Enter customer  name:  ");
                    cust.cust_name = Console.ReadLine();
                    Console.Write("Enter customer  password(your password must have a special character such as !/@/#): ");
                    cust.cust_p = Console.ReadLine();

                    if (validationOfPassword(cust.cust_p) == true)
                    {
                        Console.Write("Enter customer's age(customer must be 18 year's old otherwise account will not created): ");
                        cust.age = int.Parse(Console.ReadLine());
                        if (cust.age >= 18 && cust.age <= 65)
                        {
                            addCustIntoList(cust_record, cust);
                            Console.WriteLine(" Account is successfully created");
                        }
                        else
                        {
                            Console.WriteLine("To create an account your age must be 18!!!!!!!!!!!!");
                        }
                    }
                    else
                        Console.WriteLine("please enter a valid password");
                }
            }
            else
            {
                Console.WriteLine(" Please Enter Valid Id!!! ");
            }
        }
        static void addCustIntoList(List<Customer> cust_record, Customer cust)
        {

            cust_record.Add(cust);

        }

        static void addCustIntoFile(string path1, List<Customer> cust_record)
        {
            StreamWriter cust = new StreamWriter(path1, false);
            for (int i = 0; i < cust_record.Count; i++)
            {
                cust.WriteLine(cust_record[i].c_id + "," + cust_record[i].cust_name + "," + cust_record[i].cust_p + "," + cust_record[i].age);

            }
            cust.Flush();
            cust.Close();
        }
        // add customer's into file function

        static void remove_C(List<Customer> cust_record)
        {
            string _id;
            int index = -1;
            if (cust_record.Count == 0)
                Console.WriteLine("No Record Available to Remove!");
            else
            {
                header1();
                Console.Write("Enter Customer ID you want to remove:  ");
                _id = (Console.ReadLine());

                for (int i = 0; i < cust_record.Count; i++)
                {
                    if (cust_record[i].c_id == _id)
                    {
                        index = i;
                        cust_record.RemoveAt(i);
                        Console.WriteLine("Account is successfully removed");
                        break;
                    }
                }
            }
            if (index == -1)
            {
                Console.WriteLine("Invalid Customer id!");
            }
        }
        // storing customer details in array

        static Car add_Car(List<Car> car_detail)
        {
            Car car = new Car();
            Console.Write("Enter car name: ");
            car.car = Console.ReadLine();

            Console.Write("Enter car's rent: ");
            car.rent = int.Parse(Console.ReadLine());
            return car;
        }

        static void addCarIntoList(List<Car> car_detail)
        {
            car_detail.Add(add_Car(car_detail));

        }
        // storing cars details into array

        static void addCarIntoFile(string path, List<Car> car_detail)
        {
            StreamWriter car = new StreamWriter(path, false);
            for (int i = 0; i < car_detail.Count; i++)
            {
                car.WriteLine(car_detail[i].car + "," + car_detail[i].rent);

            }
            car.Flush();
            car.Close();
        }
        // add car into file
        static void remove_Car(List<Car> car_detail)
        {
            string car_name;
            int index = -1;
            if (car_detail.Count == 0)
                Console.WriteLine("No Record Available to Remove!");
            else
            {
                Console.WriteLine("Enter car name you want to remove:  ");
                car_name = Console.ReadLine();

                for (int i = 0; i < car_detail.Count; i++)
                {
                    if (car_detail[i].car == car_name)
                    {
                        index = i;
                        car_detail.RemoveAt(i);
                        Console.WriteLine("Car is successfully removed");
                        break;

                    }
                }
            }
            if (index == -1)
            {
                Console.WriteLine("Invalid Car!");
            }
        }

        static string parseRecord(string record, int field)
        {
            int commaCount = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    commaCount++;
                }
                else if (commaCount == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }

        static bool checkUser(string id, string password, List<Customer> cust_record, List<Car> car_detail)
        {
            for (int i = 0; i < cust_record.Count; i++)
            {
                if (id == cust_record[i].c_id && password == cust_record[i].cust_p)
                {
                    return true;
                }
            }
            return false;
        }
        // function for check user wether they are valid or not
        static void sorting(List<Car> car_detail)
        {
            car_detail.Sort((x, y) => x.rent.CompareTo(y.rent));
        }

        static void loadCustomerIntoList(string path1, List<Customer> cust_record)
        {
            string word;
            if (File.Exists(path1))
            {
                StreamReader cust = new StreamReader(path1);
                while ((word = cust.ReadLine()) != null)
                {
                    Customer c = new Customer();
                    c.c_id = ((parseRecord(word, 1)));
                    c.cust_name = parseRecord(word, 2);
                    c.cust_p = parseRecord(word, 3);
                    c.age = int.Parse((parseRecord(word, 4)));
                    cust_record.Add(c);
                }
                cust.Close();
            }
            else
                Console.WriteLine("File does not exist");
        }
        // function for storing data from file to arrays

        static void loadCarIntoList(string path, List<Car> car_detail)
        {
            string word;
            if (File.Exists(path))
            {
                StreamReader car = new StreamReader(path);
                while ((word = car.ReadLine()) != null)
                {
                    Car a = new Car();
                    a.car = parseRecord(word, 1);
                    a.rent = int.Parse((parseRecord(word, 2)));

                    car_detail.Add(a);
                }
                car.Close();
            }
            else
                Console.WriteLine("File does not exists!!!!!");
        }
        // function for storing cars from file to arrays

        static void Main(string[] args)
        {
            char status = ' ';
            string id = "";
            string password = "";
            //------------------- Data Structures-----------------------------
            string path = "car.txt";
            string path1 = "customer.txt";
            List<Car> car_detail = new List<Car>();
            List<Customer> cust_record = new List<Customer>();
            loadCarIntoList(path, car_detail);
            loadCustomerIntoList(path1, cust_record);

            char mainchoice, login, option = ' ';
            int budget = 0, rental_amount = 0, day = 0;
            string car_name = "";

            /* Hard code Id and password....
                Admin id is 123 and password is abc@ */
            while (true)
            {
                mainchoice = status_menu(ref status);
                login = login_portal(ref status, ref id, ref password);
                if (status == 'a')
                {
                    if (id == "123" && password == "abc@")
                    {
                        while (true)
                        {
                            option = admin_menu(option);
                            if (option == '1')
                            {
                                models(car_detail);
                            } // display model of cars
                            else if (option == '2')
                            {
                                header1();
                                add_C(cust_record);
                                //addCustIntoList(cust_record);
                                system_cls();
                            } // Add customers
                            else if (option == '3')
                            {
                                remove_C(cust_record);
                                system_cls();
                            } // remove customers
                            else if (option == '4')
                            {
                                header1();
                                edit_rent(car_detail);
                                system_cls();
                            } // change rent
                            else if (option == '5')
                            {
                                header1();
                                cust_display(cust_record);
                                system_cls();
                            } // view customer's detail
                            else if (option == '6')
                            {
                                header1();
                                addCarIntoList(car_detail);
                                system_cls();
                            } // Add cars
                            else if (option == '7')
                            {
                                header1();
                                remove_Car(car_detail);
                                system_cls();
                            } // Remove cars
                            else if (option == '8')
                            {
                                addCustIntoFile(path1, cust_record); // add customer into file
                                addCarIntoFile(path, car_detail);  // add car into file
                                break;             // log out
                            }
                            else
                            {
                                Console.WriteLine("You Chose Wrong option ");
                            }
                        } // end of admin while loop
                    }
                    else
                    {
                        Console.WriteLine("You entered wrong password");
                        system_cls();
                    }
                }   // start of customers option

                else if (status == 'b')
                {
                    if (checkUser(id, password, cust_record, car_detail))
                    {
                        while (true)

                        {
                            option = cust_menu(option);
                            if (option == '1')
                            {
                                Budget(budget, car_detail);
                                system_cls();
                            } // Recommend cars under customer's budget
                            else if (option == '2')
                            {
                                models(car_detail);
                            } // display rent of all cars
                            else if (option == '3')
                            {
                                header1();

                                sorting(car_detail);
                                for (int i = 0; i < car_detail.Count; i++)
                                {
                                    Console.WriteLine(car_detail[i].car + " car with rent " + car_detail[i].rent);
                                }
                                system_cls();
                            } // sort cars on the basis of rent
                            else if (option == '4')
                            {
                                invoice(car_name, day, rental_amount, car_detail);
                                system_cls();
                            } // bill of customer
                            else if (option == '5')
                            {
                                break; // log out
                            }
                            else
                            {
                                Console.WriteLine("You Choose Wrong option ");
                                system_cls();

                            } // end of customer's while loop
                        }
                    }
                    else
                    {
                        Console.WriteLine("You entered wrond password ");
                        system_cls();
                    }
                }

                else if (status == 'c')
                {
                    Console.WriteLine("Thank you for using our application!!!!!!!!!!!!!!!");
                    system_cls();
                    break;
                }
                else
                {
                    Console.WriteLine("You entered wrong option......");
                    system_cls();
                }
            }
        }

        ///////////////////////////////  PROGRAM END...... /////////////////////////////////



    }
}

