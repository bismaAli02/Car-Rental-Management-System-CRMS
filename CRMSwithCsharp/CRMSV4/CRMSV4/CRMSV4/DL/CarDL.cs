using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRMSV4.BL;
using System.IO;

namespace CRMSV4.DL
{
    public class CarDL
    {
        private static List<Car> carList = new List<Car>();
        private static List<Car> carUnderBudgetList = new List<Car>();
        private static string path = "Car.txt";
        public static List<Car> CarList { get => carList; set => carList = value; }
        public static List<Car> CarUnderBudgetList { get => carUnderBudgetList; set => carUnderBudgetList = value; }

        public static List<Car> GetListOfCarUnderBudget(int rent)
        {
            carUnderBudgetList.Clear();
            foreach (Car car in carList)
            {
                if (car.Rent <= rent)
                {
                    carUnderBudgetList.Add(car);
                }
            }
            return carUnderBudgetList;
        }
        public static List<Car> GetSortedList()
        {
            List<Car> sortedCarList = CarList.OrderBy(x => x.Rent).ToList();
            return sortedCarList;
        }
        public static void AddCarInList(Car c)
        {
            carList.Add(c);
        }
        public static bool DeleteCar(Car c)
        {
            int idx = -1;
            for (int i = 0; i < CarList.Count; i++)
            {
                if (carList[i].CarName == c.CarName)
                {
                    idx = i;
                }
            }
            if (idx != -1)
            {
                CarList.RemoveAt(idx);
                return true;
            }
            return false;
        }
        public static void EditCar(Car c1, Car c2)
        {
            foreach (Car c in CarList)
            {
                if (c.CarName == c1.CarName)
                {
                    c.CarName = c2.CarName;
                    c.Rent = c2.Rent;
                    c.IsAvailable = c2.IsAvailable;
                }
            }
        }
        public static Car FindCar(string CarName)
        {
            foreach (Car item in carList)
            {
                if (CarName == item.CarName)
                {
                    return item;
                }
            }

            return null;
        }
        public static void addCarIntoFile()
        {
            StreamWriter car = new StreamWriter(path, false);
            for (int i = 0; i < carList.Count; i++)
            {
                car.WriteLine(carList[i].CarName + "," + carList[i].Rent + "," + carList[i].IsAvailable);

            }
            car.Flush();
            car.Close();
        }

        public static void loadCarIntoList()
        {
            string word;
            if (File.Exists(path))
            {
                StreamReader car = new StreamReader(path);
                while ((word = car.ReadLine()) != null)
                {
                    Car a = new Car();
                    string[] SplittedRecord = word.Split(',');
                    a.CarName = SplittedRecord[0];
                    a.Rent = int.Parse(SplittedRecord[1]);
                    a.IsAvailable = bool.Parse(SplittedRecord[2]);

                    AddCarInList(a);
                }
                car.Close();
            }
        }
    }
}
