from BL.Car import Car
from DL.CarDL import CarDL


class CarUI:
    @staticmethod
    def AddCar():
        name = input("Enter Car name: ")
        rent = int(input("Enter the rent of car: "))
        c = Car(name, rent, True)
        CarDL.addUserInList(c)
        CarDL.AddCarIntoFile()

    @staticmethod
    def GenerateInvoice(cust):
        print("Invoice of a customer: \n")
        model = input("Enter car model: ")
        rentAmount = 0
        for c in CarDL.carList:
            if(c.car == model and c.IsAvailable == True):
                print("If you avail this car more than 4 days you will get 5% discount")
                day = int(input("Enter number of days: "))
                rentAmount = c.CalculateRent(day)
                print("YOUR TOTAL AMOUNT:   " + str(rentAmount))
                c.IsAvailable = False
                cust.rentedCarName = c.car
        if(rentAmount == 0):
            print("Car not Found")

    @staticmethod
    def RemoveCar():
        name = input("Enter car name which you want to remove: ")
        if(CarDL.RemoveCar(name)):
            print("Car Removed Successfully")
        else:
            print("Record not Found")

    @staticmethod
    def DisplayCar():
        k = 0
        print("All Car\'s Model")
        for c in CarDL.carList:
            print("car Id "+str(k)+": "+c.car+"\tRent: "+str(c.rent))
            k = k+1

    @staticmethod
    def ChangeCarRent():
        name = input("Enter the model of car: ")
        for c in CarDL.carList:
            if(c.car == name):
                rent = int(input("Enter the rent: "))
                c.rent = rent
                name = None
        if(not(name == None)):
            print("Car Not Found")

    @staticmethod
    def DisplayCarUnderBudget():
        rent = input("Enter your Budget")
        rent = int(rent)
        Cars = CarDL.CarsUnderBudget(rent)
        for c in Cars:
            print("car Id: "+c.car+"\t\tRent: "+str(c.rent))

    @staticmethod
    def DisplaySortedCar():
        carList = CarDL.GetSortedCarList()
        for c in carList:
            print("car Id: "+c.car+"\t\tRent: "+str(c.rent))
