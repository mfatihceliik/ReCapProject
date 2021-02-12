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

            var result = carManager.GetCarDetails();

            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarId + " / " + car.BrandName + " / " + car.ColorName + " / " + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }


            //GetCarDetailsOperation(carManager);
            //DeleteCarOperation(carManager);
        }

        /*private static void GetCarDetailsOperation(CarManager carManager)
        {
            foreach (var cars in carManager.GetCarDetails())
            {
                Console.WriteLine(cars.CarId + " / " + cars.BrandName + " / " + cars.ColorName + " / " + cars.DailyPrice);
            }
        }*/

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
            carManager.DeleteCar(car);
        }
    }
}
