using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        [SecuredOperation("Admin")]
        public IResult Add(Brand entity)
        {
            if (entity.Name.Length > 2)
            {
                _brandDal.Add(entity);
                return new SuccessResult(Messages.AddedMessage);
            }
            else
            {
                return new ErrorResult(Messages.CarNameInvalid);
            }
            
        }
        [SecuredOperation("Admin")]
        public IResult Delete(Brand entity)
        {
            _brandDal.Delete(entity);
            return new SuccessResult(Messages.DeletedMessage);
        }


        [SecuredOperation("Admin")]
        public IDataResult<List<Brand>> GetAll()
        {
            if (DateTime.Now.Hour==18)
            {
                return new ErrorDataResult<List<Brand>>(Messages.MaintenanceTime);
            }
            else
            {
                _brandDal.GetAll();
                return new SuccessDataResult<List<Brand>>(_brandDal.GetAll());
            }

        }

        public IDataResult<Brand> GetById(int brandId)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(b => b.Id == brandId));

        }
        [SecuredOperation("Admin")]
        public IResult Update(Brand entity)
        {
            _brandDal.Update(entity);
            return new SuccessResult(Messages.UpdatedMessage);
        }
    }
}
