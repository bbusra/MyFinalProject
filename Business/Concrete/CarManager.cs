using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {
            //İş kodları
            return _carDal.GetAll();

        }

        public List<Car> GetAllByBrandId(int brandId)
        {
            return _carDal.GetAll(car => car.BrandId == brandId);
        }

        public List<Car> GetByPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(car => car.DailyPrice >= min && car.DailyPrice <= max);
        }
    }
}
