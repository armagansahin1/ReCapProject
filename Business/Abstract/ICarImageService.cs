﻿using Core.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IResult Add(IFormFile imageFile,CarImage carImage);
        IResult Update(IFormFile imageFile, CarImage carImage);
        IResult Delete(CarImage carImage);

        IResult DeleteAllCarImage(int carId);
       
        IDataResult<List<CarImage>> GetAll();
        IDataResult<List<CarImage>> GetByCarId(int carId);
       

    }
}
