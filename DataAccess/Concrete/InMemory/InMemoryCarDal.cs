using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal:ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1, ColorId=23,DailyPrice=500000,ModelYear=2019,Description="Güzel araba:)"},
                new Car{Id=2,BrandId=3, ColorId=37,DailyPrice=200000,ModelYear=2017,Description="2. el temiz araba"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            //LINQ: Language Integrated Query
            //Remove ile silme işlemi yapmak için bir for döngüsü yazıp tek tek id'leri dolaşıp kontrol etmesi gerekiyor. Linq ile bunu kısaca yazarız ve belleği yormaz. Bu yüzden avantajlıdır.
            Car carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id); //bu satır foreach döngüsünü tek seferde yazmamızı sağlar.
            _cars.Remove(carToDelete);


        }

        public Car Get(Expression<Func<Car, bool>> filter)
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

        public List<Car> GetAllByBrand(int brandId)
        {
            return _cars.Where(p => p.BrandId == brandId).ToList();
        }


        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id); //gönderdiğim ürünün id'si ile aynı id'ye sahip ürünü bul demek.
            carToUpdate.Description = car.Description;


        }
    }
}
