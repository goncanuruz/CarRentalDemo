using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        Car GetById(int carId);
        void Add(Car entity);
        void Delete(Car entity);
        void Update(Car entity);
        List<CarDetailDto> GetCarDetails();
    }
}
