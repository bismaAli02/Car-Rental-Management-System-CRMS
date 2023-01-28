import os
from time import sleep


class MenuUI:
    @staticmethod
    def Header():
        os.system("cls")
        print("***********************************************************")
        print("*                   Welcome to our company                *")
        print("***********************************************************")

    @staticmethod
    def Header1():
        os.system("cls")
        print("////////////////////////////////////////////////////////////")
        print("--          Car Rental Management System (CRMS)           --")
        print("////////////////////////////////////////////////////////////\n")

    @staticmethod
    def systemcls():
        input("Press any key to continue....")
        os.system("cls")

    @staticmethod
    def statusMenu():
        MenuUI.Header()
        print("Select your Status:  >")
        print("a.... Admin")
        print("b.... Customer")
        print("c.... Exit")
        status = input("Choose your option: ")
        return status

    @staticmethod
    def LoginPortal():
        print("               Login Portal                ")
        Id = input("Enter User ID-----------")
        Pass = input("Enter Password--------")
        return Id, Pass

    @staticmethod
    def AdminMenu():
        MenuUI.Header()
        print("Main Menu   ")
        print("Select one of the following options number . . .")
        print("1.  Display Car's model")
        print("2.  Add new customers")
        print("3.  Remove customer")
        print("4.  Change rent of cars")
        print("5.  View all customers record")
        print("6.  Add new car")
        print("7.  Remove car: ")
        print("8.  logout")
        option = input("Choose your option: ")
        return option

    @staticmethod
    def CustomerMenu():
        MenuUI.Header()
        print("Main Menu   ")
        print("Select one of the following options number . . .")
        print("1.  Display Car under budget")
        print("2.  Display rent for all cars")
        print("3.  Display cars from lower to higher rent")
        print("4.  Invoice")
        print("5.  Return Car Back")
        print("6.  Logout")
        option = input("Choose your option: ")
        return option
