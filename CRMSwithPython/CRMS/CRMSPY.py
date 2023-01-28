from gettext import Catalog
from BL.Customer import Customer
from BL.Car import Car
from DL.CustomerDL import CustomerDL
from DL.CarDL import CarDL
from UI.CustomerUI import CustomerUI
from UI.CarUI import CarUI
from UI.MenuUI import MenuUI


def main():
    CarDL.ReadCarsFromFile()
    CustomerDL.ReadCustomerFromFile()
    while(True):
        status = MenuUI.statusMenu()
        MenuUI.systemcls()
        if(status == "a"):
            Id, Pass = MenuUI.LoginPortal()
            if(Id == "123" and Pass == "abc@"):
                while(True):
                    option = MenuUI.AdminMenu()
                    MenuUI.Header1()
                    if(option == "1"):
                        CarUI.DisplayCar()
                    elif(option == "2"):
                        CustomerUI.AddCustomer()
                    elif(option == "3"):
                        CustomerUI.RemoveCustomer()
                    elif(option == "4"):
                        CarUI.ChangeCarRent()
                    elif(option == "5"):
                        CustomerUI.ViewCustomer()
                    elif(option == "6"):
                        CarUI.AddCar()
                    elif(option == "7"):
                        CarUI.RemoveCar()
                    elif(option == "8"):
                        break
                    else:
                        print("Invalid Option")
                    MenuUI.systemcls()
            else:
                print("Invalid Id or Password")
                MenuUI.systemcls()
        elif(status == "b"):
            Id, Pass = MenuUI.LoginPortal()
            Cust = CustomerDL.FindCustomer(Id, Pass)
            if(not(Cust == None)):
                while(True):
                    option = MenuUI.CustomerMenu()
                    MenuUI.Header1()
                    if(option == "1"):
                        CarUI.DisplayCarUnderBudget()
                    elif(option == "2"):
                        CarUI.DisplayCar()
                    elif(option == "3"):
                        CarUI.DisplaySortedCar()
                    elif(option == "4"):
                        CarUI.GenerateInvoice(Cust)
                    elif(option == "5"):
                        CarDL.ReturnCar(Cust)
                    elif(option == "6"):
                        break
                    else:
                        print("Invalid Option")
                    MenuUI.systemcls()
            else:
                print("Invalid Id or Password")
                MenuUI.systemcls()
        elif(status == "c"):
            break
        else:
            print("Invalid")
        MenuUI.systemcls()


if __name__ == "__main__":
    main()
