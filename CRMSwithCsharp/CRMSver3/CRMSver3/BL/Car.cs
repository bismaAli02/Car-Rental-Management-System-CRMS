using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSver3.BL
{
    class Car
    {
        //  CONSTRUCTER

        // DEFAULT CONSTRUCTER
        
        public Car()
        {

        }
       
        // PARAMETRIZED CONSTRUCTER
        public Car(string car, int rent)
        {
            this.car = car;
            this.rent = rent;
            isAvailable = true;
        }
       
        
        //   CLASS MEMBERS
        public string car;
        public int rent;
        public bool isAvailable;


        // FUNCTION
       


        public void models(List<Car> car_detail)
        {
           
            if (car_detail.Count == 0)
            {
                Console.WriteLine("Sorry no car available!!!!!!");
            }
            else
            {
                Console.WriteLine("All car's model  >");
                int i = 0;
                foreach (Car c in car_detail)
                {
                    if(c.isAvailable==true)
                    {

                        Console.WriteLine("car id " + (i + 1) + " :  " + c.car + "\t\t Rent :  " + c.rent);
                        i++;
                    }
                }
            }
           
        }
        // this function will display all cars record

       public void edit_rent(List<Car> car_detail)
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
        public float RentCalculate(int day)
        {
            float rental_amount;
            rental_amount = day * rent;
            if (day >= 5)
            {
                rental_amount = rental_amount - (rental_amount * 5 / 100);
            }
            
            return rental_amount;
        }

        

        public void Budget(int budget, List<Car> car_detail)
            {
                int c = 0;
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


        
        // this function is used for remove car from list


        public void sorting(List<Car> car_detail)
        {
            car_detail.Sort((x, y) => x.rent.CompareTo(y.rent));
        }
        // this function is used to sort car rent in assceding order

      

    }


}

