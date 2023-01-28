class Customer:
    name = ""
    age = 0
    Id = ""
    Pass = ""
    rentedCarName = ""

    def __init__(self, name=None, age=None, Id=None, Pass=None, rentedCarName="0"):
        self.name = name
        self.age = age
        self.Id = Id
        self.Pass = Pass
        self.rentedCarName = rentedCarName

    @staticmethod
    def PasswordValidation(Pass):
        for x in Pass:
            if (x == "@" or x == "!" or x == "#" or x == "%" or x == "^" or x == "&" or x == "*" or x == "$"
                ):
                return True
        return False

    def IDValidation(Id):
        count = 0
        for i in Id:
            if (ord(i) >= 33 and ord(i) <= 47) or (ord(i) >= 58 and ord(i) < 127):
                count = count+1
            else:
                count = 0
                break
        if not(count == 0):
            return True
        return False

    def ReturnCar(self, Cars):
        if not (self.rentedCarName == "0"):
            for c in Cars:
                if self.rentedCarName == c.car:
                    c.IsAvailable = True
                    self.rentedCarName = "0"
                    return True
