using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CRMS
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

        static char login_portal(ref char status, ref int id, ref string password)
        {
            if (status == 'a' || status == 'b')
            {
                header1();
                Console.WriteLine("               Login Portal                ");
                Console.Write("Enter User ID--------");
                string a = "";
                a = Console.ReadLine();
                id = int.Parse(a);
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
            Console.WriteLine("3.  Display cars from higher to lower rent");
            Console.WriteLine("4.  Invoice");
            Console.WriteLine("5.  Logout");
            Console.Write("Choose your option: ");
            option = char.Parse(Console.ReadLine());
            system_cls();
            return option;
        }

        // end of customer's menu
        static void cust_display(int[] cust_idA, string[] cust_nameA, string[] C_passwordA, int[] cust_age, ref int count)
        {
            if (count > 0)
            {
                Console.WriteLine("All customer's record:");
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("Customer_ID: " + cust_idA[i]);
                    Console.WriteLine("Customer_name: " + cust_nameA[i]);
                    Console.WriteLine("Password: " + C_passwordA[i]);
                    Console.WriteLine("Customer's age: " + cust_age[i]);
                    Console.WriteLine("                     ");
                }
            }
            else
                Console.WriteLine("No Customer record Available! ");
        }
        // end of display customers function

        static void models(string[] car_nameA, int[] car_rentA, ref int car_count)
        {
            header1();
            if (car_count == 0)
            {
                Console.WriteLine("Sorry no car available!!!!!!");
            }
            else
            {
                Console.WriteLine("All car's model  >");

                for (int i = 0; i < car_count; i++)
                {
                    Console.WriteLine("car id " + (i + 1) + " :  " + car_nameA[i] + "\t\t Rent :  " + car_rentA[i]);
                }
            }
            system_cls();
        }


        // end of customer display function
        static void edit_rent(int[] car_rentA, ref int car_count)
        {
            int _id;
            int rent;
            if (car_count == 0)
            {
                Console.WriteLine("Sorry no car available!!!!!!");
            }
            else
            {
                Console.WriteLine("Enter the Car Id: ");
                _id = int.Parse(Console.ReadLine());

                if (_id > 0 && _id <= car_count)
                {
                    Console.WriteLine("Enter new Rent: ");
                    rent = int.Parse(Console.ReadLine());
                    car_rentA[_id - 1] = rent;
                    Console.WriteLine("Rent Update Successfully!");
                }
                else
                    Console.WriteLine("Invalid Care Id!");
            }
        }
        // end of change rent function
        static void invoice(string car_name, int day, int rental_amount, string[] car_nameA, int[] car_rentA, ref int car_count)
        {
            header1();
            Console.WriteLine("Invoice of a customer: ");
            Console.WriteLine("                                 ");
            Console.Write("Enter Car model: ");
            car_name = Console.ReadLine();
            for (int i = 0; i < car_count; i++)
            {
                if (car_nameA[i] == car_name)
                {
                    Console.WriteLine("If you avail this car more than 4 days you will get 5% discount");
                    Console.Write("Enter number of days: ");
                    day = int.Parse(Console.ReadLine());
                    rental_amount = day * car_rentA[i];
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

        static void Budget(int budget, string[] car_nameA, int[] car_rentA, ref int car_count)
        {
            int c = 0;
            header1();
            Console.Write("Enter your budget: ");
            budget = int.Parse(Console.ReadLine());
            for (int i = 0; i < car_count; i++)
            {
                if (car_rentA[i] <= budget)
                {
                    Console.WriteLine(car_nameA[i] + " Car with rent " + car_rentA[i]);
                    c++;
                }
            }
            if (c == 0)
            {
                Console.WriteLine("Sorry no car available under your budget......");
            }
        }
        // end of function that recommend cars under customer's budget
        static void add_C(int[] cust_idA, string[] cust_nameA, string[] C_passwordA, int[] cust_age, ref int count)
        {
            int n = 0;
            int c_id;
            string cust_name;
            string cust_p;
            int age;
            Console.Write("Enter customer  ID:  ");
            c_id = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                if (cust_idA[i] == c_id)
                {
                    Console.WriteLine("You already assign this id to another customer Use another id");
                    n = 1;
                    break;
                }
            }
            if (n == 0)
            {
                Console.Write("Enter customer  name:  ");
                cust_name = Console.ReadLine();
                Console.Write("Enter customer  password(your password must have a special character such as !/@/#): ");
                cust_p = Console.ReadLine();

                if (validationOfPassword(cust_p) == true)
                {
                    Console.Write("Enter customer's age(customer must be 18 year's old otherwise account will not created): ");
                    age = int.Parse(Console.ReadLine());
                    if (age >= 18 && age <= 65)
                    {
                        addCustIntoArray(c_id, cust_name, cust_p, age, cust_idA, cust_nameA, C_passwordA, cust_age, ref count);
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
        // add customers function end
        static void addCustIntoArray(int c_id, string cust_name, string cust_p, int age, int[] cust_idA, string[] cust_nameA, string[] C_passwordA, int[] cust_age, ref int count)
        {

            cust_idA[count] = c_id;
            cust_nameA[count] = cust_name;
            C_passwordA[count] = cust_p;
            cust_age[count] = age;
            count++;
        }
        // storing customer details in array
        static void addCustIntoFile(string path1, int[] cust_idA, string[] cust_nameA, string[] C_passwordA, int[] cust_age, ref int count)
        {
            StreamWriter cust = new StreamWriter(path1, false);
            for (int i = 0; i < count; i++)
            {
                cust.WriteLine(cust_idA[i] + "," + cust_nameA[i] + "," + C_passwordA[i] + "," + cust_age[i]);
                cust.Flush();
            }
            cust.Close();
        }
        // add customer's into file function
        static void remove_C(int[] cust_idA, string[] cust_nameA, string[] C_passwordA, ref int count, ref int MAX_RECORDS)
        {
            int _id;
            int index = -1;
            if (count == 0)
                Console.WriteLine("No Record Available to Remove!");
            else
            {
                header1();
                Console.Write("Enter Customer ID you want to remove:  ");
                _id = int.Parse(Console.ReadLine());

                for (int i = 0; i < count; i++)
                {
                    if (cust_idA[i] == _id)
                    {
                        index = i;
                        break;
                    }
                }

                if (index >= 0 && index < MAX_RECORDS)
                {
                    for (int i = index; i < count - 1; i++)
                    {
                        cust_idA[i] = cust_idA[i + 1];
                        cust_nameA[i] = cust_nameA[i + 1];
                        C_passwordA[i] = C_passwordA[i + 1];
                    }
                    cust_idA[count] = 0;
                    cust_nameA[count] = "";
                    C_passwordA[count] = "";
                    count--;
                    Console.WriteLine("Account is successfully removed");
                }
                else
                    Console.WriteLine("Invalid Customer ID!");
            }
        }
        // remove customers function
        static void add_Car(string[] car_nameA, int[] car_rentA, ref int car_count)
        {
            string car;
            int rent;
            Console.Write("Enter car name: ");
            car = Console.ReadLine();

            Console.Write("Enter car's rent: ");
            rent = int.Parse(Console.ReadLine());
            addCarIntoArray(car, rent, car_nameA, car_rentA, ref car_count);
        }
        static void addCarIntoArray(string car, int rent, string[] car_nameA, int[] car_rentA, ref int car_count)
        {
            car_nameA[car_count] = car;
            car_rentA[car_count] = rent;
            car_count++;
        }
        // storing cars details into array
        static void addCarIntoFile(string path, string[] car_nameA, int[] car_rentA, ref int car_count)
        {
            StreamWriter car = new StreamWriter(path, false);
            for (int i = 0; i < car_count; i++)
            {
                car.WriteLine(car_nameA[i] + "," + car_rentA[i]);
                car.Flush();
            }
            car.Close();
        }
        // add car into file
        static void remove_Car(string[] car_nameA, int[] car_rentA, ref int car_count, ref int MAX_RECORDS)
        {
            string car_name;
            int index = -1;
            if (car_count == 0)
                Console.WriteLine("No Record Available to Remove!");
            else
            {
                Console.WriteLine("Enter car name you want to remove:  ");
                car_name = Console.ReadLine();

                for (int i = 0; i < car_count; i++)
                {
                    if (car_nameA[i] == car_name)
                    {
                        index = i;
                        break;
                    }
                }

                if (index >= 0 && index < MAX_RECORDS)
                {
                    for (int i = index; i < car_count - 1; i++)
                    {
                        car_nameA[i] = car_nameA[i + 1];
                        car_rentA[i] = car_rentA[i + 1];
                    }
                    car_nameA[car_count] = "";
                    car_rentA[car_count] = 0;

                    car_count--;
                    Console.WriteLine("Car is successfully removed");
                }
                else
                    Console.WriteLine("Invalid Car !");
            }
        }
        // function for removing car
        static int sorting(int s, int[] car_rentA, ref int car_count)
        {
            int largest = 0;
            int idx = 0;
            largest = -1;
            for (int i = s; i < car_count; i++)
            {
                if (largest < car_rentA[i])
                {
                    largest = car_rentA[i];
                    idx = i;
                }
            }
            return idx;
        }
        // function for sorting car
        static bool checkUser(int id, string password, int[] cust_idA, string[] C_passwordA, ref int MAX_RECORDS)
        {
            for (int i = 0; i < MAX_RECORDS; i++)
            {
                if (id == cust_idA[i] && password == C_passwordA[i])
                {
                    return true;
                }
            }
            return false;
        }
        // function for check user wether they are valid or not
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
        // function to seprate data into files
        static void loadCustomerIntoArray(string path1, string[] cust_nameA, string[] C_passwordA, int[] cust_age, int[] cust_idA, ref int count)
        {
            string word;
            if (File.Exists(path1))
            {
                StreamReader cust = new StreamReader(path1);
                while ((word = cust.ReadLine()) != null)
                {
                    cust_idA[count] = int.Parse((parseRecord(word, 1)));
                    cust_nameA[count] = parseRecord(word, 2);
                    C_passwordA[count] = parseRecord(word, 3);
                    cust_age[count] = int.Parse((parseRecord(word, 4)));
                    count++;
                }
                cust.Close();
            }
            else
                Console.WriteLine("File does not exist");
        }
        // function for storing data from file to arrays
        static void loadCarIntoArray(string path, string[] car_nameA, int[] car_rentA, ref int car_count)
        {
            string word;
            if (File.Exists(path))
            {
                StreamReader car = new StreamReader(path);
                while ((word = car.ReadLine()) != null)
                {
                    car_nameA[car_count] = parseRecord(word, 1);
                    car_rentA[car_count] = int.Parse((parseRecord(word, 2)));
                    car_count++;
                }
                car.Close();
            }
            else
                Console.WriteLine("File does not exists!!!!!");
        }
        // function for storing cars from file to arrays
        static bool validationOfPassword(string pass)
        {
            for (int x = 0; x < pass.Length; x++)
            {
                if (pass[x] == '@' || pass[x] == '!' || pass[x] == '#' || pass[x] == '%' || pass[x] == '^' || pass[x] == '&' || pass[x] == '*' || pass[x] == '$')
                    return true;
            }
            return false;
        }
        // function for checking that password is valid or not
        static void Main(string[] args)
        {
            char status = ' ';
            int id = 0;
            string password = "";
            int car_count = 0;
            int MAX_RECORDS = 20;
            int count = 0;
            //------------------- Data Structures-----------------------------
            string path = "F:\\second semester\\CRMS\\CRMS\\car.txt";
            string path1 = "F:\\second semester\\CRMS\\CRMS\\customer.txt";
            string[] car_nameA = new string[MAX_RECORDS];
            int[] car_rentA = new int[MAX_RECORDS];
            string[] cust_nameA = new string[MAX_RECORDS];
            int[] cust_idA = new int[MAX_RECORDS];
            string[] C_passwordA = new string[MAX_RECORDS];
            int[] cust_age = new int[MAX_RECORDS];

            loadCarIntoArray(path, car_nameA, car_rentA, ref car_count);
            loadCustomerIntoArray(path1, cust_nameA, C_passwordA, cust_age, cust_idA, ref count);

            char mainchoice, login, option = ' ';
            int budget = 0, rental_amount = 0, day = 0;
            string car_name = "";

            /* Hard code Id and password....
                Admin id is 123 and password is abc@ */
            while (true)
            {
                mainchoice = status_menu(ref status);
                login = login_portal(ref status, ref id, ref password);
                if (status == 'a' && id == 123 && password == "abc@")
                {
                    while (true)
                    {
                        option = admin_menu(option);
                        if (option == '1')
                        {
                            models(car_nameA, car_rentA, ref car_count);
                        } // display model of cars
                        else if (option == '2')
                        {
                            header1();
                            add_C(cust_idA, cust_nameA, C_passwordA, cust_age, ref count);
                            system_cls();
                        } // Add customers
                        else if (option == '3')
                        {
                            remove_C(cust_idA, cust_nameA, C_passwordA, ref count, ref MAX_RECORDS);
                            system_cls();
                        } // remove customers
                        else if (option == '4')
                        {
                            header1();
                            edit_rent(car_rentA, ref car_count);
                            system_cls();
                        } // change rent
                        else if (option == '5')
                        {
                            header1();
                            cust_display(cust_idA, cust_nameA, C_passwordA, cust_age, ref count);
                            system_cls();
                        } // view customer's detail
                        else if (option == '6')
                        {
                            header1();
                            add_Car(car_nameA, car_rentA, ref car_count);
                            system_cls();
                        } // Add cars
                        else if (option == '7')
                        {
                            header1();
                            remove_Car(car_nameA, car_rentA, ref car_count, ref MAX_RECORDS);
                            system_cls();
                        } // Remove cars
                        else if (option == '8')
                        {
                            addCustIntoFile(path1, cust_idA, cust_nameA, C_passwordA, cust_age, ref count); // add customer into file
                            addCarIntoFile(path, car_nameA, car_rentA, ref car_count);  // add car into file
                            break;             // log out
                        }
                        else
                        {
                            Console.WriteLine("You Chose Wrong option ");
                        }
                    } // end of admin while loop
                }   // start of customers option
                else if (status == 'b')
                {
                    if (checkUser(id, password, cust_idA, C_passwordA, ref MAX_RECORDS))
                    {
                        while (true)

                        {
                            option = cust_menu(option);
                            if (option == '1')
                            {
                                Budget(budget, car_nameA, car_rentA, ref car_count);
                                system_cls();
                            } // Recommend cars under customer's budget
                            else if (option == '2')
                            {
                                models(car_nameA, car_rentA, ref car_count);
                            } // display rent of all cars
                            else if (option == '3')
                            {
                                header1();
                                int temp, high_idx;
                                string tempS;
                                for (int s = 0; s < car_count; s++)
                                {
                                    high_idx = sorting(s, car_rentA, ref car_count);
                                    temp = car_rentA[high_idx];
                                    car_rentA[high_idx] = car_rentA[s];
                                    car_rentA[s] = temp;

                                    tempS = car_nameA[high_idx];
                                    car_nameA[high_idx] = car_nameA[s];
                                    car_nameA[s] = tempS;
                                }

                                for (int i = 0; i < car_count; i++)
                                {
                                    Console.WriteLine(car_nameA[i] + " car with rent " + car_rentA[i]);
                                }
                                system_cls();
                            } // sort cars on the basis of rent
                            else if (option == '4')
                            {
                                invoice(car_name, day, rental_amount, car_nameA, car_rentA, ref car_count);
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


