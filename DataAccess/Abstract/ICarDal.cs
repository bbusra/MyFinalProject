using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //DAL data access layer demek.
    //Carla ilgili veritabanında içeren operasyonları içeren interfacedir.
    public interface ICarDal:IEntityRepository<Car>
    {
        
    }

}
