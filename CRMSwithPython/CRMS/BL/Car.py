class Car:
    car = ""
    rent = 0
    IsAvailable = True

    def __init__(self, car=None, rent=None, IsAvailable=True):
        self.car = car
        self.rent = rent
        self.IsAvailable = IsAvailable

    def CalculateRent(self, days):
        rental_amount = days * self.rent
        if days >= 5:
            rental_amount = rental_amount - (rental_amount * 5 / 100)
        return rental_amount
