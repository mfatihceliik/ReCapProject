using Business.Concrete;
using DataAccess.Concrete.InMemory;
using DataAccess.Concrete.RentACar;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new CarDal());
            //CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.BrandId);
            }
        }
    }
}
