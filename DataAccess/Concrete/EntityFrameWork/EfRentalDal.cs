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
                var result = from r in context.Rentals
                             join c in context.Customers
                             on r.CustomerId equals c.Id
                             join u in context.Users
                             on c.UserId equals u.Id
                             join cr in context.Cars
                             on r.CarId equals cr.Id
                             select new RentalDetailDto
                             {
                                 UserId = u.Id,
                                 RentalId = r.Id,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 Email=u.Email,
                                 CarName=cr.Name,
                                 DailyPrice=cr.DailyPrice,
                                 RentDate=r.RentDate,
                                 ReturnDate=r.ReturnDate
                             };
                return result.ToList();



            }
        }
    }
}
