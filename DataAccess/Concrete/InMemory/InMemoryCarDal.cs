using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id = 1, BrandId = "BMW", ColorID = "Black",ModelYear = "2014", DailyPrice = 350, Description = "Motor Hacmi 2001 - 2500 cm3" },
                new Car{Id = 2, BrandId = "Citroën", ColorID = "White",ModelYear = "2018", DailyPrice = 80, Description = "Motor Hacmi 1401 - 1600 cm3" },
                new Car{Id = 3, BrandId = "Mercedes-Benz", ColorID = "Black",ModelYear = "2018", DailyPrice = 500, Description = "Motor Hacmi 1601 - 1800 cm3" },
                new Car{Id = 4, BrandId = "Fiat", ColorID = "Grey",ModelYear = "2017", DailyPrice = 120, Description = "Motor Hacmi 1301 - 1400 cm3" },
                new Car{Id = 5, BrandId = "Renault", ColorID = "White",ModelYear = "2016", DailyPrice = 120, Description = "Motor Hacmi 1401 - 1600 cm3" },
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorID = car.ColorID;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
