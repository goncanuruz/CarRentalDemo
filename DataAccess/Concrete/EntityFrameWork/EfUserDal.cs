using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfUserDal : EfRepositoryBase<User, CarRentalContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (CarRentalContext context=new CarRentalContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join UserOperationClaim in context.UserOperationClaims
                             on operationClaim.Id equals UserOperationClaim.OperationClaimId
                             where (UserOperationClaim.UserId == user.Id)
                             select new OperationClaim { Id=operationClaim.Id, Name=operationClaim.Name};
                return result.ToList();
            }
        }
    }
}
