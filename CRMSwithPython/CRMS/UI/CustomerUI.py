from BL.Customer import Customer
from BL.Car import Car
from DL.CustomerDL import CustomerDL
from DL.CarDL import CarDL


class CustomerUI:
    @staticmethod
    def AddCustomer():
        name = input("Enter Customer name: ")
        age = input("Enter age: ")
        Id = str(input("Enter the Id of Customer: "))
        while(Customer.IDValidation(Id)):
            Id = str(input("Enter the valid Id of Customer"))
        Pass = input(
            "Enter customer  password(your password must have a special character such as !/@/#): ")
        while not(Customer.PasswordValidation(Pass)):
            Pass = input(
                "Enter customer  password(your password must have a special character such as !/@/#)")
        c = Customer(name, age, Id, Pass)
        CustomerDL.AddCustomerInList(c)
        CustomerDL.AddCustomerIntoFile()

    @staticmethod
    def RemoveCustomer():
        Id = input("Enter the Id of Customer to be removed: ")
        if(CustomerDL.DeleteCustomer(Id)):
            print("Record Deleted")
        else:
            print("Record Not Found")
        CustomerDL.AddCustomerIntoFile()

    @staticmethod
    def ViewCustomer():
        for c in CustomerDL.CustomerList:
            print("Customer Id: " + c.Id)
            print("Customer Name: "+c.name)
            print("Customer Pass: "+c.Pass)
            print("Customer Age: "+str(c.age)+"\n")
