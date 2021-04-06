﻿using Core.Entities;
using Core.Utilities.Results;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<CarDetailDTO>> GetAll();
        IDataResult<Car> GetById(int Id );
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
        IDataResult<List<Car>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<CarDetailDTO>> GetCarDetails();
        IDataResult<List<Car>> GetAllByColorId(int colorId);
        IDataResult<List<Car>> GetAllByBrandId(int brandId);

        IDataResult<List<CarDetailDTO>> GetAllByBrandIdAndColorId(int brandId,int colorId);

    }
}
