using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSV4.BL
{
    public class Car
    {
        //  CONSTRUCTER

        // DEFAULT CONSTRUCTER
        public Car()
        {

        }

        // PARAMETRIZED CONSTRUCTER
        public Car(string carName, int rent)
        {
            this.carName = carName;
            this.rent = rent;
            isAvailable = true;
        }
        public Car(string carName, int rent, bool isAvailable)
        {
            CarName = carName;
            Rent = rent;
            this.isAvailable = isAvailable;
        }

        private string carName;
        private int rent;
        private bool isAvailable;


        //Getter Setters
        public string CarName { get => carName; set => carName = value; }
        public int Rent { get => rent; set => rent = value; }
        public bool IsAvailable { get => isAvailable; set => isAvailable = value; }

        public float RentCalculate(int day)
        {
            float rentalAmount;
            rentalAmount = day * rent;
            if (day >= 5)
            {
                rentalAmount = rentalAmount - (rentalAmount * 5 / 100);
            }

            return rentalAmount;
        }


    }
}
