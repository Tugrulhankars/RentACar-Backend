using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> {
            new Car { BrandId = 1, BrandName = "Mercedes-Benz", Id = 1, DailyPrice = 150, ModalYear = 2018, ColorId = 1, Description = "Otomatik" },
            new Car { BrandId = 2, BrandName = "BMW", Id = 2, DailyPrice = 150, ModalYear = 2018, ColorId = 2, Description = "Otomatik" },
            new Car { BrandId = 3, BrandName = "Audi", Id = 3, DailyPrice = 150, ModalYear = 2015, ColorId = 3, Description = "Otomatik" },
            new Car { BrandId = 4, BrandName = "Volvo", Id = 4, DailyPrice = 140, ModalYear = 2014, ColorId = 4, Description = "Otomatik" },
            new Car { BrandId = 5, BrandName = "Seat", Id = 5, DailyPrice = 110, ModalYear = 2019, ColorId = 5, Description = "Otomatik" } };
        }
        

        

        public void Add(Car car)
        {
            Console.WriteLine(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete= _cars.SingleOrDefault(c=>c.Id == car.Id);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int categoryId)
        {
            return _cars.Where(c => c.CategoryId == categoryId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c=>c.Id == car.Id);
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.BrandName = car.BrandName;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.Description = car.Description;
            carToUpdate.ModalYear = car.ModalYear;


        }
    }
}
