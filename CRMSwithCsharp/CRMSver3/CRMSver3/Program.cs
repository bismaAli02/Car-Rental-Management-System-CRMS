using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CRMSver3.BL;

namespace CRMSver3
{
    class program
    {
       

        static void header()
        {
            Console.WriteLine("***********************************************************");
            Console.WriteLine("*                   Welcome to our company                *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine(" ");
        }
        // end of header function

        public static void header1()
        {
            Console.WriteLine("////////////////////////////////////////////////////////////");
            Console.WriteLine("--          Car Rental Management System (CRMS)           --");
            Console.WriteLine("////////////////////////////////////////////////////////////");
            Console.WriteLine(" ");
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
            Console.WriteLine("5.  Return Car Back");
            Console.WriteLine("6.  Logout");
            Console.Write("Choose your option: ");
            option = char.Parse(Console.ReadLine());
            system_cls();
            return option;
        }
       


        static Customer add_C(List<Customer> cust_record,Customer c)
        {
            string c_id;
            string cust_name;
            string cust_p;
            int age;
            
            int n = 0;

            Console.Write("Enter customer  ID:  ");
            c_id = Console.ReadLine();
            foreach(var temp in cust_record)
            {
                if (temp.c_id == c_id)
                {
                    Console.WriteLine("You already assign this id to another customer Use another id");
                    n = 1;
                    break;
                }
            }

            if (cust_record[0].validationOfId(c_id) == true)
            {
                if (n == 0)
                {
                    Console.Write("Enter customer  name:  ");
                    cust_name = Console.ReadLine();
                    Console.Write("Enter customer  password(your password must have a special character such as !/@/#): ");
                    cust_p = Console.ReadLine();

                    if (cust_record[0].validationOfPassword(cust_p) == true)
                    {
                        Console.Write("Enter customer's age(customer must be 18 year's old otherwise account will not created): ");
                        age = int.Parse(Console.ReadLine());
                        if (age >= 18 && age <= 65)
                        {
                            Customer cust = new Customer(c_id, cust_name, cust_p, age);
                            c = cust;
                            
                            return cust;
                            
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
            return null;
        }

        static void addCustIntoList(List<Customer> cust_record, Customer cust)
        {

            cust_record.Add(cust);

        }




        // this function will add the customer into list









        static void addCustIntoFile(string path1, Customer c)
        {
            StreamWriter cust = new StreamWriter(path1, true);
           
            cust.WriteLine(c.c_id + "," + c.cust_name + "," + c.cust_p + "," + c.age+","+c.rentedCarName);
            cust.Flush();
            cust.Close();
        }
        // add customer's into file function


        static void addCustIntoFileWhenRemoveAnyCust(string path1, List<Customer> cust_record)
        {
            StreamWriter cust = new StreamWriter(path1, false);
            for (int i = 0; i < cust_record.Count; i++)
            {
                cust.WriteLine(cust_record[i].c_id + "," + cust_record[i].cust_name + "," + cust_record[i].cust_p + "," + cust_record[i].age+","+cust_record[i].rentedCarName);

            }
            cust.Flush();
            cust.Close();
        }

            // storing customer details in array

        static Car add_Car()
        {
           string car;
            int rent;
            Console.Write("Enter car name: ");
            car = Console.ReadLine();

            Console.Write("Enter car's rent: ");
            rent = int.Parse(Console.ReadLine());
            Car carObj = new Car(car, rent);
            return carObj;
        }

        static void addCarIntoList(List<Car> car_detail,Car c)
        {
            car_detail.Add(c);

        }
        // storing cars details into array



        static void addCarIntoFile(string path, Car c)
        {
            StreamWriter car = new StreamWriter(path, true);
            car.WriteLine(c.car + "," + c.rent+","+c.isAvailable);
            car.Flush();
            car.Close();
        }
        // add car into file


        static void addCarIntoFileWheRemoveAnyCar(string path, List<Car> car_detail)
        {
            StreamWriter car = new StreamWriter(path, false);
            for (int i = 0; i < car_detail.Count; i++)
            {
                car.WriteLine(car_detail[i].car + "," + car_detail[i].rent+","+car_detail[i].isAvailable);

            }
            car.Flush();
            car.Close();
        }
        // add car into file
        // add car into file


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
                    c.rentedCarName = parseRecord(word, 5);
                    addCustIntoList(cust_record, c);
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
                    a.isAvailable = bool.Parse(parseRecord(word,3));

                    addCarIntoList(car_detail,a);
                }
                car.Close();
            }
            else
                Console.WriteLine("File does not exists!!!!!");
        }
        // function for storing cars from file to arrays
        static void invoice(string car_name, int day, float rental_amount, List<Car> car_detail, Customer c)
        {
            if (c.rentedCarName == "0")
            {

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
                        //rental_amount = 0;
                        rental_amount = car_detail[i].RentCalculate(day);
                        Console.WriteLine("YOUR TOTAL AMOUNT: " + rental_amount);
                        car_detail[i].isAvailable = false;
                        c.rentedCarName = car_detail[i].car;
                    }
                }
                if (rental_amount == 0)
                {
                    Console.WriteLine("Car not found!!!!");
                }
            }
            // invoice of a customer
            // end of invoice function
        }
        static void remove_C(List<Customer> cust_record)
        {
            string _id;
            int index = -1;
            if (cust_record.Count == 0)
                Console.WriteLine("No Record Available to Remove!");
            else
            {

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
                                header1();
                                car_detail[0].models(car_detail);
                                system_cls();
                            } // display model of cars
                            else if (option == '2')
                            {
                                header1();
                                Customer c = new Customer();
                                c=  add_C(cust_record,c);
                                if(c!=null)
                                {
                                    addCustIntoList(cust_record,c);
                                    addCustIntoFile(path1, c); // add customer into file
                                    Console.WriteLine(" Account is successfully created");


                                }
                                system_cls();
                            } // Add customers
                            else if (option == '3')
                            {
                                header1();
                                remove_C(cust_record);
                                addCustIntoFileWhenRemoveAnyCust(path1, cust_record);
                                system_cls();
                            } // remove customers
                            else if (option == '4')
                            {
                                header1();
                                car_detail[0].edit_rent(car_detail);
                                system_cls();
                            } // change rent
                            else if (option == '5')
                            {
                                header1();
                                cust_record[0].cust_display(cust_record);
                                system_cls();
                            } // view customer's detail
                            else if (option == '6')
                            {
                                header1();
                                Car c = add_Car();
                                addCarIntoList(car_detail,c);
                                addCarIntoFile(path, c);
                                system_cls();
                            } // Add cars
                            else if (option == '7')
                            {
                                header1();
                                remove_Car(car_detail);

                                addCarIntoFileWheRemoveAnyCar(path, car_detail);
                                system_cls();
                            } // Remove cars
                            else if (option == '8')
                            {
                               
                               
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
                    int idx = -1;
                    if (cust_record[0].checkUser(id, password, cust_record, car_detail,ref idx))
                    {
                        while (true)
                        {
                            option = cust_menu(option);
                            if (option == '1')
                            {
                                header1();
                                car_detail[0].Budget(budget, car_detail);
                                system_cls();
                            } // Recommend cars under customer's budget
                            else if (option == '2')
                            {
                                header1();
                                car_detail[0].models(car_detail);
                                system_cls();
                            } // display rent of all cars
                            else if (option == '3')
                            {
                                header1();

                                car_detail[0].sorting(car_detail);
                                for (int i = 0; i < car_detail.Count; i++)
                                {
                                    Console.WriteLine(car_detail[i].car + " car with rent " + car_detail[i].rent);
                                }
                                system_cls();
                            } // sort cars on the basis of rent
                            else if (option == '4')
                            {
                                header();
                                invoice(car_name, day, rental_amount, car_detail,cust_record[idx]);
                                system_cls();
                            } // bill of customer
                            else if(option=='5')
                            {
                                header();
                                cust_record[idx].returnCarBack(car_detail);
                            }
                            else if (option == '6')
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

