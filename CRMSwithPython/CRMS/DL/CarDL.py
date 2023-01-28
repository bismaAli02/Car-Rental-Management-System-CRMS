from ast import Lambda
import os.path
from BL.Car import Car
from DL.CustomerDL import CustomerDL
from BL.Customer import Customer


class CarDL:
    carList = []

    path = "DL\\CarFile.txt"

    @staticmethod
    def addUserInList(car):
        CarDL.carList.append(car)

    @staticmethod
    def CarsUnderBudget(rent):
        CarUnderBudget = []
        for c in CarDL.carList:
            if c.rent < rent:
                CarUnderBudget.append(c)
        return CarUnderBudget

    @staticmethod
    def ReturnCar(cust):
        if(not(cust.rentedCarName == "0")):
            for c in CarDL.carList:
                if(c.car == cust.rentedCarName):
                    c.IsAvailable = True
                    cust.rentedCarName = "0"
                    print("Car Returned")
        else:
            print("No car taken on rent")
        CarDL.AddCarIntoFile()
        CustomerDL.AddCustomerIntoFile()

    @staticmethod
    def GetSortedCarList():
        # CarDL.carList.sort()
        # CarDL.carList.sort(key=Lambda x: x.rent)
        return sorted(CarDL.carList, key=lambda x: x.rent)
        # return CarDL.carList
    #     Pass

    @staticmethod
    def RemoveCar(car):
        i = 0
        for c in CarDL.carList:
            if(c.car == car):
                CarDL.carList.pop(i)
                return True
            i = i+1
        return False

    @staticmethod
    def EditCar(c1, c2):
        for c in CarDL.carList:
            if c.car == c1.car:
                c.car = c2.car
                c.rent = c2.rent
                c.IsAvailable = c2.IsAvailable
                return True
        return False

    @staticmethod
    def FindCar(name):
        for c in CarDL.carList:
            if c.car == name:
                return c
        return None

    @staticmethod
    def AddCarIntoFile():
        file = open(CarDL.path, "w")
        for c in CarDL.carList:
            file.write(c.car + "," + str(c.rent) +
                       "," + str(c.IsAvailable) + "\n")
        file.close()

    @staticmethod
    def Parsedata(line):
        line = line.split(",")
        return line[0], int(line[1]), bool(line[2])

    @staticmethod
    def ReadCarsFromFile():
        if os.path.exists(CarDL.path):
            file = open(CarDL.path, "r")
            record = file.read().split("\n")
            file.close()
            for line in record:
                if not(line == ''):
                    car, rent, IsAvailable = CarDL.Parsedata(line)
                    c = Car(car, rent, IsAvailable)
                    CarDL.addUserInList(c)
            return True
        else:
            n = input()
            return False
