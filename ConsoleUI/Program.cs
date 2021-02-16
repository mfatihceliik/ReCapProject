using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using DataAccess.Concrete.RentACar;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new CarDal());
            UserManager userManager = new UserManager(new UserDal());
            RentalManager rentalManager = new RentalManager(new RentalDal());
            
            
            
            //GetRentalDetails(rentalManager);
            //GetAllRentals(rentalManager);
            //AddRental(rentalManager);
            //AddUser(userManager);
            //GetAllUsers(userManager);
            //GetCarDetailsOperation(carManager);
            //DeleteCarOperation(carManager);
        }

        private static void GetRentalDetails(RentalManager rentalManager)
        {
            var result = rentalManager.GetRentalDetails();
            if (result.Success)
            {
                foreach (var rentals in result.Data)
                {
                    Console.WriteLine(rentals.CarName + " / " + rentals.CustomerName + " / " + rentals.RentDate + " / " + rentals.ReturnDate);
                }
            }
        }

        private static void GetAllRentals(RentalManager rentalManager)
        {
            var result = rentalManager.GetAll();

            if (result.Success)
            {
                foreach (var rentals in result.Data)
                {
                    Console.WriteLine(rentals.RentalId + " / " + rentals.CarId + " / " + rentals.CustomerId + " / " + rentals.RentDate + " / " + rentals.ReturnDate);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void AddRental(RentalManager rentalManager)
        {
            Rental rental = new Rental()
            {
                CarId = 5,
                CustomerId = 1,
                RentDate = new DateTime(2021, 2, 13),
                ReturnDate = null

            };
            rentalManager.Add(rental);
        }

        private static void AddUser(UserManager userManager)
        {
            User user = new User()
            {
                FirstName = "Eymen",
                LastName = "Kaya",
                Email = "eymen@outlook.com",
                Password = "123456"
            };
            userManager.Add(user);
        }

        private static void GetAllUsers(UserManager userManager)
        {
            var result = userManager.GetAll().Data;
            foreach (var users in result)
            {
                Console.WriteLine(users.UserId + " / " + users.FirstName + " / " + users.LastName + " / " + users.Email + " / " + users.Password);
            }
        }

        private static void GetCarDetailsOperation(CarManager carManager)
        {
            var result = carManager.GetCarDetails();

            if (result.Success)
            {
                foreach (var cars in result.Data)
                {
                    Console.WriteLine(cars.CarId + " / " + cars.BrandName + " / " + cars.ColorName + " / " + cars.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void DeleteCarOperation(CarManager carManager)
        {
            Car car = new Car()
            {
                CarId = 4,
                BrandId = 4,
                ColorId = 5,
                ModelYear = "2016",
                DailyPrice = 150,
                CarDescription = "Motor Hacmi 1601 - 1800 cm3",
            };
            carManager.Delete(car);
        }
    }
}
