using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfRentalDal : EfRepositoryBase<Rental, CarRentalContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (CarRentalContext context=new CarRentalContext())
            {
                var result = from rental in context.Rentals
                             join car in context.Cars on
                             rental.CarId equals car.Id                             
                             join customer in context.Customers
                             on rental.CustomerId equals customer.Id
                             select new RentalDetailDto { CarId=car.Id, Id=rental.Id,CarName=car.Name, CustomerId=customer.Id,CompanyName=customer.CompanyName,RentDate=rental.RentDate,ReturnDate=rental.ReturnDate
                             };
                return result.ToList();


            }


        }
        
    }
}
