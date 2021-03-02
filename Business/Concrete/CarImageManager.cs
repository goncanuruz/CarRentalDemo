﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.FileHelper;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }

        public IResult Add(IFormFile file,CarImage carImage)
        {
            //var result = BusinessRules.Run(CheckIfCarImageLimitExceded(carImage.CarId));
            //if (result!=null)
            //{
            //    return result;
            //}
            var imageResult = ImageFileHelper.Upload(file);
            carImage.ImagePath = imageResult.Message;
            carImage.Date = DateTime.Now;
            _carImageDal.Add(carImage);
            return new SuccessResult(Messages.AddedMessage);

        }

        
        public IResult Update(IFormFile file, CarImage carImage)
        {
          
            _carImageDal.Update(carImage);
            return new SuccessResult();

        }

       
        public IResult Delete(IFormFile file,CarImage carImage)
        {
          


            _carImageDal.Delete(carImage);
            return new SuccessResult();
        }


        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());
        }

        public IDataResult<CarImage> GetById(int Id)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(c=>c.Id==Id));
        }

     
        private IResult CheckIfCarImageLimitExceded(int carId)
        {
            var result = _carImageDal.GetAll(c=>c.CarId==carId);
            if (result.Count>=5)
            {
                new ErrorResult("A car have to max 5 images ");
            }
            return new SuccessResult();

        }
    }
}