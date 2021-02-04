using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
                new Car{Id = 1, BrandId = 1, ColorId = 1, ModelYear = "2014", DailyPrice = 350, CarDescription = "Motor Hacmi 2001 - 2500 cm3" },
                new Car{Id = 2, BrandId = 2, ColorId = 2, ModelYear = "2018", DailyPrice = 80, CarDescription = "Motor Hacmi 1401 - 1600 cm3" },
                new Car{Id = 3, BrandId = 3, ColorId = 1, ModelYear = "2018", DailyPrice = 500, CarDescription = "Motor Hacmi 1601 - 1800 cm3" },
                new Car{Id = 4, BrandId = 4, ColorId = 3, ModelYear = "2017", DailyPrice = 120, CarDescription = "Motor Hacmi 1301 - 1400 cm3" },
                new Car{Id = 5, BrandId = 5, ColorId = 2, ModelYear = "2016", DailyPrice = 120, CarDescription = "Motor Hacmi 1401 - 1600 cm3" },
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

        public List<Car> Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.CarDescription = car.CarDescription;
        }

        Car IEntityRepository<Car>.Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
