from BL.Customer import Customer
import os.path


class CustomerDL:
    CustomerList = []
    path = "DL\\customer.txt"

    @staticmethod
    def EditCustomer(c1, c2):
        for cust in CustomerDL.CustomerList:
            if(cust.Id == c1.Id):
                cust.name = c2.name
                cust.age = c2.age
                cust.Id == c2.Id
                cust.Pass = c2.Pass
                return True
        return False

    @staticmethod
    def AddCustomerInList(cust):
        CustomerDL.CustomerList.append(cust)

    @staticmethod
    def DeleteCustomer(Id):
        i = 0
        for cust in CustomerDL.CustomerList:
            if(cust.Id == Id):
                CustomerDL.CustomerList.pop(i)
                return True
            i = i+1
        return False

    @staticmethod
    def FindCustByname(name):
        for cust in CustomerDL.CustomerList:
            if(cust.name == name):
                return cust
        return None

    @staticmethod
    def FindCustomer(Id, Pass):
        for cust in CustomerDL.CustomerList:
            if(cust.Id == Id and cust.Pass == Pass):
                return cust
        return None

    @staticmethod
    def AddCustomerIntoFile():
        file = open(CustomerDL.path, "w")
        for c in CustomerDL.CustomerList:
            file.write(c.Id + "," + c.name + "," + c.Pass +
                       ","+str(c.age)+","+c.rentedCarName + "\n")
        file.close()

    @staticmethod
    def Parsedata(line):
        line = line.split(",")
        return line[1], int(line[3]), line[0], line[2], line[4]

    @staticmethod
    def ReadCustomerFromFile():
        if os.path.exists(CustomerDL.path):
            file = open(CustomerDL.path, "r")
            record = file.read().split("\n")
            file.close()
            for line in record:
                if not(line == ''):
                    name, age, Id, Pass, rentedCarName = CustomerDL.Parsedata(
                        line)
                    c = Customer(name, age, Id, Pass, rentedCarName)
                    CustomerDL.AddCustomerInList(c)
            return True
        else:
            return False

    @staticmethod
    def ValidationId(Id):
        for c in CustomerDL.CustomerList:
            if(c.Id == Id):
                return False
        return True
