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
                new Car{ CarId=1, BrandId=1, ColorId=2, DailyPrice=300, ModelYear="2010", Description="Hızlı ve güvenli."},
                new Car{ CarId=2, BrandId=1, ColorId=3, DailyPrice=200, ModelYear="2011", Description="Otomatik vites."},
                new Car{ CarId=3, BrandId=4, ColorId=1, DailyPrice=100, ModelYear="2012", Description="Uzun yol aracıdır."},
                new Car{ CarId=4, BrandId=3, ColorId=4, DailyPrice=400, ModelYear="2010", Description="Hızlı ve güvenli."}

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car CarToDelete = _cars.SingleOrDefault(C => C.CarId == car.CarId);
            _cars.Remove(CarToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car CarToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            CarToUpdate.CarId = car.CarId;
            CarToUpdate.ColorId = car.ColorId;
            CarToUpdate.Description = car.Description;


        }
    }
}
