﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {

        List<Car> GetAll();
        List<Car> GetAllByBrandId(int id);
        List<Car> GetByPrice(decimal min, decimal max);


    }
}
