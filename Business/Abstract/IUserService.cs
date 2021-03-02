using Core.Entities.Concrete;
using Core.Utilities.Results;

using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetByEmail(int email);
        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);
    }
}
